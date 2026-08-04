using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteSimulador
{
    public partial class frmProposta : Form
    {

        public frmProposta(Proposta p, ResultadoCalculo r)
        {
            InitializeComponent();
            proposta = p;
            resultado = r;
        }
        private Proposta proposta;
        private ResultadoCalculo resultado;


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
            lblTaxaAdmin.Text = $"Taxa Administrativa: {resultado.ValorTaxaAdmin:C2}";
            lblReserva.Text = $"Fundo Reserva: {resultado.ValorFundoReserva:C2}";
            lblPercentAdesao.Text = $"Adesão: {resultado.ValorTotalAdesao:C2}";
            lblParcela.Text = $"Parcela Inicial: {resultado.ParcelaInicial:C2}";
            lblTipoLance.Text = proposta.TipoLance == 1 ? "Tipo Lance: Livre": "Tipo Lance: Embutido";
            lblPercentLance.Text = $"Percentual Lance: {resultado.PercentualLance:0.##}%";
            lblPosContemp.Text = $"Pós Contemplação: {resultado.ParcelaPosContemplacao:C2}";
            lblValorTotal.Text = $"Valor Total Operação: {resultado.ValorTotalOperacao:C2}";
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
