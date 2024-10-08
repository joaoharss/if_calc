using Calculadora.Contracts;

namespace Calculadora.Model
{
    internal class CalculadoraX : ICalculadora
    {
        public int calculation(IOperation operation, int value1, int value2) => operation.calc(value1, value2);
    }
}
