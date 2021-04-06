using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Returns users and chats that were blocked by the current user
        /// </summary>
        public class GetBlockedMessageSenders : Function<MessageSenders>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getBlockedMessageSenders";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Number of users and chats to skip in the result; must be non-negative
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public int Offset { get; set; }

            /// <summary>
            /// The maximum number of users and chats to return; up to 100
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns users and chats that were blocked by the current user
        /// </summary>
        public static Task<MessageSenders> GetBlockedMessageSendersAsync(
            this Client client, int offset = default, int limit = default)
        {
            return client.ExecuteAsync(new GetBlockedMessageSenders
            {
                Offset = offset, Limit = limit
            });
        }
    }
}