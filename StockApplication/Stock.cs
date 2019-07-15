using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    class Stock
    {
        private int _min;
        private int _max;
        private List<StockData> _stockDataList;

        public int Min
        {
            get 
            {
                return _min;
            }
            set
            {
                _min = value;
            }
        }

        public int Max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
            }
        }

        public List<StockData> StockDataList
        {
            get
            {
                return _stockDataList;
            }
            set
            {
                _stockDataList = value;
            }
        }

    }
}
