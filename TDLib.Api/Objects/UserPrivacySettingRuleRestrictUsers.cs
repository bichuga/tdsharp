using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class UserPrivacySettingRule : Object
        {
            public class UserPrivacySettingRuleRestrictUsers : UserPrivacySettingRule
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingRuleRestrictUsers";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_ids")]
                public int[] UserIds { get; set; }
            }
        }
    }
}