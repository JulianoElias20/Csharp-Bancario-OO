using DepositoBancarioOO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            string veri = Console.ReadLine();

            Bancario dados;

            if (veri == "s" || veri == "S")
            {
                Console.WriteLine("Entre com o valor para depósito: ");
                double saldo = double.Parse(Console.ReadLine());

                dados = new Bancario(numero, nome, saldo);
            }

            else if (veri == "n" || veri == "N")
            {

                dados = new Bancario(numero, nome);

            }
            else
            {
                dados = new Bancario();
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(dados.ToString());

            Console.Write("Entre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            dados.Deposito(valor);

            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(dados.ToString());

            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            dados.Saque(valor);

            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(dados.ToString());


        }
    }
}
