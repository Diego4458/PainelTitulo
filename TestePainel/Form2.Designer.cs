namespace TestePainel
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mandar = new System.Windows.Forms.Button();
            this.Tilt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(21, 95);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(248, 20);
            this.login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // Mandar
            // 
            this.Mandar.Location = new System.Drawing.Point(21, 138);
            this.Mandar.Name = "Mandar";
            this.Mandar.Size = new System.Drawing.Size(248, 63);
            this.Mandar.TabIndex = 4;
            this.Mandar.Text = "Mandar Titulo";
            this.Mandar.UseVisualStyleBackColor = true;
            this.Mandar.Click += new System.EventHandler(this.Mandar_Click);
            // 
            // Tilt
            // 
            this.Tilt.FormattingEnabled = true;
            this.Tilt.Location = new System.Drawing.Point(21, 42);
            this.Tilt.Name = "Tilt";
            this.Tilt.Size = new System.Drawing.Size(248, 21);
            this.Tilt.TabIndex = 5;
            this.Tilt.SelectedIndexChanged += new System.EventHandler(this.Tilt_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(281, 213);
            this.Controls.Add(this.Tilt);
            this.Controls.Add(this.Mandar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mandar;
        private System.Windows.Forms.ComboBox Tilt;
    }
}