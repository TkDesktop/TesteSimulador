using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraLance
    {
        public decimal CalcularValorLance(decimal valorCredito, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return 0;

            return valorCredito * (percentualLance / 100M);
        }


        public decimal CalcularCreditoAposLance(decimal valorCredito, decimal percentualLance, int tipoLance)
        {
            if (percentualLance <= 0 || tipoLance != 2)
                return valorCredito;

            return valorCredito -
                   CalcularValorLance(valorCredito, percentualLance);
        }


        public decimal CalcularFundoComumAposLance(decimal fundoComum, decimal percentualLance)
        {
            if (percentualLance <= 0)
                return fundoComum;

            return fundoComum *
                   ((100M - percentualLance) / 100M);
        }
    }
}

