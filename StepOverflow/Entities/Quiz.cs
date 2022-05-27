using System;
using System.Collections.Generic;

namespace StepOverflow.Entities
{
    public class Quiz : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Subject { get; set; }
        public List<QuizQuestion> Questions { get; set; }
        public int DifficultyLevel { get; set; } = (int)Difficulty.Easy;
    }
}
