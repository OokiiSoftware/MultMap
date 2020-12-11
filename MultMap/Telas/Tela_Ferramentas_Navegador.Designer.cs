namespace MultMap.Telas
{
    partial class Tela_Ferramentas_Navegador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Ferramentas_Navegador));
            this.Painel_Navegador = new System.Windows.Forms.Panel();
            this.Browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_prox = new System.Windows.Forms.Button();
            this.btn_ant = new System.Windows.Forms.Button();
            this.Painel_Superior = new System.Windows.Forms.Panel();
            this.Tb_pesquisa = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.Tb_url = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.Painel_Navegador.SuspendLayout();
            this.Painel_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Navegador
            // 
            this.Painel_Navegador.Controls.Add(this.Browser);
            this.Painel_Navegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Navegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Painel_Navegador.Location = new System.Drawing.Point(0, 53);
            this.Painel_Navegador.Margin = new System.Windows.Forms.Padding(0);
            this.Painel_Navegador.Name = "Painel_Navegador";
            this.Painel_Navegador.Size = new System.Drawing.Size(788, 425);
            this.Painel_Navegador.TabIndex = 0;
            this.Painel_Navegador.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Browser
            // 
            this.Browser.ActivateBrowserOnCreation = false;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(788, 425);
            this.Browser.TabIndex = 0;
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iconList.ImageSize = new System.Drawing.Size(16, 16);
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_atualizar_2;
            this.btn_atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Location = new System.Drawing.Point(55, 5);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(20, 20);
            this.btn_atualizar.TabIndex = 3;
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            this.btn_atualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_ir
            // 
            this.btn_ir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ir.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_pesquisar;
            this.btn_ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_ir.FlatAppearance.BorderSize = 0;
            this.btn_ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ir.Location = new System.Drawing.Point(587, 5);
            this.btn_ir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(20, 20);
            this.btn_ir.TabIndex = 6;
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.Btn_ir_Click);
            this.btn_ir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_inicio;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(80, 5);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(0);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(20, 20);
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            this.btn_inicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_prox
            // 
            this.btn_prox.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_seta_prox;
            this.btn_prox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_prox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_prox.FlatAppearance.BorderSize = 0;
            this.btn_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prox.Location = new System.Drawing.Point(30, 5);
            this.btn_prox.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(20, 20);
            this.btn_prox.TabIndex = 2;
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.Btn_prox_Click);
            this.btn_prox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_ant
            // 
            this.btn_ant.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_seta_ant;
            this.btn_ant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_ant.FlatAppearance.BorderSize = 0;
            this.btn_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ant.Location = new System.Drawing.Point(5, 5);
            this.btn_ant.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(20, 20);
            this.btn_ant.TabIndex = 1;
            this.btn_ant.UseVisualStyleBackColor = true;
            this.btn_ant.Click += new System.EventHandler(this.Btn_ant_Click);
            this.btn_ant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Painel_Superior
            // 
            this.Painel_Superior.BackColor = System.Drawing.Color.Gainsboro;
            this.Painel_Superior.Controls.Add(this.Tb_pesquisa);
            this.Painel_Superior.Controls.Add(this.Tb_url);
            this.Painel_Superior.Controls.Add(this.btn_inicio);
            this.Painel_Superior.Controls.Add(this.btn_atualizar);
            this.Painel_Superior.Controls.Add(this.btn_ant);
            this.Painel_Superior.Controls.Add(this.btn_prox);
            this.Painel_Superior.Controls.Add(this.btn_ir);
            this.Painel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Painel_Superior.Location = new System.Drawing.Point(0, 23);
            this.Painel_Superior.Margin = new System.Windows.Forms.Padding(0);
            this.Painel_Superior.Name = "Painel_Superior";
            this.Painel_Superior.Size = new System.Drawing.Size(788, 30);
            this.Painel_Superior.TabIndex = 1;
            this.Painel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Tb_ip
            // 
            this.Tb_pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_pesquisa.BackColor = System.Drawing.Color.White;
            this.Tb_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_pesquisa.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_pesquisa.ButtonIcon = null;
            this.Tb_pesquisa.ButtonVisivel = false;
            this.Tb_pesquisa.ButtonWidth = 27;
            this.Tb_pesquisa.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_pesquisa.Hint = "";
            this.Tb_pesquisa.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_pesquisa.Location = new System.Drawing.Point(615, 5);
            this.Tb_pesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_pesquisa.Name = "Tb_ip";
            this.Tb_pesquisa.Size = new System.Drawing.Size(164, 20);
            this.Tb_pesquisa.TabIndex = 7;
            this.Tb_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_pesquisa_KeyPress);
            this.Tb_pesquisa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Tb_url
            // 
            this.Tb_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_url.BackColor = System.Drawing.Color.White;
            this.Tb_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_url.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_url.ButtonIcon = null;
            this.Tb_url.ButtonVisivel = false;
            this.Tb_url.ButtonWidth = 27;
            this.Tb_url.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_url.Hint = null;
            this.Tb_url.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_url.Location = new System.Drawing.Point(113, 5);
            this.Tb_url.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_url.Name = "Tb_url";
            this.Tb_url.Size = new System.Drawing.Size(472, 20);
            this.Tb_url.TabIndex = 5;
            this.Tb_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_url_KeyPress);
            this.Tb_url.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
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
            this.cabecalho1.MinimumSize = new System.Drawing.Size(0, 23);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(788, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Navegador";
            // 
            // Tela_Ferramentas_Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 478);
            this.Controls.Add(this.Painel_Navegador);
            this.Controls.Add(this.Painel_Superior);
            this.Controls.Add(this.cabecalho1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Tela_Ferramentas_Navegador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Navegador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tela_Ferramentas_Navegador_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.Painel_Navegador.ResumeLayout(false);
            this.Painel_Superior.ResumeLayout(false);
            this.Painel_Superior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Navegador;
        private System.Windows.Forms.Button btn_ant;
        private System.Windows.Forms.Button btn_prox;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Panel Painel_Superior;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private Telas.Ferramentas.CustonTextBox Tb_pesquisa;
        private Telas.Ferramentas.CustonTextBox Tb_url;
        private CefSharp.WinForms.ChromiumWebBrowser Browser;
        private System.Windows.Forms.ImageList iconList;
    }
}