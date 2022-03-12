using System;

namespace StepOverflow.Entities
{
    public class UserLinks : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

    }
}
