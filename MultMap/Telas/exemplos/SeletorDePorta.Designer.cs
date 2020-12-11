namespace MultMap.Telas.exemplos
{
    partial class SeletorDePorta
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
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flow
            // 
            this.Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow.Location = new System.Drawing.Point(0, 0);
            this.Flow.Margin = new System.Windows.Forms.Padding(0);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(293, 75);
            this.Flow.TabIndex = 0;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Location = new System.Drawing.Point(0, 75);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(293, 23);
            this.Btn_Cancelar.TabIndex = 0;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // SeletorDePorta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(293, 98);
            this.Controls.Add(this.Flow);
            this.Controls.Add(this.Btn_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeletorDePorta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeletorDePorta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}