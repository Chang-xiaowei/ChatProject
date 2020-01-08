using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatService
{
    public class ServerCore
    {
        #region - Variables 
        private static ServerCore mInstance = new ServerCore();
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -
        private ServerCore()
        {

        }
        #endregion

        #region - public Functions -
        public static ServerCore GetInstance()
        {
            return mInstance;
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
