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

        string textoSaudacao = "Seja Bem Vindo, Admin Como vamos te ajudar hoje?";
        int indice = 0;
        int etapa = 0;
        bool confirma = false;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblSaudacao.Text = "";

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
    }
}
