namespace TesteSimulador
{
    partial class frmImovel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCalcular = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnLimpar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnSair = new ReaLTaiizor.Controls.HopeRoundButton();
            this.lblValorBem = new ReaLTaiizor.Controls.LabelEdit();
            this.lblLance = new ReaLTaiizor.Controls.LabelEdit();
            this.lblAdesao = new ReaLTaiizor.Controls.LabelEdit();
            this.lblTaxaAdmin = new ReaLTaiizor.Controls.LabelEdit();
            this.lblPrazo = new ReaLTaiizor.Controls.LabelEdit();
            this.rdbLanceEmbutido = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.rdbLanceLivre = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.lblFundoReserva = new ReaLTaiizor.Controls.LabelEdit();
            this.lblValorAdministrativa = new ReaLTaiizor.Controls.LabelEdit();
            this.lblValorAdesao = new ReaLTaiizor.Controls.LabelEdit();
            this.lblValorReserva = new ReaLTaiizor.Controls.LabelEdit();
            this.txtValorBem = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtPrazo = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtAdministrativa = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtAdesao = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtReserva = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtLance = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtValorAdmin = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtValorAdesao = new ReaLTaiizor.Controls.MoonTextBox();
            this.txtValorReserva = new ReaLTaiizor.Controls.MoonTextBox();
            this.lblEscolha = new ReaLTaiizor.Controls.LabelEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pbrFinal = new ReaLTaiizor.Controls.AloneProgressBar();
            this.lblFinal = new ReaLTaiizor.Controls.LabelEdit();
            this.cboAdministradora = new ReaLTaiizor.Controls.SkyComboBox();
            this.tmrFinal = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BorderColor = System.Drawing.Color.Yellow;
            this.btnCalcular.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCalcular.DefaultColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.HoverTextColor = System.Drawing.Color.White;
            this.btnCalcular.InfoColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(77, 406);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.PrimaryColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Size = new System.Drawing.Size(178, 32);
            this.btnCalcular.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular Oferta";
            this.btnCalcular.TextColor = System.Drawing.Color.White;
            this.btnCalcular.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BorderColor = System.Drawing.Color.Yellow;
            this.btnLimpar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnLimpar.DefaultColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.HoverTextColor = System.Drawing.Color.White;
            this.btnLimpar.InfoColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(309, 406);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.PrimaryColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Size = new System.Drawing.Size(178, 32);
            this.btnLimpar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.TextColor = System.Drawing.Color.White;
            this.btnLimpar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BorderColor = System.Drawing.Color.Yellow;
            this.btnSair.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSair.DefaultColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.HoverTextColor = System.Drawing.Color.White;
            this.btnSair.InfoColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(560, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.PrimaryColor = System.Drawing.Color.Transparent;
            this.btnSair.Size = new System.Drawing.Size(178, 32);
            this.btnSair.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblValorBem
            // 
            this.lblValorBem.AutoSize = true;
            this.lblValorBem.BackColor = System.Drawing.Color.Transparent;
            this.lblValorBem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblValorBem.Location = new System.Drawing.Point(12, 44);
            this.lblValorBem.Name = "lblValorBem";
            this.lblValorBem.Size = new System.Drawing.Size(108, 21);
            this.lblValorBem.TabIndex = 37;
            this.lblValorBem.Text = "Valor do Bem";
            // 
            // lblLance
            // 
            this.lblLance.AutoSize = true;
            this.lblLance.BackColor = System.Drawing.Color.Transparent;
            this.lblLance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblLance.Location = new System.Drawing.Point(208, 115);
            this.lblLance.Name = "lblLance";
            this.lblLance.Size = new System.Drawing.Size(69, 21);
            this.lblLance.TabIndex = 43;
            this.lblLance.Text = "% Lance";
            // 
            // lblAdesao
            // 
            this.lblAdesao.AutoSize = true;
            this.lblAdesao.BackColor = System.Drawing.Color.Transparent;
            this.lblAdesao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdesao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblAdesao.Location = new System.Drawing.Point(12, 254);
            this.lblAdesao.Name = "lblAdesao";
            this.lblAdesao.Size = new System.Drawing.Size(105, 21);
            this.lblAdesao.TabIndex = 45;
            this.lblAdesao.Text = "% de Adesão";
            // 
            // lblTaxaAdmin
            // 
            this.lblTaxaAdmin.AutoSize = true;
            this.lblTaxaAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxaAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTaxaAdmin.Location = new System.Drawing.Point(12, 187);
            this.lblTaxaAdmin.Name = "lblTaxaAdmin";
            this.lblTaxaAdmin.Size = new System.Drawing.Size(132, 21);
            this.lblTaxaAdmin.TabIndex = 47;
            this.lblTaxaAdmin.Text = "% Administrativa";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.BackColor = System.Drawing.Color.Transparent;
            this.lblPrazo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblPrazo.Location = new System.Drawing.Point(12, 115);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(50, 21);
            this.lblPrazo.TabIndex = 49;
            this.lblPrazo.Text = "Prazo";
            // 
            // rdbLanceEmbutido
            // 
            this.rdbLanceEmbutido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.rdbLanceEmbutido.BaseColor = System.Drawing.Color.White;
            this.rdbLanceEmbutido.BorderColor = System.Drawing.Color.Lime;
            this.rdbLanceEmbutido.Checked = false;
            this.rdbLanceEmbutido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbLanceEmbutido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLanceEmbutido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rdbLanceEmbutido.Location = new System.Drawing.Point(217, 90);
            this.rdbLanceEmbutido.Name = "rdbLanceEmbutido";
            this.rdbLanceEmbutido.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdbLanceEmbutido.Size = new System.Drawing.Size(136, 22);
            this.rdbLanceEmbutido.TabIndex = 6;
            this.rdbLanceEmbutido.Text = "Lance Embutido";
            // 
            // rdbLanceLivre
            // 
            this.rdbLanceLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.rdbLanceLivre.BaseColor = System.Drawing.Color.White;
            this.rdbLanceLivre.BorderColor = System.Drawing.Color.Lime;
            this.rdbLanceLivre.Checked = false;
            this.rdbLanceLivre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbLanceLivre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLanceLivre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rdbLanceLivre.Location = new System.Drawing.Point(217, 57);
            this.rdbLanceLivre.Name = "rdbLanceLivre";
            this.rdbLanceLivre.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdbLanceLivre.Size = new System.Drawing.Size(112, 22);
            this.rdbLanceLivre.TabIndex = 5;
            this.rdbLanceLivre.Text = "Lance Livre";
            // 
            // lblFundoReserva
            // 
            this.lblFundoReserva.AutoSize = true;
            this.lblFundoReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblFundoReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundoReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblFundoReserva.Location = new System.Drawing.Point(12, 326);
            this.lblFundoReserva.Name = "lblFundoReserva";
            this.lblFundoReserva.Size = new System.Drawing.Size(135, 21);
            this.lblFundoReserva.TabIndex = 52;
            this.lblFundoReserva.Text = "% Fundo Reserva";
            // 
            // lblValorAdministrativa
            // 
            this.lblValorAdministrativa.AutoSize = true;
            this.lblValorAdministrativa.BackColor = System.Drawing.Color.Transparent;
            this.lblValorAdministrativa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAdministrativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblValorAdministrativa.Location = new System.Drawing.Point(208, 187);
            this.lblValorAdministrativa.Name = "lblValorAdministrativa";
            this.lblValorAdministrativa.Size = new System.Drawing.Size(156, 21);
            this.lblValorAdministrativa.TabIndex = 54;
            this.lblValorAdministrativa.Text = "Valor Administrativa";
            // 
            // lblValorAdesao
            // 
            this.lblValorAdesao.AutoSize = true;
            this.lblValorAdesao.BackColor = System.Drawing.Color.Transparent;
            this.lblValorAdesao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAdesao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblValorAdesao.Location = new System.Drawing.Point(208, 254);
            this.lblValorAdesao.Name = "lblValorAdesao";
            this.lblValorAdesao.Size = new System.Drawing.Size(129, 21);
            this.lblValorAdesao.TabIndex = 56;
            this.lblValorAdesao.Text = "Valor de Adesão";
            // 
            // lblValorReserva
            // 
            this.lblValorReserva.AutoSize = true;
            this.lblValorReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblValorReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblValorReserva.Location = new System.Drawing.Point(208, 326);
            this.lblValorReserva.Name = "lblValorReserva";
            this.lblValorReserva.Size = new System.Drawing.Size(159, 21);
            this.lblValorReserva.TabIndex = 58;
            this.lblValorReserva.Text = "Valor Fundo Reserva";
            // 
            // txtValorBem
            // 
            this.txtValorBem.BackColor = System.Drawing.Color.White;
            this.txtValorBem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtValorBem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorBem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorBem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtValorBem.Location = new System.Drawing.Point(16, 77);
            this.txtValorBem.Name = "txtValorBem";
            this.txtValorBem.Size = new System.Drawing.Size(167, 22);
            this.txtValorBem.TabIndex = 0;
            this.txtValorBem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrazo
            // 
            this.txtPrazo.BackColor = System.Drawing.Color.White;
            this.txtPrazo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtPrazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrazo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrazo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPrazo.Location = new System.Drawing.Point(16, 150);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(167, 22);
            this.txtPrazo.TabIndex = 1;
            this.txtPrazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdministrativa
            // 
            this.txtAdministrativa.BackColor = System.Drawing.Color.White;
            this.txtAdministrativa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtAdministrativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdministrativa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministrativa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAdministrativa.Location = new System.Drawing.Point(16, 220);
            this.txtAdministrativa.Name = "txtAdministrativa";
            this.txtAdministrativa.Size = new System.Drawing.Size(167, 22);
            this.txtAdministrativa.TabIndex = 2;
            this.txtAdministrativa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdesao
            // 
            this.txtAdesao.BackColor = System.Drawing.Color.White;
            this.txtAdesao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtAdesao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdesao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdesao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAdesao.Location = new System.Drawing.Point(16, 288);
            this.txtAdesao.Name = "txtAdesao";
            this.txtAdesao.Size = new System.Drawing.Size(167, 22);
            this.txtAdesao.TabIndex = 3;
            this.txtAdesao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReserva
            // 
            this.txtReserva.BackColor = System.Drawing.Color.White;
            this.txtReserva.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReserva.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserva.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtReserva.Location = new System.Drawing.Point(16, 361);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(167, 22);
            this.txtReserva.TabIndex = 4;
            this.txtReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLance
            // 
            this.txtLance.BackColor = System.Drawing.Color.White;
            this.txtLance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtLance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLance.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtLance.Location = new System.Drawing.Point(212, 150);
            this.txtLance.Name = "txtLance";
            this.txtLance.Size = new System.Drawing.Size(167, 22);
            this.txtLance.TabIndex = 7;
            this.txtLance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorAdmin
            // 
            this.txtValorAdmin.BackColor = System.Drawing.Color.White;
            this.txtValorAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtValorAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorAdmin.Enabled = false;
            this.txtValorAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAdmin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtValorAdmin.Location = new System.Drawing.Point(212, 220);
            this.txtValorAdmin.Name = "txtValorAdmin";
            this.txtValorAdmin.Size = new System.Drawing.Size(167, 22);
            this.txtValorAdmin.TabIndex = 8;
            this.txtValorAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorAdesao
            // 
            this.txtValorAdesao.BackColor = System.Drawing.Color.White;
            this.txtValorAdesao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtValorAdesao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorAdesao.Enabled = false;
            this.txtValorAdesao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAdesao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtValorAdesao.Location = new System.Drawing.Point(212, 288);
            this.txtValorAdesao.Name = "txtValorAdesao";
            this.txtValorAdesao.Size = new System.Drawing.Size(167, 22);
            this.txtValorAdesao.TabIndex = 9;
            this.txtValorAdesao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorReserva
            // 
            this.txtValorReserva.BackColor = System.Drawing.Color.White;
            this.txtValorReserva.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.txtValorReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorReserva.Enabled = false;
            this.txtValorReserva.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorReserva.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtValorReserva.Location = new System.Drawing.Point(212, 361);
            this.txtValorReserva.Name = "txtValorReserva";
            this.txtValorReserva.Size = new System.Drawing.Size(167, 22);
            this.txtValorReserva.TabIndex = 10;
            this.txtValorReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.BackColor = System.Drawing.Color.Transparent;
            this.lblEscolha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblEscolha.Location = new System.Drawing.Point(515, 151);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(193, 21);
            this.lblEscolha.TabIndex = 73;
            this.lblEscolha.Text = "Escolha a Administradora";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFinal);
            this.panel1.Controls.Add(this.pbrFinal);
            this.panel1.Location = new System.Drawing.Point(397, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 180);
            this.panel1.TabIndex = 74;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.iconPictureBox1.BackgroundImage = global::TesteSimulador.Properties.Resources.ChatGPT_Image_30_de_jun__de_2026__19_44_45;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 122;
            this.iconPictureBox1.Location = new System.Drawing.Point(535, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(152, 122);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 71;
            this.iconPictureBox1.TabStop = false;
            // 
            // pbrFinal
            // 
            this.pbrFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.pbrFinal.BackgroundColor = System.Drawing.Color.Transparent;
            this.pbrFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.pbrFinal.Location = new System.Drawing.Point(13, 93);
            this.pbrFinal.Maximum = 100;
            this.pbrFinal.Minimum = 0;
            this.pbrFinal.Name = "pbrFinal";
            this.pbrFinal.Size = new System.Drawing.Size(355, 12);
            this.pbrFinal.Stripes = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.pbrFinal.TabIndex = 78;
            this.pbrFinal.Text = "aloneProgressBar1";
            this.pbrFinal.Value = 50;
            this.pbrFinal.Visible = false;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblFinal.Location = new System.Drawing.Point(135, 75);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(54, 15);
            this.lblFinal.TabIndex = 79;
            this.lblFinal.Text = "Aguarde";
            this.lblFinal.Visible = false;
            // 
            // cboAdministradora
            // 
            this.cboAdministradora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.cboAdministradora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboAdministradora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAdministradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdministradora.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdministradora.ForeColor = System.Drawing.Color.Black;
            this.cboAdministradora.FormattingEnabled = true;
            this.cboAdministradora.ItemHeight = 16;
            this.cboAdministradora.ItemHighlightColor = System.Drawing.Color.Transparent;
            this.cboAdministradora.Items.AddRange(new object[] {
            "SAFRA",
            "MAGALU",
            "HS",
            "EMBRACON",
            "ADEMICON",
            "AUDI",
            "BMW",
            "CANOPUS",
            "DODGE"});
            this.cboAdministradora.Location = new System.Drawing.Point(519, 175);
            this.cboAdministradora.Name = "cboAdministradora";
            this.cboAdministradora.Size = new System.Drawing.Size(189, 22);
            this.cboAdministradora.StartIndex = 0;
            this.cboAdministradora.TabIndex = 76;
            // 
            // tmrFinal
            // 
            this.tmrFinal.Interval = 450;
            this.tmrFinal.Tick += new System.EventHandler(this.tmrFinal_Tick);
            // 
            // frmImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboAdministradora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtValorReserva);
            this.Controls.Add(this.txtValorAdesao);
            this.Controls.Add(this.txtValorAdmin);
            this.Controls.Add(this.txtLance);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.txtAdesao);
            this.Controls.Add(this.txtAdministrativa);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.txtValorBem);
            this.Controls.Add(this.lblValorReserva);
            this.Controls.Add(this.lblValorAdesao);
            this.Controls.Add(this.lblValorAdministrativa);
            this.Controls.Add(this.lblFundoReserva);
            this.Controls.Add(this.rdbLanceLivre);
            this.Controls.Add(this.rdbLanceEmbutido);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblTaxaAdmin);
            this.Controls.Add(this.lblAdesao);
            this.Controls.Add(this.lblLance);
            this.Controls.Add(this.lblValorBem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImovel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTORIA BENVENUTO - IMÓVEL";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmImovel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.HopeRoundButton btnLimpar;
        private ReaLTaiizor.Controls.HopeRoundButton btnSair;
        private ReaLTaiizor.Controls.LabelEdit lblValorBem;
        private ReaLTaiizor.Controls.LabelEdit lblLance;
        private ReaLTaiizor.Controls.LabelEdit lblAdesao;
        private ReaLTaiizor.Controls.LabelEdit lblTaxaAdmin;
        private ReaLTaiizor.Controls.LabelEdit lblPrazo;
        private ReaLTaiizor.Controls.ForeverRadioButton rdbLanceEmbutido;
        private ReaLTaiizor.Controls.ForeverRadioButton rdbLanceLivre;
        private ReaLTaiizor.Controls.LabelEdit lblFundoReserva;
        private ReaLTaiizor.Controls.LabelEdit lblValorAdministrativa;
        private ReaLTaiizor.Controls.LabelEdit lblValorAdesao;
        private ReaLTaiizor.Controls.LabelEdit lblValorReserva;
        private ReaLTaiizor.Controls.MoonTextBox txtValorBem;
        private ReaLTaiizor.Controls.MoonTextBox txtPrazo;
        private ReaLTaiizor.Controls.MoonTextBox txtAdministrativa;
        private ReaLTaiizor.Controls.MoonTextBox txtAdesao;
        private ReaLTaiizor.Controls.MoonTextBox txtReserva;
        private ReaLTaiizor.Controls.MoonTextBox txtLance;
        private ReaLTaiizor.Controls.MoonTextBox txtValorAdmin;
        private ReaLTaiizor.Controls.MoonTextBox txtValorAdesao;
        private ReaLTaiizor.Controls.MoonTextBox txtValorReserva;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ReaLTaiizor.Controls.LabelEdit lblEscolha;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.AloneProgressBar pbrFinal;
        private ReaLTaiizor.Controls.LabelEdit lblFinal;
        private ReaLTaiizor.Controls.SkyComboBox cboAdministradora;
        private System.Windows.Forms.Timer tmrFinal;
        public ReaLTaiizor.Controls.HopeRoundButton btnCalcular;
    }
}