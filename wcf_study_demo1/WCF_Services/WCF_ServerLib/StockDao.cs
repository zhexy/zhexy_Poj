using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCF_Lib;

namespace WCF_ServerLib
{
    public class StockDao:IStockDao
    {
         //第二种写法：显式实现接口
         Stock IStockDao.QueryByCode(string code)
        {
            List<Stock> list = this.GetStocks();
            Stock stock = list.FirstOrDefault(s => s.Code == code);
            return stock;
        }

        public List<Stock> Query()
        {
            return this.GetStocks();
        }

        public bool Create(Stock s)
        {
            Console.WriteLine("添加股票成功:{0},{1},{2}",s.Code,s.Name,s.Price);
            return true;
        }

        private List<Stock> GetStocks()
        {
            List<Stock> stockList = new List<Stock> 
            {
                new Stock{Code="ms",Name="微软",Price=100},
                new Stock{Code="ibm",Name="商用电脑",Price=90},
                new Stock{Code="soufun",Name="搜房网",Price=120},
                new Stock{Code="baidu",Name="百度",Price=105}
            };
            return stockList;
        }
    }
}
