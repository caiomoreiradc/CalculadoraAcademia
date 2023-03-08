namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora da academia!");
            Console.Write("Insira o primeiro número: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            string operacao = "";
            decimal resultado = 0;

            while (true)
            {
                Console.WriteLine("1- Realizar Soma:");
                Console.WriteLine("2- Realizar subtração:");
                Console.WriteLine("3- Realizar multiplicação:");
                Console.WriteLine("4- Realizar Divisão:");
                Console.WriteLine("5- Fechar Programa:");
                operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        resultado = num1 / num2;
                        break;                    
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Operação inválida\n");
                        continue;
                }
                break;
            }

            Console.WriteLine("O resultado da operação é: " + Math.Round(resultado, 2));
            Console.ReadLine();

        }
    }
}