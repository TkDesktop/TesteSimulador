using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class ResultadoCalculo
    {
        // Fundo comum mensal
        public decimal FundoComum { get; set; }
        // Taxa administrativa mensal
        public decimal ValorTaxaAdmin { get; set; }
        // Fundo reserva mensal
        public decimal ValorFundoReserva { get; set; }
        // VALORES TOTAIS DAS TAXAS
        // Taxa administrativa total do contrato
        public decimal ValorTotalTaxaAdmin { get; set; }
        // Fundo reserva total do contrato
        public decimal ValorTotalFundoReserva { get; set; }
        // ADESÃO
        // Valor total da adesão
        public decimal ValorTotalAdesao { get; set; }

        // Valor da adesão dividida em 2 ou 12 vezes
        public decimal ValorParcelaAdesao { get; set; }
        // PARCELAS
        // Parcela sem adesão
        public decimal ParcelaAntesContemplacao { get; set; }
        // Parcela incluindo adesão
        public decimal ParcelaInicial { get; set; }
        // Parcela após contemplação/lance
        public decimal ParcelaPosContemplacao { get; set; }
        // LANCE
        // Valor do lance em reais
        public decimal ValorLance { get; set; }
        // Percentual utilizado no lance
        public decimal PercentualLance { get; set; }
        // OPERAÇÃO
        // Carta + taxas + adesão
        public decimal ValorTotalOperacao { get; set; }
        public int ParcelasReduzidasLance { get; set; }
        public int PrazoFinal { get; set; }

        public ResultadoCalculo()
        {
            FundoComum = 0;
            ValorTaxaAdmin = 0;
            ValorFundoReserva = 0;
            ValorTotalTaxaAdmin = 0;
            ValorTotalFundoReserva = 0;
            ValorTotalAdesao = 0;
            ValorParcelaAdesao = 0;
            ParcelaAntesContemplacao = 0;
            ParcelaInicial = 0;
            ParcelaPosContemplacao = 0;
            ValorLance = 0;
            PercentualLance = 0;
            ValorTotalOperacao = 0;
        }
    }
}
