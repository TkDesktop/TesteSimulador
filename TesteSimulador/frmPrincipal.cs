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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        int indice = 0;
        int etapa = 0;
        string saudacao = "";
        string textoSaudacao = "";
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblSaudacao.Text = "";
            saudacao = ObterSaudacaoPorHorario();
            textoSaudacao = $"Seja bem vindo a Consultoria Benvenuto Vamos planejar a conquista do seu cliente?";
            tmrSaudacao.Start();
        }

        private void tmrSaudacao_Tick(object sender, EventArgs e)
        {
            if (indice < textoSaudacao.Length)
            {
                lblSaudacao.Text += textoSaudacao[indice];
                indice++;
            }
            else
            {
                tmrSaudacao.Stop();

                btnImovel.Visible = false;
                btnAutomovel.Visible = false;
                btnAgro.Visible = false;

                tmrBotoes.Start();
            }
        }


        private void tmrBotoes_Tick(object sender, EventArgs e)
        {
            switch (etapa)
            {
                case 0:
                    btnImovel.Visible = true;
                    break;

                case 1:
                    btnAutomovel.Visible = true;
                    break;

                case 2:
                    btnAgro.Visible = true;
                    break;

                case 3:
                    btnCapital.Visible = true;
                    break;

                case 4:
                    btnServico.Visible = true;
                    break;

                case 5:
                    btnPersonalizado.Visible = true;
                    tmrBotoes.Stop();
                    break;
            }

            etapa++;
        }

        private string ObterSaudacaoPorHorario()
        {
            int horaAtual = DateTime.Now.Hour;

            if (horaAtual >= 5 && horaAtual < 12)
            {
                return "Bom dia";
            }
            else if (horaAtual >= 12 && horaAtual < 18)
            {
                return "Boa tarde";
            }
            else
            {
                return "Boa noite";
            }
        }

        private void AbrirForm(Form form)
        {
            if (!VerificarAutenticacao())
            {
                form.Dispose();
                return;
            }

            // === ETAPA 2: VERIFICA SE A JANELA JÁ ESTÁ ABERTA ===
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto.GetType() == form.GetType())
                {
                    form.Dispose();

                    if (formAberto.WindowState == FormWindowState.Minimized)
                        formAberto.WindowState = FormWindowState.Normal;

                    formAberto.BringToFront();
                    formAberto.Focus();
                    return;
                }
            }

            // === ETAPA 3: EXIBE A NOVA JANELA ===
            form.TopLevel = true;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private bool VerificarAutenticacao()
        {
            // Se já estiver logado, não precisa abrir a tela de login de novo!
            if (Usuario.logado)
            {
                return true;
            }

            // Se não estiver logado, abre a tela de login
            using (frmLogin telaLogin = new frmLogin())
            {
                if (telaLogin.ShowDialog() == DialogResult.OK)
                {
                    // Marca na sessão que agora ele está logado
                    Usuario.logado = true;
                    return true;
                }
            }

            // Usuário cancelou ou fechou a tela de login
            return false;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente encerrar a aplicação?",
               "Consultoria Benvenuto", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnImovel_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmImovel());
        }

        private void btnAutomovel_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAutomovel());
        }

        private void btnCapital_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCapitaldeGiro());
        }

        private void btnAgro_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgro());
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmServico());
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPersonalizado());
        }
    }
}
