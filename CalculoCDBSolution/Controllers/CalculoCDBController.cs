using CalculoCDBWebApi.Models;
using CalculoCDBWebApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDBSolution.Controllers
{
    [ApiController]
    [Route("calculo-cdb")]
    public class CalculoCDBController : ControllerBase
    {
        private readonly ICalculoCDBService _calculoCDBService;
        public CalculoCDBController
        (
            ILogger<CalculoCDBController> logger,
            ICalculoCDBService calculoCDBService
        )
        {
            _calculoCDBService = calculoCDBService;
        }

        [HttpGet]
        public CalculoCDBResponse Get
        (
            [FromQuery] double valor,
            [FromQuery] int qtdMeses
        )
        {
            var valorBruto = _calculoCDBService.CalcularValorBruto(valor, qtdMeses);
            var valorLiquido = _calculoCDBService.CalcularValorLiquido(valorBruto, qtdMeses);
            var calculoCDBResponse = new CalculoCDBResponse(valorBruto, valorLiquido);
            return calculoCDBResponse;
        }
    }
}
