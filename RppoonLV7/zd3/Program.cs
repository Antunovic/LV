using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

namespace zd3
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider systemDataProvider = new SystemDataProvider();

            systemDataProvider.Attach(new FileLogger("performance.txt"));
            systemDataProvider.Attach(new ConsoleLogger());

            for(; ; )
            {
                //Console.WriteLine($"cpu:{}");
                //Console.WriteLine($"ram:{systemDataProvider.GetAvailableRAM()}");


                systemDataProvider.GetCPULoad();
                systemDataProvider.GetAvailableRAM();

                

                System.Threading.Thread.Sleep(1000);
            }
        }
    }

}
