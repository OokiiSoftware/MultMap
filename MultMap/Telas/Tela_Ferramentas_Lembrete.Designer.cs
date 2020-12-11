namespace MultMap.Telas
{
    partial class Tela_Ferramentas_Lembrete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Ferramentas_Lembrete));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.time_Alarme = new System.Windows.Forms.DateTimePicker();
            this.lalerta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_alarme = new System.Windows.Forms.CheckBox();
            this.cb_fixar = new System.Windows.Forms.CheckBox();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Painel_Geral = new System.Windows.Forms.Panel();
            this.Txt_Log = new System.Windows.Forms.Label();
            this.TB_Destino = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.tb_texto = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.tb_titulo = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this._indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarme = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fixado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.Painel_Geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Teal;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_adicionar.Location = new System.Drawing.Point(40, 330);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(89, 28);
            this.btn_adicionar.TabIndex = 7;
            this.btn_adicionar.Text = "Novo";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            this.btn_adicionar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_atualizar.Location = new System.Drawing.Point(165, 330);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(89, 28);
            this.btn_atualizar.TabIndex = 8;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Visible = false;
            this.btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            this.btn_atualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_excluir.Location = new System.Drawing.Point(298, 330);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(89, 28);
            this.btn_excluir.TabIndex = 9;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            this.btn_excluir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // time_Alarme
            // 
            this.time_Alarme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.time_Alarme.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.time_Alarme.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.time_Alarme.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time_Alarme.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.time_Alarme.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.time_Alarme.CustomFormat = "00:00";
            this.time_Alarme.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.time_Alarme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_Alarme.Location = new System.Drawing.Point(165, 275);
            this.time_Alarme.Margin = new System.Windows.Forms.Padding(0);
            this.time_Alarme.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.time_Alarme.Name = "time_Alarme";
            this.time_Alarme.Size = new System.Drawing.Size(89, 24);
            this.time_Alarme.TabIndex = 5;
            this.time_Alarme.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.time_Alarme.Visible = false;
            this.time_Alarme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // lalerta
            // 
            this.lalerta.AutoSize = true;
            this.lalerta.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lalerta.Location = new System.Drawing.Point(57, 286);
            this.lalerta.Name = "lalerta";
            this.lalerta.Size = new System.Drawing.Size(54, 17);
            this.lalerta.TabIndex = 0;
            this.lalerta.Text = "Alarme";
            this.lalerta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label1.Location = new System.Drawing.Point(322, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fixar";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // cb_alarme
            // 
            this.cb_alarme.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_alarme.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_alarme;
            this.cb_alarme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cb_alarme.CausesValidation = false;
            this.cb_alarme.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_alarme.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cb_alarme.FlatAppearance.BorderSize = 0;
            this.cb_alarme.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.cb_alarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_alarme.Location = new System.Drawing.Point(59, 236);
            this.cb_alarme.Margin = new System.Windows.Forms.Padding(0);
            this.cb_alarme.Name = "cb_alarme";
            this.cb_alarme.Size = new System.Drawing.Size(50, 50);
            this.cb_alarme.TabIndex = 4;
            this.cb_alarme.UseMnemonic = false;
            this.cb_alarme.UseVisualStyleBackColor = false;
            this.cb_alarme.CheckedChanged += new System.EventHandler(this.Cb_alarme_CheckedChanged);
            this.cb_alarme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // cb_fixar
            // 
            this.cb_fixar.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_fixar.BackgroundImage = global::MultMap.Properties.Resources.ic_dock_pin;
            this.cb_fixar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cb_fixar.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_fixar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cb_fixar.FlatAppearance.BorderSize = 0;
            this.cb_fixar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.cb_fixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_fixar.Location = new System.Drawing.Point(317, 236);
            this.cb_fixar.Name = "cb_fixar";
            this.cb_fixar.Size = new System.Drawing.Size(50, 50);
            this.cb_fixar.TabIndex = 6;
            this.cb_fixar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cb_fixar.UseVisualStyleBackColor = false;
            this.cb_fixar.CheckedChanged += new System.EventHandler(this.Cb_fixar_CheckedChanged);
            this.cb_fixar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Tabela
            // 
            this.Tabela.AllowUserToAddRows = false;
            this.Tabela.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabela.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tabela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._indice,
            this.id,
            this.titulo,
            this.texto,
            this.alarme,
            this.fixado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabela.EnableHeadersVisualStyles = false;
            this.Tabela.GridColor = System.Drawing.Color.Gray;
            this.Tabela.Location = new System.Drawing.Point(442, 23);
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
            this.Tabela.RowTemplate.Height = 24;
            this.Tabela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(438, 352);
            this.Tabela.TabIndex = 0;
            this.Tabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabela_lembretes_CellClick);
            this.Tabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabela_lembretes_CellDoubleClick);
            this.Tabela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Painel_Geral
            // 
            this.Painel_Geral.Controls.Add(this.Txt_Log);
            this.Painel_Geral.Controls.Add(this.TB_Destino);
            this.Painel_Geral.Controls.Add(this.tb_texto);
            this.Painel_Geral.Controls.Add(this.tb_titulo);
            this.Painel_Geral.Controls.Add(this.cb_fixar);
            this.Painel_Geral.Controls.Add(this.label1);
            this.Painel_Geral.Controls.Add(this.cb_alarme);
            this.Painel_Geral.Controls.Add(this.lalerta);
            this.Painel_Geral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Geral.Location = new System.Drawing.Point(0, 23);
            this.Painel_Geral.Name = "Painel_Geral";
            this.Painel_Geral.Size = new System.Drawing.Size(880, 352);
            this.Painel_Geral.TabIndex = 0;
            this.Painel_Geral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Txt_Log
            // 
            this.Txt_Log.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.Txt_Log.Location = new System.Drawing.Point(19, 12);
            this.Txt_Log.Name = "Txt_Log";
            this.Txt_Log.Size = new System.Drawing.Size(397, 17);
            this.Txt_Log.TabIndex = 0;
            this.Txt_Log.Text = "Log";
            this.Txt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Txt_Log.Visible = false;
            // 
            // TB_Destino
            // 
            this.TB_Destino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Destino.BackColor = System.Drawing.Color.White;
            this.TB_Destino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Destino.ButtonColor = System.Drawing.Color.Empty;
            this.TB_Destino.ButtonIcon = null;
            this.TB_Destino.ButtonVisivel = false;
            this.TB_Destino.ButtonWidth = 27;
            this.TB_Destino.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.TB_Destino.Hint = "Destino (Opcional)";
            this.TB_Destino.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Destino.Location = new System.Drawing.Point(253, 38);
            this.TB_Destino.Margin = new System.Windows.Forms.Padding(0);
            this.TB_Destino.Name = "TB_Destino";
            this.TB_Destino.Size = new System.Drawing.Size(163, 27);
            this.TB_Destino.TabIndex = 2;
            this.TB_Destino.Tag = "";
            // 
            // tb_texto
            // 
            this.tb_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_texto.BackColor = System.Drawing.Color.White;
            this.tb_texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_texto.ButtonColor = System.Drawing.Color.Empty;
            this.tb_texto.ButtonIcon = null;
            this.tb_texto.ButtonVisivel = false;
            this.tb_texto.ButtonWidth = 27;
            this.tb_texto.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.tb_texto.Hint = "Texto";
            this.tb_texto.HintAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tb_texto.Location = new System.Drawing.Point(19, 90);
            this.tb_texto.Margin = new System.Windows.Forms.Padding(0);
            this.tb_texto.Multiline = true;
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_texto.Size = new System.Drawing.Size(397, 145);
            this.tb_texto.TabIndex = 3;
            this.tb_texto.Tag = "";
            this.tb_texto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // tb_titulo
            // 
            this.tb_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_titulo.BackColor = System.Drawing.Color.White;
            this.tb_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_titulo.ButtonColor = System.Drawing.Color.Empty;
            this.tb_titulo.ButtonIcon = null;
            this.tb_titulo.ButtonVisivel = false;
            this.tb_titulo.ButtonWidth = 27;
            this.tb_titulo.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.tb_titulo.Hint = "Assunto";
            this.tb_titulo.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_titulo.Location = new System.Drawing.Point(19, 38);
            this.tb_titulo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(225, 27);
            this.tb_titulo.TabIndex = 1;
            this.tb_titulo.Tag = "";
            this.tb_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
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
            this.cabecalho1.Text = "Lembretes";
            // 
            // _indice
            // 
            this._indice.HeaderText = "*";
            this._indice.Name = "_indice";
            this._indice.ReadOnly = true;
            this._indice.Width = 40;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // texto
            // 
            this.texto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.texto.HeaderText = "Texto";
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            // 
            // alarme
            // 
            this.alarme.HeaderText = "Alarme";
            this.alarme.Name = "alarme";
            this.alarme.ReadOnly = true;
            this.alarme.Width = 60;
            // 
            // fixado
            // 
            this.fixado.HeaderText = "Fixado";
            this.fixado.Name = "fixado";
            this.fixado.ReadOnly = true;
            this.fixado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fixado.Width = 60;
            // 
            // Tela_Ferramentas_Lembrete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(880, 375);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.time_Alarme);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.Painel_Geral);
            this.Controls.Add(this.cabecalho1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_Ferramentas_Lembrete";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Meus Lembretes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.Painel_Geral.ResumeLayout(false);
            this.Painel_Geral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DateTimePicker time_Alarme;
        private System.Windows.Forms.Label lalerta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_fixar;
        public System.Windows.Forms.CheckBox cb_alarme;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel Painel_Geral;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private Telas.Ferramentas.CustonTextBox tb_titulo;
        private Telas.Ferramentas.CustonTextBox tb_texto;
        private Ferramentas.CustonTextBox TB_Destino;
        private System.Windows.Forms.Label Txt_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn _indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn texto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alarme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fixado;
    }
}