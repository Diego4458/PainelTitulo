namespace TestePainel
{
    partial class painel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(painel));
            this.Titulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Missoes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.SystemColors.Menu;
            this.Titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.ForeColor = System.Drawing.SystemColors.Menu;
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.Location = new System.Drawing.Point(25, 12);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(60, 60);
            this.Titulo.TabIndex = 0;
            this.Titulo.UseVisualStyleBackColor = false;
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // Missoes
            // 
            this.Missoes.BackColor = System.Drawing.SystemColors.Menu;
            this.Missoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Missoes.ForeColor = System.Drawing.SystemColors.Menu;
            this.Missoes.Image = ((System.Drawing.Image)(resources.GetObject("Missoes.Image")));
            this.Missoes.Location = new System.Drawing.Point(25, 102);
            this.Missoes.Name = "Missoes";
            this.Missoes.Size = new System.Drawing.Size(60, 59);
            this.Missoes.TabIndex = 2;
            this.Missoes.UseVisualStyleBackColor = false;
            this.Missoes.Click += new System.EventHandler(this.Missoes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Limpar Caixas";
            // 
            // painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(120, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Missoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.painel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Missoes;
        private System.Windows.Forms.Label label2;
    }
}

