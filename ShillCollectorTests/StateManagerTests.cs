namespace ShillCollectorTests
{
    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NSubstitute;

    using ShillCollector;
    using ShillCollector.Model;

    using TDLib.Samples.GetChats.Model;

    [TestClass]
    public class StateManagerTests
    {
        [TestMethod]
        public void LoadState()
        {
            var sc = new ShillCollection();
            var channel = new Channel { ChannelId = 2, Name = "my channel" };
            sc.AllChannels.Add(channel);
            var shill = new Shill { Address = "https://foo.finance" };
            sc.AllShills.Add(shill);
            var sl = Substitute.For<IStateLoader>();
            sl.Load().Returns(sc);

            var stateManager = new StateManager(sl);
            stateManager.Init();
            stateManager.Sites.ContainsKey("foo.finance").Should().BeTrue();
            stateManager.Sites["foo.FINANCE"].Should().Be(shill);

            stateManager.Channels.ContainsKey(2).Should().BeTrue();
            stateManager.Channels[2].Should().Be(channel);

            sl.Received(1).Load();
        }
    }
}