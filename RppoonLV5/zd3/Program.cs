using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace zd3
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("csv.csv");

            DataConsolePrinter.PrintData(virtualProxy.GetData());


            User user = User.GenerateUser("pero");

            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(user);

            DataConsolePrinter.PrintData(protectionProxy.GetData());

        }
    }

}
