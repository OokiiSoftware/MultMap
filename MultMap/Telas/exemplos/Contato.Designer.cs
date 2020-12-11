namespace MultMap.Telas.Exemplos
{
    partial class Contato
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
            this.Foto = new MultMap.Telas.Ferramentas.ImageRadius();
            this.Nome = new MultMap.Telas.Ferramentas.CustomLabel();
            this.Mensagem = new MultMap.Telas.Ferramentas.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.Color.Transparent;
            this.Foto.Enabled = false;
            this.Foto.Image = global::MultMap.Properties.Resources.ic_branco_user;
            this.Foto.Location = new System.Drawing.Point(0, 0);
            this.Foto.Margin = new System.Windows.Forms.Padding(0);
            this.Foto.Name = "Foto";
            this.Foto.Radio = 100;
            this.Foto.Size = new System.Drawing.Size(35, 35);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 5;
            this.Foto.TabStop = false;
            // 
            // Nome
            // 
            this.Nome.AutoEllipsis = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Enabled = false;
            this.Nome.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.Nome.ForeColor = System.Drawing.Color.White;
            this.Nome.Location = new System.Drawing.Point(41, 0);
            this.Nome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Nome.Name = "Nome";
            this.Nome.Radio = 0;
            this.Nome.Size = new System.Drawing.Size(119, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome do Funcionário";
            // 
            // Mensagem
            // 
            this.Mensagem.AutoEllipsis = true;
            this.Mensagem.BackColor = System.Drawing.Color.Transparent;
            this.Mensagem.Enabled = false;
            this.Mensagem.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.Mensagem.ForeColor = System.Drawing.Color.White;
            this.Mensagem.Location = new System.Drawing.Point(40, 19);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Radio = 0;
            this.Mensagem.Size = new System.Drawing.Size(119, 13);
            this.Mensagem.TabIndex = 0;
            this.Mensagem.Text = "Ultima mensagem";
            this.Mensagem.Visible = false;
            // 
            // Contato
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Mensagem);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Foto);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.Name = "Contato";
            this.Size = new System.Drawing.Size(160, 35);
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Telas.Ferramentas.ImageRadius Foto;
        public Telas.Ferramentas.CustomLabel Nome;
        public Telas.Ferramentas.CustomLabel Mensagem;
    }
}
