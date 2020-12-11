namespace MultMap.Telas.Ferramentas
{
    partial class CustonTextBox
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
            this._Hint = new System.Windows.Forms.Label();
            this.Botao = new System.Windows.Forms.Button();
            this.Btn_Left = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _Hint
            // 
            this._Hint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Hint.AutoEllipsis = true;
            this._Hint.BackColor = System.Drawing.Color.Transparent;
            this._Hint.Enabled = false;
            this._Hint.ForeColor = System.Drawing.Color.Silver;
            this._Hint.Location = new System.Drawing.Point(2, 0);
            this._Hint.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this._Hint.Name = "_Hint";
            this._Hint.Size = new System.Drawing.Size(248, 27);
            this._Hint.TabIndex = 0;
            this._Hint.Text = "Custon Hint";
            this._Hint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Botao
            // 
            this.Botao.BackColor = System.Drawing.Color.Red;
            this.Botao.BackgroundImage = global::MultMap.Properties.Resources.ic_branco_delete;
            this.Botao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Botao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao.Dock = System.Windows.Forms.DockStyle.Right;
            this.Botao.FlatAppearance.BorderSize = 0;
            this.Botao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao.Location = new System.Drawing.Point(219, 0);
            this.Botao.Margin = new System.Windows.Forms.Padding(0);
            this.Botao.Name = "Botao";
            this.Botao.Size = new System.Drawing.Size(27, 23);
            this.Botao.TabIndex = 0;
            this.Botao.UseVisualStyleBackColor = false;
            this.Botao.Visible = false;
            this.Botao.Click += new System.EventHandler(this.Botao_Click);
            // 
            // Btn_Left
            // 
            this.Btn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Left.FlatAppearance.BorderSize = 0;
            this.Btn_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Left.Location = new System.Drawing.Point(0, 0);
            this.Btn_Left.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Left.Name = "Btn_Left";
            this.Btn_Left.Size = new System.Drawing.Size(35, 35);
            this.Btn_Left.TabIndex = 0;
            this.Btn_Left.Text = "0";
            this.Btn_Left.UseVisualStyleBackColor = true;
            // 
            // CustonTextBox
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Botao);
            this.Controls.Add(this._Hint);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(250, 27);
            this.TextChanged += new System.EventHandler(this.CustonTextBox_TextChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _Hint;
        public System.Windows.Forms.Button Botao;
        private System.Windows.Forms.Button Btn_Left;
    }
}
