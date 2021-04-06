using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains a list of chat invite links
        /// </summary>
        public partial class ChatInviteLinks : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatInviteLinks";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Approximate total count of chat invite links found
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("total_count")]
public int TotalCount { get; set; }

/// <summary>
/// List of invite links
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("invite_links")]
public ChatInviteLink[] InviteLinks { get; set; }


        }
    }
}
