using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Data;

namespace MultMap.Telas
{
    public partial class PopupAtivarSistema : Form
    {
        private const string TAG = "PopupAtivarSistema";

        public PopupAtivarSistema(int id)
        {
            InitializeComponent();
            Init(id);
        }

        private void Init(int id)
        {
            try
            {
                switch (id)
                {
                    case Const.ATIVACAO_MAQUINA:
                        Ativacao();
                        break;
                    case Const.ATIVACAO_CERTIFICADO:
                        Certificado();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Certificado()
        {
            try
            {
                lbl_IDU.Visible = TB_EnderecoMac.Visible = false;

                Lbl_Info.Text =
                   "Seu certificado expirou\n\n" +

                   "Por favor, entre em contato com a\n" +
                   "equipe OkiSoftware atualizar seu\n" +
                   "certificado.\n\n" +

                   "Ōkī Software\n" +
                   "Email: 818280";
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            Comum();
        }

        private void Ativacao()
        {
            try
            {
                Lbl_Info.Text =
                    "Esta máquina não está ativada\n\n" +

                    "Por favor, entre em contato com a\n" +
                    "equipe OkiSoftware para ativar seu\n" +
                    "sistema.\n\n" +

                    "Ōkī Software\n" +
                    "Email: 818280";

                TB_EnderecoMac.Text = Import.Get.EnderecoMac();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            Comum();
        }

        private void Comum()
        {
            try
            {
                TB_EmpresaNome.Text = Import.Get.NomeEmpresa.ToUpper();
                Lbl_Info.Text = Lbl_Info.Text.Replace("818280", Const.EMAIL_COMPANY);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
    }
}
