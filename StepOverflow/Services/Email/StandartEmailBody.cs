using StepOverflow.Entities;

namespace StepOverflow.Services.Email
{
    public static class StandartEmailBody
    {
        public static AppUser User { get; set; }
        public static string VerificationSucsess { get; set; } = @$"Hello {User.Name},
Your account has been verified.
You can enjoy your time!
Best Regards,StepOverflow Team!";
        public static string VerificationFailure { get; set; } = @$"Hello {User.Name},
Your account could not verified.
We ask you try again,if you get fail again please contact our support team via stepoverflow.support@gmail.com.
Best Regards,StepOverflow Team!";
    }
}
