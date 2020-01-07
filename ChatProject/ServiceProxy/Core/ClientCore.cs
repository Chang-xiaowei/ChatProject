using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy.Core
{
    public sealed class ClientCore
    {
        //todo 从客户端拿到数据发送到服务器端
        #region - Variables 
        private static ClientCore mInstance = new ClientCore();
        private static ServerProxyCore mServerProxyCore = ServerProxyCore.GetInStance();
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -

        #endregion

        #region - public Functions -
        public static ClientCore GetInstance()
        {
            return mInstance;
        }
        
        public void Send(string msg)
        {
            mServerProxyCore.Send(msg);
        }
        #endregion

        #region - Private Functions -

        #endregion

       

        #region - Events Functions -

        #endregion

    }
}
