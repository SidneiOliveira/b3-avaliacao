namespace CalculoCDBWebApi.Models
{
    public record CalculoCDBResponse
    {
        public decimal ValorBruto { get; private set; }
        public decimal ValorLiquido { get; private set; }

        public CalculoCDBResponse(double valorBruto, double valorLiquido)
        {
            ValorBruto = decimal.Parse(valorBruto.ToString("f2"));
            ValorLiquido = decimal.Parse(valorLiquido.ToString("f2"));
        }
    }
}
