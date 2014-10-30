using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCF_Lib
{
    //数据契约
    [DataContract()]
    public class Stock
    {
        //数据成员
        [DataMember()]
        public string Code { get; set; }

        [DataMember()]
        public string Name { get; set; }

        [DataMember()]
        public int Price { get; set; }
    }
}
