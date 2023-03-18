using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;

namespace DesignPatternsAsp.Strategy
{
    public class Context
    {
        IBeerStrategy _beerStrategy;

        public IBeerStrategy Strategy
        {
            set { _beerStrategy = value; }
        }

        public Context(IBeerStrategy beerStrategy)
        {
            _beerStrategy = beerStrategy;
        }

        public void Add(FormBeerVM beerVM, IUnitOfWork uof)
        {   
            _beerStrategy.Add(beerVM, uof);
        }
    }
}
