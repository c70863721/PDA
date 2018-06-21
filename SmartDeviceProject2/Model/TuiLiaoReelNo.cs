using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tsmt.Model
{
    class TuiLiaoReelNo
    {
        string reelNo;

        public string ReelNo
        {
            get { return reelNo; }
            set { reelNo = value; }
        }
        int partNoSid;

        public int PartNoSid
        {
            get { return partNoSid; }
            set { partNoSid = value; }
        }
        string partNo;

        public string PartNo
        {
            get { return partNo; }
            set { partNo = value; }
        }
        int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        string deCode;

        public string DeCode
        {
            get { return deCode; }
            set { deCode = value; }
        }
        string workNo;

        public string WorkNo
        {
            get { return workNo; }
            set { workNo = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        string wh;

        public string WH
        {
            get { return wh; }
            set { wh = value; }
        }
    }
}
