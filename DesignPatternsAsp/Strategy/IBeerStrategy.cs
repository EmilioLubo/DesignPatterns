using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;

namespace DesignPatternsAsp.Strategy
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerVM beerVM, IUnitOfWork unitOfWork);
    }
}
