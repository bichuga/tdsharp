using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class GroupCallJoinResponse : Object
        {
            /// <summary>
            /// Describes that group call needs to be joined as a stream
            /// </summary>
            public class GroupCallJoinResponseStream : GroupCallJoinResponse
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "groupCallJoinResponseStream";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}