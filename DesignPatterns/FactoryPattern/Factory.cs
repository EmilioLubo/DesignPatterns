using System;

public abstract class SaleFactory
{
	public abstract ISale GetSale();

}

public class StoreSaleFactory : SaleFactory
{
    private decimal _extra;

    public StoreSaleFactory(decimal extra)
    {
        _extra = extra;
    }

    public override ISale GetSale()
    {
        return new StoreSale(_extra);
    }
}

public class WebSaleFactory : SaleFactory
{
    private decimal _discount;

    public WebSaleFactory(decimal discount)
    {
        _discount = discount;
    }

    public override ISale GetSale()
    {
        return new WebSale(_discount);
    }
}

public class StoreSale : ISale
{
    private decimal _extra;

    public StoreSale(decimal extra)
    {
        _extra = extra;
    }

    public void Sell(decimal total)
    {
        Console.WriteLine($"La venta en TIENDA tiene un total de {total + _extra}.");
    }
}

public class WebSale : ISale
{
    private decimal _discount;

    public WebSale(decimal discount)
    {
        _discount = discount;
    }

    public void Sell(decimal total)
    {
        Console.WriteLine($"La venta en WEB tiene un total de {total - _discount}.");
    }
}

public interface ISale
{
	public void Sell(decimal total);
}
