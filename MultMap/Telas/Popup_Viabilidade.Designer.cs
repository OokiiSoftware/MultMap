namespace MultMap.Telas
{
    partial class Popup_Viabilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup_Viabilidade));
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.flow_Clientes = new System.Windows.Forms.FlowLayoutPanel();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Salvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.btn_Salvar.Location = new System.Drawing.Point(337, 370);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(106, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Visible = false;
            this.btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // flow_Clientes
            // 
            this.flow_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow_Clientes.AutoScroll = true;
            this.flow_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.flow_Clientes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_Clientes.Location = new System.Drawing.Point(0, 23);
            this.flow_Clientes.Margin = new System.Windows.Forms.Padding(0);
            this.flow_Clientes.Name = "flow_Clientes";
            this.flow_Clientes.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.flow_Clientes.Size = new System.Drawing.Size(462, 342);
            this.flow_Clientes.TabIndex = 0;
            this.flow_Clientes.WrapContents = false;
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
            this.cabecalho1.Size = new System.Drawing.Size(450, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Clientes";
            // 
            // Popup_Viabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.cabecalho1);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.flow_Clientes);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup_Viabilidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.FlowLayoutPanel flow_Clientes;
        private Telas.Exemplos.Cabecalho cabecalho1;
    }
}