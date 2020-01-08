using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ServiceModel;
using WCF.Datas;
using WCF.Interfaces;

namespace ChatService
{
    public class ChatOperatorService : IChatServerOperator
    {
        #region - Variables 
        private List<string> mClientListenList = new List<string>();
        private ServerCore mServerCore = ServerCore.GetInstance();
        private ConcurrentDictionary<string, ClientData> mClientDatadics = new ConcurrentDictionary<string, ClientData>();//管理多个客户端队列
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -

        #endregion

        #region - public Functions -
        public void Exit()
        {
            throw new NotImplementedException();
        }
        public void Join(ClientData clientData)
        {
            if (clientData == null)
            {

            }
        }
        public void Send(string msg)
        {
            OperationContext.Current.GetCallbackChannel<IServerCallBack>().SendData(msg);
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
