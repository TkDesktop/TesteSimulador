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
            textoSaudacao = $"{saudacao}, Vamos planejar a conquista do seu cliente?";
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
                btnCapital.Visible = false;

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
                    btnCapital.Visible = true;
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
    }
}
