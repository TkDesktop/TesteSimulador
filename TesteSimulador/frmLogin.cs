using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteSimulador
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarPreenchimento();
            string user = txtLogin.Text;
            string pass = txtSenha.Text;


            if (mensagem.Length > 0 )
            {
                MessageBox.Show(mensagem, "ERRO DE PREENCHIMENTO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (ValidarAutenticacao(user, pass))
            {
                MessageBox.Show($"Seja Bem Vindo, {user}","CONSULTORIA BENVENUTO", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login e/ou Senha Incorreta, por favor tente novamente", "CONSULTORIA BENVENUTO",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtLogin.Focus();
            }

        }

        private string ValidarPreenchimento()
        {
            string msgErro = "";

            if (txtLogin.Text == string.Empty)
            {
                msgErro += "Preencha o campo LOGIN \n";
            }

            if (txtSenha.Text == string.Empty)
            {
                msgErro += "Preencha o campo SENHA \n";
            }

            return msgErro;
        }

        private bool ValidarAutenticacao(string login, string senha)
        {
            for (int i = 1; i < 11; i++)
            {
                string user = ConfigurationManager.AppSettings[$"User{i}"];
                string password = ConfigurationManager.AppSettings[$"Pass{i}"];

                if (login == user && senha == password)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
