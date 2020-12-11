namespace MultMap.Telas.Exemplos
{
    partial class Filtro
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
            this.flow = new MultMap.Telas.Ferramentas.FlowGradiente();
            this.Cb_NomeCaixa = new System.Windows.Forms.CheckBox();
            this.Cb_NomeCliente = new System.Windows.Forms.CheckBox();
            this.Cb_Estado = new System.Windows.Forms.CheckBox();
            this.Cb_Cidade = new System.Windows.Forms.CheckBox();
            this.Cb_Bairro = new System.Windows.Forms.CheckBox();
            this.Cb_Rua = new System.Windows.Forms.CheckBox();
            this.flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.AutoScroll = true;
            this.flow.colorBoton = System.Drawing.Color.Empty;
            this.flow.colorTop = System.Drawing.Color.Empty;
            this.flow.Controls.Add(this.Cb_NomeCaixa);
            this.flow.Controls.Add(this.Cb_NomeCliente);
            this.flow.Controls.Add(this.Cb_Estado);
            this.flow.Controls.Add(this.Cb_Cidade);
            this.flow.Controls.Add(this.Cb_Bairro);
            this.flow.Controls.Add(this.Cb_Rua);
            this.flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow.Location = new System.Drawing.Point(0, 0);
            this.flow.Margin = new System.Windows.Forms.Padding(0);
            this.flow.Name = "flow";
            this.flow.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.flow.Radio = 0;
            this.flow.Size = new System.Drawing.Size(139, 136);
            this.flow.TabIndex = 0;
            this.flow.WrapContents = false;
            // 
            // Cb_NomeCaixa
            // 
            this.Cb_NomeCaixa.AutoSize = true;
            this.Cb_NomeCaixa.Checked = true;
            this.Cb_NomeCaixa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_NomeCaixa.Location = new System.Drawing.Point(10, 5);
            this.Cb_NomeCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_NomeCaixa.Name = "Cb_NomeCaixa";
            this.Cb_NomeCaixa.Size = new System.Drawing.Size(116, 21);
            this.Cb_NomeCaixa.TabIndex = 1;
            this.Cb_NomeCaixa.Text = "Nome da caixa";
            this.Cb_NomeCaixa.UseVisualStyleBackColor = true;
            // 
            // Cb_NomeCliente
            // 
            this.Cb_NomeCliente.AutoSize = true;
            this.Cb_NomeCliente.Location = new System.Drawing.Point(10, 26);
            this.Cb_NomeCliente.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_NomeCliente.Name = "Cb_NomeCliente";
            this.Cb_NomeCliente.Size = new System.Drawing.Size(129, 21);
            this.Cb_NomeCliente.TabIndex = 2;
            this.Cb_NomeCliente.Text = "Nome do cliente";
            this.Cb_NomeCliente.UseVisualStyleBackColor = true;
            // 
            // Cb_Estado
            // 
            this.Cb_Estado.AutoSize = true;
            this.Cb_Estado.Location = new System.Drawing.Point(10, 47);
            this.Cb_Estado.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Estado.Name = "Cb_Estado";
            this.Cb_Estado.Size = new System.Drawing.Size(70, 21);
            this.Cb_Estado.TabIndex = 3;
            this.Cb_Estado.Text = "Estado";
            this.Cb_Estado.UseVisualStyleBackColor = true;
            // 
            // Cb_Cidade
            // 
            this.Cb_Cidade.AutoSize = true;
            this.Cb_Cidade.Location = new System.Drawing.Point(10, 68);
            this.Cb_Cidade.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Cidade.Name = "Cb_Cidade";
            this.Cb_Cidade.Size = new System.Drawing.Size(71, 21);
            this.Cb_Cidade.TabIndex = 4;
            this.Cb_Cidade.Text = "Cidade";
            this.Cb_Cidade.UseVisualStyleBackColor = true;
            // 
            // Cb_Bairro
            // 
            this.Cb_Bairro.AutoSize = true;
            this.Cb_Bairro.Location = new System.Drawing.Point(10, 89);
            this.Cb_Bairro.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Bairro.Name = "Cb_Bairro";
            this.Cb_Bairro.Size = new System.Drawing.Size(67, 21);
            this.Cb_Bairro.TabIndex = 5;
            this.Cb_Bairro.Text = "Bairro";
            this.Cb_Bairro.UseVisualStyleBackColor = true;
            // 
            // Cb_Rua
            // 
            this.Cb_Rua.AutoSize = true;
            this.Cb_Rua.Location = new System.Drawing.Point(10, 110);
            this.Cb_Rua.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Rua.Name = "Cb_Rua";
            this.Cb_Rua.Size = new System.Drawing.Size(51, 21);
            this.Cb_Rua.TabIndex = 6;
            this.Cb_Rua.Text = "Rua";
            this.Cb_Rua.UseVisualStyleBackColor = true;
            // 
            // Filtro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flow);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.Name = "Filtro";
            this.Size = new System.Drawing.Size(139, 136);
            this.flow.ResumeLayout(false);
            this.flow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox Cb_NomeCaixa;
        private Telas.Ferramentas.FlowGradiente flow;
        public System.Windows.Forms.CheckBox Cb_NomeCliente;
        public System.Windows.Forms.CheckBox Cb_Estado;
        public System.Windows.Forms.CheckBox Cb_Cidade;
        public System.Windows.Forms.CheckBox Cb_Bairro;
        public System.Windows.Forms.CheckBox Cb_Rua;
    }
}
