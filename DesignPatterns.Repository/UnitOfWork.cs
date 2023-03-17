using DesignPatterns.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DesignPatternsDbContext _db;
        public IRepository<Beer> _beers;
        public IRepository<Brand> _brands;


        public IRepository<Beer> Beers
        {
            get
            {
                return _beers == null ? _beers = new Repository<Beer>(_db) : _beers;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _brands == null ? _brands = new Repository<Brand>(_db) : _brands;
            }
        }

        public UnitOfWork(DesignPatternsDbContext db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
