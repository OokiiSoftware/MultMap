namespace MultMap.Telas
{
    partial class Tela_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicio));
            this.menu_top = new System.Windows.Forms.Panel();
            this.Logoapp = new System.Windows.Forms.PictureBox();
            this.btn_PararAlarme = new System.Windows.Forms.Button();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.txt_UsuarioLogado_Nome = new System.Windows.Forms.Label();
            this.data_hora = new System.Windows.Forms.Label();
            this.flow_menu_top = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_menu_top_user_add = new System.Windows.Forms.Button();
            this.btn_menu_top_relatorio_caixas = new System.Windows.Forms.Button();
            this.btn_menu_top_map = new System.Windows.Forms.Button();
            this.btn_menu_top_chat = new System.Windows.Forms.Button();
            this.btn_menu_top_navegador = new System.Windows.Forms.Button();
            this.btn_menu_top_exclusao = new System.Windows.Forms.Button();
            this.btn_menu_top_alteracao = new System.Windows.Forms.Button();
            this.btn_menu_top_lembretes = new System.Windows.Forms.Button();
            this.Btn_Menu_Top_Email = new System.Windows.Forms.Button();
            this.txt_app_name = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_close_app = new System.Windows.Forms.PictureBox();
            this.btn_menu_lateral = new System.Windows.Forms.PictureBox();
            this.painel_telas = new System.Windows.Forms.Panel();
            this.Painel_Lateral = new System.Windows.Forms.Panel();
            this.menu_lateral = new MultMap.Telas.Ferramentas.PanelGradient();
            this.Cb_Tema = new MultMap.Telas.Ferramentas.CustomCheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flow_menu_lateral = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_user_add = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_relatorio_caixas = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_historicos = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_historico_exclusao = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_historico_alteracao = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_ferramentas = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_ferramenta_mapa = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_ferramenta_chat = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_ferramenta_navegador = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_ferramenta_lembretes = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.Btn_ferramenta_Email = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_ajuda = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.btn_sobre = new MultMap.Telas.Exemplos.ButtonPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.img_Foto_User = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Timer_HoraAtual = new System.Windows.Forms.Timer(this.components);
            this.Timer_Alarme = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menu_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logoapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.flow_menu_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_app)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu_lateral)).BeginInit();
            this.Painel_Lateral.SuspendLayout();
            this.menu_lateral.SuspendLayout();
            this.flow_menu_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_top
            // 
            this.menu_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.menu_top.Controls.Add(this.progressBar);
            this.menu_top.Controls.Add(this.Logoapp);
            this.menu_top.Controls.Add(this.btn_PararAlarme);
            this.menu_top.Controls.Add(this.MediaPlayer);
            this.menu_top.Controls.Add(this.txt_UsuarioLogado_Nome);
            this.menu_top.Controls.Add(this.data_hora);
            this.menu_top.Controls.Add(this.flow_menu_top);
            this.menu_top.Controls.Add(this.txt_app_name);
            this.menu_top.Controls.Add(this.btn_minimize);
            this.menu_top.Controls.Add(this.btn_close_app);
            this.menu_top.Controls.Add(this.btn_menu_lateral);
            this.menu_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_top.Location = new System.Drawing.Point(0, 0);
            this.menu_top.Margin = new System.Windows.Forms.Padding(0);
            this.menu_top.Name = "menu_top";
            this.menu_top.Size = new System.Drawing.Size(1366, 44);
            this.menu_top.TabIndex = 1;
            // 
            // Logoapp
            // 
            this.Logoapp.Image = global::MultMap.Properties.Resources.logo_MapNap;
            this.Logoapp.Location = new System.Drawing.Point(49, 6);
            this.Logoapp.Name = "Logoapp";
            this.Logoapp.Size = new System.Drawing.Size(30, 30);
            this.Logoapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logoapp.TabIndex = 1;
            this.Logoapp.TabStop = false;
            // 
            // btn_PararAlarme
            // 
            this.btn_PararAlarme.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_alarme;
            this.btn_PararAlarme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PararAlarme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_PararAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PararAlarme.Location = new System.Drawing.Point(618, 3);
            this.btn_PararAlarme.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PararAlarme.Name = "btn_PararAlarme";
            this.btn_PararAlarme.Size = new System.Drawing.Size(38, 38);
            this.btn_PararAlarme.TabIndex = 2;
            this.btn_PararAlarme.UseVisualStyleBackColor = true;
            this.btn_PararAlarme.Visible = false;
            this.btn_PararAlarme.Click += new System.EventHandler(this.Btn_PararAlarme_Click);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(619, 3);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(37, 37);
            this.MediaPlayer.TabIndex = 9;
            this.MediaPlayer.Visible = false;
            // 
            // txt_UsuarioLogado_Nome
            // 
            this.txt_UsuarioLogado_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UsuarioLogado_Nome.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioLogado_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_UsuarioLogado_Nome.Location = new System.Drawing.Point(703, 1);
            this.txt_UsuarioLogado_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.txt_UsuarioLogado_Nome.Name = "txt_UsuarioLogado_Nome";
            this.txt_UsuarioLogado_Nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_UsuarioLogado_Nome.Size = new System.Drawing.Size(301, 42);
            this.txt_UsuarioLogado_Nome.TabIndex = 0;
            this.txt_UsuarioLogado_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // data_hora
            // 
            this.data_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.data_hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_hora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.data_hora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.data_hora.Location = new System.Drawing.Point(1009, 1);
            this.data_hora.Margin = new System.Windows.Forms.Padding(0);
            this.data_hora.Name = "data_hora";
            this.data_hora.Size = new System.Drawing.Size(274, 42);
            this.data_hora.TabIndex = 0;
            this.data_hora.Text = "Carregando...";
            this.data_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flow_menu_top
            // 
            this.flow_menu_top.Controls.Add(this.btn_menu_top_user_add);
            this.flow_menu_top.Controls.Add(this.btn_menu_top_relatorio_caixas);
            this.flow_menu_top.Controls.Add(this.btn_menu_top_map);
            this.flow_menu_top.Controls.Add(this.btn_menu_top_chat);
            this.flow_menu_top.Controls.Add(this.btn_menu_top_navegador);
            this.flow_menu_top.Controls.Add(this.btn_menu_top_exclusao);
            this.flow_menu_top.Controls.Add(this.btn_menu_top_alteracao);
            this.flow_menu_top.Controls.Add(this.btn_menu_top_lembretes);
            this.flow_menu_top.Controls.Add(this.Btn_Menu_Top_Email);
            this.flow_menu_top.Location = new System.Drawing.Point(225, 1);
            this.flow_menu_top.Margin = new System.Windows.Forms.Padding(2);
            this.flow_menu_top.Name = "flow_menu_top";
            this.flow_menu_top.Size = new System.Drawing.Size(390, 42);
            this.flow_menu_top.TabIndex = 1;
            // 
            // btn_menu_top_user_add
            // 
            this.btn_menu_top_user_add.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_user;
            this.btn_menu_top_user_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_user_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_user_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_user_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_user_add.Location = new System.Drawing.Point(2, 2);
            this.btn_menu_top_user_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_user_add.Name = "btn_menu_top_user_add";
            this.btn_menu_top_user_add.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_user_add.TabIndex = 1;
            this.btn_menu_top_user_add.Tag = "";
            this.btn_menu_top_user_add.UseVisualStyleBackColor = true;
            this.btn_menu_top_user_add.Visible = false;
            // 
            // btn_menu_top_relatorio_caixas
            // 
            this.btn_menu_top_relatorio_caixas.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_relatorio;
            this.btn_menu_top_relatorio_caixas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_relatorio_caixas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_relatorio_caixas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_relatorio_caixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_relatorio_caixas.Location = new System.Drawing.Point(44, 2);
            this.btn_menu_top_relatorio_caixas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_relatorio_caixas.Name = "btn_menu_top_relatorio_caixas";
            this.btn_menu_top_relatorio_caixas.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_relatorio_caixas.TabIndex = 2;
            this.btn_menu_top_relatorio_caixas.Tag = "";
            this.btn_menu_top_relatorio_caixas.UseVisualStyleBackColor = true;
            this.btn_menu_top_relatorio_caixas.Visible = false;
            // 
            // btn_menu_top_map
            // 
            this.btn_menu_top_map.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_place;
            this.btn_menu_top_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_map.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_map.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_map.Location = new System.Drawing.Point(86, 2);
            this.btn_menu_top_map.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_map.Name = "btn_menu_top_map";
            this.btn_menu_top_map.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_map.TabIndex = 3;
            this.btn_menu_top_map.Tag = "";
            this.btn_menu_top_map.UseVisualStyleBackColor = true;
            this.btn_menu_top_map.Visible = false;
            // 
            // btn_menu_top_chat
            // 
            this.btn_menu_top_chat.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_chat;
            this.btn_menu_top_chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_chat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_chat.Location = new System.Drawing.Point(128, 2);
            this.btn_menu_top_chat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_chat.Name = "btn_menu_top_chat";
            this.btn_menu_top_chat.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_chat.TabIndex = 4;
            this.btn_menu_top_chat.Tag = "";
            this.btn_menu_top_chat.UseVisualStyleBackColor = true;
            this.btn_menu_top_chat.Visible = false;
            // 
            // btn_menu_top_navegador
            // 
            this.btn_menu_top_navegador.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_navegador;
            this.btn_menu_top_navegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_navegador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_navegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_navegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_navegador.Location = new System.Drawing.Point(170, 2);
            this.btn_menu_top_navegador.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_navegador.Name = "btn_menu_top_navegador";
            this.btn_menu_top_navegador.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_navegador.TabIndex = 5;
            this.btn_menu_top_navegador.Tag = "";
            this.btn_menu_top_navegador.UseVisualStyleBackColor = true;
            this.btn_menu_top_navegador.Visible = false;
            // 
            // btn_menu_top_exclusao
            // 
            this.btn_menu_top_exclusao.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_note;
            this.btn_menu_top_exclusao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_exclusao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_exclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_exclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_exclusao.Location = new System.Drawing.Point(212, 2);
            this.btn_menu_top_exclusao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_exclusao.Name = "btn_menu_top_exclusao";
            this.btn_menu_top_exclusao.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_exclusao.TabIndex = 6;
            this.btn_menu_top_exclusao.Tag = "";
            this.btn_menu_top_exclusao.UseVisualStyleBackColor = true;
            this.btn_menu_top_exclusao.Visible = false;
            // 
            // btn_menu_top_alteracao
            // 
            this.btn_menu_top_alteracao.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_relatorio_excluir;
            this.btn_menu_top_alteracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_alteracao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_alteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_alteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_alteracao.Location = new System.Drawing.Point(254, 2);
            this.btn_menu_top_alteracao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_alteracao.Name = "btn_menu_top_alteracao";
            this.btn_menu_top_alteracao.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_alteracao.TabIndex = 7;
            this.btn_menu_top_alteracao.Tag = "";
            this.btn_menu_top_alteracao.UseVisualStyleBackColor = true;
            this.btn_menu_top_alteracao.Visible = false;
            // 
            // btn_menu_top_lembretes
            // 
            this.btn_menu_top_lembretes.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_alarme;
            this.btn_menu_top_lembretes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_top_lembretes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_top_lembretes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_top_lembretes.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_top_lembretes.Location = new System.Drawing.Point(296, 2);
            this.btn_menu_top_lembretes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu_top_lembretes.Name = "btn_menu_top_lembretes";
            this.btn_menu_top_lembretes.Size = new System.Drawing.Size(38, 38);
            this.btn_menu_top_lembretes.TabIndex = 8;
            this.btn_menu_top_lembretes.Tag = "";
            this.btn_menu_top_lembretes.UseVisualStyleBackColor = true;
            this.btn_menu_top_lembretes.Visible = false;
            // 
            // Btn_Menu_Top_Email
            // 
            this.Btn_Menu_Top_Email.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_email;
            this.Btn_Menu_Top_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Menu_Top_Email.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Menu_Top_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Top_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Top_Email.Location = new System.Drawing.Point(338, 2);
            this.Btn_Menu_Top_Email.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Menu_Top_Email.Name = "Btn_Menu_Top_Email";
            this.Btn_Menu_Top_Email.Size = new System.Drawing.Size(38, 38);
            this.Btn_Menu_Top_Email.TabIndex = 0;
            this.Btn_Menu_Top_Email.Tag = "";
            this.Btn_Menu_Top_Email.UseVisualStyleBackColor = true;
            this.Btn_Menu_Top_Email.Visible = false;
            // 
            // txt_app_name
            // 
            this.txt_app_name.AutoSize = true;
            this.txt_app_name.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_app_name.ForeColor = System.Drawing.Color.White;
            this.txt_app_name.Location = new System.Drawing.Point(82, 11);
            this.txt_app_name.Name = "txt_app_name";
            this.txt_app_name.Size = new System.Drawing.Size(92, 21);
            this.txt_app_name.TabIndex = 0;
            this.txt_app_name.Text = "MULT MAP";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(1288, 6);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_close_app
            // 
            this.btn_close_app.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close_app.Image = ((System.Drawing.Image)(resources.GetObject("btn_close_app.Image")));
            this.btn_close_app.Location = new System.Drawing.Point(1324, 6);
            this.btn_close_app.Name = "btn_close_app";
            this.btn_close_app.Size = new System.Drawing.Size(30, 30);
            this.btn_close_app.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close_app.TabIndex = 1;
            this.btn_close_app.TabStop = false;
            this.btn_close_app.Click += new System.EventHandler(this.Btn_close_app_Click);
            // 
            // btn_menu_lateral
            // 
            this.btn_menu_lateral.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_lateral.Image")));
            this.btn_menu_lateral.Location = new System.Drawing.Point(12, 6);
            this.btn_menu_lateral.Name = "btn_menu_lateral";
            this.btn_menu_lateral.Size = new System.Drawing.Size(30, 30);
            this.btn_menu_lateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_menu_lateral.TabIndex = 0;
            this.btn_menu_lateral.TabStop = false;
            this.btn_menu_lateral.Visible = false;
            this.btn_menu_lateral.Click += new System.EventHandler(this.Btn_menu_lateral_Click);
            // 
            // painel_telas
            // 
            this.painel_telas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.painel_telas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_telas.Location = new System.Drawing.Point(225, 44);
            this.painel_telas.Margin = new System.Windows.Forms.Padding(0);
            this.painel_telas.Name = "painel_telas";
            this.painel_telas.Size = new System.Drawing.Size(1141, 724);
            this.painel_telas.TabIndex = 0;
            // 
            // Painel_Lateral
            // 
            this.Painel_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Painel_Lateral.Controls.Add(this.menu_lateral);
            this.Painel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Painel_Lateral.Location = new System.Drawing.Point(0, 44);
            this.Painel_Lateral.Margin = new System.Windows.Forms.Padding(0);
            this.Painel_Lateral.Name = "Painel_Lateral";
            this.Painel_Lateral.Size = new System.Drawing.Size(225, 724);
            this.Painel_Lateral.TabIndex = 2;
            // 
            // menu_lateral
            // 
            this.menu_lateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.menu_lateral.colorBoton = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.menu_lateral.colorTop = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.menu_lateral.Controls.Add(this.Cb_Tema);
            this.menu_lateral.Controls.Add(this.progressBar1);
            this.menu_lateral.Controls.Add(this.flow_menu_lateral);
            this.menu_lateral.Controls.Add(this.label1);
            this.menu_lateral.Controls.Add(this.btn_logout);
            this.menu_lateral.Controls.Add(this.label2);
            this.menu_lateral.Controls.Add(this.shapeContainer2);
            this.menu_lateral.Location = new System.Drawing.Point(7, 6);
            this.menu_lateral.Margin = new System.Windows.Forms.Padding(0);
            this.menu_lateral.Name = "menu_lateral";
            this.menu_lateral.Radio = 10;
            this.menu_lateral.Size = new System.Drawing.Size(215, 709);
            this.menu_lateral.TabIndex = 1;
            // 
            // Cb_Tema
            // 
            this.Cb_Tema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cb_Tema.BackColor = System.Drawing.Color.White;
            this.Cb_Tema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_Tema.Location = new System.Drawing.Point(20, 646);
            this.Cb_Tema.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Tema.Name = "Cb_Tema";
            this.Cb_Tema.Radio = 100;
            this.Cb_Tema.Selecionado = false;
            this.Cb_Tema.SelecionadoFalse = System.Drawing.Color.White;
            this.Cb_Tema.SelecionadoTrue = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cb_Tema.Size = new System.Drawing.Size(20, 20);
            this.Cb_Tema.TabIndex = 14;
            this.Cb_Tema.Click += new System.EventHandler(this.Cb_Tema_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(2, 47);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 1);
            this.progressBar1.TabIndex = 0;
            // 
            // flow_menu_lateral
            // 
            this.flow_menu_lateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flow_menu_lateral.AutoScroll = true;
            this.flow_menu_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.flow_menu_lateral.Controls.Add(this.btn_user_add);
            this.flow_menu_lateral.Controls.Add(this.btn_relatorio_caixas);
            this.flow_menu_lateral.Controls.Add(this.btn_historicos);
            this.flow_menu_lateral.Controls.Add(this.btn_historico_exclusao);
            this.flow_menu_lateral.Controls.Add(this.btn_historico_alteracao);
            this.flow_menu_lateral.Controls.Add(this.btn_ferramentas);
            this.flow_menu_lateral.Controls.Add(this.btn_ferramenta_mapa);
            this.flow_menu_lateral.Controls.Add(this.btn_ferramenta_chat);
            this.flow_menu_lateral.Controls.Add(this.btn_ferramenta_navegador);
            this.flow_menu_lateral.Controls.Add(this.btn_ferramenta_lembretes);
            this.flow_menu_lateral.Controls.Add(this.Btn_ferramenta_Email);
            this.flow_menu_lateral.Controls.Add(this.btn_ajuda);
            this.flow_menu_lateral.Controls.Add(this.btn_sobre);
            this.flow_menu_lateral.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_menu_lateral.Location = new System.Drawing.Point(5, 52);
            this.flow_menu_lateral.Margin = new System.Windows.Forms.Padding(0);
            this.flow_menu_lateral.Name = "flow_menu_lateral";
            this.flow_menu_lateral.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.flow_menu_lateral.Size = new System.Drawing.Size(203, 512);
            this.flow_menu_lateral.TabIndex = 0;
            this.flow_menu_lateral.WrapContents = false;
            // 
            // btn_user_add
            // 
            this.btn_user_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_user_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user_add.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_user_add.ForeColor = System.Drawing.Color.LightGray;
            this.btn_user_add.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_person;
            this.btn_user_add.L_Icon_Selecionado = null;
            this.btn_user_add.L_Tamanho = 35;
            this.btn_user_add.Location = new System.Drawing.Point(5, 10);
            this.btn_user_add.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_user_add.Name = "btn_user_add";
            this.btn_user_add.On_Hover = System.Drawing.Color.White;
            this.btn_user_add.R_Icon_Normal = null;
            this.btn_user_add.R_Icon_Selecionado = null;
            this.btn_user_add.R_Tamanho = 35;
            this.btn_user_add.Selecionado = false;
            this.btn_user_add.Size = new System.Drawing.Size(175, 35);
            this.btn_user_add.TabIndex = 1;
            this.btn_user_add.Text = "Funcionário";
            this.btn_user_add.TextoMargem = 10;
            this.btn_user_add.Click += new System.EventHandler(this.Btn_user_add_Click);
            // 
            // btn_relatorio_caixas
            // 
            this.btn_relatorio_caixas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_relatorio_caixas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relatorio_caixas.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_relatorio_caixas.ForeColor = System.Drawing.Color.LightGray;
            this.btn_relatorio_caixas.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_relatorio;
            this.btn_relatorio_caixas.L_Icon_Selecionado = null;
            this.btn_relatorio_caixas.L_Tamanho = 35;
            this.btn_relatorio_caixas.Location = new System.Drawing.Point(5, 50);
            this.btn_relatorio_caixas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_relatorio_caixas.Name = "btn_relatorio_caixas";
            this.btn_relatorio_caixas.On_Hover = System.Drawing.Color.White;
            this.btn_relatorio_caixas.R_Icon_Normal = null;
            this.btn_relatorio_caixas.R_Icon_Selecionado = null;
            this.btn_relatorio_caixas.R_Tamanho = 35;
            this.btn_relatorio_caixas.Selecionado = false;
            this.btn_relatorio_caixas.Size = new System.Drawing.Size(175, 35);
            this.btn_relatorio_caixas.TabIndex = 2;
            this.btn_relatorio_caixas.Text = "Caixas";
            this.btn_relatorio_caixas.TextoMargem = 10;
            this.btn_relatorio_caixas.Click += new System.EventHandler(this.Btn_relatorio_caixas_Click);
            // 
            // btn_historicos
            // 
            this.btn_historicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_historicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historicos.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historicos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_historicos.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_historico;
            this.btn_historicos.L_Icon_Selecionado = null;
            this.btn_historicos.L_Tamanho = 35;
            this.btn_historicos.Location = new System.Drawing.Point(5, 90);
            this.btn_historicos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_historicos.Name = "btn_historicos";
            this.btn_historicos.On_Hover = System.Drawing.Color.White;
            this.btn_historicos.R_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_arrow_down;
            this.btn_historicos.R_Icon_Selecionado = global::MultMap.Properties.Resources.ic_branco_arrow_up;
            this.btn_historicos.R_Tamanho = 30;
            this.btn_historicos.Selecionado = false;
            this.btn_historicos.Size = new System.Drawing.Size(175, 35);
            this.btn_historicos.TabIndex = 3;
            this.btn_historicos.Text = "Históricos";
            this.btn_historicos.TextoMargem = 10;
            this.btn_historicos.Click += new System.EventHandler(this.Btn_historicos_Click);
            // 
            // btn_historico_exclusao
            // 
            this.btn_historico_exclusao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_historico_exclusao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historico_exclusao.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_historico_exclusao.ForeColor = System.Drawing.Color.LightGray;
            this.btn_historico_exclusao.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_delete;
            this.btn_historico_exclusao.L_Icon_Selecionado = null;
            this.btn_historico_exclusao.L_Tamanho = 25;
            this.btn_historico_exclusao.Location = new System.Drawing.Point(10, 125);
            this.btn_historico_exclusao.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_historico_exclusao.Name = "btn_historico_exclusao";
            this.btn_historico_exclusao.On_Hover = System.Drawing.Color.White;
            this.btn_historico_exclusao.R_Icon_Normal = null;
            this.btn_historico_exclusao.R_Icon_Selecionado = null;
            this.btn_historico_exclusao.R_Tamanho = 35;
            this.btn_historico_exclusao.Selecionado = false;
            this.btn_historico_exclusao.Size = new System.Drawing.Size(175, 35);
            this.btn_historico_exclusao.TabIndex = 4;
            this.btn_historico_exclusao.Text = "Exclusão";
            this.btn_historico_exclusao.TextoMargem = 15;
            this.btn_historico_exclusao.Visible = false;
            this.btn_historico_exclusao.Click += new System.EventHandler(this.Btn_historico_exclusao_Click);
            // 
            // btn_historico_alteracao
            // 
            this.btn_historico_alteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_historico_alteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historico_alteracao.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_historico_alteracao.ForeColor = System.Drawing.Color.LightGray;
            this.btn_historico_alteracao.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_historico_alteracao;
            this.btn_historico_alteracao.L_Icon_Selecionado = null;
            this.btn_historico_alteracao.L_Tamanho = 25;
            this.btn_historico_alteracao.Location = new System.Drawing.Point(10, 160);
            this.btn_historico_alteracao.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_historico_alteracao.Name = "btn_historico_alteracao";
            this.btn_historico_alteracao.On_Hover = System.Drawing.Color.White;
            this.btn_historico_alteracao.R_Icon_Normal = null;
            this.btn_historico_alteracao.R_Icon_Selecionado = null;
            this.btn_historico_alteracao.R_Tamanho = 35;
            this.btn_historico_alteracao.Selecionado = false;
            this.btn_historico_alteracao.Size = new System.Drawing.Size(175, 35);
            this.btn_historico_alteracao.TabIndex = 5;
            this.btn_historico_alteracao.Text = "Alteração";
            this.btn_historico_alteracao.TextoMargem = 15;
            this.btn_historico_alteracao.Visible = false;
            this.btn_historico_alteracao.Click += new System.EventHandler(this.Btn_historico_alteracao_Click);
            // 
            // btn_ferramentas
            // 
            this.btn_ferramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_ferramentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ferramentas.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ferramentas.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ferramentas.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_ferramentas;
            this.btn_ferramentas.L_Icon_Selecionado = null;
            this.btn_ferramentas.L_Tamanho = 35;
            this.btn_ferramentas.Location = new System.Drawing.Point(5, 200);
            this.btn_ferramentas.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_ferramentas.Name = "btn_ferramentas";
            this.btn_ferramentas.On_Hover = System.Drawing.Color.White;
            this.btn_ferramentas.R_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_arrow_down;
            this.btn_ferramentas.R_Icon_Selecionado = global::MultMap.Properties.Resources.ic_branco_arrow_up;
            this.btn_ferramentas.R_Tamanho = 30;
            this.btn_ferramentas.Selecionado = false;
            this.btn_ferramentas.Size = new System.Drawing.Size(175, 35);
            this.btn_ferramentas.TabIndex = 6;
            this.btn_ferramentas.Text = "Ferramentas";
            this.btn_ferramentas.TextoMargem = 10;
            this.btn_ferramentas.Click += new System.EventHandler(this.Btn_ferramentas_Click);
            // 
            // btn_ferramenta_mapa
            // 
            this.btn_ferramenta_mapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_ferramenta_mapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ferramenta_mapa.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_ferramenta_mapa.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ferramenta_mapa.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_map;
            this.btn_ferramenta_mapa.L_Icon_Selecionado = null;
            this.btn_ferramenta_mapa.L_Tamanho = 25;
            this.btn_ferramenta_mapa.Location = new System.Drawing.Point(10, 235);
            this.btn_ferramenta_mapa.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ferramenta_mapa.Name = "btn_ferramenta_mapa";
            this.btn_ferramenta_mapa.On_Hover = System.Drawing.Color.White;
            this.btn_ferramenta_mapa.R_Icon_Normal = null;
            this.btn_ferramenta_mapa.R_Icon_Selecionado = null;
            this.btn_ferramenta_mapa.R_Tamanho = 35;
            this.btn_ferramenta_mapa.Selecionado = false;
            this.btn_ferramenta_mapa.Size = new System.Drawing.Size(175, 35);
            this.btn_ferramenta_mapa.TabIndex = 7;
            this.btn_ferramenta_mapa.Text = "Mapa";
            this.btn_ferramenta_mapa.TextoMargem = 15;
            this.btn_ferramenta_mapa.Visible = false;
            this.btn_ferramenta_mapa.Click += new System.EventHandler(this.Btn_ferramenta_mapa_Click);
            // 
            // btn_ferramenta_chat
            // 
            this.btn_ferramenta_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_ferramenta_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ferramenta_chat.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_ferramenta_chat.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ferramenta_chat.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_chat;
            this.btn_ferramenta_chat.L_Icon_Selecionado = null;
            this.btn_ferramenta_chat.L_Tamanho = 25;
            this.btn_ferramenta_chat.Location = new System.Drawing.Point(10, 270);
            this.btn_ferramenta_chat.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ferramenta_chat.Name = "btn_ferramenta_chat";
            this.btn_ferramenta_chat.On_Hover = System.Drawing.Color.White;
            this.btn_ferramenta_chat.R_Icon_Normal = null;
            this.btn_ferramenta_chat.R_Icon_Selecionado = null;
            this.btn_ferramenta_chat.R_Tamanho = 35;
            this.btn_ferramenta_chat.Selecionado = false;
            this.btn_ferramenta_chat.Size = new System.Drawing.Size(175, 35);
            this.btn_ferramenta_chat.TabIndex = 8;
            this.btn_ferramenta_chat.Text = "Chat";
            this.btn_ferramenta_chat.TextoMargem = 15;
            this.btn_ferramenta_chat.Visible = false;
            this.btn_ferramenta_chat.Click += new System.EventHandler(this.Btn_ferramenta_chat_Click);
            // 
            // btn_ferramenta_navegador
            // 
            this.btn_ferramenta_navegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_ferramenta_navegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ferramenta_navegador.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_ferramenta_navegador.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ferramenta_navegador.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_browser;
            this.btn_ferramenta_navegador.L_Icon_Selecionado = null;
            this.btn_ferramenta_navegador.L_Tamanho = 25;
            this.btn_ferramenta_navegador.Location = new System.Drawing.Point(10, 305);
            this.btn_ferramenta_navegador.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ferramenta_navegador.Name = "btn_ferramenta_navegador";
            this.btn_ferramenta_navegador.On_Hover = System.Drawing.Color.White;
            this.btn_ferramenta_navegador.R_Icon_Normal = null;
            this.btn_ferramenta_navegador.R_Icon_Selecionado = null;
            this.btn_ferramenta_navegador.R_Tamanho = 35;
            this.btn_ferramenta_navegador.Selecionado = false;
            this.btn_ferramenta_navegador.Size = new System.Drawing.Size(175, 35);
            this.btn_ferramenta_navegador.TabIndex = 9;
            this.btn_ferramenta_navegador.Text = "Navegador";
            this.btn_ferramenta_navegador.TextoMargem = 15;
            this.btn_ferramenta_navegador.Visible = false;
            this.btn_ferramenta_navegador.Click += new System.EventHandler(this.Btn_ferramenta_navegador_Click);
            // 
            // btn_ferramenta_lembretes
            // 
            this.btn_ferramenta_lembretes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_ferramenta_lembretes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ferramenta_lembretes.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_ferramenta_lembretes.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ferramenta_lembretes.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_lembretes;
            this.btn_ferramenta_lembretes.L_Icon_Selecionado = null;
            this.btn_ferramenta_lembretes.L_Tamanho = 25;
            this.btn_ferramenta_lembretes.Location = new System.Drawing.Point(10, 340);
            this.btn_ferramenta_lembretes.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ferramenta_lembretes.Name = "btn_ferramenta_lembretes";
            this.btn_ferramenta_lembretes.On_Hover = System.Drawing.Color.White;
            this.btn_ferramenta_lembretes.R_Icon_Normal = null;
            this.btn_ferramenta_lembretes.R_Icon_Selecionado = null;
            this.btn_ferramenta_lembretes.R_Tamanho = 35;
            this.btn_ferramenta_lembretes.Selecionado = false;
            this.btn_ferramenta_lembretes.Size = new System.Drawing.Size(175, 35);
            this.btn_ferramenta_lembretes.TabIndex = 10;
            this.btn_ferramenta_lembretes.Text = "Lembretes";
            this.btn_ferramenta_lembretes.TextoMargem = 15;
            this.btn_ferramenta_lembretes.Visible = false;
            this.btn_ferramenta_lembretes.Click += new System.EventHandler(this.Btn_ferramenta_lembretes_Click);
            // 
            // Btn_ferramenta_Email
            // 
            this.Btn_ferramenta_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Btn_ferramenta_Email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ferramenta_Email.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Btn_ferramenta_Email.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_ferramenta_Email.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_email;
            this.Btn_ferramenta_Email.L_Icon_Selecionado = null;
            this.Btn_ferramenta_Email.L_Tamanho = 25;
            this.Btn_ferramenta_Email.Location = new System.Drawing.Point(10, 375);
            this.Btn_ferramenta_Email.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Btn_ferramenta_Email.Name = "Btn_ferramenta_Email";
            this.Btn_ferramenta_Email.On_Hover = System.Drawing.Color.White;
            this.Btn_ferramenta_Email.R_Icon_Normal = null;
            this.Btn_ferramenta_Email.R_Icon_Selecionado = null;
            this.Btn_ferramenta_Email.R_Tamanho = 35;
            this.Btn_ferramenta_Email.Selecionado = false;
            this.Btn_ferramenta_Email.Size = new System.Drawing.Size(175, 35);
            this.Btn_ferramenta_Email.TabIndex = 11;
            this.Btn_ferramenta_Email.Text = "Email";
            this.Btn_ferramenta_Email.TextoMargem = 15;
            this.Btn_ferramenta_Email.Visible = false;
            this.Btn_ferramenta_Email.Click += new System.EventHandler(this.Btn_ferramenta_Email_Click);
            // 
            // btn_ajuda
            // 
            this.btn_ajuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_ajuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajuda.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_ajuda.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ajuda.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_ajuda;
            this.btn_ajuda.L_Icon_Selecionado = null;
            this.btn_ajuda.L_Tamanho = 35;
            this.btn_ajuda.Location = new System.Drawing.Point(5, 415);
            this.btn_ajuda.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_ajuda.Name = "btn_ajuda";
            this.btn_ajuda.On_Hover = System.Drawing.Color.White;
            this.btn_ajuda.R_Icon_Normal = null;
            this.btn_ajuda.R_Icon_Selecionado = null;
            this.btn_ajuda.R_Tamanho = 35;
            this.btn_ajuda.Selecionado = false;
            this.btn_ajuda.Size = new System.Drawing.Size(175, 35);
            this.btn_ajuda.TabIndex = 12;
            this.btn_ajuda.Text = "Ajuda";
            this.btn_ajuda.TextoMargem = 10;
            this.btn_ajuda.Click += new System.EventHandler(this.Btn_ajuda_Click);
            // 
            // btn_sobre
            // 
            this.btn_sobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sobre.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_sobre.ForeColor = System.Drawing.Color.LightGray;
            this.btn_sobre.L_Icon_Normal = global::MultMap.Properties.Resources.ic_branco_sobre;
            this.btn_sobre.L_Icon_Selecionado = null;
            this.btn_sobre.L_Tamanho = 35;
            this.btn_sobre.Location = new System.Drawing.Point(5, 455);
            this.btn_sobre.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.On_Hover = System.Drawing.Color.White;
            this.btn_sobre.R_Icon_Normal = null;
            this.btn_sobre.R_Icon_Selecionado = null;
            this.btn_sobre.R_Tamanho = 35;
            this.btn_sobre.Selecionado = false;
            this.btn_sobre.Size = new System.Drawing.Size(175, 35);
            this.btn_sobre.TabIndex = 13;
            this.btn_sobre.Text = "Sobre";
            this.btn_sobre.TextoMargem = 10;
            this.btn_sobre.Click += new System.EventHandler(this.Btn_sobre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = global::MultMap.Properties.Resources.img_bnt_lougt;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(16, 671);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(28, 27);
            this.btn_logout.TabIndex = 15;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(105, 678);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bem Vindo";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.img_Foto_User});
            this.shapeContainer2.Size = new System.Drawing.Size(215, 709);
            this.shapeContainer2.TabIndex = 16;
            this.shapeContainer2.TabStop = false;
            // 
            // img_Foto_User
            // 
            this.img_Foto_User.BackgroundImage = global::MultMap.Properties.Resources.ic_branco_user;
            this.img_Foto_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_Foto_User.BorderColor = System.Drawing.Color.White;
            this.img_Foto_User.FillColor = System.Drawing.Color.White;
            this.img_Foto_User.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.img_Foto_User.Location = new System.Drawing.Point(98, 574);
            this.img_Foto_User.Name = "img_Foto_User";
            this.img_Foto_User.Size = new System.Drawing.Size(100, 100);
            // 
            // Timer_HoraAtual
            // 
            this.Timer_HoraAtual.Enabled = true;
            this.Timer_HoraAtual.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Timer_Alarme
            // 
            this.Timer_Alarme.Enabled = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(902, 9);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(102, 27);
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 100;
            // 
            // Tela_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.painel_telas);
            this.Controls.Add(this.Painel_Lateral);
            this.Controls.Add(this.menu_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mult Map";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_top.ResumeLayout(false);
            this.menu_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logoapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.flow_menu_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_app)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu_lateral)).EndInit();
            this.Painel_Lateral.ResumeLayout(false);
            this.menu_lateral.ResumeLayout(false);
            this.menu_lateral.PerformLayout();
            this.flow_menu_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_top;
        private System.Windows.Forms.Label txt_app_name;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_close_app;
        private System.Windows.Forms.PictureBox btn_menu_lateral;
        private System.Windows.Forms.Panel painel_telas;
        private System.Windows.Forms.Panel Painel_Lateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flow_menu_lateral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flow_menu_top;
        public System.Windows.Forms.Button btn_menu_top_relatorio_caixas;
        private System.Windows.Forms.Button btn_menu_top_map;
        private System.Windows.Forms.Button btn_menu_top_chat;
        private System.Windows.Forms.Button btn_menu_top_navegador;
        private System.Windows.Forms.Button btn_menu_top_user_add;
        private System.Windows.Forms.Button btn_menu_top_exclusao;
        private System.Windows.Forms.Button btn_menu_top_alteracao;
        private System.Windows.Forms.Button btn_menu_top_lembretes;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label data_hora;
        private System.Windows.Forms.Label txt_UsuarioLogado_Nome;
        private System.Windows.Forms.Timer Timer_HoraAtual;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Timer Timer_Alarme;
        private System.Windows.Forms.Button btn_PararAlarme;
        private System.Windows.Forms.Button Btn_Menu_Top_Email;
        private Telas.Ferramentas.PanelGradient menu_lateral;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Telas.Exemplos.ButtonPersonalizado btn_user_add;
        private Telas.Exemplos.ButtonPersonalizado btn_historicos;
        private Telas.Exemplos.ButtonPersonalizado btn_relatorio_caixas;
        private Telas.Exemplos.ButtonPersonalizado btn_historico_exclusao;
        private Telas.Exemplos.ButtonPersonalizado btn_historico_alteracao;
        private Telas.Exemplos.ButtonPersonalizado btn_ferramentas;
        private Telas.Exemplos.ButtonPersonalizado btn_ferramenta_mapa;
        private Telas.Exemplos.ButtonPersonalizado btn_ferramenta_chat;
        private Telas.Exemplos.ButtonPersonalizado btn_ferramenta_navegador;
        private Telas.Exemplos.ButtonPersonalizado btn_ferramenta_lembretes;
        private Telas.Exemplos.ButtonPersonalizado Btn_ferramenta_Email;
        private Telas.Exemplos.ButtonPersonalizado btn_ajuda;
        private Telas.Exemplos.ButtonPersonalizado btn_sobre;
        private Telas.Ferramentas.CustomCheckBox Cb_Tema;
        private System.Windows.Forms.PictureBox Logoapp;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape img_Foto_User;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}