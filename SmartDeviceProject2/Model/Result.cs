using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tsmt.Model
{
    [Serializable]
    class Result
    {
        int sid;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        Object data;

        public Object Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
