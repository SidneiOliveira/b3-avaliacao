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
    [InlineData(100, 2)]
    public void CalcularValorBrutoDeveRetonarValorPositivo(double valorInicial, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorBruto(valorInicial, qtdMeses);
        Assert.True(result > 0);
    }

    [Theory]
    [InlineData(100, 2)]
    public void CalcularValorLiquidoDeveRetonarValorPositivo(double valorBruto, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorLiquido(valorBruto, qtdMeses);
        Assert.True(result > 0);
    }

    [Theory]
    [InlineData(100, 6)]
    public void CalcularValorLiquidoAteSeisMesesDeveRetonarValorPositivo(double valorBruto, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorLiquido(valorBruto, qtdMeses);
        Assert.True(result > 0);
    }

    [Theory]
    [InlineData(100, 12)]
    public void CalcularValorLiquidoAteDozeMesesDeveRetonarValorPositivo(double valorBruto, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorLiquido(valorBruto, qtdMeses);
        Assert.True(result > 0);
    }

    [Theory]
    [InlineData(100, 24)]
    public void CalcularValorLiquidoAteVinteEQuatroMesesDeveRetonarValorPositivo(double valorBruto, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorLiquido(valorBruto, qtdMeses);
        Assert.True(result > 0);
    }

    [Theory]
    [InlineData(100, 99)]
    public void CalcularValorLiquidoAcimaDeVinteEQuatroMesesDeveRetonarValorPositivo(double valorBruto, int qtdMeses)
    {
        var result = _calculoCDBService.CalcularValorLiquido(valorBruto, qtdMeses);
        Assert.True(result > 0);
    }
}
