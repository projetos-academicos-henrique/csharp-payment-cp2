using System;
using System.Globalization;
using csharp_payment.Models;

namespace csharp_payment;

public static class PagamentoService
{
    public static void ProcessarCartao()
    {
        Console.WriteLine("\n--- Pagamento com Cartão ---");
        decimal valor = SolicitarValor();
        
        Console.Write("Informe o número do cartão: ");
        string? numeroCartao = Console.ReadLine() ?? string.Empty;

        var pagamento = new PagamentoCartao
        {
            Valor = valor,
            NumeroCartao = numeroCartao
        };

        pagamento.ProcessarPagamento();
    }

    public static void ProcessarBoleto()
    {
        Console.WriteLine("\n--- Pagamento com Boleto ---");
        decimal valor = SolicitarValor();
        
        Console.Write("Informe o código de barras: ");
        string? codigoBarras = Console.ReadLine() ?? string.Empty;

        var pagamento = new PagamentoBoleto
        {
            Valor = valor,
            CodigoBarras = codigoBarras
        };

        pagamento.ProcessarPagamento();
    }

    public static decimal SolicitarValor()
    {
        decimal valor;
        while (true)
        {
            Console.Write("Informe o valor do pagamento: ");
            string? input = Console.ReadLine();
            
            if (input != null)
            {
                input = input.Replace(',', '.');
                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out valor) && valor > 0)
                {
                    break;
                }
            }
            Console.WriteLine("Valor inválido! Por favor, insira um número válido maior que 0.");
        }
        return valor;
    }
}