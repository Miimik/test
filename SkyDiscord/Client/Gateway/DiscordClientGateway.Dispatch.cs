﻿using System;
using System.Threading.Tasks;
using SkyDiscord.Logging;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientGateway
    {
        private async Task HandleDispatchAsync(PayloadModel payload, GatewayDispatch? gatewayEvent = null)
        {
            if (gatewayEvent == null) // if not queued
            {
                if (_lastSequenceNumber == payload.S)
                    Log(LogSeverity.Warning, $"S is the same as the previous one: {payload.S}.");

                try
                {
                    gatewayEvent = Serializer.StringToEnum<GatewayDispatch>(payload.T);
                }
                catch (JsonSerializationException)
                { }

                if (gatewayEvent == null)
                {
                    Log(LogSeverity.Warning, $"Unknown dispatch: {payload.T}\n{payload.D}.");
                    return;
                }

                if (gatewayEvent != GatewayDispatch.GuildMembersChunk
                    && gatewayEvent != GatewayDispatch.GuildCreate
                    && gatewayEvent != GatewayDispatch.GuildSync
                    && gatewayEvent != GatewayDispatch.Ready)
                {
                    lock (_readyPayloadQueue)
                    {
                        var tcs = _readyTaskCompletionSource;
                        if (tcs != null && !tcs.Task.IsCompleted)
                        {
                            Log(LogSeverity.Debug, $"Queueing up {gatewayEvent.Value}.");
                            _readyPayloadQueue.Enqueue((payload, gatewayEvent.Value));
                            return;
                        }
                    }
                }
            }

            _lastSequenceNumber = payload.S;
            Log(LogSeverity.Trace, $"Dispatch: {gatewayEvent.Value}.");
            switch (gatewayEvent)
            {
                case GatewayDispatch.Ready:
                {
                    _identifyTcs.TrySetResult(true);
                    Log(LogSeverity.Information, "Successfully identified.");
                    var model = payload.D.ToType<ReadyModel>();
                    _sessionId = model.SessionId;
                    _trace = model.Trace;

                    try
                    {
                        await State.HandleReadyAsync(model).ConfigureAwait(false);
                    }
                    finally
                    {
                        _readyTaskCompletionSource = new TaskCompletionSource<bool>();
                        _ = DelayedInvokeReadyAsync();
                    }
                    break;
                }

                case GatewayDispatch.Resumed:
                {
                    _identifyTcs.TrySetResult(true);
                    Log(LogSeverity.Information, "Resumed.");
                    break;
                }

                case GatewayDispatch.ChannelCreate:
                {
                    await State.HandleChannelCreateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.ChannelUpdate:
                {
                    await State.HandleChannelUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.ChannelDelete:
                {
                    await State.HandleChannelDeleteAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.ChannelPinsUpdate:
                {
                    await State.HandleChannelPinsUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildCreate:
                {
                    _lastGuildCreate = DateTimeOffset.UtcNow;
                    await State.HandleGuildCreateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildUpdate:
                {
                    await State.HandleGuildUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildDelete:
                {
                    await State.HandleGuildDeleteAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildBanAdd:
                {
                    await State.HandleGuildBanAddAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildBanRemove:
                {
                    await State.HandleGuildBanRemoveAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildEmojisUpdate:
                {
                    await State.HandleGuildEmojisUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildIntegrationsUpdate:
                {
                    // TODO
                    return;
                }

                case GatewayDispatch.GuildMemberAdd:
                {
                    await State.HandleGuildMemberAddAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildMemberRemove:
                {

                    await State.HandleGuildMemberRemoveAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildMemberUpdate:
                {
                    await State.HandleGuildMemberUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildMembersChunk:
                {
                    await State.HandleGuildMembersChunkAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildSync:
                {
                    await State.HandleGuildSyncAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildRoleCreate:
                {
                    await State.HandleGuildRoleCreateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildRoleUpdate:
                {
                    await State.HandleGuildRoleUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.GuildRoleDelete:
                {
                    await State.HandleGuildRoleDeleteAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.InviteCreate:
                {
                    await State.HandleInviteCreateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.InviteDelete:
                {
                    await State.HandleInviteDeleteAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageAck:
                {
                    // pass
                    return;
                }

                case GatewayDispatch.MessageCreate:
                {
                    await State.HandleMessageCreateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageUpdate:
                {
                    await State.HandleMessageUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageDelete:
                {
                    await State.HandleMessageDeleteAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageDeleteBulk:
                {
                    await State.HandleMessageDeleteBulkAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageReactionAdd:
                {
                    await State.HandleMessageReactionAddAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageReactionRemove:
                {
                    await State.HandleMessageReactionRemoveAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageReactionRemoveAll:
                {
                    await State.HandleMessageReactionRemoveAllAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.MessageReactionRemoveEmoji:
                {
                    await State.HandleMessageReactionRemoveEmojiAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.PresenceUpdate:
                {
                    await State.HandlePresenceUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.PresencesReplace:
                {
                    // TODO: implement for users?
                    return;
                }

                case GatewayDispatch.TypingStart:
                {
                    await State.HandleTypingStartedAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.UserUpdate:
                {
                    await State.HandleUserUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.VoiceStateUpdate:
                {
                    await State.HandleVoiceStateUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.VoiceServerUpdate:
                {
                    await State.HandleVoiceServerUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                case GatewayDispatch.WebhooksUpdate:
                {
                    await State.HandleWebhooksUpdateAsync(payload).ConfigureAwait(false);
                    return;
                }

                default:
                {
                    Log(LogSeverity.Warning, $"Unknown dispatch: {payload.T}\n{payload.D}");
                    return;
                }
            }
        }
    }
}
