using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCF.Datas.Structs;
using WCF.Interfaces;

namespace ServiceProxy.Server
{
    public class ServerServiceClient : DuplexChannelFactory<IChatServerOperator>, IChatServerOperator
    {
        #region - Variables 

        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -
        public ServerServiceClient(InstanceContext callBackInstance, ServiceEndpoint endpoint) : base(callBackInstance, endpoint) { }
        public ServerServiceClient(InstanceContext callBackInstance, string endpointConfiguratonName) : base(callBackInstance, endpointConfiguratonName) { }


        #endregion

        #region - public Functions -


        public void Join(ClientData clientData)
        {
            try
            {
                base.CreateChannel().Join(clientData);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
        public void Send(string msg)
        {
            try
            {
                base.CreateChannel().Send(msg);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }
        public void Exit()
        {
            try
            {
                base.CreateChannel().Exit();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
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
