using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required,
        CallbackContract = typeof(IServerCallBack))]
    public interface IChatServerOperator
    {
        [OperationContract(IsOneWay =true,IsInitiating =true,IsTerminating =false)]
        void Send(string msg);

    }
}
