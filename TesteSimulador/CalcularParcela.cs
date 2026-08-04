using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalcularParcela
    {
        // Parcela normal:
        // Fundo comum + Taxa administrativa + Fundo reserva
        public decimal CalcularParcelaMensal(decimal fundoComum, decimal taxaAdmin, decimal fundoReserva)
        {
            return fundoComum + taxaAdmin + fundoReserva;
        }
        // Parcela inicial com adesão
        public decimal CalcularParcelaComAdesao(decimal parcelaMensal, decimal parcelaAdesao)
        {
            return parcelaMensal + parcelaAdesao;
        }
        // Somente para LANCE EMBUTIDO
        // Lance livre NÃO passa aqui
        public decimal CalcularParcelaComLanceEmbutido(decimal fundoComum, decimal taxaAdmin, decimal fundoReserva, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return fundoComum + taxaAdmin + fundoReserva;


            decimal fundoComumRestante = fundoComum * ((100M - percentualLance) / 100M);

            return fundoComumRestante + taxaAdmin + fundoReserva;
        }

        public decimal CalcularParcelaPosContemplacao( decimal fundoComum, decimal taxaAdmin, decimal fundoReserva, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return fundoComum + taxaAdmin + fundoReserva;
            decimal percentualRestante = (100M - percentualLance) / 100M;
            decimal novoFundoComum = fundoComum * percentualRestante;
            return novoFundoComum + taxaAdmin + fundoReserva;
        }
    }
}
