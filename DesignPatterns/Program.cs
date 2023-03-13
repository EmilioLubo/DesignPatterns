// See https://aka.ms/new-console-template for more information


using DesignPatterns.DependencyInjection;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.Singleton;
using Beer = DesignPatterns.Models.Beer;

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

//var beer = new Beer("Stout", "Quilmes");
//var trago = new BeerDrink(beer, 20, 10);
//trago.Build();

//EntytyFramework =>

//using (var context = new DesignPatternsDbContext())
//{
//    var list = context.Beers.ToList();
//    foreach (var item in list)
//    {
//        Console.WriteLine(item.Name);
//    }
//}

//Repository Pattern

using(var context = new DesignPatternsDbContext())
{
    var br = new Repository<Beer>(context); //Not BeerRepository
    var beer = new Beer()
    {
        Name = "Brahma",
        Style = "Unico"
    };
    br.Add(beer);
    br.Save();

    foreach(var b in br.Get())
    {
        Console.WriteLine(b.Name);
    }

    br.Delete(beer.BeerId - 1);

    var brr = new Repository<Brand>(context);
    var brand = new Brand()
    {
        Name = "Brahma",
    };
    brr.Add(brand);
    brr.Save();

    foreach (var b in brr.Get())
    {
        Console.WriteLine(b.Name);
    }
}