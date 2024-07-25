using CalculoCDBWebApi.Service;

namespace Tests.Service;

public sealed class CalculoCDBServiceTests
{
    private readonly CalculoCDBService _calculoCDBService;

    public CalculoCDBServiceTests()
    {
        _calculoCDBService = new CalculoCDBService();
    }

    [Theory]
    [InlineData(10.5, 1)]
    [InlineData(100.5, 2)]
    [InlineData(1000.5, 3)]
    public void CalcularValorBrutoDeveRetonarValorPositivo(double valorInicial, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorBruto(valorInicial, qtdMeses);
        Assert.True(result > 0);
    }

    [Theory]
    [InlineData(10.5, 1)]
    [InlineData(100.5, 2)]
    [InlineData(1000.5, 3)]
    public void CalcularValorLiquidoDeveRetonarValorPositivo(double valorBruto, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorLiquido(valorBruto, qtdMeses);
        Assert.True(result > 0);
    }
}
