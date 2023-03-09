using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInjection
{
    public class BeerDrink
    {
        private Beer _beer;
        private decimal _water;
        private decimal _sugar;

        public BeerDrink(Beer beer, decimal water, decimal sugar)
        {
            _beer = beer;
            _water= water;
            _sugar= sugar;
        }

        public void Build()
        {
            Console.WriteLine($"Preparamos la bebida con {_beer.Name}, agua {_water} y azúcar {_sugar}.");
        }
    }
}
