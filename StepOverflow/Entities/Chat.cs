using System;

namespace StepOverflow.Entities
{
    public class Chat : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Message Message { get; set; }

    }
}
