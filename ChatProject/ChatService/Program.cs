using ChatService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ChatOperatorService)))
            {
                host.Opened -= Host_Opened;
                host.Opened += Host_Opened;
                host.Open();
                Console.ReadKey();
                host.Close();                
            }
        }

        private static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("服务已经打开"+DateTime.Now.ToString());
        }
    }
}
