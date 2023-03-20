using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NewCustomer : IState
    {
        public void Action(CustomerContext cs, decimal amount)
        {
            Console.WriteLine($"Se agrega saldo a su cuenta {amount}");
            cs.Residue = amount;
            cs.SetState(new NonDebtorCustomer());
        }
    }
}
