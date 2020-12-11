namespace MultMap.Telas
{
    partial class PopupAtivarSistema
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
            this.TB_EnderecoMac = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.lbl_IDU = new System.Windows.Forms.Label();
            this.Lbl_Info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_EmpresaNome = new MultMap.Telas.Ferramentas.CustonTextBox();
            this.SuspendLayout();
            // 
            // TB_EnderecoMac
            // 
            this.TB_EnderecoMac.BackColor = System.Drawing.Color.White;
            this.TB_EnderecoMac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_EnderecoMac.ButtonColor = System.Drawing.Color.Empty;
            this.TB_EnderecoMac.ButtonIcon = null;
            this.TB_EnderecoMac.ButtonVisivel = false;
            this.TB_EnderecoMac.ButtonWidth = 27;
            this.TB_EnderecoMac.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.TB_EnderecoMac.Hint = null;
            this.TB_EnderecoMac.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_EnderecoMac.Location = new System.Drawing.Point(56, 34);
            this.TB_EnderecoMac.Margin = new System.Windows.Forms.Padding(0);
            this.TB_EnderecoMac.Name = "TB_EnderecoMac";
            this.TB_EnderecoMac.ReadOnly = true;
            this.TB_EnderecoMac.Size = new System.Drawing.Size(197, 20);
            this.TB_EnderecoMac.TabIndex = 2;
            // 
            // lbl_IDU
            // 
            this.lbl_IDU.AutoSize = true;
            this.lbl_IDU.Location = new System.Drawing.Point(9, 34);
            this.lbl_IDU.Name = "lbl_IDU";
            this.lbl_IDU.Size = new System.Drawing.Size(33, 18);
            this.lbl_IDU.TabIndex = 0;
            this.lbl_IDU.Text = "UID";
            // 
            // Lbl_Info
            // 
            this.Lbl_Info.AutoSize = true;
            this.Lbl_Info.Location = new System.Drawing.Point(12, 69);
            this.Lbl_Info.Name = "Lbl_Info";
            this.Lbl_Info.Size = new System.Drawing.Size(46, 18);
            this.Lbl_Info.TabIndex = 0;
            this.Lbl_Info.Text = "TEXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPN";
            // 
            // TB_EmpresaNome
            // 
            this.TB_EmpresaNome.BackColor = System.Drawing.Color.White;
            this.TB_EmpresaNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_EmpresaNome.ButtonColor = System.Drawing.Color.Empty;
            this.TB_EmpresaNome.ButtonIcon = null;
            this.TB_EmpresaNome.ButtonVisivel = false;
            this.TB_EmpresaNome.ButtonWidth = 27;
            this.TB_EmpresaNome.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.TB_EmpresaNome.Hint = null;
            this.TB_EmpresaNome.HintAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_EmpresaNome.Location = new System.Drawing.Point(56, 9);
            this.TB_EmpresaNome.Margin = new System.Windows.Forms.Padding(0);
            this.TB_EmpresaNome.Name = "TB_EmpresaNome";
            this.TB_EmpresaNome.ReadOnly = true;
            this.TB_EmpresaNome.Size = new System.Drawing.Size(197, 20);
            this.TB_EmpresaNome.TabIndex = 1;
            this.TB_EmpresaNome.Text = "Companhia";
            // 
            // PopupAtivarSistema
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(262, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_EmpresaNome);
            this.Controls.Add(this.Lbl_Info);
            this.Controls.Add(this.lbl_IDU);
            this.Controls.Add(this.TB_EnderecoMac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PopupAtivarSistema";
            this.Text = "Ativar o Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ferramentas.CustonTextBox TB_EnderecoMac;
        private System.Windows.Forms.Label lbl_IDU;
        private System.Windows.Forms.Label Lbl_Info;
        private System.Windows.Forms.Label label2;
        private Ferramentas.CustonTextBox TB_EmpresaNome;
    }
}