using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class ResultadoCalculo
    {
        // Parte destinada ao pagamento do crédito
        public decimal FundoComum { get; set; }
        // Taxa administrativa em valor mensal
        public decimal ValorTaxaAdmin { get; set; }
        // Fundo reserva em valor mensal
        public decimal ValorFundoReserva { get; set; }
   
        public decimal ValorTotalAdesao { get; set; }


        // Valor da parcela da adesão
        // Depende:
        // Convencional = divide em 2
        // Mais por Menos = divide em 12
        public decimal ValorParcelaAdesao { get; set; }

        // Parcela antes da contemplação
        public decimal ParcelaInicial { get; set; }


        // Parcela depois da contemplação
        // Aplicando regra de lance
        public decimal ParcelaPosContemplacao { get; set; }

        // Valor do lance em reais
        public decimal ValorLance { get; set; }


        // Percentual utilizado
        public decimal PercentualLance { get; set; }

        public decimal ValorTotalOperacao { get; set; }



        // ============================
        // CONSTRUTOR
        // ============================

        public ResultadoCalculo()
        {
            FundoComum = 0;
            ValorTaxaAdmin = 0;
            ValorFundoReserva = 0;
            ValorTotalAdesao = 0;
            ValorParcelaAdesao = 0;
            ParcelaInicial = 0;
            ParcelaPosContemplacao = 0;
            ValorLance = 0;
            PercentualLance = 0;
            ValorTotalOperacao = 0; 
        }

    }
}
