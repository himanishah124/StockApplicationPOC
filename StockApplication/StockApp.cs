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
            int i=0;
            bool success = false;
            string again="";
            Console.WriteLine("Welcome to Stock App");
            do
            {
                Console.WriteLine("Press 1 for Stock1 \n Press 2 for Stock2 \n Press 3 for Exit ");
                success = Int32.TryParse(Console.ReadLine(), out i);
                if (success && (i == 1 || i == 2))
                {
                    Stock _stock1 = new Stock();
                    if (i == 1)
                    {
                        _stock1.Min = 240;
                        _stock1.Max = 270;
                    }
                    else
                    {
                        _stock1.Min = 180;
                        _stock1.Max = 210;
                    }
                    GetStockPrice(_stock1);
                }
                else if (i == 3)
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

        public static void GetStockPrice(Stock _stock)
        {
            _stock.StockDataList = new List<StockData>();
            Console.WriteLine("Press Esc to Stop");
            //while()
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                Subscriber _subscriber = new Subscriber(_stock);
                int price=_subscriber.StockPrice() ;
                _stock.StockDataList.Add(new StockData { StockTime = DateTime.Now, StockPrice = price });
                Console.WriteLine(price);
                Thread.Sleep(1000);
            }
            Console.WriteLine("The list of price change for the subscribed Stock");
            foreach (StockData _stockData in _stock.StockDataList)
            {
                Console.WriteLine("Time : " +_stockData.StockTime + " || Price : " + _stockData.StockPrice);
            }
        }

    }
}
