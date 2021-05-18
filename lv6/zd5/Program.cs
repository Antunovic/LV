using System;

namespace zd5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            logger.Log("razvoj", MessageType.INFO);
            fileLogger.Log("rppoon LV6", MessageType.ERROR);

           


        }
    }
}
