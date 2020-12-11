namespace MultMap.Telas
{
    partial class Tela_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_User));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_limpar_campos = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txt_Log = new System.Windows.Forms.Label();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Painel_Geral = new System.Windows.Forms.Panel();
            this.Btn_PerfilAlterar = new System.Windows.Forms.Button();
            this.Btn_VerPerfil = new System.Windows.Forms.Button();
            this.Btn_PerfilRemover = new System.Windows.Forms.Button();
            this.Btn_PerfilAdd = new System.Windows.Forms.Button();
            this.CB_Perfil = new System.Windows.Forms.ComboBox();
            this.cb_Pesquisa = new System.Windows.Forms.CheckBox();
            this.cb_AlterarSenha = new System.Windows.Forms.CheckBox();
            this.tb_confirmar_senha = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.tb_senha = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.tb_usuario = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.tb_nome = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.Linha_5 = new System.Windows.Forms.Panel();
            this.Linha_4 = new System.Windows.Forms.Panel();
            this.Linha_3 = new System.Windows.Forms.Panel();
            this.Linha_2 = new System.Windows.Forms.Panel();
            this.Linha_1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.img_Foto = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.cabecalho1 = new MultMap.Telas.Exemplos.Cabecalho();
            this.Painel_Geral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cadastrar.BackColor = System.Drawing.Color.Lime;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(96, 308);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(176, 28);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Adicionar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            this.btn_cadastrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_limpar_campos
            // 
            this.btn_limpar_campos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpar_campos.BackColor = System.Drawing.Color.Peru;
            this.btn_limpar_campos.FlatAppearance.BorderSize = 0;
            this.btn_limpar_campos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar_campos.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_limpar_campos.ForeColor = System.Drawing.Color.White;
            this.btn_limpar_campos.Location = new System.Drawing.Point(276, 285);
            this.btn_limpar_campos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpar_campos.Name = "btn_limpar_campos";
            this.btn_limpar_campos.Size = new System.Drawing.Size(105, 28);
            this.btn_limpar_campos.TabIndex = 14;
            this.btn_limpar_campos.Text = "Limpar Campos";
            this.btn_limpar_campos.UseVisualStyleBackColor = false;
            this.btn_limpar_campos.Visible = false;
            this.btn_limpar_campos.Click += new System.EventHandler(this.Btn_limpar_campos_Click);
            this.btn_limpar_campos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_excluir.BackColor = System.Drawing.Color.Maroon;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(11, 285);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(81, 28);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            this.btn_excluir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // txt_Log
            // 
            this.txt_Log.Enabled = false;
            this.txt_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_Log.Location = new System.Drawing.Point(50, 2);
            this.txt_Log.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(303, 20);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "Carregando dados..";
            this.txt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Log.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.BackColor = System.Drawing.Color.White;
            this.tb_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Telefone.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.tb_Telefone.ForeColor = System.Drawing.Color.Silver;
            this.tb_Telefone.Location = new System.Drawing.Point(226, 73);
            this.tb_Telefone.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Telefone.Mask = "(99) 00000-0000";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(155, 26);
            this.tb_Telefone.TabIndex = 3;
            this.tb_Telefone.Enter += new System.EventHandler(this.Tb_telefone_Enter);
            this.tb_Telefone.Leave += new System.EventHandler(this.Tb_telefone_Leave);
            this.tb_Telefone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Painel_Geral
            // 
            this.Painel_Geral.BackColor = System.Drawing.Color.Gainsboro;
            this.Painel_Geral.Controls.Add(this.Btn_PerfilAlterar);
            this.Painel_Geral.Controls.Add(this.Btn_VerPerfil);
            this.Painel_Geral.Controls.Add(this.Btn_PerfilRemover);
            this.Painel_Geral.Controls.Add(this.Btn_PerfilAdd);
            this.Painel_Geral.Controls.Add(this.CB_Perfil);
            this.Painel_Geral.Controls.Add(this.cb_Pesquisa);
            this.Painel_Geral.Controls.Add(this.cb_AlterarSenha);
            this.Painel_Geral.Controls.Add(this.btn_limpar_campos);
            this.Painel_Geral.Controls.Add(this.tb_confirmar_senha);
            this.Painel_Geral.Controls.Add(this.tb_senha);
            this.Painel_Geral.Controls.Add(this.txt_Log);
            this.Painel_Geral.Controls.Add(this.tb_usuario);
            this.Painel_Geral.Controls.Add(this.tb_nome);
            this.Painel_Geral.Controls.Add(this.Linha_5);
            this.Painel_Geral.Controls.Add(this.Linha_4);
            this.Painel_Geral.Controls.Add(this.Linha_3);
            this.Painel_Geral.Controls.Add(this.Linha_2);
            this.Painel_Geral.Controls.Add(this.tb_Telefone);
            this.Painel_Geral.Controls.Add(this.Linha_1);
            this.Painel_Geral.Controls.Add(this.btn_excluir);
            this.Painel_Geral.Controls.Add(this.shapeContainer1);
            this.Painel_Geral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Geral.Location = new System.Drawing.Point(0, 23);
            this.Painel_Geral.Name = "Painel_Geral";
            this.Painel_Geral.Size = new System.Drawing.Size(777, 322);
            this.Painel_Geral.TabIndex = 0;
            this.Painel_Geral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Btn_PerfilAlterar
            // 
            this.Btn_PerfilAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_PerfilAlterar.BackColor = System.Drawing.Color.White;
            this.Btn_PerfilAlterar.FlatAppearance.BorderSize = 0;
            this.Btn_PerfilAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PerfilAlterar.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Btn_PerfilAlterar.Location = new System.Drawing.Point(195, 220);
            this.Btn_PerfilAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PerfilAlterar.Name = "Btn_PerfilAlterar";
            this.Btn_PerfilAlterar.Size = new System.Drawing.Size(68, 25);
            this.Btn_PerfilAlterar.TabIndex = 19;
            this.Btn_PerfilAlterar.Text = "Editar";
            this.Btn_PerfilAlterar.UseVisualStyleBackColor = false;
            this.Btn_PerfilAlterar.Click += new System.EventHandler(this.Btn_PerfilAlterar_Click);
            // 
            // Btn_VerPerfil
            // 
            this.Btn_VerPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_VerPerfil.BackColor = System.Drawing.Color.White;
            this.Btn_VerPerfil.FlatAppearance.BorderSize = 0;
            this.Btn_VerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VerPerfil.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Btn_VerPerfil.Location = new System.Drawing.Point(281, 217);
            this.Btn_VerPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_VerPerfil.Name = "Btn_VerPerfil";
            this.Btn_VerPerfil.Size = new System.Drawing.Size(100, 31);
            this.Btn_VerPerfil.TabIndex = 18;
            this.Btn_VerPerfil.Text = "Ver Perfil";
            this.Btn_VerPerfil.UseVisualStyleBackColor = false;
            this.Btn_VerPerfil.Visible = false;
            this.Btn_VerPerfil.Click += new System.EventHandler(this.Btn_VerPerfil_Click);
            // 
            // Btn_PerfilRemover
            // 
            this.Btn_PerfilRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_PerfilRemover.BackColor = System.Drawing.Color.White;
            this.Btn_PerfilRemover.FlatAppearance.BorderSize = 0;
            this.Btn_PerfilRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PerfilRemover.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Btn_PerfilRemover.Location = new System.Drawing.Point(137, 220);
            this.Btn_PerfilRemover.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PerfilRemover.Name = "Btn_PerfilRemover";
            this.Btn_PerfilRemover.Size = new System.Drawing.Size(25, 25);
            this.Btn_PerfilRemover.TabIndex = 17;
            this.Btn_PerfilRemover.Text = "-";
            this.Btn_PerfilRemover.UseVisualStyleBackColor = false;
            this.Btn_PerfilRemover.Click += new System.EventHandler(this.Btn_PerfilRemover_Click);
            // 
            // Btn_PerfilAdd
            // 
            this.Btn_PerfilAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_PerfilAdd.BackColor = System.Drawing.Color.White;
            this.Btn_PerfilAdd.FlatAppearance.BorderSize = 0;
            this.Btn_PerfilAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PerfilAdd.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Btn_PerfilAdd.Location = new System.Drawing.Point(166, 220);
            this.Btn_PerfilAdd.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PerfilAdd.Name = "Btn_PerfilAdd";
            this.Btn_PerfilAdd.Size = new System.Drawing.Size(25, 25);
            this.Btn_PerfilAdd.TabIndex = 16;
            this.Btn_PerfilAdd.Text = "+";
            this.Btn_PerfilAdd.UseVisualStyleBackColor = false;
            this.Btn_PerfilAdd.Click += new System.EventHandler(this.Btn_PerfilAdd_Click);
            // 
            // CB_Perfil
            // 
            this.CB_Perfil.FormattingEnabled = true;
            this.CB_Perfil.Location = new System.Drawing.Point(11, 220);
            this.CB_Perfil.Name = "CB_Perfil";
            this.CB_Perfil.Size = new System.Drawing.Size(121, 25);
            this.CB_Perfil.TabIndex = 15;
            // 
            // cb_Pesquisa
            // 
            this.cb_Pesquisa.AutoSize = true;
            this.cb_Pesquisa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_Pesquisa.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cb_Pesquisa.Location = new System.Drawing.Point(299, 253);
            this.cb_Pesquisa.Name = "cb_Pesquisa";
            this.cb_Pesquisa.Size = new System.Drawing.Size(82, 21);
            this.cb_Pesquisa.TabIndex = 11;
            this.cb_Pesquisa.Text = "Pesquisar";
            this.cb_Pesquisa.UseVisualStyleBackColor = true;
            this.cb_Pesquisa.CheckedChanged += new System.EventHandler(this.Cb_Pesquisa_CheckedChanged);
            this.cb_Pesquisa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // cb_AlterarSenha
            // 
            this.cb_AlterarSenha.AutoSize = true;
            this.cb_AlterarSenha.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cb_AlterarSenha.Location = new System.Drawing.Point(11, 253);
            this.cb_AlterarSenha.Name = "cb_AlterarSenha";
            this.cb_AlterarSenha.Size = new System.Drawing.Size(108, 21);
            this.cb_AlterarSenha.TabIndex = 10;
            this.cb_AlterarSenha.Text = "Alterar Senha";
            this.cb_AlterarSenha.UseVisualStyleBackColor = true;
            this.cb_AlterarSenha.Visible = false;
            this.cb_AlterarSenha.CheckedChanged += new System.EventHandler(this.Cb_AlterarSenha_CheckedChanged);
            this.cb_AlterarSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // tb_confirmar_senha
            // 
            this.tb_confirmar_senha.BackColor = System.Drawing.Color.White;
            this.tb_confirmar_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirmar_senha.ButtonColor = System.Drawing.Color.Empty;
            this.tb_confirmar_senha.ButtonIcon = null;
            this.tb_confirmar_senha.ButtonVisivel = false;
            this.tb_confirmar_senha.ButtonWidth = 27;
            this.tb_confirmar_senha.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.tb_confirmar_senha.Hint = "Confirmar senha";
            this.tb_confirmar_senha.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_confirmar_senha.Location = new System.Drawing.Point(11, 167);
            this.tb_confirmar_senha.Margin = new System.Windows.Forms.Padding(0);
            this.tb_confirmar_senha.Name = "tb_confirmar_senha";
            this.tb_confirmar_senha.Size = new System.Drawing.Size(252, 25);
            this.tb_confirmar_senha.TabIndex = 5;
            this.tb_confirmar_senha.UseSystemPasswordChar = true;
            this.tb_confirmar_senha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // tb_senha
            // 
            this.tb_senha.BackColor = System.Drawing.Color.White;
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_senha.ButtonColor = System.Drawing.Color.Empty;
            this.tb_senha.ButtonIcon = null;
            this.tb_senha.ButtonVisivel = false;
            this.tb_senha.ButtonWidth = 27;
            this.tb_senha.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.tb_senha.Hint = "Senha";
            this.tb_senha.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_senha.Location = new System.Drawing.Point(11, 120);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(0);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(252, 25);
            this.tb_senha.TabIndex = 4;
            this.tb_senha.UseSystemPasswordChar = true;
            this.tb_senha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // tb_usuario
            // 
            this.tb_usuario.BackColor = System.Drawing.Color.White;
            this.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_usuario.ButtonColor = System.Drawing.Color.Empty;
            this.tb_usuario.ButtonIcon = null;
            this.tb_usuario.ButtonVisivel = false;
            this.tb_usuario.ButtonWidth = 27;
            this.tb_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tb_usuario.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.tb_usuario.Hint = "Usuário";
            this.tb_usuario.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_usuario.Location = new System.Drawing.Point(11, 74);
            this.tb_usuario.Margin = new System.Windows.Forms.Padding(0);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(202, 25);
            this.tb_usuario.TabIndex = 2;
            this.tb_usuario.Tag = "Este dado não poderá ser alterado futuramente";
            this.tb_usuario.TextChanged += new System.EventHandler(this.Tb_usuario_OnValueChanged);
            this.tb_usuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.Color.White;
            this.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nome.ButtonColor = System.Drawing.Color.Empty;
            this.tb_nome.ButtonIcon = null;
            this.tb_nome.ButtonVisivel = false;
            this.tb_nome.ButtonWidth = 27;
            this.tb_nome.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.tb_nome.Hint = "Nome Completo";
            this.tb_nome.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_nome.Location = new System.Drawing.Point(11, 29);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(370, 25);
            this.tb_nome.TabIndex = 1;
            this.tb_nome.Tag = "Este dado não poderá ser alterado futuramente";
            this.tb_nome.TextChanged += new System.EventHandler(this.Tb_nome_OnValueChanged);
            this.tb_nome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // Linha_5
            // 
            this.Linha_5.BackColor = System.Drawing.Color.Black;
            this.Linha_5.Location = new System.Drawing.Point(11, 192);
            this.Linha_5.Margin = new System.Windows.Forms.Padding(0);
            this.Linha_5.Name = "Linha_5";
            this.Linha_5.Size = new System.Drawing.Size(252, 1);
            this.Linha_5.TabIndex = 0;
            // 
            // Linha_4
            // 
            this.Linha_4.BackColor = System.Drawing.Color.Black;
            this.Linha_4.Location = new System.Drawing.Point(11, 145);
            this.Linha_4.Margin = new System.Windows.Forms.Padding(0);
            this.Linha_4.Name = "Linha_4";
            this.Linha_4.Size = new System.Drawing.Size(252, 1);
            this.Linha_4.TabIndex = 0;
            // 
            // Linha_3
            // 
            this.Linha_3.BackColor = System.Drawing.Color.Black;
            this.Linha_3.Location = new System.Drawing.Point(226, 98);
            this.Linha_3.Margin = new System.Windows.Forms.Padding(0);
            this.Linha_3.Name = "Linha_3";
            this.Linha_3.Size = new System.Drawing.Size(155, 1);
            this.Linha_3.TabIndex = 0;
            // 
            // Linha_2
            // 
            this.Linha_2.BackColor = System.Drawing.Color.Black;
            this.Linha_2.Location = new System.Drawing.Point(11, 99);
            this.Linha_2.Margin = new System.Windows.Forms.Padding(0);
            this.Linha_2.Name = "Linha_2";
            this.Linha_2.Size = new System.Drawing.Size(202, 1);
            this.Linha_2.TabIndex = 0;
            // 
            // Linha_1
            // 
            this.Linha_1.BackColor = System.Drawing.Color.Black;
            this.Linha_1.Location = new System.Drawing.Point(11, 54);
            this.Linha_1.Margin = new System.Windows.Forms.Padding(0);
            this.Linha_1.Name = "Linha_1";
            this.Linha_1.Size = new System.Drawing.Size(370, 1);
            this.Linha_1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.img_Foto});
            this.shapeContainer1.Size = new System.Drawing.Size(777, 322);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // img_Foto
            // 
            this.img_Foto.BackgroundImage = global::MultMap.Properties.Resources.ic_branco_user;
            this.img_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_Foto.FillColor = System.Drawing.Color.White;
            this.img_Foto.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.img_Foto.Location = new System.Drawing.Point(281, 110);
            this.img_Foto.Name = "img_Foto";
            this.img_Foto.Size = new System.Drawing.Size(100, 100);
            this.img_Foto.Visible = false;
            this.img_Foto.Click += new System.EventHandler(this.Img_Foto_Click);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.Btn_Atualizar.BackgroundImage = global::MultMap.Properties.Resources.ic_branco_atualizar;
            this.Btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Atualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Atualizar.Location = new System.Drawing.Point(708, 2);
            this.Btn_Atualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(20, 20);
            this.Btn_Atualizar.TabIndex = 15;
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Usuário";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // _indice
            // 
            this._indice.HeaderText = "*";
            this._indice.Name = "_indice";
            this._indice.ReadOnly = true;
            this._indice.Width = 40;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._indice,
            this.id,
            this.dataGridViewTextBoxColumn2,
            this.Column9,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabela.EnableHeadersVisualStyles = false;
            this.Tabela.GridColor = System.Drawing.Color.Gray;
            this.Tabela.Location = new System.Drawing.Point(393, 23);
            this.Tabela.Margin = new System.Windows.Forms.Padding(0);
            this.Tabela.MultiSelect = false;
            this.Tabela.Name = "Tabela";
            this.Tabela.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
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
            this.Tabela.Size = new System.Drawing.Size(384, 345);
            this.Tabela.TabIndex = 0;
            this.Tabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabela_CellClick);
            this.Tabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabela_CellDoubleClick);
            this.Tabela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
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
            this.cabecalho1.Size = new System.Drawing.Size(777, 23);
            this.cabecalho1.TabIndex = 0;
            this.cabecalho1.Tema = MultMap.Telas.Exemplos.Cabecalho._Tema.Dark;
            this.cabecalho1.Text = "Funcionários";
            // 
            // Tela_User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(777, 345);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.Painel_Geral);
            this.Controls.Add(this.cabecalho1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Tela_User";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tela_User_Add_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.Painel_Geral.ResumeLayout(false);
            this.Painel_Geral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_limpar_campos;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label txt_Log;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.Panel Painel_Geral;
        private System.Windows.Forms.Panel Linha_1;
        private System.Windows.Forms.Panel Linha_5;
        private System.Windows.Forms.Panel Linha_4;
        private System.Windows.Forms.Panel Linha_3;
        private System.Windows.Forms.Panel Linha_2;
        private Telas.Exemplos.Cabecalho cabecalho1;
        private System.Windows.Forms.Button Btn_Atualizar;
        private Telas.Ferramentas.CustonTextBox tb_nome;
        private Telas.Ferramentas.CustonTextBox tb_confirmar_senha;
        private Telas.Ferramentas.CustonTextBox tb_senha;
        private Telas.Ferramentas.CustonTextBox tb_usuario;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn _indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.CheckBox cb_Pesquisa;
        private System.Windows.Forms.CheckBox cb_AlterarSenha;
        private System.Windows.Forms.ComboBox CB_Perfil;
        private System.Windows.Forms.Button Btn_PerfilRemover;
        private System.Windows.Forms.Button Btn_PerfilAdd;
        private System.Windows.Forms.Button Btn_VerPerfil;
        private System.Windows.Forms.Button Btn_PerfilAlterar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape img_Foto;
    }
}