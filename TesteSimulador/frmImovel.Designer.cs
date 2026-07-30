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
            this.btnCalcular = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnPDF = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnLimpar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnSair = new ReaLTaiizor.Controls.HopeRoundButton();
            this.pnlProposta = new System.Windows.Forms.Panel();
            this.lblValorBem = new ReaLTaiizor.Controls.LabelEdit();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.rdbLanceEmbutido = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.rdbLanceLivre = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.comboBoxEdit1 = new ReaLTaiizor.Controls.ComboBoxEdit();
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
            this.btnCalcular.Location = new System.Drawing.Point(12, 406);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.PrimaryColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Size = new System.Drawing.Size(178, 32);
            this.btnCalcular.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCalcular.TabIndex = 31;
            this.btnCalcular.Text = "Calcular Oferta";
            this.btnCalcular.TextColor = System.Drawing.Color.White;
            this.btnCalcular.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            // 
            // btnPDF
            // 
            this.btnPDF.BorderColor = System.Drawing.Color.Yellow;
            this.btnPDF.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnPDF.DefaultColor = System.Drawing.Color.Transparent;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPDF.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPDF.HoverTextColor = System.Drawing.Color.White;
            this.btnPDF.InfoColor = System.Drawing.Color.Black;
            this.btnPDF.Location = new System.Drawing.Point(212, 406);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.PrimaryColor = System.Drawing.Color.Transparent;
            this.btnPDF.Size = new System.Drawing.Size(178, 32);
            this.btnPDF.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnPDF.TabIndex = 32;
            this.btnPDF.Text = "Gerar PDF";
            this.btnPDF.TextColor = System.Drawing.Color.White;
            this.btnPDF.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btnLimpar.Location = new System.Drawing.Point(410, 406);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.PrimaryColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Size = new System.Drawing.Size(178, 32);
            this.btnLimpar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.TextColor = System.Drawing.Color.White;
            this.btnLimpar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btnSair.Location = new System.Drawing.Point(610, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.PrimaryColor = System.Drawing.Color.Transparent;
            this.btnSair.Size = new System.Drawing.Size(178, 32);
            this.btnSair.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSair.TabIndex = 34;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlProposta
            // 
            this.pnlProposta.Location = new System.Drawing.Point(410, 0);
            this.pnlProposta.Name = "pnlProposta";
            this.pnlProposta.Size = new System.Drawing.Size(392, 400);
            this.pnlProposta.TabIndex = 36;
            this.pnlProposta.Visible = false;
            // 
            // lblValorBem
            // 
            this.lblValorBem.AutoSize = true;
            this.lblValorBem.BackColor = System.Drawing.Color.Transparent;
            this.lblValorBem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBem.ForeColor = System.Drawing.Color.Yellow;
            this.lblValorBem.Location = new System.Drawing.Point(12, 20);
            this.lblValorBem.Name = "lblValorBem";
            this.lblValorBem.Size = new System.Drawing.Size(108, 21);
            this.lblValorBem.TabIndex = 37;
            this.lblValorBem.Text = "Valor do Bem";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(16, 44);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(143, 20);
            this.txtLogin.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(16, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 44;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit1.ForeColor = System.Drawing.Color.Yellow;
            this.labelEdit1.Location = new System.Drawing.Point(16, 306);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(69, 21);
            this.labelEdit1.TabIndex = 43;
            this.labelEdit1.Text = "% Lance";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(16, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 46;
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit2.ForeColor = System.Drawing.Color.Yellow;
            this.labelEdit2.Location = new System.Drawing.Point(16, 207);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(126, 21);
            this.labelEdit2.TabIndex = 45;
            this.labelEdit2.Text = "Valor de Parcela";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(16, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 48;
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit3.ForeColor = System.Drawing.Color.Yellow;
            this.labelEdit3.Location = new System.Drawing.Point(12, 140);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(150, 21);
            this.labelEdit3.TabIndex = 47;
            this.labelEdit3.Text = "Taxa Administrativa";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(16, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 20);
            this.textBox4.TabIndex = 50;
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit4.ForeColor = System.Drawing.Color.Yellow;
            this.labelEdit4.Location = new System.Drawing.Point(12, 78);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(50, 21);
            this.labelEdit4.TabIndex = 49;
            this.labelEdit4.Text = "Prazo";
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
            this.rdbLanceEmbutido.Location = new System.Drawing.Point(126, 268);
            this.rdbLanceEmbutido.Name = "rdbLanceEmbutido";
            this.rdbLanceEmbutido.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdbLanceEmbutido.Size = new System.Drawing.Size(145, 22);
            this.rdbLanceEmbutido.TabIndex = 0;
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
            this.rdbLanceLivre.Location = new System.Drawing.Point(8, 268);
            this.rdbLanceLivre.Name = "rdbLanceLivre";
            this.rdbLanceLivre.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdbLanceLivre.Size = new System.Drawing.Size(112, 22);
            this.rdbLanceLivre.TabIndex = 51;
            this.rdbLanceLivre.Text = "Lance Livre";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBoxEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEdit1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEdit1.DropDownHeight = 100;
            this.comboBoxEdit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.comboBoxEdit1.FormattingEnabled = true;
            this.comboBoxEdit1.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.comboBoxEdit1.IntegralHeight = false;
            this.comboBoxEdit1.ItemHeight = 20;
            this.comboBoxEdit1.Location = new System.Drawing.Point(244, 38);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Size = new System.Drawing.Size(146, 26);
            this.comboBoxEdit1.StartIndex = 0;
            this.comboBoxEdit1.TabIndex = 52;
            // 
            // frmImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::TesteSimulador.Properties.Resources.ChatGPT_Image_30_de_jun__de_2026__19_44_45;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.rdbLanceLivre);
            this.Controls.Add(this.rdbLanceEmbutido);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelEdit4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelEdit3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelEdit2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEdit1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblValorBem);
            this.Controls.Add(this.pnlProposta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnCalcular);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImovel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTORIA BENVENUTO - IMÓVEL";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnCalcular;
        private ReaLTaiizor.Controls.HopeRoundButton btnPDF;
        private ReaLTaiizor.Controls.HopeRoundButton btnLimpar;
        private ReaLTaiizor.Controls.HopeRoundButton btnSair;
        private System.Windows.Forms.Panel pnlProposta;
        private ReaLTaiizor.Controls.LabelEdit lblValorBem;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox textBox1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private System.Windows.Forms.TextBox textBox2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private System.Windows.Forms.TextBox textBox3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private System.Windows.Forms.TextBox textBox4;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.ForeverRadioButton rdbLanceEmbutido;
        private ReaLTaiizor.Controls.ForeverRadioButton rdbLanceLivre;
        private ReaLTaiizor.Controls.ComboBoxEdit comboBoxEdit1;
    }
}