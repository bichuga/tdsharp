namespace ShillCollectorTests
{
    using System;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Newtonsoft.Json;

    using ShillCollector.Model;

    using TDLib.Samples.GetChats.Model;

    [TestClass]
    public class ModelTests
    {
        private const string SingleRecord =
            @"{""AllShills"":[{""Address"":""https://foo.finance"",""Mentions"":3,""FirstMention"":""2021-04-05T03:11:00"",""LastMention"":""2021-04-06T03:12:00""}],""AllChannels"":[{""ChannelId"":1234,""Name"":""Luke's Hullabalooga"",""OldestChatProcessed"":12313232,""NewestChatProcessed"":998989898}]}";

        [TestMethod]
        public void Deserialize_HappyPath()
        {
            var sc = new ShillCollection();
            sc.AllShills.Add(
                             new Shill
                             {
                                 Address = "https://foo.finance",
                                 FirstMention = new DateTime(2021, 4, 5, 3, 11, 0),
                                 LastMention = new DateTime(2021, 4, 6, 3, 12, 0),
                                 Mentions = 3
                             });
            sc.AllChannels.Add(new Channel { ChannelId = 1234, Name = "Luke's Hullabalooga", OldestChatProcessed = 12313232, NewestChatProcessed = 998989898 });
            JsonConvert.SerializeObject(sc).Should().Be(SingleRecord);
        }

        [TestMethod]
        public void Serialize_HappyPath()
        {
            var shills = JsonConvert.DeserializeObject<ShillCollection>(SingleRecord);
            shills.AllShills.Should().HaveCount(1);
            shills.AllShills[0].FirstMention.Should().Be(new DateTime(2021, 4, 5, 3, 11, 0));
        }
    }
}