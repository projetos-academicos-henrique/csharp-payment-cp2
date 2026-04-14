using System;
using System.Globalization;
using csharp_payment.Models;

namespace csharp_payment;

class Program
{
    static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            Menu.ExibirMenu();
            string? opcao = Console.ReadLine();
            Menu.ProcessarOpcao(opcao, ref executando);
        }
    }
}
