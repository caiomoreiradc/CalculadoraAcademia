using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] historico = new string[100];
            int qtdOperacoes = 0;

            while (true)
            {
                Console.WriteLine("Calculadora da Academia!");
                Console.WriteLine();
                Console.WriteLine("Selecione a operação:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Ver histórico");
                Console.WriteLine("6 - Sair");

                Console.WriteLine();

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 6)
                {
                    Console.WriteLine("Saindo da matrix...");
                    break;
                }

                if (opcao == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Histórico de operações:");
                    for (int i = 0; i < qtdOperacoes; i++)
                    {
                        Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Black;
                        Console.WriteLine(historico[i]);
                        Console.ResetColor();
                    }
                    continue;
                }

                Console.WriteLine("Digite o primeiro número:");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Digite o segundo número:");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                double resultado = 0;
                string operacao = "";

                switch (opcao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        operacao = $"{numero1} + {numero2} = {resultado}";
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        operacao = $"{numero1} - {numero2} = {resultado}";
                        break;
                    case 3:
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            operacao = $"{numero1} / {numero2} = {resultado}";
                        }
                        else
                        {
                            Console.WriteLine("Erro: divisão por zero!");
                            continue;
                        }
                        break;
                    case 4:
                        resultado = numero1 * numero2;
                        operacao = $"{numero1} * {numero2} = {resultado}";
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        continue;
                }

                historico[qtdOperacoes] = operacao;
                qtdOperacoes++;

                Console.WriteLine();
                Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
            }
        }
    }
}
