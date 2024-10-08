using Calculadora.Contracts.Operations;
using Calculadora.Contracts;
using Calculadora.Model;
using Calculadora.Dtos;

namespace Calculadora.Controller
{
    internal class ControllerCalc
    {
        public ResponseDTO calc(RequestDTO requestDTO)
        {
            ICalculadora calc = null;

            if (requestDTO.opcao == 1)
                calc = new Calc();
            else
                calc = new CalculadoraX();

            IOperation operation = null;

            switch (requestDTO.opcao)
            {
                case 1:
                    operation = new Somar();
                    break;
                case 2:
                    operation = new Subtrair();
                    break;
                case 3:
                    operation = new Multiplicar();
                    break;
                case 4:
                    operation = new Dividir();
                    break;
            }

            int result = calc.calculation(operation, requestDTO.opcao, requestDTO.opcao);
            return new ResponseDTO(result);
        }
    }
}
