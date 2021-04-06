namespace TDLib.Samples.GetChats.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Shill
    {
        public string Address { get; set; }
        public int Mentions { get; set; }
        public DateTime FirstMention { get; set; }
        public DateTime LastMention { get; set; }
    }

    public class ShillCollection
    {
        public List<Shill> AllShills { get; set; } = new List<Shill>();
    }
}
