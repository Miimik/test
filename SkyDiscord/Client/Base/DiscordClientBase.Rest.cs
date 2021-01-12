﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SkyDiscord.Rest;
using SkyDiscord.Rest.AuditLogs;

namespace SkyDiscord
{
    // TODO: sort or something
    public abstract partial class DiscordClientBase : IRestDiscordClient, IAsyncDisposable
    {
        public Task<string> GetGatewayUrlAsync(RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGatewayUrlAsync(options);
        public Task<RestGatewayBotResponse> GetGatewayBotUrlAsync(RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGatewayBotUrlAsync(options);
        public Task<RestApplication> GetCurrentApplicationAsync(RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetCurrentApplicationAsync(options);
        public Task<RestGuild> CreateGuildAsync(string name, string voiceRegionId = null, Stream icon = null, VerificationLevel verificationLevel = VerificationLevel.None, DefaultNotificationLevel defaultNotificationLevel = DefaultNotificationLevel.AllMessages, ContentFilterLevel contentFilterLevel = ContentFilterLevel.Disabled, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateGuildAsync(name, voiceRegionId, icon, verificationLevel, defaultNotificationLevel, contentFilterLevel, options);
        public Task<RestGuild> GetGuildAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGuildAsync(guildId, options);
        public Task<RestGuild> ModifyGuildAsync(Snowflake guildId, Action<ModifyGuildProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyGuildAsync(guildId, action, options);
        public Task DeleteGuildAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteGuildAsync(guildId, options);
        public Task<IReadOnlyList<RestGuildChannel>> GetChannelsAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetChannelsAsync(guildId, options);
        public Task<RestTextChannel> CreateTextChannelAsync(Snowflake guildId, string name, Action<CreateTextChannelProperties> action = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateTextChannelAsync(guildId, name, action, options);
        public Task<RestVoiceChannel> CreateVoiceChannelAsync(Snowflake guildId, string name, Action<CreateVoiceChannelProperties> action = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateVoiceChannelAsync(guildId, name, action, options);
        public Task<RestCategoryChannel> CreateCategoryChannelAsync(Snowflake guildId, string name, Action<CreateCategoryChannelProperties> action = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateCategoryChannelAsync(guildId, name, action, options);
        public Task ReorderChannelsAsync(Snowflake guildId, IReadOnlyDictionary<Snowflake, int> positions, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ReorderChannelsAsync(guildId, positions, options);
        public Task<RestMember> GetMemberAsync(Snowflake guildId, Snowflake memberId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetMemberAsync(guildId, memberId, options);
        public RestRequestEnumerable<RestMember> GetMembersEnumerable(Snowflake guildId, int limit, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetMembersEnumerable(guildId, limit, startFromId, options);
        public Task<IReadOnlyList<RestMember>> GetMembersAsync(Snowflake guildId, int limit = 1000, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetMembersAsync(guildId, limit, startFromId, options);
        public Task ModifyMemberAsync(Snowflake guildId, Snowflake memberId, Action<ModifyMemberProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyMemberAsync(guildId, memberId, action, options);
        public Task ModifyOwnNickAsync(Snowflake guildId, string nick, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyOwnNickAsync(guildId, nick, options);
        public Task GrantRoleAsync(Snowflake guildId, Snowflake memberId, Snowflake roleId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GrantRoleAsync(guildId, memberId, roleId, options);
        public Task RevokeRoleAsync(Snowflake guildId, Snowflake memberId, Snowflake roleId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).RevokeRoleAsync(guildId, memberId, roleId, options);
        public Task KickMemberAsync(Snowflake guildId, Snowflake memberId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).KickMemberAsync(guildId, memberId, options);
        public Task<IReadOnlyList<RestBan>> GetBansAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetBansAsync(guildId, options);
        public Task<RestBan> GetBanAsync(Snowflake guildId, Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetBanAsync(guildId, userId, options);
        public Task BanMemberAsync(Snowflake guildId, Snowflake memberId, string reason = null, int? deleteMessageDays = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).BanMemberAsync(guildId, memberId, reason, deleteMessageDays, options);
        public Task UnbanMemberAsync(Snowflake guildId, Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).UnbanMemberAsync(guildId, userId, options);
        public Task<IReadOnlyList<RestRole>> GetRolesAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetRolesAsync(guildId, options);
        public Task<RestRole> CreateRoleAsync(Snowflake guildId, Action<CreateRoleProperties> action = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateRoleAsync(guildId, action, options);
        public Task<IReadOnlyList<RestRole>> ReorderRolesAsync(Snowflake guildId, IReadOnlyDictionary<Snowflake, int> positions, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ReorderRolesAsync(guildId, positions, options);
        public Task<RestRole> ModifyRoleAsync(Snowflake guildId, Snowflake roleId, Action<ModifyRoleProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyRoleAsync(guildId, roleId, action, options);
        public Task DeleteRoleAsync(Snowflake guildId, Snowflake roleId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteRoleAsync(guildId, roleId, options);
        public Task<int> GetPruneCountAsync(Snowflake guildId, int days, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetPruneCountAsync(guildId, days, options);
        public Task<int?> PruneAsync(Snowflake guildId, int days, bool computePruneCount = true, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).PruneAsync(guildId, days, computePruneCount, options);
        public Task<IReadOnlyList<RestGuildVoiceRegion>> GetVoiceRegionsAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetVoiceRegionsAsync(guildId, options);
        public Task<IReadOnlyList<RestInvite>> GetGuildInvitesAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGuildInvitesAsync(guildId, options);
        public Task<RestWidget> GetWidgetAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetWidgetAsync(guildId, options);
        public Task<RestWidget> ModifyWidgetAsync(Snowflake guildId, Action<ModifyWidgetProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyWidgetAsync(guildId, action, options);
        public Task<string> GetVanityInviteAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetVanityInviteAsync(guildId, options);
        public Task<RestWebhook> CreateWebhookAsync(Snowflake channelId, string name, Stream avatar = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateWebhookAsync(channelId, name, avatar, options);
        public Task<IReadOnlyList<RestWebhook>> GetChannelWebhooksAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetChannelWebhooksAsync(channelId, options);
        public Task<IReadOnlyList<RestWebhook>> GetGuildWebhooksAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGuildWebhooksAsync(guildId, options);
        public Task<RestWebhook> GetWebhookAsync(Snowflake webhookId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetWebhookAsync(webhookId, options);
        public Task<RestWebhook> GetWebhookAsync(Snowflake webhookId, string webhookToken, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetWebhookAsync(webhookId, webhookToken, options);
        public Task<RestWebhook> ModifyWebhookAsync(Snowflake webhookId, Action<ModifyWebhookProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyWebhookAsync(webhookId, action, options);
        public Task<RestWebhook> ModifyWebhookAsync(Snowflake webhookId, string webhookToken, Action<ModifyWebhookProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyWebhookAsync(webhookId, webhookToken, action, options);
        public Task DeleteWebhookAsync(Snowflake webhookId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteWebhookAsync(webhookId, options);
        public Task DeleteWebhookAsync(Snowflake webhookId, string webhookToken, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteWebhookAsync(webhookId, webhookToken, options);
        public Task<RestUserMessage> ExecuteWebhookAsync(Snowflake webhookId, string webhookToken, string content = null, bool textToSpeech = false, IEnumerable<LocalEmbed> embeds = null, string name = null, string avatarUrl = null, bool wait = false, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ExecuteWebhookAsync(webhookId, webhookToken, content, textToSpeech, embeds, name, avatarUrl, wait, options);
        public Task<RestUserMessage> ExecuteWebhookAsync(Snowflake webhookId, string webhookToken, LocalAttachment attachment, string content = null, bool textToSpeech = false, IEnumerable<LocalEmbed> embeds = null, string name = null, string avatarUrl = null, bool wait = false, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ExecuteWebhookAsync(webhookId, webhookToken, attachment, content, textToSpeech, embeds, name, avatarUrl, wait, options);
        public Task<RestUserMessage> ExecuteWebhookAsync(Snowflake webhookId, string webhookToken, IEnumerable<LocalAttachment> attachments, string content = null, bool textToSpeech = false, IEnumerable<LocalEmbed> embeds = null, string name = null, string avatarUrl = null, bool wait = false, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ExecuteWebhookAsync(webhookId, webhookToken, attachments, content, textToSpeech, embeds, name, avatarUrl, wait, options);
        public Task<RestCurrentUser> GetCurrentUserAsync(RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetCurrentUserAsync(options);
        public Task<RestUser> GetUserAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetUserAsync(userId, options);
        public Task<RestCurrentUser> ModifyCurrentUserAsync(Action<ModifyCurrentUserProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyCurrentUserAsync(action, options);
        public RestRequestEnumerable<RestPartialGuild> GetGuildsEnumerable(int limit, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGuildsEnumerable(limit, direction, startFromId, options);
        public Task<IReadOnlyList<RestPartialGuild>> GetGuildsAsync(int limit = 100, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGuildsAsync(limit, direction, startFromId, options);
        public Task LeaveGuildAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).LeaveGuildAsync(guildId, options);
        public Task<IReadOnlyList<RestPrivateChannel>> GetPrivateChannelsAsync(RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetPrivateChannelsAsync(options);
        public Task<RestDmChannel> CreateDmChannelAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateDmChannelAsync(userId, options);
        public Task<IReadOnlyList<RestGuildEmoji>> GetGuildEmojisAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGuildEmojisAsync(guildId, options);
        public Task<RestGuildEmoji> GetGuildEmojiAsync(Snowflake guildId, Snowflake emojiId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetGuildEmojiAsync(guildId, emojiId, options);
        public Task<RestGuildEmoji> CreateGuildEmojiAsync(Snowflake guildId, Stream image, string name, IEnumerable<Snowflake> roleIds = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateGuildEmojiAsync(guildId, image, name, roleIds, options);
        public Task<RestGuildEmoji> ModifyGuildEmojiAsync(Snowflake guildId, Snowflake emojiId, Action<ModifyGuildEmojiProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyGuildEmojiAsync(guildId, emojiId, action, options);
        public Task DeleteGuildEmojiAsync(Snowflake guildId, Snowflake emojiId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteGuildEmojiAsync(guildId, emojiId, options);
        public Task<IReadOnlyList<RestVoiceRegion>> GetVoiceRegionsAsync(RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetVoiceRegionsAsync(options);
        public Task<RestChannel> GetChannelAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetChannelAsync(channelId, options);
        public Task<RestGroupChannel> ModifyGroupChannelAsync(Snowflake channelId, Action<ModifyGroupChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyGroupChannelAsync(channelId, action, options);
        public Task<RestTextChannel> ModifyTextChannelAsync(Snowflake channelId, Action<ModifyTextChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyTextChannelAsync(channelId, action, options);
        public Task<RestVoiceChannel> ModifyVoiceChannelAsync(Snowflake channelId, Action<ModifyVoiceChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyVoiceChannelAsync(channelId, action, options);
        public Task<RestCategoryChannel> ModifyCategoryChannelAsync(Snowflake channelId, Action<ModifyCategoryChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyCategoryChannelAsync(channelId, action, options);
        public Task DeleteOrCloseChannelAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteOrCloseChannelAsync(channelId, options);
        public RestRequestEnumerable<RestMessage> GetMessagesEnumerable(Snowflake channelId, int limit, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetMessagesEnumerable(channelId, limit, direction, startFromId, options);
        public Task<IReadOnlyList<RestMessage>> GetMessagesAsync(Snowflake channelId, int limit = 100, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetMessagesAsync(channelId, limit, direction, startFromId, options);
        public Task<RestMessage> GetMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetMessageAsync(channelId, messageId, options);
        public Task<RestUserMessage> SendMessageAsync(Snowflake channelId, string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).SendMessageAsync(channelId, content, textToSpeech, embed, mentions, options);
        public Task<RestUserMessage> SendMessageAsync(Snowflake channelId, LocalAttachment attachment, string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).SendMessageAsync(channelId, attachment, content, textToSpeech, embed, mentions, options);
        public Task<RestUserMessage> SendMessageAsync(Snowflake channelId, IEnumerable<LocalAttachment> attachments, string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).SendMessageAsync(channelId, attachments, content, textToSpeech, embed, mentions, options);
        public Task AddReactionAsync(Snowflake channelId, Snowflake messageId, IEmoji emoji, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).AddReactionAsync(channelId, messageId, emoji, options);
        public Task RemoveOwnReactionAsync(Snowflake channelId, Snowflake messageId, IEmoji emoji, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).RemoveOwnReactionAsync(channelId, messageId, emoji, options);
        public Task RemoveMemberReactionAsync(Snowflake channelId, Snowflake messageId, Snowflake memberId, IEmoji emoji, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).RemoveMemberReactionAsync(channelId, messageId, memberId, emoji, options);
        public RestRequestEnumerable<RestUser> GetReactionsEnumerable(Snowflake channelId, Snowflake messageId, IEmoji emoji, int limit, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetReactionsEnumerable(channelId, messageId, emoji, limit, startFromId, options);
        public Task<IReadOnlyList<RestUser>> GetReactionsAsync(Snowflake channelId, Snowflake messageId, IEmoji emoji, int limit = 100, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetReactionsAsync(channelId, messageId, emoji, limit, startFromId, options);
        public Task ClearReactionsAsync(Snowflake channelId, Snowflake messageId, IEmoji emoji = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ClearReactionsAsync(channelId, messageId, emoji, options);
        public Task<RestUserMessage> ModifyMessageAsync(Snowflake channelId, Snowflake messageId, Action<ModifyMessageProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).ModifyMessageAsync(channelId, messageId, action, options);
        public Task DeleteMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteMessageAsync(channelId, messageId, options);
        public RestRequestEnumerator<Snowflake> GetBulkMessageDeletionEnumerator(Snowflake channelId, IEnumerable<Snowflake> messageIds, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetBulkMessageDeletionEnumerator(channelId, messageIds, options);
        public Task DeleteMessagesAsync(Snowflake channelId, IEnumerable<Snowflake> messageIds, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteMessagesAsync(channelId, messageIds, options);
        public Task AddOrModifyOverwriteAsync(Snowflake channelId, LocalOverwrite overwrite, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).AddOrModifyOverwriteAsync(channelId, overwrite, options);
        public Task<IReadOnlyList<RestInvite>> GetChannelInvitesAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetChannelInvitesAsync(channelId, options);
        public Task<RestInvite> CreateInviteAsync(Snowflake channelId, int maxAgeSeconds = 86400, int maxUses = 0, bool isTemporaryMembership = false, bool isUnique = false, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateInviteAsync(channelId, maxAgeSeconds, maxUses, isTemporaryMembership, isUnique, options);
        public Task<RestInvite> CreateInviteAsync(Snowflake channelId, TimeSpan maxAge, int maxUses = 0, bool isTemporaryMembership = false, bool isUnique = false, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).CreateInviteAsync(channelId, maxAge, maxUses, isTemporaryMembership, isUnique, options);
        public Task DeleteOverwriteAsync(Snowflake channelId, Snowflake targetId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteOverwriteAsync(channelId, targetId, options);
        public Task TriggerTypingAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).TriggerTypingAsync(channelId, options);
        public Task<IReadOnlyList<RestUserMessage>> GetPinnedMessagesAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetPinnedMessagesAsync(channelId, options);
        public Task PinMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).PinMessageAsync(channelId, messageId, options);
        public Task UnpinMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).UnpinMessageAsync(channelId, messageId, options);
        public Task AddGroupRecipientAsync(Snowflake channelId, Snowflake userId, string nick = null, string accessToken = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).AddGroupRecipientAsync(channelId, userId, nick, accessToken, options);
        public Task RemoveGroupRecipientAsync(Snowflake channelId, Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).RemoveGroupRecipientAsync(channelId, userId, options);
        public Task<RestInvite> GetInviteAsync(string code, bool withCounts = true, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetInviteAsync(code, withCounts, options);
        public Task<RestInvite> DeleteInviteAsync(string code, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).DeleteInviteAsync(code, options);
        public RestRequestEnumerable<RestAuditLog> GetAuditLogsEnumerable(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetAuditLogsEnumerable(guildId, limit, userId, startFromId, options);
        public RestRequestEnumerable<T> GetAuditLogsEnumerable<T>(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null, RestRequestOptions options = null) where T : RestAuditLog => ((IRestDiscordClient) RestClient).GetAuditLogsEnumerable<T>(guildId, limit, userId, startFromId, options);
        public Task<IReadOnlyList<RestAuditLog>> GetAuditLogsAsync(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetAuditLogsAsync(guildId, limit, userId, startFromId, options);
        public Task<IReadOnlyList<T>> GetAuditLogsAsync<T>(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null, RestRequestOptions options = null) where T : RestAuditLog => ((IRestDiscordClient) RestClient).GetAuditLogsAsync<T>(guildId, limit, userId, startFromId, options);
        public Task<RestPreview> GetPreviewAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) RestClient).GetPreviewAsync(guildId, options);
    }
}