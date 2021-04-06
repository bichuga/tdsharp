namespace ShillCollectorTests
{
    using System;
    using System.Diagnostics;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Newtonsoft.Json;

    using TDLib.Samples.GetChats.Model;

    [TestClass]
    public class ModelTests
    {
        private const string SingleRecord =
            @"{""AllShills"":[{""Address"":""https://foo.finance"",""Mentions"":3,""FirstMention"":""2021-04-05T03:11:00"",""LastMention"":""2021-04-06T03:12:00""}]}";

        [TestMethod]
        public void Deserialize_HappyPath()
        {
            var sc = new ShillCollection();
            sc.AllShills.Add(new Shill{Address = "https://foo.finance", FirstMention = new DateTime(2021, 4,5, 3,11,0), LastMention = new DateTime(2021, 4, 6,3,12,0), Mentions = 3});

            JsonConvert.SerializeObject(sc).Should().Be(SingleRecord);
        }
        [TestMethod]
        public void Serialize_HappyPath()
        {
            ShillCollection shills = JsonConvert.DeserializeObject<ShillCollection>(SingleRecord);
            shills.AllShills.Should().HaveCount(1);
            shills.AllShills[0].FirstMention.Should().Be(new DateTime(2021, 4, 5, 3, 11, 0));
        }
    }
}