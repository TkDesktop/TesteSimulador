using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class ResultadoSimulacao
    {
        // ==========================================================
        // VALORES TOTAIS — o que o vendedor/cliente vê na tela
        // ==========================================================
        public decimal TaxaAdministracaoTotal { get; set; }
        public decimal FundoReservaTotal { get; set; }
        public decimal TotalPlano { get; set; }
        // ==========================================================
        // VALORES MENSAIS — usados internamente para compor a parcela
        // (não precisam aparecer em destaque na tela, mas ficam
        // disponíveis caso queira detalhar a composição da parcela)
        // ==========================================================
        public decimal FundoComumMensal { get; set; }
        public decimal TaxaAdministracaoMensal { get; set; }
        public decimal FundoReservaMensal { get; set; }
        public decimal AdesaoMensal { get; set; }
        // ==========================================================
        // PARCELA — resultado final da soma dos valores mensais acima
        // ==========================================================
        public decimal ParcelaMensal { get; set; }
        // ==========================================================
        // LANCE
        // ==========================================================
        public decimal ValorLance { get; set; }
        public decimal PercentualLance { get; set; }
        public decimal CreditoRecebidoComLanceEmbutido { get; set; }
        // ==========================================================
        // SIMULAÇÃO PÓS-LANCE (opcional, só preenchido se houver lance)
        // ==========================================================
        public decimal? NovoSaldoFundoComum { get; set; }
        public int? NovoPrazoComReducaoDePrazo { get; set; }
        public decimal? NovaParcelaComReducaoDeParcela { get; set; }
    }
}
