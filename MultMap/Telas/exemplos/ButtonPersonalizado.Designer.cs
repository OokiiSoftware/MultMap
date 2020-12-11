namespace MultMap.Telas.Exemplos
{
    partial class ButtonPersonalizado
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Icone_L = new System.Windows.Forms.Panel();
            this.Icone_R = new System.Windows.Forms.Panel();
            this.Texto = new MultMap.Telas.Ferramentas.CustomLabel();
            this.SuspendLayout();
            // 
            // Icone_L
            // 
            this.Icone_L.BackColor = System.Drawing.Color.Transparent;
            this.Icone_L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Icone_L.Dock = System.Windows.Forms.DockStyle.Left;
            this.Icone_L.Enabled = false;
            this.Icone_L.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icone_L.Location = new System.Drawing.Point(0, 0);
            this.Icone_L.Name = "Icone_L";
            this.Icone_L.Size = new System.Drawing.Size(35, 35);
            this.Icone_L.TabIndex = 0;
            // 
            // Icone_R
            // 
            this.Icone_R.BackColor = System.Drawing.Color.Transparent;
            this.Icone_R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Icone_R.Dock = System.Windows.Forms.DockStyle.Right;
            this.Icone_R.Enabled = false;
            this.Icone_R.Location = new System.Drawing.Point(140, 0);
            this.Icone_R.Margin = new System.Windows.Forms.Padding(0);
            this.Icone_R.Name = "Icone_R";
            this.Icone_R.Size = new System.Drawing.Size(35, 35);
            this.Icone_R.TabIndex = 0;
            // 
            // Texto
            // 
            this.Texto.AutoEllipsis = true;
            this.Texto.BackColor = System.Drawing.Color.Transparent;
            this.Texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texto.Enabled = false;
            this.Texto.ForeColor = System.Drawing.Color.White;
            this.Texto.Location = new System.Drawing.Point(35, 0);
            this.Texto.Margin = new System.Windows.Forms.Padding(0);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(105, 35);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "Botão";
            this.Texto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonPersonalizado
            // 
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Icone_R);
            this.Controls.Add(this.Icone_L);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(175, 35);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Icone_L;
        private System.Windows.Forms.Panel Icone_R;
        private Ferramentas.CustomLabel Texto;
    }
}
