using System;

namespace csharp_payment;

public static class Menu
{
    public static void ExibirMenu()
    {
        Console.WriteLine("=== Sistema de Pagamento ===");
        Console.WriteLine("1 - Processar Pagamento com Cartão");
        Console.WriteLine("2 - Processar Pagamento com Boleto");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    public static void ProcessarOpcao(string? opcao, ref bool executando)
    {
        switch (opcao)
        {
            case "1":
                PagamentoService.ProcessarCartao();
                break;
            case "2":
                PagamentoService.ProcessarBoleto();
                break;
            case "3":
                Console.WriteLine("\nSaindo do sistema...\n");
                executando = false;
                break;
            default:
                Console.WriteLine("\nOpção inválida! Tente novamente.\n");
                break;
        }
    }
}
