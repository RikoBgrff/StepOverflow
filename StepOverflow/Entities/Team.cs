using System;
using System.Collections.Generic;

namespace StepOverflow.Entities
{
    public class Team : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public List<AppUser> Members { get; set; }
        public AppUser Leader { get; set; }
        public AppUser Moderator { get; set; }
        public void NotifyMembers()
        {
            //code
        }

    }
}
