using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Conta
    {
       
        public Conta( int numero, double limite) { 
            this.Numero = numero;   
            this.Limite = limite;
            Conta.TotalDeContasCriadas++;
        
        }
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; private set; }
        public static int TotalDeContasCriadas { get; set; } 
        public static int ProximoTotalContasCriadas ()
        {

            return Conta.TotalDeContasCriadas+1;
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public bool Saca(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();

   

            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Saldo e Saque indisponivel!");
                return false;
               
            }
            this.Saldo -= valor;
            return true;
        }
       
        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }
        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }

    }
}
