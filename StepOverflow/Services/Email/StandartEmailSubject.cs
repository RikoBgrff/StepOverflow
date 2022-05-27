namespace StepOverflow.Services.Email
{
    public static class StandartEmailSubject
    {
        static public string LoginInfo { get; set; } = "Logged In";
        static public string VerifyAccount { get; set; } = "Verify your account";
        static public string VerificationSucsess { get; set; } = "Account Verified Sucsessfully";
        public static string VerificationFailure { get; set; } = "Account Verification Failed";
        static public string Info { get; set; } 
    }
}
