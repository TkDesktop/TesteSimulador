using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraConsorcio
    {
        private CalculadoraTaxa taxas = new CalculadoraTaxa();
        private CalculadoraAdesao adesao = new CalculadoraAdesao();
        private CalcularParcela parcela = new CalcularParcela();
        private CalculadoraLance lance = new CalculadoraLance();


        public ResultadoCalculo Calcular(Proposta proposta)
        {
            ResultadoCalculo resultado = new ResultadoCalculo();

            // TAXAS MENSAIS
            resultado.FundoComum = taxas.CalcularFundoComum( proposta.ValorBem, proposta.Prazo);

            resultado.ValorTaxaAdmin = taxas.CalcularTaxaAdministrativa( proposta.ValorBem, proposta.TaxaAdmin, proposta.Prazo);

            resultado.ValorFundoReserva = taxas.CalcularFundoReserva(  proposta.ValorBem, proposta.TaxaReserva, proposta.Prazo);

            // TAXAS TOTAIS
            resultado.ValorTotalTaxaAdmin = taxas.CalcularValorTotalTaxaAdministrativa( proposta.ValorBem, proposta.TaxaAdmin);

            resultado.ValorTotalFundoReserva = taxas.CalcularValorTotalFundoReserva(  proposta.ValorBem, proposta.TaxaReserva);

            // ADESÃO
            resultado.ValorTotalAdesao = adesao.CalcularValorTotalAdesao( proposta.ValorBem, proposta.TaxaAdesao);

            resultado.ValorParcelaAdesao = adesao.CalcularParcelaAdesao( resultado.ValorTotalAdesao, proposta.QuantidadeParcelasAdesao);

            // PARCELAS
            resultado.ParcelaAntesContemplacao = parcela.CalcularParcelaMensal(resultado.FundoComum, resultado.ValorTaxaAdmin, resultado.ValorFundoReserva);

            resultado.ParcelaInicial = parcela.CalcularParcelaComAdesao( resultado.ParcelaAntesContemplacao, resultado.ValorParcelaAdesao);

            // LANCE
            resultado.ValorLance = lance.CalcularValorLance( proposta.ValorBem, proposta.Lance);
            resultado.PercentualLance = proposta.Lance;
            if (proposta.TipoLance == 1) // Lance Livre
            {
                resultado.ParcelaPosContemplacao = resultado.ParcelaAntesContemplacao;

                resultado.PrazoFinal = lance.CalcularNovoPrazo( proposta.Prazo, proposta.Lance);

                resultado.ParcelasReduzidasLance = proposta.Prazo - resultado.PrazoFinal;
            }
            else // Lance Embutido
            {
                resultado.ParcelaPosContemplacao = parcela.CalcularParcelaPosContemplacao( resultado.FundoComum, resultado.ValorTaxaAdmin, resultado.ValorFundoReserva, proposta.Lance);
                resultado.PrazoFinal = proposta.Prazo;
                resultado.ParcelasReduzidasLance = 0;
            }
            resultado.ValorTotalOperacao = proposta.ValorBem +resultado.ValorTotalTaxaAdmin + resultado.ValorTotalFundoReserva + resultado.ValorTotalAdesao;

            return resultado;
        }
    }
}
