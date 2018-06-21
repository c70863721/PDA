using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tsmt.Model
{
    class ZaFaNo
    {
        string zaFaNo;

        public string ZaFaNo1
        {
            get { return zaFaNo; }
            set { zaFaNo = value; }
        }
        List<Model.FaLiaoPartNo> listFaLiaoPartNo;

        public List<Model.FaLiaoPartNo> ListFaLiaoPartNo
        {
            get { return listFaLiaoPartNo; }
            set { listFaLiaoPartNo = value; }
        }
    }
}
