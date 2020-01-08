using ServiceProxy.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Datas;
using WCF.Interfaces;

namespace ServiceProxy
{
    public class ServerServiceProxy : IChatServerOperator
    {
        #region - Variables 
        private static ServerServiceProxy mInstance = new ServerServiceProxy();
        private ServerServiceClient mServerClient = null;
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -
        public ServerServiceProxy()
        {

        }
        public static ServerServiceProxy GetInstance()
        {
            return mInstance;
        }
        #endregion

        #region - public Functions -
        public void Join(ClientData client)
        {
            if (null == client || mServerClient != null)
            {
                return;
            }
            mServerClient = new ServerServiceClient(new InstanceContext(new ServerCallback()), "defalultOperationClient");
            client.Port = mServerClient.Endpoint.Address.Uri.Port.ToString();
            try
            {
                mServerClient.Join(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Send(string msg)
        {
            mServerClient.Send(msg);
        }
        public void Exit()
        {
            mServerClient.Exit();
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
