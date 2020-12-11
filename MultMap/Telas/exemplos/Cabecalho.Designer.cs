namespace MultMap.Telas.Exemplos
{
    partial class Cabecalho
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
            this._Minimizar = new System.Windows.Forms.Button();
            this._Maximizar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this._Titulo = new MultMap.Telas.Ferramentas.CustomLabel();
            this.Flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Minimizar
            // 
            this._Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Minimizar.BackgroundImage = global::MultMap.Properties.Resources.appbar_minus_light;
            this._Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._Minimizar.FlatAppearance.BorderSize = 0;
            this._Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Minimizar.Location = new System.Drawing.Point(0, 0);
            this._Minimizar.Margin = new System.Windows.Forms.Padding(0);
            this._Minimizar.Name = "_Minimizar";
            this._Minimizar.Size = new System.Drawing.Size(23, 23);
            this._Minimizar.TabIndex = 1;
            this._Minimizar.UseVisualStyleBackColor = true;
            this._Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // _Maximizar
            // 
            this._Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Maximizar.BackgroundImage = global::MultMap.Properties.Resources.appbar_window_restore_light;
            this._Maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._Maximizar.FlatAppearance.BorderSize = 0;
            this._Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Maximizar.Location = new System.Drawing.Point(23, 0);
            this._Maximizar.Margin = new System.Windows.Forms.Padding(0);
            this._Maximizar.Name = "_Maximizar";
            this._Maximizar.Size = new System.Drawing.Size(23, 23);
            this._Maximizar.TabIndex = 2;
            this._Maximizar.UseVisualStyleBackColor = true;
            this._Maximizar.Click += new System.EventHandler(this._Maximizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.BackgroundImage = global::MultMap.Properties.Resources.appbar_close_light;
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Location = new System.Drawing.Point(46, 0);
            this.Fechar.Margin = new System.Windows.Forms.Padding(0);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(23, 23);
            this.Fechar.TabIndex = 3;
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Flow
            // 
            this.Flow.Controls.Add(this._Minimizar);
            this.Flow.Controls.Add(this._Maximizar);
            this.Flow.Controls.Add(this.Fechar);
            this.Flow.Dock = System.Windows.Forms.DockStyle.Right;
            this.Flow.Location = new System.Drawing.Point(328, 0);
            this.Flow.Margin = new System.Windows.Forms.Padding(0);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(70, 23);
            this.Flow.TabIndex = 0;
            // 
            // _Titulo
            // 
            this._Titulo.AutoEllipsis = true;
            this._Titulo.AutoSize = true;
            this._Titulo.BackColor = System.Drawing.Color.Transparent;
            this._Titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this._Titulo.Enabled = false;
            this._Titulo.Location = new System.Drawing.Point(0, 0);
            this._Titulo.Margin = new System.Windows.Forms.Padding(0);
            this._Titulo.Name = "_Titulo";
            this._Titulo.Padding = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this._Titulo.Radio = 0;
            this._Titulo.Size = new System.Drawing.Size(49, 22);
            this._Titulo.TabIndex = 0;
            this._Titulo.Text = "Titulo";
            // 
            // Cabecalho
            // 
            this.Controls.Add(this.Flow);
            this.Controls.Add(this._Titulo);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(150, 23);
            this.Size = new System.Drawing.Size(398, 23);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Cabecalho_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cabecalho_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cabecalho_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cabecalho_MouseUp);
            this.Flow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button _Maximizar;
        private System.Windows.Forms.Button _Minimizar;
        private Ferramentas.CustomLabel _Titulo;
        private System.Windows.Forms.FlowLayoutPanel Flow;
    }
}
