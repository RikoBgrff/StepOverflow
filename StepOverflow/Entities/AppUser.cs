using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace StepOverflow.Entities
{
    public class AppUser : IdentityUser,IEntity
    {
        public List<AppRole> Roles { get; set; }
        public string ProfilePicture { get; set; }
        public int? ReputationCount { get; set; }
        public int? AnswersCount { get; set; }
        public int? QuestionsCount { get; set; }
        public List<Question>? Questions { get; set; }
        public List<Answer>? Answers { get; set; }
        public string? Location { get; set; }
        public List<UserLinks>? UserLinks { get; set; }
        public int? JobStatus { get; set; } = 0;
        public string? Resume { get; set; }
        public List<Job>? SavedJobs { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? Biography { get; set; }
        int IEntity.Id { get; set; }
    }
}
