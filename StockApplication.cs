﻿using System;
using System.IO;

namespace Problem_2
{
    class StockApplication
    {
        static void Main(string[] args)
        {
            // For Console display
            Console.WriteLine("{0}{1}{2}{3}\n", "Broker".PadRight(15), "Stock".PadRight(15), "Value".PadRight(15), "Changes".PadRight(15));

            // For Textfile display
            string title = "Date    Time".PadRight(25) + "Stock Name".PadRight(20) + "Initial Value".PadRight(20) + "Current Value\n\n";
            string path = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))), "output.txt");
            File.WriteAllText(path, title);

            // Program
            Stock stock1 = new Stock("Technology", 160, 5, 15);
            Stock stock2 = new Stock("Retail", 30, 2, 6);
            Stock stock3 = new Stock("Banking", 90, 4, 10);
            Stock stock4 = new Stock("Commodity", 500, 20, 50);

            
            StockBroker b1 = new StockBroker("Broker 1");
            b1.AddStock(stock1);
            b1.AddStock(stock2);

            StockBroker b2 = new StockBroker("Broker 2");
            b2.AddStock(stock1);
            b2.AddStock(stock3);
            b2.AddStock(stock4);

            StockBroker b3 = new StockBroker("Broker 3");
            b3.AddStock(stock1);
            b3.AddStock(stock3);

            StockBroker b4 = new StockBroker("Broker 4");
            b4.AddStock(stock1);
            b4.AddStock(stock2);
            b4.AddStock(stock3);
            b4.AddStock(stock4);
        }
    }
}
