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

            resultado.FundoComum = taxas.CalcularFundoComum( proposta.ValorBem, proposta.Prazo);

            resultado.ValorTaxaAdmin = taxas.CalcularTaxaAdministrativa( proposta.ValorBem, proposta.TaxaAdmin, proposta.Prazo);

            resultado.ValorFundoReserva = taxas.CalcularFundoReserva( proposta.ValorBem, proposta.TaxaReserva, proposta.Prazo);

            resultado.ValorTotalAdesao = adesao.CalcularValorTotalAdesao( proposta.ValorBem, proposta.TaxaAdesao);

            resultado.ValorParcelaAdesao = adesao.CalcularParcelaAdesao( resultado.ValorTotalAdesao, proposta.QuantidadeParcelasAdesao);

            decimal parcelaBase = parcela.CalcularParcelaMensal(resultado.FundoComum, resultado.ValorTaxaAdmin, resultado.ValorFundoReserva);

            resultado.ParcelaInicial = parcela.CalcularParcelaComAdesao( parcelaBase, resultado.ValorParcelaAdesao);

            resultado.ValorLance = proposta.Lance > 0 ? lance.CalcularValorLance( proposta.ValorBem,proposta.Lance) : 0;

            resultado.PercentualLance = proposta.Lance;

            resultado.ParcelaPosContemplacao = parcela.CalcularParcelaPosContemplacao( resultado.FundoComum, resultado.ValorTaxaAdmin, resultado.ValorFundoReserva, proposta.Lance);

            resultado.ValorTotalOperacao = proposta.ValorBem + (proposta.ValorBem * proposta.TaxaAdmin / 100) + (proposta.ValorBem * proposta.TaxaReserva / 100) + resultado.ValorTotalAdesao;
            return resultado;
        }
    }
}
