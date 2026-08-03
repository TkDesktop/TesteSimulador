using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraTaxa
    {


        // ============================================
        // FUNDO COMUM
        // OBRIGATÓRIO
        // ============================================

        public decimal CalcularFundoComum(
            decimal valorCredito,
            int prazo)
        {

            if (valorCredito <= 0)
                throw new Exception(
                    "Valor do crédito deve ser maior que zero.");


            if (prazo <= 0)
                throw new Exception(
                    "Prazo deve ser maior que zero.");


            return valorCredito / prazo;
        }



        // ============================================
        // TAXA ADMINISTRATIVA
        // OBRIGATÓRIA
        // ============================================

        public decimal CalcularTaxaAdministrativa(
            decimal valorCredito,
            decimal percentualTaxa,
            int prazo)
        {

            if (valorCredito <= 0)
                throw new Exception(
                    "Valor do crédito inválido.");


            if (prazo <= 0)
                throw new Exception(
                    "Prazo inválido.");


            decimal valorTotal = valorCredito * (percentualTaxa / 100M);


            return valorTotal / prazo;
        }



        // ============================================
        // FUNDO DE RESERVA
        // OPCIONAL
        //
        // Se percentual = 0
        // retorna zero
        // ============================================

        public decimal CalcularFundoReserva(decimal valorCredito, decimal percentualReserva, int prazo)
        {

            // Não possui fundo reserva
            if (percentualReserva <= 0)
                return 0;


            decimal valorTotal = valorCredito * (percentualReserva / 100M);


            return valorTotal / prazo;
        }
    }
}
