namespace zd7
{
    class RegistrationValidator : IRegistrationValidator
    {

        private IEmailValidatorService emailValidator;

        private IPasswordValidatorService passwordValidator;

        public RegistrationValidator()
        {
            emailValidator = new EmailValidator();
            passwordValidator = new PasswordValidator(8);
        }
        public bool IsUserEntryValid(UserEntry entry)
        {
            if(emailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password))
            {
                return true;
            }

            return false;
        }
    }


}
