namespace MultMap.exemplos
{
    partial class Layout_Mensagem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Texto = new System.Windows.Forms.Label();
            this.Container_2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Container_Texto = new System.Windows.Forms.FlowLayoutPanel();
            this.Horario = new System.Windows.Forms.Label();
            this.Container_2.SuspendLayout();
            this.Container_Texto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.BackColor = System.Drawing.Color.Transparent;
            this.Texto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Texto.Dock = System.Windows.Forms.DockStyle.Left;
            this.Texto.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.Location = new System.Drawing.Point(0, 0);
            this.Texto.Margin = new System.Windows.Forms.Padding(0);
            this.Texto.Name = "Texto";
            this.Texto.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.Texto.Size = new System.Drawing.Size(172, 44);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "Mensagem de text\r\nCom quebra  de linha";
            // 
            // Container_2
            // 
            this.Container_2.BackColor = System.Drawing.Color.White;
            this.Container_2.Controls.Add(this.Container_Texto);
            this.Container_2.Controls.Add(this.Horario);
            this.Container_2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.Container_2.Location = new System.Drawing.Point(0, 0);
            this.Container_2.Margin = new System.Windows.Forms.Padding(0);
            this.Container_2.Name = "Container_2";
            this.Container_2.Size = new System.Drawing.Size(218, 50);
            this.Container_2.TabIndex = 3;
            // 
            // Container_Texto
            // 
            this.Container_Texto.BackColor = System.Drawing.Color.Transparent;
            this.Container_Texto.Controls.Add(this.Texto);
            this.Container_Texto.Location = new System.Drawing.Point(0, 1);
            this.Container_Texto.Margin = new System.Windows.Forms.Padding(0);
            this.Container_Texto.Name = "Container_Texto";
            this.Container_Texto.Size = new System.Drawing.Size(175, 49);
            this.Container_Texto.TabIndex = 2;
            // 
            // Horario
            // 
            this.Horario.AutoSize = true;
            this.Horario.BackColor = System.Drawing.Color.Transparent;
            this.Horario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Horario.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.Horario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Horario.Location = new System.Drawing.Point(175, 27);
            this.Horario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Horario.Name = "Horario";
            this.Horario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Horario.Size = new System.Drawing.Size(38, 20);
            this.Horario.TabIndex = 1;
            this.Horario.Text = "00:00";
            // 
            // Layout_Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Container_2);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(40, 0, 0, 4);
            this.Name = "Layout_Mensagem";
            this.Size = new System.Drawing.Size(401, 419);
            this.ParentChanged += new System.EventHandler(this.Layout_Mensagem_ParentChanged);
            this.Container_2.ResumeLayout(false);
            this.Container_2.PerformLayout();
            this.Container_Texto.ResumeLayout(false);
            this.Container_Texto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.FlowLayoutPanel Container_Texto;
        private System.Windows.Forms.FlowLayoutPanel Container_2;
        private System.Windows.Forms.Label Horario;
    }
}
