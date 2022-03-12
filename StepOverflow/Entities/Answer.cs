using System;

namespace StepOverflow.Entities
{
    public class Answer : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }

        public int QuestionId { get; set; }
    }
}
