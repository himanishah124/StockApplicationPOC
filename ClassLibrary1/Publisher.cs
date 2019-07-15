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

        public int Stock()
        {
            if (eventObj != null)
                eventObj();
            return new Random().Next(_min, _max);
        }

    }
}
