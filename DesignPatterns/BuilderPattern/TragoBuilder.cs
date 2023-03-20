using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class TragoBuilder : IBuilder
    {
        private Trago _trago;

        public TragoBuilder()
        {
            Reset();
        }
        public void AddIngredients(string ingredients)
        {
            if (_trago.Ingredientes == null)
                _trago.Ingredientes = new List<string>();

            _trago.Ingredientes.Add(ingredients);
        }

        public void Mix()
        {
            string ingredientes = _trago.Ingredientes.Aggregate((i, j) => i + ", " + j);
            _trago.Result= $"Bebida preparada con {_trago.Alcohol} de alcohol \n \n Con los siguientes ingredientes: {ingredientes}";
            Console.WriteLine("Mezclando...");
        }

        public void Reset()
        {
            _trago = new Trago();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Trago Listo...");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _trago.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _trago.Milk = milk;
        }

        public void SetWater(int water)
        {
            _trago.Water = water;
        }

        public Trago GetTrago()
        {
            return _trago;
        }
    }
}
