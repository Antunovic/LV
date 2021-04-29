using System;

namespace zd6
{
    class Program
    {
        static void Main(string[] args)
        {

            string password1 = "a5F3t8s";
            string password2 = "a5F%(3t8s";
            string password3 = "at#148s";

            string email1 = "aantunovic@etfos.hr";
            string email2 = "aantunovic@gmail.com";
            string email3 = "aanutnovvic.hr";

            EmailValidator emailValidator = new EmailValidator();

            PasswordValidator passwordValidator = new PasswordValidator(8);

            Console.WriteLine(passwordValidator.IsValidPassword(password1));
            Console.WriteLine(passwordValidator.IsValidPassword(password2));
            Console.WriteLine(passwordValidator.IsValidPassword(password3));

            Console.WriteLine(emailValidator.IsValidAddress(email1));
            Console.WriteLine(emailValidator.IsValidAddress(email2));
            Console.WriteLine(emailValidator.IsValidAddress(email3));
        }
    }

}
