namespace TdLib
{
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    /// <summary>Autogenerated TDLib APIs</summary>
    public static partial class TdApi
    {
        /// <summary>Deletes all call messages</summary>
        public static Task<Ok> DeleteAllCallMessagesAsync(this Client client, bool revoke = default)
        {
            return client.ExecuteAsync(new DeleteAllCallMessages { Revoke = revoke });
        }

        /// <summary>Deletes all call messages</summary>
        public class DeleteAllCallMessages : Function<Ok>
        {
            /// <summary>Data type for serialization</summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteAllCallMessages";

            /// <summary>Extra data attached to the function</summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>Pass true to delete the messages for all users</summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("revoke")]
            public bool Revoke { get; set; }
        }
    }
}