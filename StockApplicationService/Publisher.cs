///-----------------------------------------------------------------
///   Namespace:      StockApplicationService
///   Class:          Publisher
///   Description:    Generates the stock value within the specified limits
///   Author:         Himani Shah                    Date: 07/12/2019
///-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplicationService
{
    public class Publisher
    {
        public delegate void delObj();
        public event delObj eventObj;

        private int _min;

        private int _max;

        public Publisher(int _min, int _max)
        {
            this._min = _min;
            this._max = _max;
        }

        /// <summary>
        /// Generates the price within the given limits
        /// </summary>
        /// <returns>stock price</returns>
        public int GetStockPrice()
        {
            if (eventObj != null)
                eventObj();
            return new Random().Next(_min, _max);
        }

    }
}
