namespace TDLib.Samples.GetChats.Model
{
    using System;

    public class Shill
    {
        public string Address { get; set; }

        public int Mentions { get; set; }

        public DateTime FirstMention { get; set; }

        public DateTime LastMention { get; set; }
    }
}