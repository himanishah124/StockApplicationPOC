using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApplicationService;

namespace StockApplication
{
    class Subscriber
    {
        private Publisher _publisher;

        public Subscriber(Stock _stock)
        {
            _publisher = new Publisher(_stock.Min,_stock.Max);
            _publisher.eventObj += eventHandler;
        }

        void eventHandler()
        {
            Console.Write("StockPrice  : ");
        }

        public int StockPrice()
        {
            return _publisher.Stock();
        }

    }
}
