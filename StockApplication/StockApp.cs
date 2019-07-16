///-----------------------------------------------------------------
///   Namespace:      StockApplication
///   Class:          StockApp
///   Description:    Main class that receives updates on the stock price
///   Author:         Himani Shah                    Date: 07/12/2019
///-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockApplication
{
    class StockApp
    {
        static void Main(string[] args)
        {
            int stockNumber=0;
            bool success = false;
            string again="";
            Console.WriteLine("Welcome to Stock App");
            do
            {
                //Subscribe to a stock to see price change along with timestamp
                Console.WriteLine("Press 1 for Stock1 \nPress 2 for Stock2 \nPress 3 for Exit ");
                success = Int32.TryParse(Console.ReadLine(), out stockNumber);

                //Set the limits for the stock 
                if (success && (stockNumber == 1 || stockNumber == 2))
                {
                    Stock stock = new Stock();
                    if (stockNumber == 1)
                    {
                        stock.Min = 240;
                        stock.Max = 270;
                    }
                    else
                    {
                        stock.Min = 180;
                        stock.Max = 210;
                    }

                    GetStockPrice(stock);
                    GetStockUpdateList(stock);
                }
                else if (stockNumber == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                    continue;
                }
                Console.WriteLine("Do you wish to subscribe again? Y/N");
                again = Console.ReadLine();
            }
            while (again.ToUpper()=="Y");
        }

        /// <summary>
        /// Get the price change of subscribed stock 
        /// </summary>
        /// <param name="_stock"></param>
        public static void GetStockPrice(Stock _stock)
        {
            _stock.StockDataList = new List<StockData>();
            Console.WriteLine("Press Esc to Stop");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                Subscriber _subscriber = new Subscriber(_stock);
                int price=_subscriber.GetStockPrice() ;
                _stock.StockDataList.Add(new StockData { StockTime = DateTime.Now, StockPrice = price });
                Console.WriteLine(price);
                Thread.Sleep(1000);
            }
            
        }

        /// <summary>
        /// Publish the list of price change along with timestamp for the subscribed stock
        /// </summary>
        /// <param name="_stock"></param>
        public static void GetStockUpdateList(Stock _stock)
        {
            Console.WriteLine("The list of price change for the subscribed Stock");
            foreach (StockData _stockData in _stock.StockDataList)
            {
                Console.WriteLine("Time : " + _stockData.StockTime + " || Price : " + _stockData.StockPrice);
            }
        }

    }
}
