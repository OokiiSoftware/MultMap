namespace MultMap.Telas
{
    partial class Tela_Ferramentas_Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Ferramentas_Map));
            this.cb_Calcular_Distancia = new System.Windows.Forms.CheckBox();
            this.Pmap = new System.Windows.Forms.Panel();
            this.Painel_Alerta_Manutencao = new MultMap.Telas.Ferramentas.PanelGradient();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_Manutencao = new MultMap.Telas.Ferramentas.CustomCheckBox();
            this.Flow_CaixasManutencao = new MultMap.Telas.Ferramentas.FlowGradiente();
            this.panelGradient1 = new MultMap.Telas.Ferramentas.PanelGradient();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Pesquisa = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.btn_Map_Type = new MultMap.Telas.Ferramentas.CustomLabel();
            this.btn_Remover_Marcadores_Temporarios = new MultMap.Telas.Ferramentas.CustomLabel();
            this.txt_Log = new MultMap.Telas.Ferramentas.CustomLabel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.Pmap.SuspendLayout();
            this.Painel_Alerta_Manutencao.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Calcular_Distancia
            // 
            this.cb_Calcular_Distancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Calcular_Distancia.AutoSize = true;
            this.cb_Calcular_Distancia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_Calcular_Distancia.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Calcular_Distancia.Location = new System.Drawing.Point(722, 405);
            this.cb_Calcular_Distancia.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cb_Calcular_Distancia.Name = "cb_Calcular_Distancia";
            this.cb_Calcular_Distancia.Padding = new System.Windows.Forms.Padding(3);
            this.cb_Calcular_Distancia.Size = new System.Drawing.Size(129, 26);
            this.cb_Calcular_Distancia.TabIndex = 6;
            this.cb_Calcular_Distancia.Text = "Medir Distancias";
            this.cb_Calcular_Distancia.UseVisualStyleBackColor = false;
            this.cb_Calcular_Distancia.Visible = false;
            this.cb_Calcular_Distancia.CheckedChanged += new System.EventHandler(this.Cb_calcular_distancia_CheckedChanged);
            this.cb_Calcular_Distancia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Pmap
            // 
            this.Pmap.Controls.Add(this.Painel_Alerta_Manutencao);
            this.Pmap.Controls.Add(this.Flow_CaixasManutencao);
            this.Pmap.Controls.Add(this.panelGradient1);
            this.Pmap.Controls.Add(this.Tb_Pesquisa);
            this.Pmap.Controls.Add(this.btn_Map_Type);
            this.Pmap.Controls.Add(this.cb_Calcular_Distancia);
            this.Pmap.Controls.Add(this.btn_Remover_Marcadores_Temporarios);
            this.Pmap.Controls.Add(this.txt_Log);
            this.Pmap.Controls.Add(this.map);
            this.Pmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pmap.Location = new System.Drawing.Point(0, 23);
            this.Pmap.Margin = new System.Windows.Forms.Padding(2);
            this.Pmap.Name = "Pmap";
            this.Pmap.Size = new System.Drawing.Size(880, 455);
            this.Pmap.TabIndex = 16;
            // 
            // Painel_Alerta_Manutencao
            // 
            this.Painel_Alerta_Manutencao.colorBoton = System.Drawing.Color.White;
            this.Painel_Alerta_Manutencao.colorTop = System.Drawing.Color.White;
            this.Painel_Alerta_Manutencao.Controls.Add(this.label9);
            this.Painel_Alerta_Manutencao.Controls.Add(this.CB_Manutencao);
            this.Painel_Alerta_Manutencao.Location = new System.Drawing.Point(17, 74);
            this.Painel_Alerta_Manutencao.Name = "Painel_Alerta_Manutencao";
            this.Painel_Alerta_Manutencao.Radio = 10;
            this.Painel_Alerta_Manutencao.Size = new System.Drawing.Size(159, 39);
            this.Painel_Alerta_Manutencao.TabIndex = 2;
            this.Painel_Alerta_Manutencao.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Manutenção";
            // 
            // CB_Manutencao
            // 
            this.CB_Manutencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CB_Manutencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Manutencao.Location = new System.Drawing.Point(11, 10);
            this.CB_Manutencao.Margin = new System.Windows.Forms.Padding(0);
            this.CB_Manutencao.Name = "CB_Manutencao";
            this.CB_Manutencao.Radio = 10;
            this.CB_Manutencao.Selecionado = false;
            this.CB_Manutencao.SelecionadoFalse = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CB_Manutencao.SelecionadoTrue = System.Drawing.Color.Silver;
            this.CB_Manutencao.Size = new System.Drawing.Size(20, 20);
            this.CB_Manutencao.TabIndex = 1;
            this.CB_Manutencao.Text = "customCheckBox1";
            this.CB_Manutencao.Click += new System.EventHandler(this.CB_Manutencao_Click);
            // 
            // Flow_CaixasManutencao
            // 
            this.Flow_CaixasManutencao.AutoScroll = true;
            this.Flow_CaixasManutencao.colorBoton = System.Drawing.Color.White;
            this.Flow_CaixasManutencao.colorTop = System.Drawing.Color.White;
            this.Flow_CaixasManutencao.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flow_CaixasManutencao.Location = new System.Drawing.Point(17, 119);
            this.Flow_CaixasManutencao.MaximumSize = new System.Drawing.Size(178, 272);
            this.Flow_CaixasManutencao.Name = "Flow_CaixasManutencao";
            this.Flow_CaixasManutencao.Radio = 10;
            this.Flow_CaixasManutencao.Size = new System.Drawing.Size(178, 10);
            this.Flow_CaixasManutencao.TabIndex = 3;
            this.Flow_CaixasManutencao.Visible = false;
            this.Flow_CaixasManutencao.WrapContents = false;
            // 
            // panelGradient1
            // 
            this.panelGradient1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelGradient1.colorBoton = System.Drawing.Color.Empty;
            this.panelGradient1.colorTop = System.Drawing.Color.Empty;
            this.panelGradient1.Controls.Add(this.label8);
            this.panelGradient1.Controls.Add(this.label6);
            this.panelGradient1.Controls.Add(this.label7);
            this.panelGradient1.Controls.Add(this.label4);
            this.panelGradient1.Controls.Add(this.label5);
            this.panelGradient1.Controls.Add(this.label3);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Location = new System.Drawing.Point(17, 397);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Radio = 10;
            this.panelGradient1.Size = new System.Drawing.Size(474, 34);
            this.panelGradient1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Livre (GPon)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manutenção";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(355, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 10);
            this.label7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cheio";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(273, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 10);
            this.label5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(148, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 10);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Livre (PacPon)";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 10);
            this.label1.TabIndex = 0;
            // 
            // Tb_Pesquisa
            // 
            this.Tb_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Pesquisa.BackColor = System.Drawing.Color.White;
            this.Tb_Pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Pesquisa.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_Pesquisa.ButtonIcon = null;
            this.Tb_Pesquisa.ButtonVisivel = false;
            this.Tb_Pesquisa.ButtonWidth = 27;
            this.Tb_Pesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Pesquisa.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_Pesquisa.Hint = "Pesquisar";
            this.Tb_Pesquisa.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_Pesquisa.Location = new System.Drawing.Point(567, 17);
            this.Tb_Pesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_Pesquisa.Name = "Tb_Pesquisa";
            this.Tb_Pesquisa.Size = new System.Drawing.Size(284, 20);
            this.Tb_Pesquisa.TabIndex = 1;
            this.Tb_Pesquisa.Tag = "";
            this.Tb_Pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_pesquisa_KeyDown);
            this.Tb_Pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_pesquisa_KeyPress);
            this.Tb_Pesquisa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_Map_Type
            // 
            this.btn_Map_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Map_Type.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btn_Map_Type.Location = new System.Drawing.Point(769, 377);
            this.btn_Map_Type.Name = "btn_Map_Type";
            this.btn_Map_Type.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Map_Type.Radio = 10;
            this.btn_Map_Type.Size = new System.Drawing.Size(82, 23);
            this.btn_Map_Type.TabIndex = 5;
            this.btn_Map_Type.Text = "Mapa";
            this.btn_Map_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Map_Type.Click += new System.EventHandler(this.Btn_map_type_Click);
            this.btn_Map_Type.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_Remover_Marcadores_Temporarios
            // 
            this.btn_Remover_Marcadores_Temporarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remover_Marcadores_Temporarios.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btn_Remover_Marcadores_Temporarios.Location = new System.Drawing.Point(769, 316);
            this.btn_Remover_Marcadores_Temporarios.Name = "btn_Remover_Marcadores_Temporarios";
            this.btn_Remover_Marcadores_Temporarios.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Remover_Marcadores_Temporarios.Radio = 10;
            this.btn_Remover_Marcadores_Temporarios.Size = new System.Drawing.Size(82, 56);
            this.btn_Remover_Marcadores_Temporarios.TabIndex = 4;
            this.btn_Remover_Marcadores_Temporarios.Text = "Remover Marcadores Temporarios";
            this.btn_Remover_Marcadores_Temporarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Remover_Marcadores_Temporarios.Visible = false;
            this.btn_Remover_Marcadores_Temporarios.Click += new System.EventHandler(this.Btn_remover_marcadores_temporarios_Click);
            this.btn_Remover_Marcadores_Temporarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // txt_Log
            // 
            this.txt_Log.AutoSize = true;
            this.txt_Log.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txt_Log.Location = new System.Drawing.Point(13, 17);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Padding = new System.Windows.Forms.Padding(8);
            this.txt_Log.Radio = 10;
            this.txt_Log.Size = new System.Drawing.Size(164, 54);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "Carregando dados.\r\nPor favor, aguarde";
            this.txt_Log.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.White;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Transparent;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Margin = new System.Windows.Forms.Padding(0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 20;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(880, 455);
            this.map.TabIndex = 0;
            this.map.Zoom = 9D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.Map_OnMarkerClick);
            this.map.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.Map_OnMarkerEnter);
            this.map.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.Map_OnMarkerLeave);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Map_MouseClick);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Map_MouseDoubleClick);
            this.map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map_MouseDown);
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            this.map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Map_MouseUp);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.Btn_Atualizar.BackgroundImage = global::MultMap.Properties.Resources.ic_branco_atualizar;
            this.Btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Atualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Atualizar.Location = new System.Drawing.Point(793, 2);
            this.Btn_Atualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(20, 20);
            this.Btn_Atualizar.TabIndex = 7;
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
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
            this.cabecalho1.Text = "Google Maps";
            // 
            // Tela_Ferramentas_Map
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 478);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Pmap);
            this.Controls.Add(this.cabecalho1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tela_Ferramentas_Map";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Google Maps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tela_Ferramentas_Map_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.Pmap.ResumeLayout(false);
            this.Pmap.PerformLayout();
            this.Painel_Alerta_Manutencao.ResumeLayout(false);
            this.Painel_Alerta_Manutencao.PerformLayout();
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.CheckBox cb_Calcular_Distancia;
        private System.Windows.Forms.Panel Pmap;
        private Telas.Ferramentas.CustomLabel btn_Map_Type;
        private Telas.Ferramentas.CustomLabel btn_Remover_Marcadores_Temporarios;
        private Telas.Ferramentas.CustomLabel txt_Log;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private Telas.Ferramentas.CustonTextBox Tb_Pesquisa;
        private System.Windows.Forms.Button Btn_Atualizar;
        private Ferramentas.PanelGradient panelGradient1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Ferramentas.FlowGradiente Flow_CaixasManutencao;
        private Ferramentas.PanelGradient Painel_Alerta_Manutencao;
        private System.Windows.Forms.Label label9;
        private Ferramentas.CustomCheckBox CB_Manutencao;
    }
}