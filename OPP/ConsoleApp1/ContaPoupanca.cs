using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ContaPoupanca : Conta, IConta
    {
        public ContaPoupanca(int numero, double limite) : base(numero, limite)
        {
           
        }
        public void MostrarNumeroDaConta()
        {
            Console.WriteLine($"A conta poupança é: {this.Numero}");
        }
        public override  bool Saca(double valor)
        {
            bool deuCertoSaque = base.Saca(valor);
            if(deuCertoSaque)
            {
                this.Saldo -= 6;
            }
            return false;
        }
    }
}
