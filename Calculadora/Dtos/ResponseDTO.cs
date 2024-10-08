namespace Calculadora.Dtos
{
    internal class ResponseDTO
    {
        public int result { get; private set; }

        public ResponseDTO(int result)
        {
            this.result = result;
        }
    }
}
