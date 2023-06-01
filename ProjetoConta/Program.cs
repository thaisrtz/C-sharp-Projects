using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta account;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Conta(numero, titular, depositoInicial);
            }
            else { account = new Conta(numero, titular); }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + account);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            account.Deposito(valor);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), "F2");
            account.Saque(valor);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(account);
        }
    }
}
