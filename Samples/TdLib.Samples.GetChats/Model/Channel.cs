namespace ShillCollector.Model
{
    public class Channel
    {
        public int ChannelId { get; set; }

        public string Name { get; set; }

        public long OldestChatProcessed { get; set; }

        public long NewestChatProcessed { get; set; }
    }
}