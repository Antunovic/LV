using System;

namespace zd7
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationValidator registration = new RegistrationValidator();

            UserEntry user;


            do
            {
                user = UserEntry.ReadUserFromConsole();
            }
            while (registration.IsUserEntryValid(user)!=true);
        }
    }


}
