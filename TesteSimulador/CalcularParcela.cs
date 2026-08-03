using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalcularParcela
    {
        // =====================================================
        // Calcula a parcela normal antes da contemplação
        // Fundo Comum + Taxa Administrativa + Fundo Reserva
        // =====================================================
        public decimal CalcularParcelaMensal(
            decimal fundoComum,
            decimal taxaAdmin,
            decimal fundoReserva)
        {
            return fundoComum + taxaAdmin + fundoReserva;
        }



        // =====================================================
        // Adiciona a parcela de adesão nas primeiras parcelas
        // Convencional = 2 vezes
        // Mais por Menos = 12 vezes
        // =====================================================
        public decimal CalcularParcelaComAdesao( decimal parcelaMensal,decimal parcelaAdesao)
        {
            return parcelaMensal + parcelaAdesao;
        }
        public decimal CalcularParcelaPosContemplacao( decimal fundoComum,decimal taxaAdmin, decimal fundoReserva, decimal percentualLance)
        {
            if (percentualLance <= 0)
            {
                return fundoComum + taxaAdmin + fundoReserva;
            }


            decimal novoFundoComum = fundoComum * ((100M - percentualLance) / 100M);

            return novoFundoComum + taxaAdmin + fundoReserva;
        }
    }
}
