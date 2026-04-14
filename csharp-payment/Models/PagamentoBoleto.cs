using System;

namespace csharp_payment.Models;

public class PagamentoBoleto : IPagamento
{
    public decimal Valor { get; set; }
    public string CodigoBarras { get; set; } = string.Empty;

    public void ProcessarPagamento()
    {
        string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine($"\nOpção 2: Processando pagamento de R$ {Valor:N2} via Boleto (Cod Barra: {CodigoBarras}) na data {dataAtual}.\n");
    }
}
