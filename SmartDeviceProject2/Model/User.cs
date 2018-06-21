using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tsmt.Model
{
    [Serializable]
    public class User
    {
        int sfcSid;

        public int SFCSid
        {
            get { return sfcSid; }
            set { sfcSid = value; }
        }
        int sajetSid;

        public int SajetSid
        {
            get { return sajetSid; }
            set { sajetSid = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string userNo;

        public string UserNo
        {
            get { return userNo; }
            set { userNo = value; }
        }
        string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

    }
}
