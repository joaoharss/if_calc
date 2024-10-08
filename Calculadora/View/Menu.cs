using Calculadora.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.View
{
    internal class Menu
    {
        public RequestDTO show()
        {
            this.showMenu();
            return this.captureValues();
        }

        private RequestDTO captureValues()
        {
            
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            return new RequestDTO(opcao, valor1, valor2);
        }

        private void showMenu()
        {
            Console.WriteLine("---->Olá Meu fi!<----");
            Console.WriteLine("Escolha uma das opção:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Vá embora ...");

        }

        public void showResult(ResponseDTO responseDTO)
        {
            Console.WriteLine("O Resultado é: " + responseDTO);
        }
    }
}
