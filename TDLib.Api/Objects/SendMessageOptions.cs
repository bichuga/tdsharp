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
        /// Options to be used when a message is send
        /// </summary>
        public class SendMessageOptions : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendMessageOptions";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Pass true to disable notification for the message. Must be false if the message is sent to a secret chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_notification")]
            public bool DisableNotification { get; set; }

            /// <summary>
            /// Pass true if the message is sent from the background
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("from_background")]
            public bool FromBackground { get; set; }

            /// <summary>
            /// Message scheduling state. Messages sent to a secret chat, live location messages and self-destructing messages can't be scheduled
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("scheduling_state")]
            public MessageSchedulingState SchedulingState { get; set; }
        }
    }
}