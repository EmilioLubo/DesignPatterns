using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RepositoryPattern
{
    internal class BeerRepository : IBeerRepository
    {
        private DesignPatternsDbContext _db;

        public BeerRepository(DesignPatternsDbContext db)
        {
            _db = db;
        }

        public void Add(Beer beer)
        {
            _db.Beers.Add(beer);
        }

        public void Delete(int id)
        {
            var beer = _db.Beers.Find(id);
            _db.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get()
        {
            return _db.Beers.ToList();
        }

        public Beer Get(int id)
        {
            return _db.Beers.Find(id);
        }
        public void Update(Beer beer)
        {
            _db.Entry(beer).State = EntityState.Modified;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
