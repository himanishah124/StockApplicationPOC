///-----------------------------------------------------------------
///   Namespace:      StockApplication
///   Class:          Subscriber
///   Description:    Subscribes to the  publisher class to get the stock price and defines the event handler
///   Author:         Himani Shah                    Date: 07/12/2019
///-----------------------------------------------------------------
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

        public int GetStockPrice()
        {
            return _publisher.GetStockPrice();
        }

    }
}
