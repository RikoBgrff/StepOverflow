using System;
using System.Collections.Generic;

namespace StepOverflow.Entities
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public AppUser User { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public string Topic { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
