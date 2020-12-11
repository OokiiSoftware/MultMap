namespace MultMap.Telas
{
    partial class Tela_Relatorio
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
            this.RV_Relatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_Relatorio
            // 
            this.RV_Relatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_Relatorio.LocalReport.ReportEmbeddedResource = "Meu_Terminal.Auxiliar.RelatorioGrafico1.1.rdlc";
            this.RV_Relatorio.Location = new System.Drawing.Point(0, 0);
            this.RV_Relatorio.Name = "RV_Relatorio";
            this.RV_Relatorio.ServerReport.BearerToken = null;
            this.RV_Relatorio.Size = new System.Drawing.Size(664, 300);
            this.RV_Relatorio.TabIndex = 1;
            // 
            // Tela_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 300);
            this.Controls.Add(this.RV_Relatorio);
            this.Name = "Tela_Relatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer RV_Relatorio;
    }
}