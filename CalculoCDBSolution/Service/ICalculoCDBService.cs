namespace CalculoCDBWebApi.Service
{
    public interface ICalculoCDBService
    {
        public double CalcularValorBruto(double valorInicial, int qtdMeses);
        public double CalcularValorLiquido(double valorBruto, int qtdMeses);
    }
}
