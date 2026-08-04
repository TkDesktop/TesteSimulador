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
    public partial class frmImovel : Form
    {
        public frmImovel()
        {
            InitializeComponent();
        }

        int progresso = 0;
        int contadorPontos = 0;
        string mensagemBase = "Carregando Sistema";

        private ResultadoCalculo resultado;
        private Proposta proposta;

        private void Limpar()
        {
            txtNomeCliente.Clear();
            txtValorBem.Clear();
            txtPrazo.Clear();
            txtAdministrativa.Clear();
            txtLance.Clear();
            txtReserva.Clear();
            txtAdesao.Clear();

            rdbLanceEmbutido.Checked = false;
            rdbLanceLivre.Checked = false;

            cboAdministradora.SelectedIndex = -1;

            txtValorBem.Focus();
            btnCalcular.Enabled = true;
            rdbConvencional.Checked = false;
            rdbMaisPorMenos.Checked = false;

        }

        private void frmImovel_Load(object sender, EventArgs e)
        {
            cboAdministradora.SelectedIndex = -1;
        }

        private void tmrFinal_Tick(object sender, EventArgs e)
        {
            progresso += 2;

            if (progresso <= 100)
            {
                pbrFinal.Value = progresso;
            }

            // 2. Define qual mensagem exibir de acordo com a porcentagem
            if (progresso < 35)
            {
                mensagemBase = "Carregando proposta";
            }
            else if (progresso < 70)
            {
                mensagemBase = "Analisando administradoras";
            }
            else if (progresso < 100)
            {
                mensagemBase = "Montando proposta";
            }

            // 3. Efeito dos pontos animados (. -> .. -> ...)
            contadorPontos++;
            int numPontos = (contadorPontos / 3) % 4; // Alterna entre 0, 1, 2 e 3 pontos
            string pontos = new string('.', numPontos);

            // Atualiza a Label com a mensagem do momento + pontinhos
            lblFinal.Text = mensagemBase + pontos;

            // 4. Ação final após a conclusão
            if (progresso >= 100)
            {
                tmrFinal.Stop();
                lblFinal.Text = "Proposta concluída!";


                // Abre o formulário da proposta
                frmProposta telaProposta = new frmProposta(proposta, resultado);
                telaProposta.ShowDialog();
            }
        }

        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;

            if (txtValorBem.Text == string.Empty )
            {
                msgErro += "Preencha o campo VALOR DO BEM!. \n";
            }
            if (txtPrazo.Text == string.Empty)
            {
                msgErro += "Preencha o campo PRAZO!. \n";
            }
            if (txtAdministrativa.Text == string.Empty)
            {
                msgErro += "Preencha o campo % ADMINISTRATIVA!. \n";
            }
            if (txtAdesao.Text == string.Empty)
            {
                msgErro += "Preencha o campo % ADESÃO!. \n";
            }
            if (txtReserva.Text == string.Empty)
            {
                msgErro += "Preencha o campo % RESERVA!. \n";
            }
            if (txtLance.Text == string.Empty)
            {
                msgErro += "Preencha o campo % LANCE!. \n";
            }
            if (cboAdministradora.SelectedIndex == -1)
            {
                msgErro += "Escolha uma ADMINISTRADORA!. \n";
            }
            if (rdbLanceEmbutido.Checked == false && rdbLanceLivre.Checked == false)
            {
                msgErro += "Selecione o tipo de LANCE!. \n";
            }

            return msgErro;
        }

        private Proposta PreencherClasse()
        {
            Proposta p = new Proposta();

            p.NomeCliente = txtNomeCliente.Text;
            int.TryParse(txtPrazo.Text, out int prazo);
            p.Prazo = prazo;
            decimal.TryParse(txtValorBem.Text, out decimal valorBem);
            p.ValorBem = valorBem;
            decimal.TryParse(txtAdministrativa.Text, out decimal taxaAdmin);
            p.TaxaAdmin = taxaAdmin;
            decimal.TryParse(txtAdesao.Text, out decimal taxaAdesao);
            p.TaxaAdesao = taxaAdesao;
            decimal.TryParse(txtReserva.Text, out decimal taxaReserva);
            p.TaxaReserva = taxaReserva;
            decimal.TryParse(txtLance.Text, out decimal lance);
            p.Lance = lance;
            p.Administradora = cboAdministradora.SelectedItem.ToString();

            // Tipo de lance
            if (rdbLanceLivre.Checked)
                p.TipoLance = 1;
            else if (rdbLanceEmbutido.Checked)
                p.TipoLance = 2;
            // Adesão
            if (taxaAdesao > 0)
            {
                if (rdbConvencional.Checked)
                    p.QuantidadeParcelasAdesao = 2;

                if (rdbMaisPorMenos.Checked)
                    p.QuantidadeParcelasAdesao = 12;
            }
            else
            {
                p.QuantidadeParcelasAdesao = 0;
            }
            return p;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarPreenchimento();

            if (mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "ERRO DE PREENCHIMENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            proposta = PreencherClasse();
            CalculadoraConsorcio calc = new CalculadoraConsorcio();
            resultado = calc.Calcular(proposta);
            progresso = 0;
            contadorPontos = 0;

            pbrFinal.Value = 0;
            pbrFinal.Visible = true;
            lblFinal.Visible = true;

            btnCalcular.Enabled = false;

            tmrFinal.Start();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
