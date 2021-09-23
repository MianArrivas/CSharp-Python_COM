using System;
using System.Collections.Generic;

namespace Python_JSON_Communication
{
    public class CJsonMessage
    {
        private string sMessage;
        public string Message { get { return sMessage; } set { sMessage = value; } }

        public CJsonMessage(string Message )
        {
            this.sMessage = Message;
        }

        public CJsonMessage(  )
        {
        }
    }
}
