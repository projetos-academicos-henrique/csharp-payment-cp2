# Sistema de Pagamento em C#

Este projeto é uma aplicação de console desenvolvida em C# que simula um sistema de processamento de pagamentos, utilizando conceitos de Programação Orientada a Objetos (POO), como Interfaces e Injeção de Dependência simples.

## 👥 Integrantes do Grupo
- Andrey Nagata - RM: 555339
- Henrique Soubhia - RM: 554493
- Oliver Trindade - RM: 554954
- Pedro Gutierre - RM: 555445
- William Feng - RM: 555132

---

## 🛠️ Documentação do Projeto

### O Problema
O sistema visa padronizar a forma como diferentes métodos de pagamento (Cartão e Boleto) são processados, garantindo que todos sigam um contrato comum.

### Arquitetura e Padrões
O projeto utiliza uma interface `IPagamento` para garantir que qualquer novo método de pagamento implemente a propriedade `Valor` e o método `ProcessarPagamento()`.

**Estrutura de Pastas:**
* `/Models`: Contém a Interface e as classes concretas (`PagamentoCartao`, `PagamentoBoleto`).
* `PagamentoService.cs`: Camada de serviço responsável pela lógica de captura de dados e instanciacão dos modelos.
* `Menu.cs`: Gerencia a interação visual com o usuário via console.
* `Program.cs`: Ponto de entrada da aplicação.

**Print do sistema:**

![Print do sistema](https://raw.githubusercontent.com/projetos-academicos-henrique/csharp-payment-cp2/refs/heads/main/print.png)
