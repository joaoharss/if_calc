namespace Calculadora.Contracts
{
    internal interface ICalculadora
    {
        public int calculation(IOperation operation, int value1, int value2);
    }
}
