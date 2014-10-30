using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCF_Lib
{
    
    //服务契约
    [ServiceContract()]
    public interface IStockDao
    {
        //操作契约
        [OperationContract()]
        Stock QueryByCode(string code);

        //操作契约
        [OperationContract()]
        List<Stock> Query();

        //操作契约
        [OperationContract()]
        bool Create(Stock s);
    }
}
