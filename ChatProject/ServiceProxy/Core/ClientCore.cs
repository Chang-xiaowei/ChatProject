using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Utility.Tools;
using WCF.Datas;

namespace ServiceProxy.Core
{
    public sealed class ClientCore
    {
        //todo 从客户端拿到数据发送到服务器端
        #region - Variables 
        private ClientData mCurrentClientData = null;
        private static ClientCore mInstance = new ClientCore();
        private  ServerProxyCore mServerProxyCore = ServerProxyCore.GetInStance();
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -

        #endregion

        #region - public Functions -
        private ClientCore()
        {
            mCurrentClientData = new ClientData();
            mCurrentClientData.IP = PubFunHelper.GetLocalIP();
            mCurrentClientData.Name = Dns.GetHostName();
            Join();
        }
        public static ClientCore GetInstance()
        {
            return mInstance;
        }
        
        public void Send(string msg)
        {
            mServerProxyCore.Send(msg);
        }
        public void Join()
        {
            mServerProxyCore.Join(mCurrentClientData);
        }
        #endregion

        #region - Private Functions -

        #endregion
        

        #region - Events Functions -

        #endregion

    }
}
