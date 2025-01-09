using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class ContaCorrente:Conta, IConta
    {
        public ContaCorrente( int numero, double limite): base(numero, limite) { }
    }
}
