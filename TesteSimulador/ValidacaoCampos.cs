using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteSimulador
{
    public static class ValidacaoCampos
    {
        // Permite apenas números inteiros (ex: Prazo)
        public static void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Permite números e uma única vírgula decimal (ex: taxas em %)
        public static void ApenasDecimal(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txt != null && txt.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        // Remove o "%" ao entrar no campo
        public static void RemoverPercentual(object sender, System.EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.Text = txt.Text.Replace("%", "").Trim();
            }
        }

        // Adiciona o "%" ao sair do campo (se tiver algum valor digitado)
        public static void AdicionarPercentual(object sender, System.EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && !string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = txt.Text.Trim() + "%";
            }
        }

        // Remove o "R$" ao entrar no campo
        public static void RemoverMoeda(object sender, System.EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.Text = txt.Text.Replace("R$", "").Trim();
            }
        }

        // Adiciona o "R$" ao sair do campo (se tiver algum valor digitado)
        public static void AdicionarMoeda(object sender, System.EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && !string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "R$ " + txt.Text.Trim();
            }
        }
    }
}
