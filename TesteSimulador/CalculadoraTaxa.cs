using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraTaxa
    {

        // Fundo comum mensal
        public decimal CalcularFundoComum(decimal valorCredito, int prazo)
        {
            if (valorCredito <= 0)
                throw new Exception("Valor do crédito deve ser maior que zero.");

            if (prazo <= 0)
                throw new Exception("Prazo deve ser maior que zero.");

            return valorCredito / prazo;
        }


        // Taxa administrativa mensal
        public decimal CalcularTaxaAdministrativa(decimal valorCredito, decimal percentualTaxa, int prazo)
        {
            if (valorCredito <= 0)
                throw new Exception("Valor do crédito inválido.");

            if (prazo <= 0)
                throw new Exception("Prazo inválido.");

            decimal valorTotal = CalcularValorTotalTaxaAdministrativa(valorCredito, percentualTaxa);

            return valorTotal / prazo;
        }


        // Valor total da taxa administrativa
        public decimal CalcularValorTotalTaxaAdministrativa(decimal valorCredito, decimal percentualTaxa)
        {
            if (percentualTaxa <= 0)
                return 0;

            return valorCredito * (percentualTaxa / 100M);
        }


        // Fundo de reserva mensal
        public decimal CalcularFundoReserva(decimal valorCredito, decimal percentualReserva, int prazo)
        {
            if (percentualReserva <= 0)
                return 0;

            if (prazo <= 0)
                throw new Exception("Prazo inválido.");

            decimal valorTotal = CalcularValorTotalFundoReserva(valorCredito, percentualReserva);

            return valorTotal / prazo;
        }


        // Valor total do fundo de reserva
        public decimal CalcularValorTotalFundoReserva(decimal valorCredito, decimal percentualReserva)
        {
            if (percentualReserva <= 0)
                return 0;

            return valorCredito * (percentualReserva / 100M);
        }
    }
}
