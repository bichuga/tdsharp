using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class LinkState : Object
        {
            public class LinkStateKnowsPhoneNumber : LinkState
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "linkStateKnowsPhoneNumber";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}