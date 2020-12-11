using System;
using System.Windows.Forms;

namespace Meu_Terminal
{
    public partial class Popup_Config_DB : Form
    {
        public Popup_Config_DB()
        {
            InitializeComponent();
        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            Conectar(false);
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Conectar(true);
            Application.Restart();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conectar(bool salvar)
        {
            if(CN_ConexaoDinamica.Criarconexao(tb_servidor.Text, tb_banco.Text, tb_usuario.Text, tb_senha.Text, salvar))
                MessageBox.Show("Conectado com sucesso", "alerta", MessageBoxButtons.OK);
            else
                MessageBox.Show("Erro ao conectar, verificar a configuração", "alerta", MessageBoxButtons.OK);
        }
    }
}
