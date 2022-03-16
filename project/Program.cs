using System;
using System.Globalization;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1;

            System.Console.Write("Informe o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            System.Console.Write("Informe o nome do titular da conta: ");
            string nome = Console.ReadLine();

            System.Console.Write("Haverá deposito inicial(s/n): ");
            string resp = Console.ReadLine().ToLower();

            while(resp != "s" && resp != "n")
            {
                System.Console.WriteLine("Resposta Inválida!");
                System.Console.Write("Haverá deposito inicial(s/n): ");
                resp = Console.ReadLine().ToLower();
            }

            if(resp == "s")
            {
                System.Console.Write("Informe o valor do depósito inicial: $ ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1 = new Conta(num, nome, valorDepositoInicial);
            } 
            else
            {
                c1 = new Conta(num, nome);
            }

            System.Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c1.ToString());
            
            System.Console.Write("Insira o valor a depositar: $ ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Depositar(deposito);
            System.Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(c1.ToString());

            System.Console.Write("Insira o valor do saque: $ ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Sacar(saque);
            System.Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(c1.ToString());
        }
    }
}