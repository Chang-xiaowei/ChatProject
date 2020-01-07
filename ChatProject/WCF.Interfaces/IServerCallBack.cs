using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Interfaces
{
    public interface IServerCallBack
    {
        [OperationContract(IsOneWay =true)]
        void SendData(string msg);

    }
}
