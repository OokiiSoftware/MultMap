namespace MultMap.Telas
{
    partial class Tela_Ferramentas_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Ferramentas_Chat));
            this.panel_Conversa = new System.Windows.Forms.Panel();
            this.time_Verificar_Conversas = new System.Windows.Forms.Timer(this.components);
            this.btn_Enviar_ = new System.Windows.Forms.PictureBox();
            this.Txt_Log = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nome_Conversa = new System.Windows.Forms.Label();
            this.fl_Contatos = new System.Windows.Forms.FlowLayoutPanel();
            this.contato1 = new MultMap.Telas.Exemplos.Contato();
            this.tb_mensagem = new MetroFramework.Controls.MetroTextBox();
            this.Cb_Enviar_Msg_Enter = new MultMap.Telas.Ferramentas.CustomCheckBox();
            this.Img_Foto_Conversa = new MultMap.Telas.Ferramentas.ImageRadius();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Enviar_)).BeginInit();
            this.fl_Contatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Foto_Conversa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Conversa
            // 
            this.panel_Conversa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Conversa.Location = new System.Drawing.Point(171, 77);
            this.panel_Conversa.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Conversa.Name = "panel_Conversa";
            this.panel_Conversa.Size = new System.Drawing.Size(708, 349);
            this.panel_Conversa.TabIndex = 0;
            // 
            // time_Verificar_Conversas
            // 
            this.time_Verificar_Conversas.Enabled = true;
            this.time_Verificar_Conversas.Interval = 1000;
            this.time_Verificar_Conversas.Tick += new System.EventHandler(this.Time_Verificar_Conversas_Tick);
            // 
            // btn_Enviar_
            // 
            this.btn_Enviar_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Enviar_.BackColor = System.Drawing.Color.White;
            this.btn_Enviar_.Image = global::MultMap.Properties.Resources.ic_preto_send;
            this.btn_Enviar_.Location = new System.Drawing.Point(823, 426);
            this.btn_Enviar_.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Enviar_.Name = "btn_Enviar_";
            this.btn_Enviar_.Size = new System.Drawing.Size(57, 52);
            this.btn_Enviar_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Enviar_.TabIndex = 22;
            this.btn_Enviar_.TabStop = false;
            this.btn_Enviar_.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Enviar_MouseClick);
            this.btn_Enviar_.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Txt_Log
            // 
            this.Txt_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Log.AutoSize = true;
            this.Txt_Log.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Log.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.Txt_Log.ForeColor = System.Drawing.Color.Black;
            this.Txt_Log.Location = new System.Drawing.Point(679, 56);
            this.Txt_Log.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Log.Name = "Txt_Log";
            this.Txt_Log.Size = new System.Drawing.Size(168, 14);
            this.Txt_Log.TabIndex = 0;
            this.Txt_Log.Text = "Ctrl+Enter para quebra de linha";
            this.Txt_Log.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(678, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enviar msg com Enter";
            // 
            // Txt_Nome_Conversa
            // 
            this.Txt_Nome_Conversa.AutoSize = true;
            this.Txt_Nome_Conversa.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Nome_Conversa.Enabled = false;
            this.Txt_Nome_Conversa.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Txt_Nome_Conversa.ForeColor = System.Drawing.Color.Black;
            this.Txt_Nome_Conversa.Location = new System.Drawing.Point(242, 40);
            this.Txt_Nome_Conversa.Name = "Txt_Nome_Conversa";
            this.Txt_Nome_Conversa.Size = new System.Drawing.Size(130, 19);
            this.Txt_Nome_Conversa.TabIndex = 0;
            this.Txt_Nome_Conversa.Text = "Nome do contato";
            this.Txt_Nome_Conversa.Visible = false;
            // 
            // fl_Contatos
            // 
            this.fl_Contatos.AutoScroll = true;
            this.fl_Contatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.fl_Contatos.Controls.Add(this.contato1);
            this.fl_Contatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.fl_Contatos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fl_Contatos.Location = new System.Drawing.Point(0, 23);
            this.fl_Contatos.Margin = new System.Windows.Forms.Padding(0);
            this.fl_Contatos.Name = "fl_Contatos";
            this.fl_Contatos.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.fl_Contatos.Size = new System.Drawing.Size(185, 455);
            this.fl_Contatos.TabIndex = 0;
            this.fl_Contatos.WrapContents = false;
            // 
            // contato1
            // 
            this.contato1.BackColor = System.Drawing.Color.Transparent;
            this.contato1.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.contato1.Location = new System.Drawing.Point(8, 13);
            this.contato1.Name = "contato1";
            this.contato1.Size = new System.Drawing.Size(160, 35);
            this.contato1.TabIndex = 0;
            this.contato1.Visible = false;
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_mensagem.CustomButton.BackColor = System.Drawing.Color.Black;
            this.tb_mensagem.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_mensagem.CustomButton.Image = null;
            this.tb_mensagem.CustomButton.Location = new System.Drawing.Point(602, 2);
            this.tb_mensagem.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.tb_mensagem.CustomButton.Name = "";
            this.tb_mensagem.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.tb_mensagem.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_mensagem.CustomButton.TabIndex = 0;
            this.tb_mensagem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_mensagem.CustomButton.UseCustomBackColor = true;
            this.tb_mensagem.CustomButton.UseSelectable = true;
            this.tb_mensagem.CustomButton.UseVisualStyleBackColor = false;
            this.tb_mensagem.CustomButton.Visible = false;
            this.tb_mensagem.Icon = global::MultMap.Properties.Resources.ic_preto_send;
            this.tb_mensagem.IconRight = true;
            this.tb_mensagem.Lines = new string[0];
            this.tb_mensagem.Location = new System.Drawing.Point(171, 426);
            this.tb_mensagem.Margin = new System.Windows.Forms.Padding(0);
            this.tb_mensagem.MaxLength = 32767;
            this.tb_mensagem.Multiline = true;
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.PasswordChar = '\0';
            this.tb_mensagem.PromptText = "Digite aqui";
            this.tb_mensagem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_mensagem.SelectedText = "";
            this.tb_mensagem.SelectionLength = 0;
            this.tb_mensagem.SelectionStart = 0;
            this.tb_mensagem.ShortcutsEnabled = true;
            this.tb_mensagem.Size = new System.Drawing.Size(652, 52);
            this.tb_mensagem.Style = MetroFramework.MetroColorStyle.Black;
            this.tb_mensagem.TabIndex = 2;
            this.tb_mensagem.UseCustomBackColor = true;
            this.tb_mensagem.UseSelectable = true;
            this.tb_mensagem.UseStyleColors = true;
            this.tb_mensagem.WaterMark = "Digite aqui";
            this.tb_mensagem.WaterMarkColor = System.Drawing.Color.Silver;
            this.tb_mensagem.WaterMarkFont = new System.Drawing.Font("Bahnschrift", 12F);
            this.tb_mensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_mensagem_KeyPress);
            this.tb_mensagem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Cb_Enviar_Msg_Enter
            // 
            this.Cb_Enviar_Msg_Enter.BackColor = System.Drawing.Color.Lime;
            this.Cb_Enviar_Msg_Enter.Location = new System.Drawing.Point(850, 40);
            this.Cb_Enviar_Msg_Enter.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Enviar_Msg_Enter.Name = "Cb_Enviar_Msg_Enter";
            this.Cb_Enviar_Msg_Enter.Radio = 10;
            this.Cb_Enviar_Msg_Enter.Selecionado = true;
            this.Cb_Enviar_Msg_Enter.SelecionadoFalse = System.Drawing.Color.Silver;
            this.Cb_Enviar_Msg_Enter.SelecionadoTrue = System.Drawing.Color.Lime;
            this.Cb_Enviar_Msg_Enter.Size = new System.Drawing.Size(20, 20);
            this.Cb_Enviar_Msg_Enter.TabIndex = 1;
            this.Cb_Enviar_Msg_Enter.Click += new System.EventHandler(this.Cb_Enviar_Msg_Enter_OnChange);
            // 
            // Img_Foto_Conversa
            // 
            this.Img_Foto_Conversa.BackColor = System.Drawing.Color.White;
            this.Img_Foto_Conversa.Enabled = false;
            this.Img_Foto_Conversa.Image = global::MultMap.Properties.Resources.ic_branco_user;
            this.Img_Foto_Conversa.Location = new System.Drawing.Point(189, 27);
            this.Img_Foto_Conversa.Margin = new System.Windows.Forms.Padding(0);
            this.Img_Foto_Conversa.Name = "Img_Foto_Conversa";
            this.Img_Foto_Conversa.Radio = 100;
            this.Img_Foto_Conversa.Size = new System.Drawing.Size(50, 50);
            this.Img_Foto_Conversa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Foto_Conversa.TabIndex = 27;
            this.Img_Foto_Conversa.TabStop = false;
            this.Img_Foto_Conversa.Visible = false;
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
            this.cabecalho1.Minimizar = true;
            this.cabecalho1.MinimumSize = new System.Drawing.Size(0, 23);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(880, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Chat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(171, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 54);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Tela_Ferramentas_Chat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_Enviar_Msg_Enter);
            this.Controls.Add(this.tb_mensagem);
            this.Controls.Add(this.Txt_Log);
            this.Controls.Add(this.btn_Enviar_);
            this.Controls.Add(this.panel_Conversa);
            this.Controls.Add(this.Img_Foto_Conversa);
            this.Controls.Add(this.Txt_Nome_Conversa);
            this.Controls.Add(this.fl_Contatos);
            this.Controls.Add(this.cabecalho1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 320);
            this.Name = "Tela_Ferramentas_Chat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Chat";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Enviar_)).EndInit();
            this.fl_Contatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Foto_Conversa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Conversa;
        private System.Windows.Forms.Timer time_Verificar_Conversas;
        private System.Windows.Forms.PictureBox btn_Enviar_;
        private System.Windows.Forms.Label Txt_Nome_Conversa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Txt_Log;
        private Telas.Ferramentas.ImageRadius Img_Foto_Conversa;
        private System.Windows.Forms.FlowLayoutPanel fl_Contatos;
        private Telas.Ferramentas.CustomCheckBox Cb_Enviar_Msg_Enter;
        private MetroFramework.Controls.MetroTextBox tb_mensagem;
        private Telas.Exemplos.Contato contato1;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}