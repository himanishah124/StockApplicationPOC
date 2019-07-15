using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    class StockData
    {
        private DateTime _stockTime;
        private int _stockPrice;

        public DateTime StockTime 
        { 
            get { return _stockTime; }
            set { _stockTime=value; }
        }

        public int StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }
    }
}
