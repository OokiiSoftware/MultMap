﻿namespace MultMap.Telas
{
    partial class Tela_Historico_Exclusao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Historico_Exclusao));
            this.txt_Log = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.Barra_menu_top = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBarUpdate = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DT_Fim = new System.Windows.Forms.DateTimePicker();
            this.DT_Inicio = new System.Windows.Forms.DateTimePicker();
            this.cb_Atualizar_DataFim = new System.Windows.Forms.CheckBox();
            this.Barra_inferior = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ant = new System.Windows.Forms.Button();
            this.txt_pg = new System.Windows.Forms.Label();
            this.btn_prox = new System.Windows.Forms.Button();
            this.Txt_Cont_Selecao = new System.Windows.Forms.Label();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cb_SelecionarTudo = new System.Windows.Forms.CheckBox();
            this.Tb_Pesquisa = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.tb_Quant_Itens_Por_Pagina = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.Selecionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barra_menu_top.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Barra_inferior.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Log
            // 
            this.txt_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Log.AutoSize = true;
            this.txt_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Log.Location = new System.Drawing.Point(158, 0);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(126, 17);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "Carregando dados";
            this.txt_Log.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
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
            this.btn_imprimir.Location = new System.Drawing.Point(116, 0);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(55, 55);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            this.btn_imprimir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
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
            this.btn_atualizar.Location = new System.Drawing.Point(0, 0);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(55, 55);
            this.btn_atualizar.TabIndex = 1;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            this.btn_atualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Barra_menu_top
            // 
            this.Barra_menu_top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Barra_menu_top.Controls.Add(this.Tb_Pesquisa);
            this.Barra_menu_top.Controls.Add(this.flowLayoutPanel1);
            this.Barra_menu_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_menu_top.Location = new System.Drawing.Point(0, 23);
            this.Barra_menu_top.Margin = new System.Windows.Forms.Padding(0);
            this.Barra_menu_top.Name = "Barra_menu_top";
            this.Barra_menu_top.Size = new System.Drawing.Size(880, 60);
            this.Barra_menu_top.TabIndex = 1;
            this.Barra_menu_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btn_atualizar);
            this.flowLayoutPanel1.Controls.Add(this.progressBarUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btn_imprimir);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.cb_Atualizar_DataFim);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 60);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // progressBarUpdate
            // 
            this.progressBarUpdate.Location = new System.Drawing.Point(58, 3);
            this.progressBarUpdate.Name = "progressBarUpdate";
            this.progressBarUpdate.Size = new System.Drawing.Size(55, 55);
            this.progressBarUpdate.TabIndex = 9;
            this.progressBarUpdate.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DT_Fim);
            this.panel1.Controls.Add(this.DT_Inicio);
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 60);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Até:";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // DT_Fim
            // 
            this.DT_Fim.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.DT_Fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Fim.Location = new System.Drawing.Point(51, 31);
            this.DT_Fim.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Fim.Name = "DT_Fim";
            this.DT_Fim.Size = new System.Drawing.Size(86, 22);
            this.DT_Fim.TabIndex = 2;
            this.DT_Fim.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Fim.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DT_Fim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // DT_Inicio
            // 
            this.DT_Inicio.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.DT_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Inicio.Location = new System.Drawing.Point(51, 8);
            this.DT_Inicio.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Inicio.Name = "DT_Inicio";
            this.DT_Inicio.Size = new System.Drawing.Size(86, 22);
            this.DT_Inicio.TabIndex = 1;
            this.DT_Inicio.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DT_Inicio.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DT_Inicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // cb_Atualizar_DataFim
            // 
            this.cb_Atualizar_DataFim.AutoSize = true;
            this.cb_Atualizar_DataFim.Checked = true;
            this.cb_Atualizar_DataFim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Atualizar_DataFim.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.cb_Atualizar_DataFim.Location = new System.Drawing.Point(324, 3);
            this.cb_Atualizar_DataFim.Name = "cb_Atualizar_DataFim";
            this.cb_Atualizar_DataFim.Size = new System.Drawing.Size(115, 38);
            this.cb_Atualizar_DataFim.TabIndex = 4;
            this.cb_Atualizar_DataFim.Text = "Atualizar data\r\npelo servidor";
            this.cb_Atualizar_DataFim.UseVisualStyleBackColor = true;
            // 
            // Barra_inferior
            // 
            this.Barra_inferior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Barra_inferior.Controls.Add(this.tb_Quant_Itens_Por_Pagina);
            this.Barra_inferior.Controls.Add(this.label4);
            this.Barra_inferior.Controls.Add(this.flowLayoutPanel2);
            this.Barra_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Barra_inferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Barra_inferior.ForeColor = System.Drawing.Color.Black;
            this.Barra_inferior.Location = new System.Drawing.Point(0, 428);
            this.Barra_inferior.Margin = new System.Windows.Forms.Padding(0);
            this.Barra_inferior.Name = "Barra_inferior";
            this.Barra_inferior.Size = new System.Drawing.Size(880, 50);
            this.Barra_inferior.TabIndex = 3;
            this.Barra_inferior.TabStop = false;
            this.Barra_inferior.Text = "Navegação";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "itens por\r\npágina";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btn_ant);
            this.flowLayoutPanel2.Controls.Add(this.txt_pg);
            this.flowLayoutPanel2.Controls.Add(this.btn_prox);
            this.flowLayoutPanel2.Controls.Add(this.txt_Log);
            this.flowLayoutPanel2.Controls.Add(this.Txt_Cont_Selecao);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 16);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(635, 31);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_ant
            // 
            this.btn_ant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // txt_pg
            // 
            this.txt_pg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_pg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_pg.Location = new System.Drawing.Point(30, 0);
            this.txt_pg.Margin = new System.Windows.Forms.Padding(0);
            this.txt_pg.Name = "txt_pg";
            this.txt_pg.Size = new System.Drawing.Size(95, 30);
            this.txt_pg.TabIndex = 0;
            this.txt_pg.Text = "0/0";
            this.txt_pg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_pg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_prox
            // 
            this.btn_prox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prox.BackgroundImage = global::MultMap.Properties.Resources.ic_azul_seta_prox;
            this.btn_prox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_prox.FlatAppearance.BorderSize = 0;
            this.btn_prox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_prox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prox.Location = new System.Drawing.Point(125, 0);
            this.btn_prox.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(30, 30);
            this.btn_prox.TabIndex = 2;
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.Btn_prox_Click);
            this.btn_prox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Txt_Cont_Selecao
            // 
            this.Txt_Cont_Selecao.AutoEllipsis = true;
            this.Txt_Cont_Selecao.AutoSize = true;
            this.Txt_Cont_Selecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_Cont_Selecao.Location = new System.Drawing.Point(290, 0);
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
            this.Tabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabela.BackgroundColor = System.Drawing.Color.White;
            this.Tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tabela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Data,
            this.Funcionario,
            this.Motivo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabela.EnableHeadersVisualStyles = false;
            this.Tabela.GridColor = System.Drawing.Color.Gray;
            this.Tabela.Location = new System.Drawing.Point(0, 83);
            this.Tabela.Margin = new System.Windows.Forms.Padding(0);
            this.Tabela.MultiSelect = false;
            this.Tabela.Name = "Tabela";
            this.Tabela.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Tabela.Size = new System.Drawing.Size(880, 345);
            this.Tabela.TabIndex = 0;
            this.Tabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabela_CellClick);
            this.Tabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabela_CellDoubleClick);
            this.Tabela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tabela_KeyPress);
            this.Tabela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // Cb_SelecionarTudo
            // 
            this.Cb_SelecionarTudo.AutoSize = true;
            this.Cb_SelecionarTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.Cb_SelecionarTudo.Location = new System.Drawing.Point(13, 88);
            this.Cb_SelecionarTudo.Name = "Cb_SelecionarTudo";
            this.Cb_SelecionarTudo.Size = new System.Drawing.Size(15, 14);
            this.Cb_SelecionarTudo.TabIndex = 2;
            this.Cb_SelecionarTudo.UseVisualStyleBackColor = false;
            this.Cb_SelecionarTudo.CheckedChanged += new System.EventHandler(this.Selecionatudo_CheckedChanged);
            // 
            // Tb_Pesquisa
            // 
            this.Tb_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Pesquisa.BackColor = System.Drawing.Color.Azure;
            this.Tb_Pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Pesquisa.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_Pesquisa.ButtonIcon = null;
            this.Tb_Pesquisa.ButtonVisivel = false;
            this.Tb_Pesquisa.ButtonWidth = 27;
            this.Tb_Pesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Pesquisa.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_Pesquisa.Hint = "Pesquisar";
            this.Tb_Pesquisa.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_Pesquisa.Location = new System.Drawing.Point(587, 14);
            this.Tb_Pesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_Pesquisa.Name = "Tb_Pesquisa";
            this.Tb_Pesquisa.Size = new System.Drawing.Size(284, 27);
            this.Tb_Pesquisa.TabIndex = 2;
            this.Tb_Pesquisa.Tag = "";
            this.Tb_Pesquisa.TextChanged += new System.EventHandler(this.Tb_Pesquisa_TextChanged);
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
            this.tb_Quant_Itens_Por_Pagina.Location = new System.Drawing.Point(817, 16);
            this.tb_Quant_Itens_Por_Pagina.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Quant_Itens_Por_Pagina.Name = "tb_Quant_Itens_Por_Pagina";
            this.tb_Quant_Itens_Por_Pagina.Size = new System.Drawing.Size(54, 27);
            this.tb_Quant_Itens_Por_Pagina.TabIndex = 2;
            this.tb_Quant_Itens_Por_Pagina.Tag = "";
            this.tb_Quant_Itens_Por_Pagina.Text = "100";
            this.tb_Quant_Itens_Por_Pagina.TextChanged += new System.EventHandler(this.Tb_Quant_Itens_Por_Pagina_TextChanged);
            this.tb_Quant_Itens_Por_Pagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Quant_Itens_Por_Pagina_KeyPress);
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
            this.cabecalho1.Size = new System.Drawing.Size(880, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Histórico de Exclusão";
            // 
            // Selecionado
            // 
            this.Selecionado.HeaderText = "";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.ReadOnly = true;
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
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Funcionario
            // 
            this.Funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Funcionario.HeaderText = "Funcionário";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.ReadOnly = true;
            this.Funcionario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Motivo
            // 
            this.Motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tela_Historico_Exclusao
            // 
            this.ClientSize = new System.Drawing.Size(880, 478);
            this.Controls.Add(this.Cb_SelecionarTudo);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.Barra_menu_top);
            this.Controls.Add(this.Barra_inferior);
            this.Controls.Add(this.cabecalho1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Historico_Exclusao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Histrico de Exclusão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tela_Historico_Exclusao_FormClosing);
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
        private System.Windows.Forms.Label txt_Log;
        private System.Windows.Forms.Button btn_imprimir;
        public System.Windows.Forms.Button btn_atualizar;
        public System.Windows.Forms.GroupBox Barra_inferior;
        public System.Windows.Forms.Label txt_pg;
        public System.Windows.Forms.Button btn_ant;
        public System.Windows.Forms.Button btn_prox;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker DT_Fim;
        private System.Windows.Forms.DateTimePicker DT_Inicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_Atualizar_DataFim;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private Telas.Ferramentas.CustonTextBox Tb_Pesquisa;
        private Telas.Ferramentas.CustonTextBox tb_Quant_Itens_Por_Pagina;
        private System.Windows.Forms.CheckBox Cb_SelecionarTudo;
        private System.Windows.Forms.Label Txt_Cont_Selecao;
        private System.Windows.Forms.ProgressBar progressBarUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn _indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
    }
}