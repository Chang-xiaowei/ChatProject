using ServiceProxy.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Datas;

namespace ServiceProxy.Core
{
    public class ServerProxyCore
    {
        #region - Variables 
        private ClientData mCurrentClientData = null;       
        private static ServerProxyCore mInstance = new ServerProxyCore();
        private static ServerServiceProxy mServerServiceProxy = ServerServiceProxy.GetInstance();
        #endregion

        #region - Properties -
        public ClientData CurrentClient
        {
            get { return mCurrentClientData; }
        }
        #endregion

        #region - Constructors -
        private ServerProxyCore()
        {
           
        }
        #endregion

        #region - public Functions -
        public static ServerProxyCore GetInStance()
        {
            return mInstance;
        }
        public void Join(ClientData client)
        {
            mServerServiceProxy.Join(client);
        }
        public void Send(string msg)
        {
            mServerServiceProxy.Send(msg);
        }
        public void Exit()
        {
            mServerServiceProxy.Exit();
        }
        #endregion

        #region - Private Functions -
     
        #endregion

        #region - Private Functions -

        #endregion

        #region - Events Functions -

        #endregion

    }
}
