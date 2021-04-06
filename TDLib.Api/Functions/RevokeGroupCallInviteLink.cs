namespace TdLib
{
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    /// <summary>Autogenerated TDLib APIs</summary>
    public static partial class TdApi
    {
        /// <summary>Revokes invite link for a group call. Requires groupCall.can_be_managed group
        /// call flag</summary>
        public static Task<Ok> RevokeGroupCallInviteLinkAsync(this Client client, int groupCallId = default)
        {
            return client.ExecuteAsync(new RevokeGroupCallInviteLink { GroupCallId = groupCallId });
        }

        /// <summary>Revokes invite link for a group call. Requires groupCall.can_be_managed group
        /// call flag</summary>
        public class RevokeGroupCallInviteLink : Function<Ok>
        {
            /// <summary>Data type for serialization</summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "revokeGroupCallInviteLink";

            /// <summary>Extra data attached to the function</summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>Group call identifier</summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }
        }
    }
}