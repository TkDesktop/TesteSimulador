using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TesteSimulador
{
    public class Proposta
    {
        // DADOS DO CLIENTE
        public string NomeCliente { get; set; }

        // DADOS DO CONSÓRCIO
        // Valor da carta de crédito
        public decimal ValorBem { get; set; }

        // Prazo total do consórcio
        // Exemplo: 80, 100, 120 meses
        public int Prazo { get; set; }

        // TAXAS INFORMADAS
        // Percentual da taxa administrativa
        // Exemplo: 18 = 18%
        public decimal TaxaAdmin { get; set; }


        // Percentual da adesão
        // Exemplo: 3,5 = 3,5%
        public decimal TaxaAdesao { get; set; }

        // Percentual do fundo de reserva
        // Exemplo: 2 = 2%
        public decimal TaxaReserva { get; set; }

        // ADMINISTRADORA
        public string Administradora { get; set; }

        // LANCE
        // Percentual do lance
        // Exemplo: 25 = 25%
        public decimal Lance { get; set; }


        // Tipo de lance escolhido no RadioButton
        // Livre ou Embutido
        public int TipoLance { get; set; }

        // ADESÃO
        // Quantidade de parcelas para diluir a adesão
        //
        // Convencional = 2
        // Mais por Menos = 12
        //
        public int QuantidadeParcelasAdesao { get; set; }

        // RESULTADOS DOS CÁLCULOS
        // Valor mensal do fundo comum
        public decimal FundoComum { get; set; }

        // Valor mensal da taxa administrativa
        public decimal ValorTaxaAdmin { get; set; }

        // Valor da parcela com adesão
        public decimal ParcelaInicial { get; set; }

        // Valor mensal do fundo reserva
        public decimal ValorFundoReserva { get; set; }

        // Valor total da adesão
        public decimal ValorAdesao { get; set; }

        // Valor da parcela após contemplação/lance
        public decimal ParcelaPosContemplacao { get; set; }


        // CONSTRUTOR
        public Proposta()
        {
            NomeCliente = string.Empty;
            Administradora = string.Empty;
            TipoLance = 1;


            ValorBem = 0;
            Prazo = 0;

            TaxaAdmin = 0;
            TaxaAdesao = 0;
            TaxaReserva = 0;

            Lance = 0;
            // Padrão inicial
            // Convencional
            QuantidadeParcelasAdesao = 2;

            FundoComum = 0;
            ValorTaxaAdmin = 0;
            ValorFundoReserva = 0;
            ValorAdesao = 0;

            ParcelaInicial = 0;
            ParcelaPosContemplacao = 0;
        }
    }
}
    
