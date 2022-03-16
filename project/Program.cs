using System;
using System.Globalization;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Informe o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            System.Console.Write("Informe o nome do titular da conta: ");
            string nome = Console.ReadLine();

            System.Console.Write("Haverá deposito inicial(s/n): ");
            string depInicial = Console.ReadLine().ToLower();

            while(depInicial != "s" && depInicial != "n")
            {
                System.Console.WriteLine("Resposta Inválida!");
                System.Console.Write("Haverá deposito inicial(s/n): ");
                depInicial = Console.ReadLine().ToLower();
            }

            Conta c1 = new Conta(num, nome);

            if(depInicial == "s")
            {
                System.Console.Write("Informe o valor do depósito inicial: $ ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1 = new Conta(num, nome, valorDepositoInicial);
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