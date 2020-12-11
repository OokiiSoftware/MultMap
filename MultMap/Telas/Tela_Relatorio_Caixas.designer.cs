using System;

namespace MultMap.Telas
{
    partial class Tela_Relatorio_Caixas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Relatorio_Caixas));
            this.Barra_menu_top = new System.Windows.Forms.Panel();
            this.Btn_Filtro = new System.Windows.Forms.Button();
            this.Tb_Pesquisa = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.progressBarUpdate = new System.Windows.Forms.ProgressBar();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_Relatorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_Inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_Fim = new System.Windows.Forms.DateTimePicker();
            this.cb_Atualizar_DataFim = new System.Windows.Forms.CheckBox();
            this.btn_prox = new System.Windows.Forms.Button();
            this.btn_ant = new System.Windows.Forms.Button();
            this.Barra_inferior = new System.Windows.Forms.GroupBox();
            this.Tb_TotalClientes = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_TotalCaixas = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_TotalPortasDisponiveis = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Quant_Itens_Por_Pagina = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_pg = new System.Windows.Forms.Label();
            this.txt_Log = new System.Windows.Forms.Label();
            this.txt_Ajuda_Cancelar = new System.Windows.Forms.Label();
            this.Txt_Cont_Selecao = new System.Windows.Forms.Label();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.Cb_SelecionarTudo = new System.Windows.Forms.CheckBox();
            this.filtro = new MultMap.Telas.Exemplos.Filtro();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.Selecionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Portas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geolocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barra_menu_top.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Barra_inferior.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_menu_top
            // 
            this.Barra_menu_top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Barra_menu_top.Controls.Add(this.Btn_Filtro);
            this.Barra_menu_top.Controls.Add(this.Tb_Pesquisa);
            this.Barra_menu_top.Controls.Add(this.flowLayoutPanel1);
            this.Barra_menu_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_menu_top.Location = new System.Drawing.Point(0, 23);
            this.Barra_menu_top.Margin = new System.Windows.Forms.Padding(0);
            this.Barra_menu_top.Name = "Barra_menu_top";
            this.Barra_menu_top.Size = new System.Drawing.Size(930, 60);
            this.Barra_menu_top.TabIndex = 1;
            this.Barra_menu_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Btn_Filtro
            // 
            this.Btn_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Filtro.BackColor = System.Drawing.Color.Azure;
            this.Btn_Filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Filtro.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Filtro.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Btn_Filtro.Location = new System.Drawing.Point(640, 12);
            this.Btn_Filtro.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Filtro.Name = "Btn_Filtro";
            this.Btn_Filtro.Size = new System.Drawing.Size(44, 38);
            this.Btn_Filtro.TabIndex = 2;
            this.Btn_Filtro.Text = "Filtro";
            this.Btn_Filtro.UseVisualStyleBackColor = false;
            this.Btn_Filtro.Click += new System.EventHandler(this.Btn_Filtro_Click);
            // 
            // Tb_Pesquisa
            // 
            this.Tb_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Pesquisa.BackColor = System.Drawing.Color.Azure;
            this.Tb_Pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Pesquisa.ButtonColor = System.Drawing.Color.Azure;
            this.Tb_Pesquisa.ButtonIcon = global::MultMap.Properties.Resources.ic_azul_pesquisar;
            this.Tb_Pesquisa.ButtonVisivel = false;
            this.Tb_Pesquisa.ButtonWidth = 27;
            this.Tb_Pesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Pesquisa.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_Pesquisa.Hint = "Pesquisar";
            this.Tb_Pesquisa.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_Pesquisa.Location = new System.Drawing.Point(694, 15);
            this.Tb_Pesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_Pesquisa.Name = "Tb_Pesquisa";
            this.Tb_Pesquisa.Size = new System.Drawing.Size(227, 27);
            this.Tb_Pesquisa.TabIndex = 3;
            this.Tb_Pesquisa.Tag = "";
            this.Tb_Pesquisa.TextChanged += new System.EventHandler(this.Tb_Pesquisa_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_salvar);
            this.flowLayoutPanel1.Controls.Add(this.progressBarUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btn_atualizar);
            this.flowLayoutPanel1.Controls.Add(this.btn_excluir);
            this.flowLayoutPanel1.Controls.Add(this.btn_imprimir);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Relatorio);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.cb_Atualizar_DataFim);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 60);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_save;
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(0, 0);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(55, 55);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            this.btn_salvar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // progressBarUpdate
            // 
            this.progressBarUpdate.Location = new System.Drawing.Point(58, 3);
            this.progressBarUpdate.Name = "progressBarUpdate";
            this.progressBarUpdate.Size = new System.Drawing.Size(55, 55);
            this.progressBarUpdate.TabIndex = 8;
            this.progressBarUpdate.Visible = false;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_atualizar;
            this.btn_atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Location = new System.Drawing.Point(116, 0);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(55, 55);
            this.btn_atualizar.TabIndex = 2;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            this.btn_atualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_delete;
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.Color.Coral;
            this.btn_excluir.Location = new System.Drawing.Point(171, 0);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(55, 55);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            this.btn_excluir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_print;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Bahnschrift", 13F);
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Location = new System.Drawing.Point(226, 0);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(55, 55);
            this.btn_imprimir.TabIndex = 4;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            this.btn_imprimir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Btn_Relatorio
            // 
            this.Btn_Relatorio.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Relatorio.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_relatorio;
            this.Btn_Relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Relatorio.FlatAppearance.BorderSize = 0;
            this.Btn_Relatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.Btn_Relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Relatorio.ForeColor = System.Drawing.Color.Coral;
            this.Btn_Relatorio.Location = new System.Drawing.Point(281, 0);
            this.Btn_Relatorio.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Relatorio.Name = "Btn_Relatorio";
            this.Btn_Relatorio.Size = new System.Drawing.Size(55, 55);
            this.Btn_Relatorio.TabIndex = 5;
            this.Btn_Relatorio.UseVisualStyleBackColor = false;
            this.Btn_Relatorio.Click += new System.EventHandler(this.Btn_Relatorio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DT_Inicio);
            this.panel1.Controls.Add(this.DT_Fim);
            this.panel1.Location = new System.Drawing.Point(336, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 60);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "De:";
            // 
            // DT_Inicio
            // 
            this.DT_Inicio.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DT_Inicio.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DT_Inicio.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.DT_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Inicio.Location = new System.Drawing.Point(38, 8);
            this.DT_Inicio.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Inicio.Name = "DT_Inicio";
            this.DT_Inicio.Size = new System.Drawing.Size(86, 22);
            this.DT_Inicio.TabIndex = 1;
            this.DT_Inicio.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Inicio.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DT_Inicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // DT_Fim
            // 
            this.DT_Fim.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.DT_Fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Fim.Location = new System.Drawing.Point(38, 31);
            this.DT_Fim.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Fim.Name = "DT_Fim";
            this.DT_Fim.Size = new System.Drawing.Size(86, 22);
            this.DT_Fim.TabIndex = 2;
            this.DT_Fim.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Fim.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DT_Fim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // cb_Atualizar_DataFim
            // 
            this.cb_Atualizar_DataFim.AutoSize = true;
            this.cb_Atualizar_DataFim.Checked = true;
            this.cb_Atualizar_DataFim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Atualizar_DataFim.Location = new System.Drawing.Point(3, 64);
            this.cb_Atualizar_DataFim.Name = "cb_Atualizar_DataFim";
            this.cb_Atualizar_DataFim.Size = new System.Drawing.Size(120, 40);
            this.cb_Atualizar_DataFim.TabIndex = 7;
            this.cb_Atualizar_DataFim.Text = "Atualizar data\r\npelo servidor\r\n";
            this.cb_Atualizar_DataFim.UseVisualStyleBackColor = true;
            this.cb_Atualizar_DataFim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_prox
            // 
            this.btn_prox.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_seta_prox;
            this.btn_prox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_prox.FlatAppearance.BorderSize = 0;
            this.btn_prox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_prox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prox.Location = new System.Drawing.Point(92, 0);
            this.btn_prox.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(30, 30);
            this.btn_prox.TabIndex = 2;
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.Btn_prox_Click);
            this.btn_prox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_ant
            // 
            this.btn_ant.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_seta_ant;
            this.btn_ant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ant.FlatAppearance.BorderSize = 0;
            this.btn_ant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_ant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ant.Location = new System.Drawing.Point(0, 0);
            this.btn_ant.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(30, 30);
            this.btn_ant.TabIndex = 1;
            this.btn_ant.UseVisualStyleBackColor = true;
            this.btn_ant.Click += new System.EventHandler(this.Btn_ant_Click);
            this.btn_ant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Barra_inferior
            // 
            this.Barra_inferior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Barra_inferior.Controls.Add(this.Tb_TotalClientes);
            this.Barra_inferior.Controls.Add(this.label6);
            this.Barra_inferior.Controls.Add(this.Tb_TotalCaixas);
            this.Barra_inferior.Controls.Add(this.label5);
            this.Barra_inferior.Controls.Add(this.label1);
            this.Barra_inferior.Controls.Add(this.TB_TotalPortasDisponiveis);
            this.Barra_inferior.Controls.Add(this.label4);
            this.Barra_inferior.Controls.Add(this.tb_Quant_Itens_Por_Pagina);
            this.Barra_inferior.Controls.Add(this.flowLayoutPanel2);
            this.Barra_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Barra_inferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Barra_inferior.ForeColor = System.Drawing.Color.Black;
            this.Barra_inferior.Location = new System.Drawing.Point(0, 435);
            this.Barra_inferior.Margin = new System.Windows.Forms.Padding(0);
            this.Barra_inferior.Name = "Barra_inferior";
            this.Barra_inferior.Size = new System.Drawing.Size(930, 50);
            this.Barra_inferior.TabIndex = 4;
            this.Barra_inferior.TabStop = false;
            this.Barra_inferior.Text = "Navegação";
            // 
            // Tb_TotalClientes
            // 
            this.Tb_TotalClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_TotalClientes.BackColor = System.Drawing.Color.RoyalBlue;
            this.Tb_TotalClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_TotalClientes.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_TotalClientes.ButtonIcon = null;
            this.Tb_TotalClientes.ButtonVisivel = false;
            this.Tb_TotalClientes.ButtonWidth = 27;
            this.Tb_TotalClientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_TotalClientes.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_TotalClientes.ForeColor = System.Drawing.Color.White;
            this.Tb_TotalClientes.Hint = "Quant";
            this.Tb_TotalClientes.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_TotalClientes.Location = new System.Drawing.Point(635, 18);
            this.Tb_TotalClientes.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_TotalClientes.Name = "Tb_TotalClientes";
            this.Tb_TotalClientes.ReadOnly = true;
            this.Tb_TotalClientes.Size = new System.Drawing.Size(38, 27);
            this.Tb_TotalClientes.TabIndex = 0;
            this.Tb_TotalClientes.Tag = "";
            this.Tb_TotalClientes.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total\r\nClientes";
            // 
            // Tb_TotalCaixas
            // 
            this.Tb_TotalCaixas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_TotalCaixas.BackColor = System.Drawing.Color.RoyalBlue;
            this.Tb_TotalCaixas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_TotalCaixas.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_TotalCaixas.ButtonIcon = null;
            this.Tb_TotalCaixas.ButtonVisivel = false;
            this.Tb_TotalCaixas.ButtonWidth = 27;
            this.Tb_TotalCaixas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_TotalCaixas.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_TotalCaixas.ForeColor = System.Drawing.Color.White;
            this.Tb_TotalCaixas.Hint = "Quant";
            this.Tb_TotalCaixas.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_TotalCaixas.Location = new System.Drawing.Point(553, 19);
            this.Tb_TotalCaixas.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_TotalCaixas.Name = "Tb_TotalCaixas";
            this.Tb_TotalCaixas.ReadOnly = true;
            this.Tb_TotalCaixas.Size = new System.Drawing.Size(38, 27);
            this.Tb_TotalCaixas.TabIndex = 0;
            this.Tb_TotalCaixas.Tag = "";
            this.Tb_TotalCaixas.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total\r\nCaixas";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Portas \r\nDisponíveis";
            // 
            // TB_TotalPortasDisponiveis
            // 
            this.TB_TotalPortasDisponiveis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_TotalPortasDisponiveis.BackColor = System.Drawing.Color.Gray;
            this.TB_TotalPortasDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_TotalPortasDisponiveis.ButtonColor = System.Drawing.Color.Empty;
            this.TB_TotalPortasDisponiveis.ButtonIcon = null;
            this.TB_TotalPortasDisponiveis.ButtonVisivel = false;
            this.TB_TotalPortasDisponiveis.ButtonWidth = 27;
            this.TB_TotalPortasDisponiveis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_TotalPortasDisponiveis.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.TB_TotalPortasDisponiveis.ForeColor = System.Drawing.Color.White;
            this.TB_TotalPortasDisponiveis.Hint = "Quant";
            this.TB_TotalPortasDisponiveis.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_TotalPortasDisponiveis.Location = new System.Drawing.Point(746, 18);
            this.TB_TotalPortasDisponiveis.Margin = new System.Windows.Forms.Padding(0);
            this.TB_TotalPortasDisponiveis.Name = "TB_TotalPortasDisponiveis";
            this.TB_TotalPortasDisponiveis.ReadOnly = true;
            this.TB_TotalPortasDisponiveis.Size = new System.Drawing.Size(56, 27);
            this.TB_TotalPortasDisponiveis.TabIndex = 0;
            this.TB_TotalPortasDisponiveis.Tag = "";
            this.TB_TotalPortasDisponiveis.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "itens por\r\npágina\r\n";
            // 
            // tb_Quant_Itens_Por_Pagina
            // 
            this.tb_Quant_Itens_Por_Pagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Quant_Itens_Por_Pagina.BackColor = System.Drawing.Color.Azure;
            this.tb_Quant_Itens_Por_Pagina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Quant_Itens_Por_Pagina.ButtonColor = System.Drawing.Color.Empty;
            this.tb_Quant_Itens_Por_Pagina.ButtonIcon = null;
            this.tb_Quant_Itens_Por_Pagina.ButtonVisivel = false;
            this.tb_Quant_Itens_Por_Pagina.ButtonWidth = 27;
            this.tb_Quant_Itens_Por_Pagina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Quant_Itens_Por_Pagina.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.tb_Quant_Itens_Por_Pagina.Hint = "Quant";
            this.tb_Quant_Itens_Por_Pagina.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_Quant_Itens_Por_Pagina.Location = new System.Drawing.Point(856, 17);
            this.tb_Quant_Itens_Por_Pagina.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Quant_Itens_Por_Pagina.Name = "tb_Quant_Itens_Por_Pagina";
            this.tb_Quant_Itens_Por_Pagina.Size = new System.Drawing.Size(54, 27);
            this.tb_Quant_Itens_Por_Pagina.TabIndex = 2;
            this.tb_Quant_Itens_Por_Pagina.Tag = "";
            this.tb_Quant_Itens_Por_Pagina.Text = "100";
            this.tb_Quant_Itens_Por_Pagina.TextChanged += new System.EventHandler(this.Tb_Quant_Itens_Por_Pagina_TextChanged);
            this.tb_Quant_Itens_Por_Pagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Quant_Itens_Por_Pagina_KeyPress);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btn_ant);
            this.flowLayoutPanel2.Controls.Add(this.txt_pg);
            this.flowLayoutPanel2.Controls.Add(this.btn_prox);
            this.flowLayoutPanel2.Controls.Add(this.txt_Log);
            this.flowLayoutPanel2.Controls.Add(this.txt_Ajuda_Cancelar);
            this.flowLayoutPanel2.Controls.Add(this.Txt_Cont_Selecao);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 17);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(475, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // txt_pg
            // 
            this.txt_pg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_pg.Location = new System.Drawing.Point(33, 0);
            this.txt_pg.Name = "txt_pg";
            this.txt_pg.Size = new System.Drawing.Size(56, 30);
            this.txt_pg.TabIndex = 0;
            this.txt_pg.Text = "0/0";
            this.txt_pg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Log
            // 
            this.txt_Log.AutoEllipsis = true;
            this.txt_Log.AutoSize = true;
            this.txt_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Log.Location = new System.Drawing.Point(125, 0);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(126, 17);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "Carregando dados";
            this.txt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Ajuda_Cancelar
            // 
            this.txt_Ajuda_Cancelar.AutoEllipsis = true;
            this.txt_Ajuda_Cancelar.AutoSize = true;
            this.txt_Ajuda_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Ajuda_Cancelar.Location = new System.Drawing.Point(257, 0);
            this.txt_Ajuda_Cancelar.Name = "txt_Ajuda_Cancelar";
            this.txt_Ajuda_Cancelar.Size = new System.Drawing.Size(200, 17);
            this.txt_Ajuda_Cancelar.TabIndex = 0;
            this.txt_Ajuda_Cancelar.Text = "Precione para cancelar (ESC )";
            this.txt_Ajuda_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Ajuda_Cancelar.Visible = false;
            // 
            // Txt_Cont_Selecao
            // 
            this.Txt_Cont_Selecao.AutoEllipsis = true;
            this.Txt_Cont_Selecao.AutoSize = true;
            this.Txt_Cont_Selecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_Cont_Selecao.Location = new System.Drawing.Point(463, 0);
            this.Txt_Cont_Selecao.Name = "Txt_Cont_Selecao";
            this.Txt_Cont_Selecao.Size = new System.Drawing.Size(0, 17);
            this.Txt_Cont_Selecao.TabIndex = 0;
            this.Txt_Cont_Selecao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tabela
            // 
            this.Tabela.AllowUserToAddRows = false;
            this.Tabela.AllowUserToDeleteRows = false;
            this.Tabela.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabela.BackgroundColor = System.Drawing.Color.White;
            this.Tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tabela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionado,
            this._indice,
            this.id,
            this.Nome,
            this.Status,
            this.Portas,
            this.Disponivel,
            this.geolocalizacao,
            this.Bairro,
            this.Rua});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabela.EnableHeadersVisualStyles = false;
            this.Tabela.GridColor = System.Drawing.Color.Gray;
            this.Tabela.Location = new System.Drawing.Point(0, 83);
            this.Tabela.Margin = new System.Windows.Forms.Padding(0);
            this.Tabela.MultiSelect = false;
            this.Tabela.Name = "Tabela";
            this.Tabela.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Tabela.RowHeadersVisible = false;
            this.Tabela.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.Tabela.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Tabela.RowTemplate.Height = 24;
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(930, 352);
            this.Tabela.TabIndex = 0;
            this.Tabela.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tabela_CellMouseClick);
            this.Tabela.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tabela_CellMouseDoubleClick);
            this.Tabela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tabela_KeyPress);
            this.Tabela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Cb_SelecionarTudo
            // 
            this.Cb_SelecionarTudo.AutoSize = true;
            this.Cb_SelecionarTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.Cb_SelecionarTudo.Location = new System.Drawing.Point(13, 87);
            this.Cb_SelecionarTudo.Name = "Cb_SelecionarTudo";
            this.Cb_SelecionarTudo.Size = new System.Drawing.Size(15, 14);
            this.Cb_SelecionarTudo.TabIndex = 2;
            this.Cb_SelecionarTudo.UseVisualStyleBackColor = false;
            this.Cb_SelecionarTudo.CheckedChanged += new System.EventHandler(this.Selecionatudo_CheckedChanged);
            // 
            // filtro
            // 
            this.filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtro.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.filtro.Location = new System.Drawing.Point(640, 83);
            this.filtro.Margin = new System.Windows.Forms.Padding(0);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(139, 137);
            this.filtro.TabIndex = 3;
            this.filtro.Visible = false;
            // 
            // cabecalho1
            // 
            this.cabecalho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.cabecalho1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabecalho1.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.cabecalho1.ForeColor = System.Drawing.Color.White;
            this.cabecalho1.formPai = this;
            this.cabecalho1.Location = new System.Drawing.Point(0, 0);
            this.cabecalho1.Margin = new System.Windows.Forms.Padding(16, 21, 16, 21);
            this.cabecalho1.Maximizar = true;
            this.cabecalho1.Minimizar = true;
            this.cabecalho1.MinimumSize = new System.Drawing.Size(0, 23);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(930, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Relatorios de Caixas";
            // 
            // Selecionado
            // 
            this.Selecionado.HeaderText = "";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.ReadOnly = true;
            this.Selecionado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Selecionado.Width = 40;
            // 
            // _indice
            // 
            this._indice.HeaderText = "*";
            this._indice.Name = "_indice";
            this._indice.ReadOnly = true;
            this._indice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._indice.Visible = false;
            this._indice.Width = 40;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 80;
            // 
            // Portas
            // 
            this.Portas.HeaderText = "Portas";
            this.Portas.Name = "Portas";
            this.Portas.ReadOnly = true;
            this.Portas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Portas.Width = 80;
            // 
            // Disponivel
            // 
            this.Disponivel.HeaderText = "Disponível";
            this.Disponivel.Name = "Disponivel";
            this.Disponivel.ReadOnly = true;
            this.Disponivel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Disponivel.Width = 114;
            // 
            // geolocalizacao
            // 
            this.geolocalizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.geolocalizacao.HeaderText = "Geolocalização";
            this.geolocalizacao.Name = "geolocalizacao";
            this.geolocalizacao.ReadOnly = true;
            this.geolocalizacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Bairro
            // 
            this.Bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Rua
            // 
            this.Rua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            this.Rua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tela_Relatorio_Caixas
            // 
            this.AccessibleDescription = "fechar";
            this.AccessibleName = "Relatorio Caixa";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(930, 485);
            this.Controls.Add(this.Cb_SelecionarTudo);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.Barra_inferior);
            this.Controls.Add(this.Barra_menu_top);
            this.Controls.Add(this.cabecalho1);
            this.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Relatorio_Caixas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Relatório de Caixas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tela_Relatorio_Caixas_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.Barra_menu_top.ResumeLayout(false);
            this.Barra_menu_top.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Barra_inferior.ResumeLayout(false);
            this.Barra_inferior.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Barra_menu_top;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_excluir;
        public System.Windows.Forms.Button btn_prox;
        public System.Windows.Forms.Button btn_ant;
        public System.Windows.Forms.GroupBox Barra_inferior;
        private System.Windows.Forms.DateTimePicker DT_Fim;
        private System.Windows.Forms.DateTimePicker DT_Inicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_salvar;
        private Telas.Exemplos.Filtro filtro;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private System.Windows.Forms.Button Btn_Filtro;
        private Telas.Ferramentas.CustonTextBox Tb_Pesquisa;
        private Telas.Ferramentas.CustonTextBox tb_Quant_Itens_Por_Pagina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_pg;
        private System.Windows.Forms.Label txt_Log;
        private System.Windows.Forms.Label txt_Ajuda_Cancelar;
        private System.Windows.Forms.CheckBox cb_Atualizar_DataFim;
        private System.Windows.Forms.Button Btn_Relatorio;
        private System.Windows.Forms.CheckBox Cb_SelecionarTudo;
        private System.Windows.Forms.Label Txt_Cont_Selecao;
        private Ferramentas.CustonTextBox Tb_TotalCaixas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Ferramentas.CustonTextBox TB_TotalPortasDisponiveis;
        private Ferramentas.CustonTextBox Tb_TotalClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBarUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn _indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Portas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn geolocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
    }
}