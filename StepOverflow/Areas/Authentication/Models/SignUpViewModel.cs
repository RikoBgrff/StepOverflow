using System;

namespace StepOverflow.Areas.Register.Models
{
    public class SignUpViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public string Location { get; set; }
        public string Biography { get; set; }
        public string PhoneNumber { get; set; }

    }
}
