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
    public partial class frmPersonalizado : Form
    {
        public frmPersonalizado()
        {
            InitializeComponent();
        }

        private ResultadoCalculo resultado;
        private Proposta proposta;

        int progresso = 0;
        int contadorPontos = 0;
        string mensagemBase = "Carregando Sistema";

        private void frmPersonalizado_Load(object sender, EventArgs e)
        {
            cboAdministradora.SelectedIndex = -1;
        }

        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;

            if (txtValorBem.Text == string.Empty)
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

        private void Limpar()
        {
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarPreenchimento();

            if (mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "ERRO DE PREENCHIMENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progresso = 0;
            contadorPontos = 0;

            pbrFinal.Value = 0;
            pbrFinal.Visible = true;
            lblFinal.Visible = true;

            // Bloqueia o botão durante o processo
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
