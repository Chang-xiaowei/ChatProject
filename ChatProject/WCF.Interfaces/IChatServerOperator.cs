using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Datas.Structs;

namespace WCF.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required,
        CallbackContract = typeof(IServerCallBack))]
    public interface IChatServerOperator
    {
        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
        void Join(ClientData clientData);
        [OperationContract(IsOneWay =true,IsInitiating =true,IsTerminating =false)]
        void Send(string msg);

        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = true)]
        void Exit();
    }
}
