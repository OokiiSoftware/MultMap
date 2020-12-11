namespace MultMap.Telas
{
    partial class Popup_Delete_Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup_Delete_Caixa));
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Log = new System.Windows.Forms.Label();
            this.tb_motivo = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_excluir.BackColor = System.Drawing.Color.Brown;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_excluir.Location = new System.Drawing.Point(36, 236);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            this.btn_excluir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancelar.BackColor = System.Drawing.Color.Gray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(171, 236);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            this.btn_cancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmar a Exclusão do Registro?";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Se confirmar, o registro será apagado definitivamente do banco de dados!";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // txt_Log
            // 
            this.txt_Log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Log.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Log.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txt_Log.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_Log.Location = new System.Drawing.Point(36, 202);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(215, 20);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "Log";
            this.txt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Log.Visible = false;
            this.txt_Log.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // tb_motivo
            // 
            // 
            // 
            // 
            this.tb_motivo.CustomButton.Image = null;
            this.tb_motivo.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.tb_motivo.CustomButton.Name = "";
            this.tb_motivo.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.tb_motivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_motivo.CustomButton.TabIndex = 1;
            this.tb_motivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_motivo.CustomButton.UseSelectable = true;
            this.tb_motivo.CustomButton.Visible = false;
            this.tb_motivo.Lines = new string[0];
            this.tb_motivo.Location = new System.Drawing.Point(36, 122);
            this.tb_motivo.MaxLength = 32767;
            this.tb_motivo.Multiline = true;
            this.tb_motivo.Name = "tb_motivo";
            this.tb_motivo.PasswordChar = '\0';
            this.tb_motivo.PromptText = "Motivo";
            this.tb_motivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_motivo.SelectedText = "";
            this.tb_motivo.SelectionLength = 0;
            this.tb_motivo.SelectionStart = 0;
            this.tb_motivo.ShortcutsEnabled = true;
            this.tb_motivo.Size = new System.Drawing.Size(215, 70);
            this.tb_motivo.TabIndex = 1;
            this.tb_motivo.UseSelectable = true;
            this.tb_motivo.WaterMark = "Motivo";
            this.tb_motivo.WaterMarkColor = System.Drawing.Color.Silver;
            this.tb_motivo.WaterMarkFont = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.tb_motivo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alerta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 241);
            this.panel1.TabIndex = 0;
            // 
            // Popup_Delete_Caixa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(289, 271);
            this.Controls.Add(this.tb_motivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup_Delete_Caixa";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Deletar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_Log;
        private MetroFramework.Controls.MetroTextBox tb_motivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}