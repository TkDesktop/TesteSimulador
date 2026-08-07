using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class CalculadoraConsorcioEmbracon : ICalculadoraConsorcio
    {
        public ResultadoSimulacao Calcular(ParametrosSimulacao p)
        {
            ValidarParametros(p);

            var resultado = new ResultadoSimulacao();

            // 1) Fundo comum mensal
            resultado.FundoComumMensal = Arredondar(CalcularFundoComumMensal(p));

            // 2) Taxa de administração
            resultado.TaxaAdministracaoTotal = Arredondar(CalcularTaxaAdministracaoTotal(p));
            resultado.TaxaAdministracaoMensal = Arredondar(resultado.TaxaAdministracaoTotal / p.Prazo);

            // 3) Fundo de reserva
            resultado.FundoReservaTotal = Arredondar(CalcularFundoReservaTotal(p));
            resultado.FundoReservaMensal = Arredondar(resultado.FundoReservaTotal / p.Prazo);

            // 4) Adesão
            resultado.AdesaoMensal = Arredondar(CalcularAdesaoMensal(p));

            // 5) Parcela mensal
            resultado.ParcelaMensal = Arredondar( resultado.FundoComumMensal + resultado.TaxaAdministracaoMensal + resultado.FundoReservaMensal + resultado.AdesaoMensal
            );

            // 6) Total do plano
            resultado.TotalPlano = Arredondar(CalcularTotalPlano(p, resultado));

            // 8) e 9) Lance (só calcula se o vendedor informou)
            if (p.InformouLance)
            {
                CalcularLance(p, resultado);

                if (p.LanceEmbutido)
                {
                    resultado.CreditoRecebidoComLanceEmbutido = Arredondar(p.ValorCarta - resultado.ValorLance);
                }

                // 10) e 11) Simulações pós-lance
                CalcularSimulacaoPosLance(p, resultado);
            }

            return resultado;
        }

        // MÉTODOS DE CÁLCULO — cada regra isolada em seu método
        private decimal CalcularFundoComumMensal(ParametrosSimulacao p)
        {
            return p.ValorCarta / p.Prazo;
        }

        private decimal CalcularTaxaAdministracaoTotal(ParametrosSimulacao p)
        {
            return p.ValorCarta * (p.TaxaAdministracao / 100);
        }

        private decimal CalcularFundoReservaTotal(ParametrosSimulacao p)
        {
            return p.ValorCarta * (p.FundoReserva / 100);
        }

        private decimal CalcularAdesaoMensal(ParametrosSimulacao p)
        {
            // Se não parcelar (0 ou 1 parcela), considera à vista => não entra na mensalidade
            if (p.QuantidadeParcelasAdesao <= 1)
            {
                return 0;
            }

            return p.ValorAdesao / p.QuantidadeParcelasAdesao;
        }

        private decimal CalcularTotalPlano(ParametrosSimulacao p, ResultadoSimulacao r)
        {
            return p.ValorCarta + r.TaxaAdministracaoTotal + r.FundoReservaTotal + p.ValorAdesao;
        }

        private void CalcularLance(ParametrosSimulacao p, ResultadoSimulacao r)
        {
            // Lance sempre em percentual, conforme definido
            r.PercentualLance = p.PercentualLance;
            r.ValorLance = Arredondar(p.ValorCarta * (p.PercentualLance / 100));
        }

        private void CalcularSimulacaoPosLance(ParametrosSimulacao p, ResultadoSimulacao r)
        {
            // Abate o lance do saldo do fundo comum (considerando o prazo total, já que
            // não trabalhamos com parcelas pagas nesse simulador)
            decimal saldoFundoComumAtual = r.FundoComumMensal * p.Prazo;
            decimal novoSaldoFundoComum = saldoFundoComumAtual - r.ValorLance;
            if (novoSaldoFundoComum < 0)
            {
                novoSaldoFundoComum = 0;
            }
            r.NovoSaldoFundoComum = Arredondar(novoSaldoFundoComum);
            // 10) Redução de PRAZO (mantém o valor da parcela, diminui quantos meses faltam)
            if (r.FundoComumMensal > 0)
            {
                r.NovoPrazoComReducaoDePrazo = (int)Math.Ceiling(novoSaldoFundoComum / r.FundoComumMensal);
            }
            // 11) Redução de PARCELA (mantém o prazo, diminui o valor de cada parcela)
            if (p.Prazo > 0)
            {
                decimal novoFundoComum = novoSaldoFundoComum / p.Prazo;

                decimal novaParcela = novoFundoComum + r.TaxaAdministracaoMensal + r.FundoReservaMensal + r.AdesaoMensal;

                r.NovaParcelaComReducaoDeParcela = Arredondar(novaParcela);
            }
        }
        // VALIDAÇÃO
        private void ValidarParametros(ParametrosSimulacao p)
        {
            var erros = new List<string>();

            if (p.ValorCarta <= 0)
                erros.Add("Informe o VALOR DA CARTA DE CRÉDITO.");

            if (p.Prazo <= 0)
                erros.Add("Informe o PRAZO DO GRUPO (em meses).");

            if (p.TaxaAdministracao < 0)
                erros.Add("A TAXA DE ADMINISTRAÇÃO não pode ser negativa.");

            if (p.FundoReserva < 0)
                erros.Add("O FUNDO DE RESERVA não pode ser negativo.");

            if (p.ValorAdesao < 0)
                erros.Add("O VALOR DE ADESÃO não pode ser negativo.");

            if (p.InformouLance && p.PercentualLance <= 0)
                erros.Add("Informe um PERCENTUAL DE LANCE válido.");

            if (erros.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", erros));
            }
        }

        // AUXILIAR
        private decimal Arredondar(decimal valor)
        {
            return Math.Round(valor, 2, MidpointRounding.AwayFromZero);
        }
    }
}
