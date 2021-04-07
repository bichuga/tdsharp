namespace ShillCollector
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using ShillCollector.Model;

    using TDLib.Samples.GetChats.Model;

    public class StateManager
    {
        private readonly IStateLoader stateLoader;

        private readonly Regex siteEx = new("https?://(.*)", RegexOptions.IgnoreCase);

        public StateManager(IStateLoader stateLoader)
        {
            this.stateLoader = stateLoader;
        }

        public SortedDictionary<string, Shill> Sites { get; } = new(StringComparer.OrdinalIgnoreCase);

        public SortedDictionary<int, Channel> Channels { get; } = new();

        public void Init()
        {
            ShillCollection sc = this.stateLoader.Load();
            foreach (Shill shill in sc.AllShills)
            {
                Match match = this.siteEx.Match(shill.Address);
                if (match.Success)
                {
                    this.Sites[match.Groups[1].Value] = shill;
                }
                else
                {
                    Console.WriteLine($"Unable to parse {shill.Address}");
                }
            }

            foreach (Channel channel in sc.AllChannels)
            {
                this.Channels[channel.ChannelId] = channel;
            }
        }

        public void Save()
        {
            var sc = new ShillCollection();
            sc.AllChannels = this.Channels.Values.ToList();
            sc.AllShills = this.Sites.Values.ToList();
            this.stateLoader.Save(sc);
        }
    }
}