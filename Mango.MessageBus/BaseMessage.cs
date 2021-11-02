using System;

namespace Mango.MessageBus
{
    public class BaseMessage
    {
        public int Id { get; set; }
        public string MessageCreated { get; set; }
    }
}
