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
        /// Describes a document of any type
        /// </summary>
        public partial class Document : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "document";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Original name of the file; as defined by the sender
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_name")]
            public string FileName { get; set; }

            /// <summary>
            /// MIME type of the file; as defined by the sender
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("mime_type")]
            public string MimeType { get; set; }

            /// <summary>
            /// Document minithumbnail; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("minithumbnail")]
            public Minithumbnail Minithumbnail { get; set; }

            /// <summary>
            /// Document thumbnail in JPEG or PNG format (PNG will be used only for background patterns); as defined by the sender; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("thumbnail")]
            public PhotoSize Thumbnail { get; set; }

            /// <summary>
            /// File containing the document
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("document")]
            public File Document_ { get; set; }
        }
    }
}