using System;

namespace StepOverflow.Entities
{
    public class Benefit : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Name { get; set; }

    }
}
