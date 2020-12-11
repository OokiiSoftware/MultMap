namespace MultMap.Telas.Ferramentas
{
    partial class CustonTextBox2
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
            this.Btn_Right = new System.Windows.Forms.Button();
            this.Btn_Left = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Right
            // 
            this.Btn_Right.BackColor = System.Drawing.Color.Red;
            this.Btn_Right.BackgroundImage = global::MultMap.Properties.Resources.ic_branco_delete;
            this.Btn_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Right.FlatAppearance.BorderSize = 0;
            this.Btn_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Right.Location = new System.Drawing.Point(223, 0);
            this.Btn_Right.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Right.Name = "Btn_Right";
            this.Btn_Right.Size = new System.Drawing.Size(27, 23);
            this.Btn_Right.TabIndex = 0;
            this.Btn_Right.UseVisualStyleBackColor = false;
            this.Btn_Right.Visible = false;
            this.Btn_Right.Click += new System.EventHandler(this.Botao_Click);
            // 
            // Btn_Left
            // 
            this.Btn_Left.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Left.FlatAppearance.BorderSize = 0;
            this.Btn_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Left.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.Btn_Left.Location = new System.Drawing.Point(0, 0);
            this.Btn_Left.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Left.Name = "Btn_Left";
            this.Btn_Left.Size = new System.Drawing.Size(29, 23);
            this.Btn_Left.TabIndex = 0;
            this.Btn_Left.Text = "0";
            this.Btn_Left.UseVisualStyleBackColor = false;
            this.Btn_Left.Click += new System.EventHandler(this.Botao_Click);
            // 
            // Box
            // 
            this.Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Bold);
            this.Box.Location = new System.Drawing.Point(29, 0);
            this.Box.Margin = new System.Windows.Forms.Padding(0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(194, 23);
            this.Box.TabIndex = 0;
            this.Box.TextChanged += new System.EventHandler(this.CustonTextBox_TextChanged);
            // 
            // CustonTextBox2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Btn_Left);
            this.Controls.Add(this.Btn_Right);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CustonTextBox2";
            this.Size = new System.Drawing.Size(250, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Btn_Right;
        public System.Windows.Forms.Button Btn_Left;
        public System.Windows.Forms.TextBox Box;
    }
}
