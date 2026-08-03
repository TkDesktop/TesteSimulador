using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraAdesao
    {
        public decimal CalcularValorTotalAdesao(decimal valorCredito, decimal percentualAdesao)
        {
            if (percentualAdesao <= 0) 
                return 0;

            if (valorCredito <= 0) 
                throw new Exception("Valor do crédito inválido.");

            return valorCredito * (percentualAdesao / 100M);
        }


        public decimal CalcularParcelaAdesao(decimal valorTotalAdesao, int quantidadeParcelas)
        {
            if (valorTotalAdesao <= 0) 
                return 0;

            if (quantidadeParcelas <= 0) 
                throw new Exception("Quantidade de parcelas inválida.");

            return valorTotalAdesao / quantidadeParcelas;
        }

    }
}
