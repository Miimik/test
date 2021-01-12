using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;
using SkyDiscord.WebSocket;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientGateway
    {
        public int? ShardId => _shard?[0];

        private readonly int[] _shard;
        internal UserStatus? _status;
        internal ActivityModel _activity;

        internal void SetStatus(UserStatus status)
        {
            switch (status)
            {
                case UserStatus.Invisible:
                case UserStatus.Idle:
                case UserStatus.DoNotDisturb:
                case UserStatus.Online:
                    _status = status;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(status));
            }
        }

        internal void SetActivity(LocalActivity activity)
        {
            _activity = activity == null
                ? null
                : new ActivityModel
                {
                    Name = activity.Name,
                    Url = activity.Url,
                    Type = activity.Type
                };
        }

        internal Task SendGuildSyncAsync(IEnumerable<ulong> guildIds)
            => SendAsync(new PayloadModel
            {
                Op = GatewayOperationCode.GuildSync,
                D = Serializer.GetJsonElement(guildIds)
            });

        internal Task SendRequestMembersAsync(ulong guildId)
             => SendAsync(new PayloadModel
             {
                 Op = GatewayOperationCode.RequestGuildMembers,
                 D = Serializer.GetJsonElement(new RequestMembersModel
                 {
                     GuildId = guildId,
                     Query = "",
                     Limit = 0,
                     Presences = false
                 })
             });

        internal Task SendResumeAsync()
            => SendAsync(new PayloadModel
            {
                Op = GatewayOperationCode.Resume,
                D = Serializer.GetJsonElement(new ResumeModel
                {
                    Token = Client.Token,
                    Seq = _lastSequenceNumber,
                    SessionId = _sessionId
                })
            });

        internal Task SendHeartbeatAsync(CancellationToken cancellationToken)
            => SendAsync(new PayloadModel
            {
                Op = GatewayOperationCode.Heartbeat,
                D = Serializer.GetJsonElement(_lastSequenceNumber)
            }, cancellationToken);

        internal async Task SendIdentifyAsync()
        {
            await _identifyLock.WaitAsync().ConfigureAwait(false);
            var model = new IdentifyModel
            {
                Token = Client.Token,
                LargeThreshold = 250,
                Presence = new UpdateStatusModel
                {
                    Status = _status,
                    Game = _activity ?? Optional<ActivityModel>.Empty
                },
                Shard = _shard,
                GuildSubscriptions = true
            };

            if (Library.Debug.MobileIndicator)
            {
                model.Properties.Os = "android";
                model.Properties.Browser = "Discord Android";
            }

            await SendAsync(new PayloadModel
            {
                Op = GatewayOperationCode.Identify,
                D = Serializer.GetJsonElement(model)
            }).ConfigureAwait(false);
        }

        internal Task SendVoiceStateUpdateAsync(ulong guildId, ulong? channelId, bool muted, bool deafened)
            => SendAsync(new PayloadModel
            {
                Op = GatewayOperationCode.VoiceStateUpdate,
                D = Serializer.GetJsonElement(new VoiceStateModel
                {
                    GuildId = guildId,
                    ChannelId = channelId,
                    Mute = muted,
                    Deaf = deafened
                })
            });

        internal Task SendPresenceAsync(CancellationToken cancellationToken = default)
            => SendAsync(new PayloadModel
            {
                Op = GatewayOperationCode.StatusUpdate,
                D = Serializer.GetJsonElement(new UpdateStatusModel
                {
                    Status = _status,
                    Game = _activity
                })
            }, cancellationToken);

        internal Task SendAsync(PayloadModel payload)
            => SendAsync(payload, CancellationToken.None);

        internal async Task SendAsync(PayloadModel payload, CancellationToken cancellationToken)
        {
            var json = Serializer.Serialize(payload);

            if (Library.Debug.DumpJson)
                Library.Debug.DumpWriter.WriteLine(Encoding.UTF8.GetString(json.Span));

            await _ws.SendAsync(new WebSocketRequest(json, cancellationToken)).ConfigureAwait(false);
        }
    }
}
