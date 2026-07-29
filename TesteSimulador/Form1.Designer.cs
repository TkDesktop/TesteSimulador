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
            this.pnlSaudacao = new System.Windows.Forms.Panel();
            this.tmrSaudacao = new System.Windows.Forms.Timer(this.components);
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.pnlSaudacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSaudacao
            // 
            this.pnlSaudacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.pnlSaudacao.Controls.Add(this.lblSaudacao);
            this.pnlSaudacao.Location = new System.Drawing.Point(0, -3);
            this.pnlSaudacao.Name = "pnlSaudacao";
            this.pnlSaudacao.Size = new System.Drawing.Size(905, 60);
            this.pnlSaudacao.TabIndex = 0;
            // 
            // tmrSaudacao
            // 
            this.tmrSaudacao.Interval = 120;
            this.tmrSaudacao.Tick += new System.EventHandler(this.tmrSaudacao_Tick);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(904, 661);
            this.Controls.Add(this.pnlSaudacao);
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
    }
}

