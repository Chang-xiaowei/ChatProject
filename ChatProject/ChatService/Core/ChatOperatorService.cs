using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Interfaces;

namespace ChatService.Core
{
    public class ChatOperatorService : IChatServerOperator
    {
        public void Send(string msg)
        {
            OperationContext.Current.GetCallbackChannel<IServerCallBack>().SendData(msg);
        }
    }
}
