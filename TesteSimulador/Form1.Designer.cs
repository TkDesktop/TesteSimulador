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
            this.pnlSaudacao = new System.Windows.Forms.Panel();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.tmrSaudacao = new System.Windows.Forms.Timer(this.components);
            this.tmrBotoes = new System.Windows.Forms.Timer(this.components);
            this.btnImovel = new System.Windows.Forms.Button();
            this.btnAutomovel = new System.Windows.Forms.Button();
            this.btnCapital = new System.Windows.Forms.Button();
            this.pnlSaudacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSaudacao
            // 
            this.pnlSaudacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSaudacao.Controls.Add(this.lblSaudacao);
            this.pnlSaudacao.Location = new System.Drawing.Point(0, -3);
            this.pnlSaudacao.Name = "pnlSaudacao";
            this.pnlSaudacao.Size = new System.Drawing.Size(905, 60);
            this.pnlSaudacao.TabIndex = 0;
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.BackColor = System.Drawing.Color.Transparent;
            this.lblSaudacao.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.ForeColor = System.Drawing.Color.Gold;
            this.lblSaudacao.Location = new System.Drawing.Point(24, 21);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(70, 22);
            this.lblSaudacao.TabIndex = 0;
            this.lblSaudacao.Text = "label1";
            // 
            // tmrSaudacao
            // 
            this.tmrSaudacao.Interval = 120;
            this.tmrSaudacao.Tick += new System.EventHandler(this.tmrSaudacao_Tick);
            // 
            // tmrBotoes
            // 
            this.tmrBotoes.Interval = 500;
            this.tmrBotoes.Tick += new System.EventHandler(this.tmrBotoes_Tick);
            // 
            // btnImovel
            // 
            this.btnImovel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImovel.Location = new System.Drawing.Point(12, 77);
            this.btnImovel.Name = "btnImovel";
            this.btnImovel.Size = new System.Drawing.Size(114, 61);
            this.btnImovel.TabIndex = 1;
            this.btnImovel.Text = "IMOVEL";
            this.btnImovel.UseVisualStyleBackColor = true;
            this.btnImovel.Visible = false;
            // 
            // btnAutomovel
            // 
            this.btnAutomovel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutomovel.Location = new System.Drawing.Point(12, 159);
            this.btnAutomovel.Name = "btnAutomovel";
            this.btnAutomovel.Size = new System.Drawing.Size(114, 61);
            this.btnAutomovel.TabIndex = 2;
            this.btnAutomovel.Text = "AUTOMOVEL";
            this.btnAutomovel.UseVisualStyleBackColor = true;
            this.btnAutomovel.Visible = false;
            // 
            // btnCapital
            // 
            this.btnCapital.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapital.Location = new System.Drawing.Point(12, 239);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(114, 61);
            this.btnCapital.TabIndex = 3;
            this.btnCapital.Text = "CAPITAL DE GIRO";
            this.btnCapital.UseVisualStyleBackColor = true;
            this.btnCapital.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::TesteSimulador.Properties.Resources.ChatGPT_Image_30_de_jun__de_2026__19_44_45;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(904, 661);
            this.Controls.Add(this.btnCapital);
            this.Controls.Add(this.btnAutomovel);
            this.Controls.Add(this.btnImovel);
            this.Controls.Add(this.pnlSaudacao);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Teste";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlSaudacao.ResumeLayout(false);
            this.pnlSaudacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSaudacao;
        private System.Windows.Forms.Timer tmrSaudacao;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Timer tmrBotoes;
        private System.Windows.Forms.Button btnImovel;
        private System.Windows.Forms.Button btnAutomovel;
        private System.Windows.Forms.Button btnCapital;
    }
}

