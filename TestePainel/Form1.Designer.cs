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
            this.label3 = new System.Windows.Forms.Label();
            this.Sociedade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Contas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jogadores = new System.Windows.Forms.Label();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Missões";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sociedades Criadas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sociedade
            // 
            this.Sociedade.AutoSize = true;
            this.Sociedade.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sociedade.Location = new System.Drawing.Point(329, 9);
            this.Sociedade.Name = "Sociedade";
            this.Sociedade.Size = new System.Drawing.Size(35, 39);
            this.Sociedade.TabIndex = 5;
            this.Sociedade.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contas Criadas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contas
            // 
            this.Contas.AutoSize = true;
            this.Contas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contas.Location = new System.Drawing.Point(329, 75);
            this.Contas.Name = "Contas";
            this.Contas.Size = new System.Drawing.Size(35, 39);
            this.Contas.TabIndex = 7;
            this.Contas.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jogadores Online:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jogadores
            // 
            this.jogadores.AutoSize = true;
            this.jogadores.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogadores.Location = new System.Drawing.Point(329, 143);
            this.jogadores.Name = "jogadores";
            this.jogadores.Size = new System.Drawing.Size(35, 39);
            this.jogadores.TabIndex = 9;
            this.jogadores.Text = "3";
            // 
            // painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(373, 189);
            this.Controls.Add(this.jogadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Contas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sociedade);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Sociedade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Contas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label jogadores;
    }
}

