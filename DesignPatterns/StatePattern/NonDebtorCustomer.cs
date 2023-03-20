using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NonDebtorCustomer : IState
    {
        public void Action(CustomerContext cs, decimal amount)
        {
            if (amount <= cs.Residue)
            {
                cs.Discount(amount);
                Console.WriteLine($"Solicitud permitida, gasta {amount} y le queda el saldo de {cs.Residue}.");

                if (cs.Residue <= 0)
                    cs.SetState(new DebtorCustomer());
            }
            else
                Console.WriteLine($"Su saldo ({cs.Residue}) no es suficiente para cubrir el monto de {amount}.");
        }
    }
}
