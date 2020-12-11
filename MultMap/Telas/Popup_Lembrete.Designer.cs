namespace MultMap.Telas
{
    partial class Popup_Lembrete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup_Lembrete));
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.Label();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.txt_Log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Texto
            // 
            this.txt_Texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Texto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Texto.Location = new System.Drawing.Point(14, 49);
            this.txt_Texto.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.txt_Texto.Multiline = true;
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Texto.Size = new System.Drawing.Size(245, 208);
            this.txt_Texto.TabIndex = 1;
            this.txt_Texto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Titulo.Font = new System.Drawing.Font("Bahnschrift Light", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.Location = new System.Drawing.Point(0, 23);
            this.txt_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(259, 26);
            this.txt_Titulo.TabIndex = 0;
            this.txt_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
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
            this.cabecalho1.Maximizar = false;
            this.cabecalho1.Minimizar = false;
            this.cabecalho1.MinimumSize = new System.Drawing.Size(0, 23);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(259, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Lembrete";
            // 
            // txt_Log
            // 
            this.txt_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(99)))));
            this.txt_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Log.Enabled = false;
            this.txt_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.Location = new System.Drawing.Point(0, 49);
            this.txt_Log.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(259, 222);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "Salvando";
            this.txt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Log.Visible = false;
            this.txt_Log.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Popup_Lembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 271);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.cabecalho1);
            this.Controls.Add(this.txt_Texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup_Lembrete";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Lembrete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Popup_Lembrete_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Label txt_Titulo;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private System.Windows.Forms.Label txt_Log;
    }
}