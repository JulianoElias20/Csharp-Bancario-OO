using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoBancarioOO
{
    internal class Bancario
    {
        public int Nconta {get; private set;}
        public double Saldo { get; private set; }
        public string Titular {get; set;}
        
        public Bancario() { }
        public Bancario(int nconta, string titular)
        {
            Nconta = nconta;
            Titular = titular;
            
        }

        public Bancario(int nconta, string titular, double saldo): this(nconta,titular)
        {

            Deposito(saldo);
        }

        public void Deposito(double valor)
        {
             Saldo += valor;
        }

        public void  Saque(double valor)
        {
            Saldo= Saldo-valor-5;
        }

        public override string ToString()
        {
            return $"Conta {Nconta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2")}";
        }

    }
}
