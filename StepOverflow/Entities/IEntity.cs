using System;

namespace StepOverflow.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
