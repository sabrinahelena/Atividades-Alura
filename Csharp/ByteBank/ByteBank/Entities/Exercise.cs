using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Entities
{
    public class Exercise
    {
        List<ContaCorrente> contas = new List<ContaCorrente>();
        public void Menu()
        {
            Console.WriteLine("Quantas contas deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for(int i=1; i<=quantidade; i++) //Repete as informações dentro do foor a quant. de vezes estipulada pelo usuário
            {
                Cliente cliente = new Cliente();
                ContaCorrente conta = new ContaCorrente();
                Console.Write($"Nome cliente #{i}: ");
                cliente.Nome = Console.ReadLine();
                Console.Write($"CPF cliente #{i}: ");
                cliente.CPF = Console.ReadLine();
                Console.Write($"Profissao cliente #{i}: ");
                cliente.Profissao = Console.ReadLine();
                Console.Write($"Conta cliente #{i}: ");
                conta.Conta = Console.ReadLine();
                Console.Write($"Numero de agência cliente #{i}: ");
                conta.NumeroAgencia = int.Parse(Console.ReadLine());
                Console.Write($"Nome de agência cliente #{i}: ");
                conta.NomeAgencia = Console.ReadLine();
                Console.Write($"Saldo do cliente #{i}: ");
                conta.Saldo = double.Parse(Console.ReadLine());
                conta.Titular = cliente;

                contas.Add(conta);

            }
            int b = 0;
            while (b == 0)
            {
                Console.WriteLine($"Bem vindo ao banco ByteBank! O que deseja fazer? " + Environment.NewLine +
                    $"1 - Exibir informações da conta" + Environment.NewLine +
                    $"2 - Sacar" + Environment.NewLine +
                    $"3 - Depositar" + Environment.NewLine +
                    $"4 - Sair do loop" + Environment.NewLine +
                    $"5 - Trasnferir");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        foreach (ContaCorrente item in contas)
                        {
                            Console.WriteLine($"*******************************************************" + Environment.NewLine +
                                $"* INFORMAÇÕES TITULAR *" + Environment.NewLine +
                                $"Nome: {item.Titular.Nome}" + Environment.NewLine +
                                $"CPF: {item.Titular.CPF}" + Environment.NewLine +
                                $"Profissão: {item.Titular.Profissao}" + Environment.NewLine +
                                $"*******************************************************" + Environment.NewLine +
                                $"* INFORMAÇÕES CONTA *" + Environment.NewLine +
                                $"Conta: {item.Conta}" + Environment.NewLine +
                                $"Numero de agência: {item.NumeroAgencia}" + Environment.NewLine +
                                $"Nome de agência: {item.NomeAgencia}" + Environment.NewLine +
                                $"Saldo: {item.Saldo}");
                        }
                        break;
                    case 2:
                        foreach (ContaCorrente item in contas)
                        {
                            Console.WriteLine("Digite o valor a ser sacado: ");
                            Console.Write("Valor: ");
                            double saque = double.Parse(Console.ReadLine());
                            item.Sacar(saque);
                        }
                        break;
                    case 3:
                        foreach (ContaCorrente item in contas)
                        {
                            Console.WriteLine("Digite o valor a ser depositado: ");
                            Console.Write("Valor: ");
                            double deposito = double.Parse(Console.ReadLine());
                            item.Depositar(deposito);
                        }
                        break;
                    case 4:
                        b = 1;
                        break;
                    //case 5:
                    //    foreach (ContaCorrente item in contas)
                    //    {
                    //        Console.WriteLine("Digite a conta para transferir: ");

                    //    }
                    //    break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            }
        }
    }
}
