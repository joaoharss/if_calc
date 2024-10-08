using Calculadora.Dtos;

namespace Calculadora.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Meu fi!");
            Console.WriteLine("Escolha uma das opção:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Vá embora ...");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());
            int resultado = -1;
            switch (opcao)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }
            if (resultado == -1)
                Console.WriteLine("T+");
            else
                Console.WriteLine("O Resultado eh " + resultado);
        }
    }
}
