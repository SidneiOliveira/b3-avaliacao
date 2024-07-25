namespace CalculoCDBWebApi.Models
{
    public record CalculoCDBResponse
    {
        public double ValorBruto { get; private set; }
        public double ValorLiquido { get; private set; }

        public CalculoCDBResponse(double valorBruto, double valorLiquido)
        {
            ValorBruto = valorBruto;
            ValorLiquido = valorLiquido;
        }
    }
}
