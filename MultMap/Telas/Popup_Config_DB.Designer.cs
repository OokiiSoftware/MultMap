namespace Meu_Terminal
{
    partial class Popup_Config_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup_Config_DB));
            this.tb_servidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_banco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntconecta = new System.Windows.Forms.Button();
            this.bntsalva = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Borda_Tela = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // tb_servidor
            // 
            this.tb_servidor.Location = new System.Drawing.Point(74, 48);
            this.tb_servidor.Margin = new System.Windows.Forms.Padding(2);
            this.tb_servidor.Name = "tb_servidor";
            this.tb_servidor.Size = new System.Drawing.Size(228, 20);
            this.tb_servidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(74, 80);
            this.tb_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(228, 20);
            this.tb_usuario.TabIndex = 2;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(74, 113);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(2);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(228, 20);
            this.tb_senha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senha:";
            // 
            // tb_banco
            // 
            this.tb_banco.Location = new System.Drawing.Point(74, 145);
            this.tb_banco.Margin = new System.Windows.Forms.Padding(2);
            this.tb_banco.Name = "tb_banco";
            this.tb_banco.Size = new System.Drawing.Size(228, 20);
            this.tb_banco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Banco:";
            // 
            // bntconecta
            // 
            this.bntconecta.Location = new System.Drawing.Point(157, 183);
            this.bntconecta.Margin = new System.Windows.Forms.Padding(2);
            this.bntconecta.Name = "bntconecta";
            this.bntconecta.Size = new System.Drawing.Size(76, 27);
            this.bntconecta.TabIndex = 6;
            this.bntconecta.Text = "Conectar";
            this.bntconecta.UseVisualStyleBackColor = true;
            this.bntconecta.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // bntsalva
            // 
            this.bntsalva.Location = new System.Drawing.Point(238, 183);
            this.bntsalva.Margin = new System.Windows.Forms.Padding(2);
            this.bntsalva.Name = "bntsalva";
            this.bntsalva.Size = new System.Drawing.Size(64, 27);
            this.bntsalva.TabIndex = 7;
            this.bntsalva.Text = "Salvar";
            this.bntsalva.UseVisualStyleBackColor = true;
            this.bntsalva.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dados do Servidor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Borda_Tela
            // 
            this.Borda_Tela.ElipseRadius = 7;
            this.Borda_Tela.TargetControl = this;
            // 
            // Popup_Config_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bntsalva);
            this.Controls.Add(this.bntconecta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_banco);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_servidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Popup_Config_DB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do Banco de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_servidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntconecta;
        private System.Windows.Forms.Button bntsalva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse Borda_Tela;
    }
}