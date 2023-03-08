// See https://aka.ms/new-console-template for more information


using DesignPatterns.Singleton;

Console.WriteLine("Hello, World!");


//var singleton = Singleton.Instance;
//var s = Singleton.Instance;
//var log = Log.Instance;
//log.Save("a");
//log.Save("b");

SaleFactory storeSaleFactory = new StoreSaleFactory(10);
SaleFactory webSaleFactory = new WebSaleFactory(10);

ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(15);

ISale sale2 = webSaleFactory.GetSale();
sale2.Sell(15);

