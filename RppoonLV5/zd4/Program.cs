﻿using System;

namespace zd4
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggingProxy loggingProxy = new LoggingProxy();

            DataConsolePrinter.PrintData(loggingProxy.GetData());
        }
    }

}
