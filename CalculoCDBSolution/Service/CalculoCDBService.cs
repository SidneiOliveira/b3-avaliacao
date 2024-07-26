namespace CalculoCDBWebApi.Service
{
    public record CalculoCDBService : ICalculoCDBService
    {
        private static readonly double CDI = 1.08;
        private static readonly double TB = 0.009;
        private static readonly int VALOR_FIXO_CALCULO_TAXA_SOBRE_CDI = 1;
        private static readonly int QTD_MESES_INICIAL_PARA_CALCULO_VALOR_BRUTO = 1;

        private static readonly double ATE_SEIS_MESES = 0.225;
        private static readonly double ATE_DOZE_MESES = 0.2;
        private static readonly double ATE_VINTE_E_QUATRO_MESES = 0.175;
        private static readonly double ACIMA_DE_VINTE_E_QUATRO_MESES = 0.15;

        public readonly KeyValuePair<int, double> ATE_SEIS_MESES_KEY = new (6, ATE_SEIS_MESES);
        public readonly KeyValuePair<int, double> ATE_DOZE_MESES_KEY = new (12, ATE_DOZE_MESES);
        public readonly KeyValuePair<int, double> ATE_VINTE_E_QUATRO_MESES_KEY = new (24, ATE_VINTE_E_QUATRO_MESES);
        public readonly KeyValuePair<int, double> ACIMA_DE_VINTE_E_QUATRO_MESES_KEY = new (25, ACIMA_DE_VINTE_E_QUATRO_MESES);

        public double CalcularValorBruto(double valorInicial, int qtdMeses)
        {
            var taxaMaisPagamentoSobreCDI = VALOR_FIXO_CALCULO_TAXA_SOBRE_CDI + (TB * CDI);
            double valorCalculado = valorInicial;

            do
            {
                valorCalculado += valorCalculado * taxaMaisPagamentoSobreCDI;
                qtdMeses--;
            } while (qtdMeses >= QTD_MESES_INICIAL_PARA_CALCULO_VALOR_BRUTO);

            return valorCalculado;
        }

        public double CalcularValorLiquido(double valorBruto, int qtdMeses)
        {
            double valorCalculado;
            double valorImpostoDevido;

            if (qtdMeses <= ATE_SEIS_MESES_KEY.Key)
            {
                valorImpostoDevido = (valorBruto * ATE_SEIS_MESES_KEY.Value);
            }
            else
            if (qtdMeses <= ATE_DOZE_MESES_KEY.Key)
            {
                valorImpostoDevido = (valorBruto * ATE_DOZE_MESES_KEY.Value);
            }
            else
            if (qtdMeses <= ATE_VINTE_E_QUATRO_MESES_KEY.Key)
            {
                valorImpostoDevido = (valorBruto * ATE_VINTE_E_QUATRO_MESES_KEY.Value);
            }
            else
            {
                valorImpostoDevido = (valorBruto * ACIMA_DE_VINTE_E_QUATRO_MESES_KEY.Value);
            }

            valorCalculado = (valorBruto - valorImpostoDevido);

            return valorCalculado;
        }
    }
}
