using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraAdesao
    {
        // Calcula o valor total da adesão
        // Exemplo:
        // Carta: 100.000
        // Adesão: 3%
        // Resultado: 3.000
        public decimal CalcularValorTotalAdesao(decimal valorCredito, decimal percentualAdesao)
        {
            if (valorCredito <= 0)
                throw new Exception("Valor do crédito inválido.");

            if (percentualAdesao <= 0)
                return 0;

            return valorCredito * (percentualAdesao / 100M);
        }
        // Divide a adesão conforme o plano escolhido
        // Convencional = 2
        // Mais por Menos = 12
        public decimal CalcularParcelaAdesao(decimal valorTotalAdesao, int quantidadeParcelas)
        {
            if (valorTotalAdesao <= 0)
                return 0;

            if (quantidadeParcelas != 2 && quantidadeParcelas != 12)
                throw new Exception("Quantidade de parcelas de adesão inválida.");

            return valorTotalAdesao / quantidadeParcelas;

        }
    }
}

