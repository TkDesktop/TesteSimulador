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
    public partial class frmSimulador : Form
    {
        private ResultadoSimulacao resultado;
        private ParametrosSimulacao parametros;
        private CategoriaConsorcio categoria;
        private Proposta proposta;

        int progresso = 0;
        int contadorPontos = 0;
        string mensagemBase = "Carregando Sistema";

        private void DefinirCategoria(CategoriaConsorcio categoria)
        {
            this.categoria = categoria;

            string nomeCategoria;

            switch (categoria)
            {
                case CategoriaConsorcio.Imovel:
                    nomeCategoria = "CONSÓRCIO IMOBILIÁRIO";
                    break;

                case CategoriaConsorcio.Automovel:
                    nomeCategoria = "CONSÓRCIO DE AUTOMÓVEIS";
                    break;

                case CategoriaConsorcio.Agro:
                    nomeCategoria = "CONSÓRCIO DE AGRO / PESADOS";
                    break;

                case CategoriaConsorcio.Capital:
                    nomeCategoria = "CONSÓRCIO DE CAPITAL DE GIRO";
                    break;

                case CategoriaConsorcio.Servicos:
                    nomeCategoria = "CONSÓRCIO DE SERVIÇOS";
                    break;

                case CategoriaConsorcio.Personalizado:
                    nomeCategoria = "CONSÓRCIO PERSONALIZADO";
                    break;

                default:
                    nomeCategoria = "CONSÓRCIO GERAL";
                    break;
            }

            Text = $"CONSULTORIA BENVENUTO - {nomeCategoria}";
        }

        public frmSimulador(CategoriaConsorcio categoria)
        {
            InitializeComponent();

            

            txtPrazo.KeyPress += ValidacaoCampos.ApenasNumeros;

            // Campos percentuais
            txtAdministrativa.KeyPress += ValidacaoCampos.ApenasDecimal;
            txtAdministrativa.Enter += ValidacaoCampos.RemoverPercentual;
            txtAdministrativa.Leave += ValidacaoCampos.AdicionarPercentual;

            txtAdesao.KeyPress += ValidacaoCampos.ApenasDecimal;
            txtAdesao.Enter += ValidacaoCampos.RemoverPercentual;
            txtAdesao.Leave += ValidacaoCampos.AdicionarPercentual;

            txtReserva.KeyPress += ValidacaoCampos.ApenasDecimal;
            txtReserva.Enter += ValidacaoCampos.RemoverPercentual;
            txtReserva.Leave += ValidacaoCampos.AdicionarPercentual;

            txtLance.KeyPress += ValidacaoCampos.ApenasDecimal;
            txtLance.Enter += ValidacaoCampos.RemoverPercentual;
            txtLance.Leave += ValidacaoCampos.AdicionarPercentual;

            DefinirCategoria(categoria);


        }

        private void Limpar()
        {
            txtNomeCliente.Clear();
            txtValorBem.Clear();
            txtPrazo.Clear();
            txtAdministrativa.Clear();
            txtLance.Clear();
            txtReserva.Clear();
            txtAdesao.Clear();
            cboLance.SelectedIndex = -1;

            cboAdministradora.SelectedIndex = -1;

            txtValorBem.Focus();
            btnCalcular.Enabled = true;


        }

        private void tmrFinal_Tick(object sender, EventArgs e)
        {
            lblFinal.Visible = true;
            pbrFinal.Visible = true;
            
            
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
            if (cboLance.SelectedIndex == -1)
            {
                msgErro += "Selecione o tipo de LANCE!. \n";
            }

            return msgErro;
        }

        private ParametrosSimulacao PreencherParametros()
        {
            ParametrosSimulacao p = new ParametrosSimulacao();

            p.TaxaAdministracao = ConverterDecimal(txtAdministrativa.Text);
            p.FundoReserva = ConverterDecimal(txtReserva.Text);
            p.ValorAdesao = ConverterDecimal(txtAdesao.Text);
            p.QuantidadeParcelasAdesao = 2;

            // Funções auxiliares para limpar R$, % e pontuações de moeda
            decimal ConverterDecimal(string texto)
            {
                if (string.IsNullOrWhiteSpace(texto)) return 0m;

                // Remove 'R$', '%', espaços e pontos de milhar, mantendo vírgula decimal
                string limpo = texto.Replace("R$", "")
                                    .Replace("%", "")
                                    .Replace(".", "")
                                    .Trim();

                decimal.TryParse(limpo, out decimal valor);
                return valor;
            }

            int ConverterInt(string texto)
            {
                int.TryParse(texto.Trim(), out int valor);
                return valor;
            }

            // 1. Valores e Prazo
            p.ValorCarta = ConverterDecimal(txtValorBem.Text);
            p.Prazo = ConverterInt(txtPrazo.Text);

            // 2. Taxas
            p.TaxaAdministracao = ConverterDecimal(txtAdministrativa.Text);
            p.FundoReserva = ConverterDecimal(txtReserva.Text);
            p.ValorAdesao = ConverterDecimal(txtAdesao.Text);

            // 3. Opção de Lance
            string opcaoLance = (cboLance.SelectedItem?.ToString() ?? string.Empty).Trim();
            decimal percentualLance = ConverterDecimal(txtLance.Text);

            if (string.Equals(opcaoLance, "LANCE EMBUTIDO", StringComparison.OrdinalIgnoreCase))
            {
                p.InformouLance = percentualLance > 0;
                p.LanceEmbutido = true;
                p.PercentualLance = percentualLance;
            }
            else if (string.Equals(opcaoLance, "LANCE LIVRE", StringComparison.OrdinalIgnoreCase))
            {
                p.InformouLance = percentualLance > 0;
                p.LanceEmbutido = false;
                p.PercentualLance = percentualLance;
            }
            else
            {
                p.InformouLance = false;
                p.LanceEmbutido = false;
                p.PercentualLance = 0m;
            }

            return p;
        }
          
        private void frmSimulador_Load(object sender, EventArgs e)
        {
            cboAdministradora.SelectedIndex = -1;
            txtValorBem.KeyPress += ValidacaoCampos.ApenasDecimal;
            txtValorBem.Enter += ValidacaoCampos.RemoverMoeda;
            txtValorBem.Leave += ValidacaoCampos.AdicionarMoeda;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarPreenchimento();

            if (mensagem.Length > 0)
            {
                MessageBox.Show(mensagem, "ERRO DE PREENCHIMENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            parametros = PreencherParametros();
            ICalculadoraConsorcio calc = new CalculadoraConsorcioEmbracon();
            resultado = calc.Calcular(parametros);

            proposta = new Proposta
            {
                NomeCliente = string.IsNullOrWhiteSpace(txtNomeCliente.Text) ? "Cliente" : txtNomeCliente.Text,
                Administradora = cboAdministradora.SelectedItem?.ToString() ?? "Embracon",
                ValorBem = parametros.ValorCarta,
                Prazo = parametros.Prazo,
                QuantidadeParcelasAdesao = 2, // Ajuste se houver campo de parcelamento de adesão
                TipoLance = parametros.LanceEmbutido ? 2 : 1
            };

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
