using System;
using System.ServiceModel;
using WCF.Datas.Structs;
using WCF.Interfaces;

namespace ChatService.Core
{
    public class ChatOperatorService : IChatServerOperator
    {
        public void Exit()
        {
            throw new NotImplementedException();
        }
        public void Join(ClientData clientData)
        {
            if (clientData==null)
            {
                
            }
        }

        public void Send(string msg)
        {
            OperationContext.Current.GetCallbackChannel<IServerCallBack>().SendData(msg);
        }
    }
}
