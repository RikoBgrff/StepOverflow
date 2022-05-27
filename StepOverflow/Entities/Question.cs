using System.Collections.Generic;

namespace StepOverflow.Entities
{
    public class Question : Post
    {
        public List<Answer> Answers { get; set; }

    }
}
