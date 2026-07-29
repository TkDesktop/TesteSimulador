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
            }
        }

    }
}
