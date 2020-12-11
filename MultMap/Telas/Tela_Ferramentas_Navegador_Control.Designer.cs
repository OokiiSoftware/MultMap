namespace MultMap.Telas
{
    partial class Tela_Ferramentas_Navegador_Control
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
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.SuspendLayout();
            // 
            // cabecalho1
            // 
            this.cabecalho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.cabecalho1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabecalho1.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.cabecalho1.ForeColor = System.Drawing.Color.White;
            this.cabecalho1.formPai = this;
            this.cabecalho1.Location = new System.Drawing.Point(0, 0);
            this.cabecalho1.Margin = new System.Windows.Forms.Padding(0);
            this.cabecalho1.Maximizar = true;
            this.cabecalho1.Minimizar = true;
            this.cabecalho1.MinimumSize = new System.Drawing.Size(150, 23);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(749, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Navegador";
            // 
            // Tela_Ferramentas_Navegador_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.cabecalho1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Ferramentas_Navegador_Control";
            this.Text = "Tela_Ferramentas_Navegador_Control";
            this.ResumeLayout(false);

        }

        #endregion

        private Exemplos.Cabecalho cabecalho1;
    }
}