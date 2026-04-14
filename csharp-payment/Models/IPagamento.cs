namespace csharp_payment.Models;

public interface IPagamento
{
    decimal Valor { get; set; }
    void ProcessarPagamento();
}
