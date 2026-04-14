using System;

namespace csharp_payment.Models;

public class PagamentoCartao : IPagamento
{
    public decimal Valor { get; set; }
    public string NumeroCartao { get; set; } = string.Empty;

    public void ProcessarPagamento()
    {
        string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine($"\nOpção 1: Processando pagamento de R$ {Valor:N2} via Cartão (Número: {NumeroCartao}) na data {dataAtual}.\n");
    }
}
