using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TesteSimulador
{
    public partial class frmProposta : Form
    {
        private Proposta proposta;
        private ResultadoSimulacao resultado;

        public frmProposta(Proposta p, ResultadoSimulacao r)
        {
            InitializeComponent();
            proposta = p;
            resultado = r;
        }


        private void frmProposta_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            // Gera um número entre 100 e 999 (ajuste os limites conforme sua preferência)
            int numeroProposta = random.Next(100, 1000);

            // Define o texto na Label de título
            lblTituloProposta.Text = $"Proposta nº {numeroProposta}";

            CarregarDados();
        }

        private void CarregarDados()
        {
            lblNomeCliente.Text = $"Cliente: {proposta.NomeCliente}";
            lblValorCarta.Text = $"Valor da Carta: {proposta.ValorBem:C2}";
            lblPrazo.Text = $"Prazo: {proposta.Prazo} meses";
            lblAdministradora.Text = $"Administradora: {proposta.Administradora}";

            // Valores totais da operação
            lblTaxaAdmin.Text = $"Taxa Administrativa: {resultado.TaxaAdministracaoTotal:C2}";
            lblReserva.Text = $"Fundo Reserva: {resultado.FundoReservaTotal:C2}";
            lblPercentAdesao.Text = $"Adesão Mensal: {resultado.AdesaoMensal:C2}";

            // Parcelas
            lblParcela.Text = $"Parcela Normal: {resultado.ParcelaMensal:C2}";

            decimal parcelaComAdesao = resultado.ParcelaMensal;
            lblValorParcelaAdesao.Text = $"Parcela com Adesão ({proposta.QuantidadeParcelasAdesao}x): {parcelaComAdesao:C2}";

            // Lance
            lblTipoLance.Text = proposta.TipoLance == 1 ? "Tipo Lance: Livre" : "Tipo Lance: Embutido";
            lblPercentLance.Text = $"Percentual Lance: {resultado.PercentualLance:0.##}%";

            // Pós contemplação
            decimal posContemplacao = resultado.NovaParcelaComReducaoDeParcela ?? resultado.ParcelaMensal;
            lblPosContemp.Text = $"Pós Contemplação: {posContemplacao:C2}";

            // Total da operação
            lblValorTotal.Text = $"Valor Total Operação: {resultado.TotalPlano:C2}";

            if (proposta.TipoLance == 1 && resultado.NovoPrazoComReducaoDePrazo.HasValue && resultado.NovoPrazoComReducaoDePrazo > 0)
            {
                lblReducaoLance.Text = $"Novo prazo pós-lance: {resultado.NovoPrazoComReducaoDePrazo.Value} meses";
            }
            else
            {
                lblReducaoLance.Text = "Lance aplicado no crédito/parcela.";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                GeradorPDF gerador = new GeradorPDF();
                string arquivoGerado = gerador.Gerar(proposta, resultado);

                MessageBox.Show(
                    "PDF criado com sucesso!",
                    "Geração de Proposta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Abre a pasta contendo o arquivo PDF gerado
                System.Diagnostics.Process.Start(
                    "explorer.exe",
                    Path.GetDirectoryName(arquivoGerado)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao gerar PDF:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
