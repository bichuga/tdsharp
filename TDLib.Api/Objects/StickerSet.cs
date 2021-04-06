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
        /// Represents a sticker set
        /// </summary>
        public partial class StickerSet : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "stickerSet";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the sticker set
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public long Id { get; set; }

            /// <summary>
            /// Title of the sticker set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Name of the sticker set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Sticker set thumbnail in WEBP or TGS format with width and height 100; may be null. The file can be downloaded only before the thumbnail is changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("thumbnail")]
            public PhotoSize Thumbnail { get; set; }

            /// <summary>
            /// Sticker set thumbnail's outline represented as a list of closed vector paths; may be empty. The coordinate system origin is in the upper-left corner
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("thumbnail_outline")]
            public ClosedVectorPath[] ThumbnailOutline { get; set; }

            /// <summary>
            /// True, if the sticker set has been installed by the current user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_installed")]
            public bool IsInstalled { get; set; }

            /// <summary>
            /// True, if the sticker set has been archived. A sticker set can't be installed and archived simultaneously
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_archived")]
            public bool IsArchived { get; set; }

            /// <summary>
            /// True, if the sticker set is official
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_official")]
            public bool IsOfficial { get; set; }

            /// <summary>
            /// True, is the stickers in the set are animated
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_animated")]
            public bool IsAnimated { get; set; }

            /// <summary>
            /// True, if the stickers in the set are masks
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_masks")]
            public bool IsMasks { get; set; }

            /// <summary>
            /// True for already viewed trending sticker sets
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_viewed")]
            public bool IsViewed { get; set; }

            /// <summary>
            /// List of stickers in this set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("stickers")]
            public Sticker[] Stickers { get; set; }

            /// <summary>
            /// A list of emoji corresponding to the stickers in the same order. The list is only for informational purposes, because a sticker is always sent with a fixed emoji from the corresponding Sticker object
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("emojis")]
            public Emojis[] Emojis { get; set; }
        }
    }
}