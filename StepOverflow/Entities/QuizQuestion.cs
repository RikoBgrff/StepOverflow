using System;
using System.Collections.Generic;

namespace StepOverflow.Entities
{
    public class QuizQuestion : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public string TrueAnswer { get; set; }


    }
}
