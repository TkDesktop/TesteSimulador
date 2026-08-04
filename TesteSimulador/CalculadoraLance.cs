using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraLance
    {

        // Calcula o valor do lance em reais
        public decimal CalcularValorLance(decimal valorCredito, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return 0;

            return valorCredito * (percentualLance / 100M);
        }



        // Calcula o crédito disponível após lance embutido
        public decimal CalcularCreditoAposLance( decimal valorCredito, decimal percentualLance, int tipoLance)
        {
            // Lance livre não reduz a carta
            if (tipoLance != 2 || percentualLance <= 0)
                return valorCredito;
            decimal valorLance = CalcularValorLance(valorCredito, percentualLance);
            return valorCredito - valorLance;
        }



        // Calcula o saldo devedor após o lance
        public decimal CalcularSaldoDevedorAposLance( decimal valorCredito, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return valorCredito;
            decimal valorLance = CalcularValorLance(valorCredito, percentualLance);
            return valorCredito - valorLance;
        }

        public decimal CalcularReducaoPrazo(int prazo, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return prazo;

            decimal novoPrazo = prazo * ((100M - percentualLance) / 100M);

            return Math.Ceiling(novoPrazo);
        }

        public int CalcularNovoPrazo(int prazo, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return prazo;

            decimal novoPrazo = prazo * ((100M - percentualLance) / 100M);

            return (int)Math.Ceiling(novoPrazo);
        }
    }
}

