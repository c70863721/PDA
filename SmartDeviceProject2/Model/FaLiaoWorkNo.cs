using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tsmt.Model
{
    class FaLiaoWorkNo
    {
        string partNo;

        public string PartNo
        {
            get { return partNo; }
            set { partNo = value; }
        }

        int workNoSid;

        public int WorkNoSid
        {
            get { return workNoSid; }
            set { workNoSid = value; }
        }
        string workNo;

        public string WorkNo
        {
            get { return workNo; }
            set { workNo = value; }
        }
        int partNoSid;

        public int PartNoSid
        {
            get { return partNoSid; }
            set { partNoSid = value; }
        }

        List<FaLiaoPartNo> faLiaoPartNoList;

        public List<FaLiaoPartNo> FaLiaoPartNoList
        {
            get { return faLiaoPartNoList; }
            set { faLiaoPartNoList = value; }
        }
        int custType;

        public int CustType
        {
            get { return custType; }
            set { custType = value; }
        }
    }
}
