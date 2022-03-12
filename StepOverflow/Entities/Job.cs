using System.Collections.Generic;

namespace StepOverflow.Entities
{
    public class Job : Post
    {
        public string JobType { get; set; }
        public string JobExperienceLevel { get; set; }
        public string JobRole { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string CompanyCountry { get; set; }
        public List<Benefit> Benefits { get; set; }
    }
}
