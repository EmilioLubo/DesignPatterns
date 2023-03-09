// See https://aka.ms/new-console-template for more information


using DesignPatterns.DependencyInjection;
using DesignPatterns.Singleton;

Console.WriteLine("Hello, World!");

//Singleton =>

//var singleton = Singleton.Instance;
//var s = Singleton.Instance;
//var log = Log.Instance;
//log.Save("a");
//log.Save("b");


//Factory =>

//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//SaleFactory webSaleFactory = new WebSaleFactory(10);
//ISale sale1 = storeSaleFactory.GetSale();
//sale1.Sell(15);
//ISale sale2 = webSaleFactory.GetSale();
//sale2.Sell(15);

//DependencyInjection =>

var beer = new Beer("Stout", "Quilmes");
var trago = new BeerDrink(beer, 20, 10);
trago.Build();