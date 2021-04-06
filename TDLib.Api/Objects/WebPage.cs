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
        /// Describes a web page preview
        /// </summary>
        public partial class WebPage : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "webPage";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Original URL of the link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// URL to display
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("display_url")]
            public string DisplayUrl { get; set; }

            /// <summary>
            /// Type of the web page. Can be: article, photo, audio, video, document, profile, app, or something else
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public string Type { get; set; }

            /// <summary>
            /// Short name of the site (e.g., Google Docs, App Store)
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("site_name")]
            public string SiteName { get; set; }

            /// <summary>
            /// Title of the content
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("description")]
            public string Description { get; set; }

            /// <summary>
            /// Image representing the content; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public Photo Photo { get; set; }

            /// <summary>
            /// URL to show in the embedded preview
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("embed_url")]
            public string EmbedUrl { get; set; }

            /// <summary>
            /// MIME type of the embedded preview, (e.g., text/html or video/mp4)
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("embed_type")]
            public string EmbedType { get; set; }

            /// <summary>
            /// Width of the embedded preview
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("embed_width")]
            public int EmbedWidth { get; set; }

            /// <summary>
            /// Height of the embedded preview
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("embed_height")]
            public int EmbedHeight { get; set; }

            /// <summary>
            /// Duration of the content, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("duration")]
            public int Duration { get; set; }

            /// <summary>
            /// Author of the content
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("author")]
            public string Author { get; set; }

            /// <summary>
            /// Preview of the content as an animation, if available; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("animation")]
            public Animation Animation { get; set; }

            /// <summary>
            /// Preview of the content as an audio file, if available; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("audio")]
            public Audio Audio { get; set; }

            /// <summary>
            /// Preview of the content as a document, if available (currently only available for small PDF files and ZIP archives); may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("document")]
            public Document Document { get; set; }

            /// <summary>
            /// Preview of the content as a sticker for small WEBP files, if available; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public Sticker Sticker { get; set; }

            /// <summary>
            /// Preview of the content as a video, if available; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("video")]
            public Video Video { get; set; }

            /// <summary>
            /// Preview of the content as a video note, if available; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("video_note")]
            public VideoNote VideoNote { get; set; }

            /// <summary>
            /// Preview of the content as a voice note, if available; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("voice_note")]
            public VoiceNote VoiceNote { get; set; }

            /// <summary>
            /// Version of instant view, available for the web page (currently can be 1 or 2), 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("instant_view_version")]
            public int InstantViewVersion { get; set; }
        }
    }
}