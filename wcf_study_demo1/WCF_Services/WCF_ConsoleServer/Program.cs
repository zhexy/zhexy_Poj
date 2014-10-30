using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCF_ServerLib;

namespace WCF_ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(StockDao));
            host.Open();
            Console.WriteLine("服务已经启动......,请按任意键结束");
            Console.ReadLine();
            host.Close();            
        }
    }
}
