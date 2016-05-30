namespace SeenTechnology.Domain.Entities
{
    public class SocketTracking : Entity<long>
    {
        public virtual string ReceivedContent { get; set; }
        public virtual string SentContent { get; set; }
        public virtual int ReceivedBytes { get; set; }
        public virtual int SentBytes { get; set; }
        public virtual MobileDevice MobileDevice { get; set; }
        public virtual MessageType MessageType { get; set; }
    }
}
