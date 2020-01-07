using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Interfaces;

namespace ServiceProxy.Server
{
    public class ServerCallback : IServerCallBack
    {
        public void SendData(string msg)
        {
            Console.WriteLine("服务器端返回" + msg);
        }
    }
}
