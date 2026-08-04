namespace TesteSimulador
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.tmrSaudacao = new System.Windows.Forms.Timer(this.components);
            this.tmrBotoes = new System.Windows.Forms.Timer(this.components);
            this.pnlSaudacao = new ReaLTaiizor.Controls.MetroPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnImovel = new FontAwesome.Sharp.IconButton();
            this.btnAgro = new FontAwesome.Sharp.IconButton();
            this.btnAutomovel = new FontAwesome.Sharp.IconButton();
            this.btnPersonalizado = new FontAwesome.Sharp.IconButton();
            this.btnServico = new FontAwesome.Sharp.IconButton();
            this.btnCapital = new FontAwesome.Sharp.IconButton();
            this.LplBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSaudacao.SuspendLayout();
            this.LplBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.BackColor = System.Drawing.Color.Transparent;
            this.lblSaudacao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.lblSaudacao.Location = new System.Drawing.Point(18, 13);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(107, 30);
            this.lblSaudacao.TabIndex = 0;
            this.lblSaudacao.Text = "Saudação";
            // 
            // tmrSaudacao
            // 
            this.tmrSaudacao.Interval = 60;
            this.tmrSaudacao.Tick += new System.EventHandler(this.tmrSaudacao_Tick);
            // 
            // tmrBotoes
            // 
            this.tmrBotoes.Interval = 500;
            this.tmrBotoes.Tick += new System.EventHandler(this.tmrBotoes_Tick);
            // 
            // pnlSaudacao
            // 
            this.pnlSaudacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(19)))));
            this.pnlSaudacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.pnlSaudacao.BorderThickness = 2;
            this.pnlSaudacao.Controls.Add(this.flowLayoutPanel1);
            this.pnlSaudacao.Controls.Add(this.lblSaudacao);
            this.pnlSaudacao.Location = new System.Drawing.Point(-5, -3);
            this.pnlSaudacao.MetroStyleManager = null;
            this.pnlSaudacao.Name = "pnlSaudacao";
            this.pnlSaudacao.Size = new System.Drawing.Size(914, 63);
            this.pnlSaudacao.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.pnlSaudacao.TabIndex = 18;
            this.pnlSaudacao.ThemeAuthor = "Taiizor";
            this.pnlSaudacao.ThemeName = "MetroLite";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 605);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // btnImovel
            // 
            this.btnImovel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.btnImovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImovel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.btnImovel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(16)))), ((int)(((byte)(13)))));
            this.btnImovel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnImovel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImovel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImovel.ForeColor = System.Drawing.Color.White;
            this.btnImovel.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleArrowRight;
            this.btnImovel.IconColor = System.Drawing.Color.Yellow;
            this.btnImovel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImovel.IconSize = 28;
            this.btnImovel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImovel.Location = new System.Drawing.Point(3, 3);
            this.btnImovel.Name = "btnImovel";
            this.btnImovel.Size = new System.Drawing.Size(164, 60);
            this.btnImovel.TabIndex = 0;
            this.btnImovel.Text = "Imóveis";
            this.btnImovel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImovel.UseVisualStyleBackColor = false;
            this.btnImovel.Visible = false;
            this.btnImovel.Click += new System.EventHandler(this.btnImovel_Click);
            // 
            // btnAgro
            // 
            this.btnAgro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.btnAgro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.btnAgro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(16)))), ((int)(((byte)(13)))));
            this.btnAgro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnAgro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgro.ForeColor = System.Drawing.Color.White;
            this.btnAgro.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.btnAgro.IconColor = System.Drawing.Color.Yellow;
            this.btnAgro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgro.IconSize = 28;
            this.btnAgro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgro.Location = new System.Drawing.Point(3, 201);
            this.btnAgro.Name = "btnAgro";
            this.btnAgro.Size = new System.Drawing.Size(164, 60);
            this.btnAgro.TabIndex = 2;
            this.btnAgro.Text = "Agro e Pesados";
            this.btnAgro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgro.UseVisualStyleBackColor = false;
            this.btnAgro.Visible = false;
            this.btnAgro.Click += new System.EventHandler(this.btnAgro_Click);
            // 
            // btnAutomovel
            // 
            this.btnAutomovel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.btnAutomovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutomovel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.btnAutomovel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(16)))), ((int)(((byte)(13)))));
            this.btnAutomovel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnAutomovel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomovel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomovel.ForeColor = System.Drawing.Color.White;
            this.btnAutomovel.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnAutomovel.IconColor = System.Drawing.Color.Yellow;
            this.btnAutomovel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAutomovel.IconSize = 28;
            this.btnAutomovel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutomovel.Location = new System.Drawing.Point(3, 102);
            this.btnAutomovel.Name = "btnAutomovel";
            this.btnAutomovel.Size = new System.Drawing.Size(164, 60);
            this.btnAutomovel.TabIndex = 1;
            this.btnAutomovel.Text = "Automovel";
            this.btnAutomovel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAutomovel.UseVisualStyleBackColor = false;
            this.btnAutomovel.Visible = false;
            this.btnAutomovel.Click += new System.EventHandler(this.btnAutomovel_Click);
            // 
            // btnPersonalizado
            // 
            this.btnPersonalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.btnPersonalizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonalizado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.btnPersonalizado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(16)))), ((int)(((byte)(13)))));
            this.btnPersonalizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnPersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalizado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalizado.ForeColor = System.Drawing.Color.White;
            this.btnPersonalizado.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.btnPersonalizado.IconColor = System.Drawing.Color.Yellow;
            this.btnPersonalizado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonalizado.IconSize = 28;
            this.btnPersonalizado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonalizado.Location = new System.Drawing.Point(3, 498);
            this.btnPersonalizado.Name = "btnPersonalizado";
            this.btnPersonalizado.Size = new System.Drawing.Size(164, 60);
            this.btnPersonalizado.TabIndex = 5;
            this.btnPersonalizado.Text = "Personalizado";
            this.btnPersonalizado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPersonalizado.UseVisualStyleBackColor = false;
            this.btnPersonalizado.Visible = false;
            this.btnPersonalizado.Click += new System.EventHandler(this.btnPersonalizado_Click);
            // 
            // btnServico
            // 
            this.btnServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.btnServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.btnServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(16)))), ((int)(((byte)(13)))));
            this.btnServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.ForeColor = System.Drawing.Color.White;
            this.btnServico.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnServico.IconColor = System.Drawing.Color.Yellow;
            this.btnServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServico.IconSize = 28;
            this.btnServico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServico.Location = new System.Drawing.Point(3, 399);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(164, 60);
            this.btnServico.TabIndex = 4;
            this.btnServico.Text = "Serviços";
            this.btnServico.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnServico.UseVisualStyleBackColor = false;
            this.btnServico.Visible = false;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnCapital
            // 
            this.btnCapital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.btnCapital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapital.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.btnCapital.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(16)))), ((int)(((byte)(13)))));
            this.btnCapital.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnCapital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapital.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapital.ForeColor = System.Drawing.Color.White;
            this.btnCapital.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnCapital.IconColor = System.Drawing.Color.Yellow;
            this.btnCapital.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapital.IconSize = 28;
            this.btnCapital.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapital.Location = new System.Drawing.Point(3, 300);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(164, 60);
            this.btnCapital.TabIndex = 3;
            this.btnCapital.Text = "Capital de Giro";
            this.btnCapital.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCapital.UseVisualStyleBackColor = false;
            this.btnCapital.Visible = false;
            this.btnCapital.Click += new System.EventHandler(this.btnCapital_Click);
            // 
            // LplBotoes
            // 
            this.LplBotoes.ColumnCount = 1;
            this.LplBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LplBotoes.Controls.Add(this.btnImovel, 0, 0);
            this.LplBotoes.Controls.Add(this.btnPersonalizado, 0, 5);
            this.LplBotoes.Controls.Add(this.btnServico, 0, 4);
            this.LplBotoes.Controls.Add(this.btnCapital, 0, 3);
            this.LplBotoes.Controls.Add(this.btnAutomovel, 0, 1);
            this.LplBotoes.Controls.Add(this.btnAgro, 0, 2);
            this.LplBotoes.Location = new System.Drawing.Point(-1, 66);
            this.LplBotoes.Name = "LplBotoes";
            this.LplBotoes.RowCount = 6;
            this.LplBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LplBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LplBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LplBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LplBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LplBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LplBotoes.Size = new System.Drawing.Size(200, 596);
            this.LplBotoes.TabIndex = 25;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::TesteSimulador.Properties.Resources.ChatGPT_Image_30_de_jun__de_2026__19_44_45;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(904, 661);
            this.Controls.Add(this.LplBotoes);
            this.Controls.Add(this.pnlSaudacao);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTORIA BENVENUTO - PRINCIPAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlSaudacao.ResumeLayout(false);
            this.pnlSaudacao.PerformLayout();
            this.LplBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrSaudacao;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Timer tmrBotoes;
        private ReaLTaiizor.Controls.MetroPanel pnlSaudacao;
        private FontAwesome.Sharp.IconButton btnImovel;
        private FontAwesome.Sharp.IconButton btnAgro;
        private FontAwesome.Sharp.IconButton btnAutomovel;
        private FontAwesome.Sharp.IconButton btnPersonalizado;
        private FontAwesome.Sharp.IconButton btnServico;
        private FontAwesome.Sharp.IconButton btnCapital;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel LplBotoes;
    }
}

