namespace MultMap.Telas
{
    partial class Tela_Login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.Painel_Azul = new System.Windows.Forms.Panel();
            this.Btn_Sobre = new System.Windows.Forms.Button();
            this.Lbl_Versao = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_senha = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.tb_usuario = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Img_Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_UID = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.Bar_UID = new System.Windows.Forms.ProgressBar();
            this.Painel_Azul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel_Azul
            // 
            this.Painel_Azul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Painel_Azul.Controls.Add(this.Btn_Sobre);
            this.Painel_Azul.Controls.Add(this.Lbl_Versao);
            this.Painel_Azul.Controls.Add(this.progressBar);
            this.Painel_Azul.Controls.Add(this.pictureBox3);
            this.Painel_Azul.Controls.Add(this.pictureBox2);
            this.Painel_Azul.Controls.Add(this.txt_Log);
            this.Painel_Azul.Controls.Add(this.label1);
            this.Painel_Azul.Controls.Add(this.tb_senha);
            this.Painel_Azul.Controls.Add(this.progressBar4);
            this.Painel_Azul.Controls.Add(this.tb_usuario);
            this.Painel_Azul.Controls.Add(this.progressBar3);
            this.Painel_Azul.Controls.Add(this.btn_confirmar);
            this.Painel_Azul.Controls.Add(this.btn_Minimizar);
            this.Painel_Azul.Controls.Add(this.btn_Close);
            this.Painel_Azul.Dock = System.Windows.Forms.DockStyle.Right;
            this.Painel_Azul.Location = new System.Drawing.Point(190, 0);
            this.Painel_Azul.Margin = new System.Windows.Forms.Padding(0);
            this.Painel_Azul.Name = "Painel_Azul";
            this.Painel_Azul.Size = new System.Drawing.Size(450, 300);
            this.Painel_Azul.TabIndex = 1;
            // 
            // Btn_Sobre
            // 
            this.Btn_Sobre.BackgroundImage = global::MultMap.Properties.Resources.ic_branco_sobre;
            this.Btn_Sobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sobre.FlatAppearance.BorderSize = 0;
            this.Btn_Sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sobre.Location = new System.Drawing.Point(424, 274);
            this.Btn_Sobre.Name = "Btn_Sobre";
            this.Btn_Sobre.Size = new System.Drawing.Size(20, 20);
            this.Btn_Sobre.TabIndex = 6;
            this.Btn_Sobre.UseVisualStyleBackColor = true;
            this.Btn_Sobre.Click += new System.EventHandler(this.Btn_Sobre_Click);
            // 
            // Lbl_Versao
            // 
            this.Lbl_Versao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Versao.AutoSize = true;
            this.Lbl_Versao.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Versao.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Lbl_Versao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_Versao.Location = new System.Drawing.Point(379, 278);
            this.Lbl_Versao.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Versao.Name = "Lbl_Versao";
            this.Lbl_Versao.Size = new System.Drawing.Size(41, 16);
            this.Lbl_Versao.TabIndex = 0;
            this.Lbl_Versao.Text = "0.0.0.0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(89, 225);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(278, 36);
            this.progressBar.TabIndex = 0;
            this.progressBar.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MultMap.Properties.Resources.icone_senha_cinza;
            this.pictureBox3.Location = new System.Drawing.Point(80, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MultMap.Properties.Resources.icone_login_cinza;
            this.pictureBox2.Location = new System.Drawing.Point(80, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Log
            // 
            this.txt_Log.AutoEllipsis = true;
            this.txt_Log.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_Log.ForeColor = System.Drawing.Color.Lime;
            this.txt_Log.Location = new System.Drawing.Point(27, 194);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(411, 22);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "Log";
            this.txt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Log.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // tb_senha
            // 
            this.tb_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_senha.ButtonColor = System.Drawing.Color.Empty;
            this.tb_senha.ButtonIcon = null;
            this.tb_senha.ButtonVisivel = false;
            this.tb_senha.ButtonWidth = 27;
            this.tb_senha.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.tb_senha.ForeColor = System.Drawing.Color.White;
            this.tb_senha.Hint = "Senha";
            this.tb_senha.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_senha.Location = new System.Drawing.Point(118, 152);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(0);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(260, 27);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.UseSystemPasswordChar = true;
            this.tb_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_senha_KeyPress);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(80, 184);
            this.progressBar4.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(300, 1);
            this.progressBar4.TabIndex = 0;
            // 
            // tb_usuario
            // 
            this.tb_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_usuario.ButtonColor = System.Drawing.Color.Empty;
            this.tb_usuario.ButtonIcon = null;
            this.tb_usuario.ButtonVisivel = false;
            this.tb_usuario.ButtonWidth = 27;
            this.tb_usuario.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.tb_usuario.ForeColor = System.Drawing.Color.White;
            this.tb_usuario.Hint = "Usuário";
            this.tb_usuario.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_usuario.Location = new System.Drawing.Point(118, 92);
            this.tb_usuario.Margin = new System.Windows.Forms.Padding(0);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(260, 27);
            this.tb_usuario.TabIndex = 1;
            this.tb_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_usuario_KeyPress);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(80, 125);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(300, 1);
            this.progressBar3.TabIndex = 0;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.ForeColor = System.Drawing.Color.Silver;
            this.btn_confirmar.Location = new System.Drawing.Point(89, 225);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(278, 36);
            this.btn_confirmar.TabIndex = 3;
            this.btn_confirmar.Text = "Acessar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackgroundImage = global::MultMap.Properties.Resources.img_bnt_mini;
            this.btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Location = new System.Drawing.Point(385, 2);
            this.btn_Minimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimizar.TabIndex = 4;
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::MultMap.Properties.Resources.img_bnt_fechar;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(415, 2);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Img_Logo
            // 
            this.Img_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Logo.Image = global::MultMap.Properties.Resources.logo_MapNap;
            this.Img_Logo.Location = new System.Drawing.Point(25, 79);
            this.Img_Logo.Name = "Img_Logo";
            this.Img_Logo.Size = new System.Drawing.Size(125, 125);
            this.Img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Logo.TabIndex = 6;
            this.Img_Logo.TabStop = false;
            this.Img_Logo.Click += new System.EventHandler(this.Img_Logo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(30, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MultMap";
            // 
            // Tb_UID
            // 
            this.Tb_UID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Tb_UID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_UID.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_UID.ButtonIcon = null;
            this.Tb_UID.ButtonVisivel = false;
            this.Tb_UID.ButtonWidth = 27;
            this.Tb_UID.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.Tb_UID.ForeColor = System.Drawing.Color.White;
            this.Tb_UID.Hint = "UID";
            this.Tb_UID.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_UID.Location = new System.Drawing.Point(25, 252);
            this.Tb_UID.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_UID.Name = "Tb_UID";
            this.Tb_UID.Size = new System.Drawing.Size(125, 27);
            this.Tb_UID.TabIndex = 7;
            this.Tb_UID.UseSystemPasswordChar = true;
            this.Tb_UID.Visible = false;
            // 
            // Bar_UID
            // 
            this.Bar_UID.Location = new System.Drawing.Point(25, 281);
            this.Bar_UID.Margin = new System.Windows.Forms.Padding(0);
            this.Bar_UID.Name = "Bar_UID";
            this.Bar_UID.Size = new System.Drawing.Size(125, 1);
            this.Bar_UID.TabIndex = 0;
            this.Bar_UID.Visible = false;
            // 
            // Tela_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(640, 300);
            this.Controls.Add(this.Bar_UID);
            this.Controls.Add(this.Tb_UID);
            this.Controls.Add(this.Img_Logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Painel_Azul);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultMap - Login";
            this.Painel_Azul.ResumeLayout(false);
            this.Painel_Azul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Painel_Azul;
        private Telas.Ferramentas.CustonTextBox tb_usuario;
        private System.Windows.Forms.ProgressBar progressBar3;
        private Telas.Ferramentas.CustonTextBox tb_senha;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label txt_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Img_Logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Versao;
        private Ferramentas.CustonTextBox Tb_UID;
        private System.Windows.Forms.ProgressBar Bar_UID;
        private System.Windows.Forms.Button Btn_Sobre;
    }
}

