using System;

namespace zd4
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;

        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }

            return instance;
        }

        public void LogTime()
        {
            Console.WriteLine(DateTime.Now);
        }

    }

}
