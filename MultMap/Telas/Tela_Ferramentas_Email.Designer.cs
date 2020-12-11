namespace MultMap.Telas
{
    partial class Tela_Ferramentas_Email
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
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Btn_Add_File = new System.Windows.Forms.Button();
            this.Btn_LimparTudo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Files = new System.Windows.Forms.ListBox();
            this.Btn_Remove_Files = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tb_Corpo = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.Tb_Titulo = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.Tb_Destino = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.Txt_Log = new System.Windows.Forms.Label();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.Txt_EMAIL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Enviar.BackColor = System.Drawing.Color.Silver;
            this.Btn_Enviar.FlatAppearance.BorderSize = 0;
            this.Btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enviar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.Btn_Enviar.Location = new System.Drawing.Point(478, 366);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(120, 33);
            this.Btn_Enviar.TabIndex = 8;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.UseVisualStyleBackColor = false;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            this.Btn_Enviar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Btn_Add_File
            // 
            this.Btn_Add_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Add_File.BackColor = System.Drawing.Color.Silver;
            this.Btn_Add_File.FlatAppearance.BorderSize = 0;
            this.Btn_Add_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_File.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.Btn_Add_File.Location = new System.Drawing.Point(478, 70);
            this.Btn_Add_File.Name = "Btn_Add_File";
            this.Btn_Add_File.Size = new System.Drawing.Size(120, 30);
            this.Btn_Add_File.TabIndex = 5;
            this.Btn_Add_File.Text = "Adicionar";
            this.Btn_Add_File.UseVisualStyleBackColor = false;
            this.Btn_Add_File.Click += new System.EventHandler(this.Btn_Add_File_Click);
            this.Btn_Add_File.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Btn_LimparTudo
            // 
            this.Btn_LimparTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_LimparTudo.BackColor = System.Drawing.Color.Silver;
            this.Btn_LimparTudo.FlatAppearance.BorderSize = 0;
            this.Btn_LimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LimparTudo.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.Btn_LimparTudo.Location = new System.Drawing.Point(478, 10);
            this.Btn_LimparTudo.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_LimparTudo.Name = "Btn_LimparTudo";
            this.Btn_LimparTudo.Size = new System.Drawing.Size(120, 57);
            this.Btn_LimparTudo.TabIndex = 4;
            this.Btn_LimparTudo.Text = "Limpar campos";
            this.Btn_LimparTudo.UseVisualStyleBackColor = false;
            this.Btn_LimparTudo.Click += new System.EventHandler(this.Btn_LimparTudo_Click);
            this.Btn_LimparTudo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Lb_Files
            // 
            this.Lb_Files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Files.BackColor = System.Drawing.Color.Silver;
            this.Lb_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lb_Files.FormattingEnabled = true;
            this.Lb_Files.ItemHeight = 14;
            this.Lb_Files.Location = new System.Drawing.Point(478, 103);
            this.Lb_Files.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_Files.Name = "Lb_Files";
            this.Lb_Files.Size = new System.Drawing.Size(120, 210);
            this.Lb_Files.TabIndex = 6;
            this.Lb_Files.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Btn_Remove_Files
            // 
            this.Btn_Remove_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Remove_Files.BackColor = System.Drawing.Color.Silver;
            this.Btn_Remove_Files.FlatAppearance.BorderSize = 0;
            this.Btn_Remove_Files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Remove_Files.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.Btn_Remove_Files.Location = new System.Drawing.Point(478, 330);
            this.Btn_Remove_Files.Name = "Btn_Remove_Files";
            this.Btn_Remove_Files.Size = new System.Drawing.Size(120, 30);
            this.Btn_Remove_Files.TabIndex = 7;
            this.Btn_Remove_Files.Text = "Remover";
            this.Btn_Remove_Files.UseVisualStyleBackColor = false;
            this.Btn_Remove_Files.Click += new System.EventHandler(this.Btn_Remove_Files_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Tb_Corpo);
            this.panel1.Controls.Add(this.Tb_Titulo);
            this.panel1.Controls.Add(this.Tb_Destino);
            this.panel1.Controls.Add(this.Btn_Remove_Files);
            this.panel1.Controls.Add(this.Btn_Enviar);
            this.panel1.Controls.Add(this.Lb_Files);
            this.panel1.Controls.Add(this.Btn_LimparTudo);
            this.panel1.Controls.Add(this.Btn_Add_File);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 415);
            this.panel1.TabIndex = 0;
            // 
            // Tb_Corpo
            // 
            this.Tb_Corpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Corpo.BackColor = System.Drawing.Color.White;
            this.Tb_Corpo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Corpo.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_Corpo.ButtonIcon = null;
            this.Tb_Corpo.ButtonVisivel = false;
            this.Tb_Corpo.ButtonWidth = 27;
            this.Tb_Corpo.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_Corpo.Hint = "Mensagem...";
            this.Tb_Corpo.HintAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Tb_Corpo.Location = new System.Drawing.Point(16, 66);
            this.Tb_Corpo.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_Corpo.Multiline = true;
            this.Tb_Corpo.Name = "Tb_Corpo";
            this.Tb_Corpo.Size = new System.Drawing.Size(450, 326);
            this.Tb_Corpo.TabIndex = 3;
            this.Tb_Corpo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Tb_Titulo
            // 
            this.Tb_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Titulo.BackColor = System.Drawing.Color.White;
            this.Tb_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Titulo.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_Titulo.ButtonIcon = null;
            this.Tb_Titulo.ButtonVisivel = false;
            this.Tb_Titulo.ButtonWidth = 27;
            this.Tb_Titulo.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_Titulo.Hint = null;
            this.Tb_Titulo.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_Titulo.Location = new System.Drawing.Point(73, 37);
            this.Tb_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_Titulo.Name = "Tb_Titulo";
            this.Tb_Titulo.Size = new System.Drawing.Size(393, 20);
            this.Tb_Titulo.TabIndex = 2;
            this.Tb_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Tb_Destino
            // 
            this.Tb_Destino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Destino.BackColor = System.Drawing.Color.White;
            this.Tb_Destino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Destino.ButtonColor = System.Drawing.Color.Empty;
            this.Tb_Destino.ButtonIcon = null;
            this.Tb_Destino.ButtonVisivel = false;
            this.Tb_Destino.ButtonWidth = 27;
            this.Tb_Destino.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Tb_Destino.Hint = null;
            this.Tb_Destino.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tb_Destino.Location = new System.Drawing.Point(73, 11);
            this.Tb_Destino.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_Destino.Name = "Tb_Destino";
            this.Tb_Destino.Size = new System.Drawing.Size(393, 20);
            this.Tb_Destino.TabIndex = 1;
            this.Tb_Destino.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Txt_Log
            // 
            this.Txt_Log.AutoSize = true;
            this.Txt_Log.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Txt_Log.Location = new System.Drawing.Point(163, 0);
            this.Txt_Log.Name = "Txt_Log";
            this.Txt_Log.Size = new System.Drawing.Size(36, 19);
            this.Txt_Log.TabIndex = 0;
            this.Txt_Log.Text = "Log";
            this.Txt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Txt_Log.Visible = false;
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
            this.cabecalho1.Size = new System.Drawing.Size(610, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Email";
            // 
            // Txt_EMAIL
            // 
            this.Txt_EMAIL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_EMAIL.AutoSize = true;
            this.Txt_EMAIL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.Txt_EMAIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Txt_EMAIL.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EMAIL.ForeColor = System.Drawing.Color.Aqua;
            this.Txt_EMAIL.Location = new System.Drawing.Point(7, -1);
            this.Txt_EMAIL.Name = "Txt_EMAIL";
            this.Txt_EMAIL.Size = new System.Drawing.Size(60, 23);
            this.Txt_EMAIL.TabIndex = 0;
            this.Txt_EMAIL.Text = "alerta";
            this.Txt_EMAIL.Visible = false;
            // 
            // Tela_Ferramentas_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(610, 438);
            this.Controls.Add(this.cabecalho1);
            this.Controls.Add(this.Txt_Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_EMAIL);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Tela_Ferramentas_Email";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Email";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Enviar;
        private System.Windows.Forms.Button Btn_Add_File;
        private System.Windows.Forms.Button Btn_LimparTudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Lb_Files;
        private System.Windows.Forms.Button Btn_Remove_Files;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Txt_Log;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private Telas.Ferramentas.CustonTextBox Tb_Corpo;
        private Telas.Ferramentas.CustonTextBox Tb_Titulo;
        private Telas.Ferramentas.CustonTextBox Tb_Destino;
        private System.Windows.Forms.Label Txt_EMAIL;
    }
}