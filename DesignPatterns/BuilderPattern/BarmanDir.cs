using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BarmanDir
    {
        private IBuilder _builder;

        public BarmanDir(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }
        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(20);
            _builder.SetWater(10);
            _builder.AddIngredients("2 limones");
            _builder.AddIngredients("pizca de sal");
            _builder.AddIngredients("80ml de tequila");
            _builder.AddIngredients("110ml de licor de naranja");
            _builder.AddIngredients("4 cubos de hielo");
            _builder.Mix();
            _builder.Rest(2000);
        }

        public void PrepareJaggerAndRedbull()
        {
            _builder.Reset();
            _builder.SetAlcohol(20);
            _builder.SetWater(10);
            _builder.AddIngredients("1/2 limon");
            _builder.AddIngredients("110");
            _builder.AddIngredients("80ml de Jaggermeister");
            _builder.AddIngredients("110ml de Redbull");
            _builder.AddIngredients("3 cubos de hielo");
            _builder.Mix();
            _builder.Rest(3000);
        }
    }
}
