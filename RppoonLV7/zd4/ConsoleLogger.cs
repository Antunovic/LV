using System;

namespace zd3
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine($"time: {DateTime.Now}, CPU load:{provider.CPULoad}, Available RAM:{provider.AvailableRAM}");

        }
    }

}
