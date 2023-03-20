using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class DebtorCustomer : IState
    {
        public void Action(CustomerContext cs, decimal amount)
        {
            Console.WriteLine($"No puedes comprar. Contáctate con Deudas."); ;
        }
    }
}
