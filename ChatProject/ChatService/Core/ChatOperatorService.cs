﻿using System;
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
            string sessionId = OperationContext.Current.SessionId;
            mClientDatadics.TryRemove(sessionId, out ClientData clientData);
            Console.WriteLine($"Exit Connction {DateTime.Now.ToString()}: Name :{clientData.Name }: IP: {clientData.IP}");
        }
        public void Join(ClientData client)
        {
            string sessionID = OperationContext.Current.SessionId;
            if (mClientDatadics.ContainsKey(sessionID))
            {
                Console.WriteLine($"Existed Client  Name :[{client.Name}] IP:[{client.IP}]");
                return;
            }
            mClientDatadics.TryAdd(sessionID, client);
            Console.WriteLine("*********************======连接服务的个数****************");
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] Join  Name [{client.Name}] IP [{client.IP}]");
            Console.WriteLine("Listener count:" + mClientDatadics.Count);           
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
