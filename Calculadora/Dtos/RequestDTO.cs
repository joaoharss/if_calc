
namespace Calculadora.Dtos
{
    internal class RequestDTO
    {
        public int opcao { get; private set; }
        public int valor1 { get; private set; }
        public int valor2 { get; private set; }
        public RequestDTO(int opcao, int valor1, int valor2)
        {
            this.opcao = opcao;
            this.valor1 = valor1;
            this.valor2 = valor2;
        }
    }
}
