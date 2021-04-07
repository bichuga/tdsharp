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
        private Shill sampleShill;

        private Channel sampleChannel;

        private ShillCollection shillCollection;

        [TestInitialize]
        public void Init()
        {
            this.shillCollection = new ShillCollection();
            this.sampleChannel = new Channel { ChannelId = 2, Name = "my channel" };
            this.sampleShill = new Shill { Address = "https://foo.finance" };
            this.shillCollection.AllChannels.Add(this.sampleChannel);
            this.shillCollection.AllShills.Add(this.sampleShill);
        }

        [TestMethod]
        public void LoadState()
        {
            var sl = Substitute.For<IStateLoader>();
            sl.Load().Returns(shillCollection);

            var stateManager = new StateManager(sl);
            stateManager.Init();
            stateManager.Sites.ContainsKey("foo.finance").Should().BeTrue();
            stateManager.Sites["foo.FINANCE"].Should().Be(this.sampleShill);

            stateManager.Channels.ContainsKey(2).Should().BeTrue();
            stateManager.Channels[2].Should().Be(this.sampleChannel);

            sl.Received(1).Load();
        }

        [TestMethod]
        public void SaveState()
        {
            var sl = Substitute.For<IStateLoader>();
            var sm = new StateManager(sl);

            sm.Save();

            sl.Received(1).Save(Arg.Any<ShillCollection>());
        }
    }
}