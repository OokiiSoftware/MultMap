using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MultMap.Auxiliar;

namespace MultMap.Telas
{
    public partial class Tela_Ferramentas_Email : Form
    {
        #region Variáveis

        private static string TAG = "Tela_Ferramentas_Email";

        private List<string> files = new List<string>();
        private string hint_mensagem;

        #endregion

        public Tela_Ferramentas_Email()
        {
            InitializeComponent();
            hint_mensagem = Tb_Corpo.Text;
            Inicializar();
        }

        #region Eventos

        private void On_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                BringToFront();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #region Botões

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }
        
        private void Btn_Add_File_Click(object sender, EventArgs e)
        {
            AbrirDialog();
        }
        
        private void Btn_Remove_Files_Click(object sender, EventArgs e)
        {
            RemoverFiles();
        }
        
        private void Btn_LimparTudo_Click(object sender, EventArgs e)
        {
            RestaurarCampos();
        }

        #endregion

        #endregion

        #region Métodos

        private void Inicializar()
        {
            try
            {
                ToolTip tip = new ToolTip();
                tip.SetToolTip(Tb_Destino, "Separe cada email com ponto e virgula");
                tip.SetToolTip(Btn_Add_File, "Adicionar arquivo");
                tip.SetToolTip(Btn_Remove_Files, "Remover item selecionado");
                tip.SetToolTip(Btn_Enviar, "Enviar email");
                tip.SetToolTip(Lb_Files, "Arquivos a serem enviados");
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            CarregarTema();
        }

        private void CarregarTema()
        {
            try
            {
                #region BackColor

                BackColor = TemaConfig.ColorPrimaryDark;
                Tb_Corpo.BackColor = TemaConfig.ColorPrimary;
                Tb_Destino.BackColor = TemaConfig.ColorPrimary;
                Tb_Titulo.BackColor = TemaConfig.ColorPrimary;
            
                Btn_Add_File.BackColor = TemaConfig.ColorPrimary;
                Btn_Enviar.BackColor = TemaConfig.ColorPrimary;
                Btn_LimparTudo.BackColor = TemaConfig.ColorPrimary;
                Btn_Remove_Files.BackColor = TemaConfig.ColorPrimary;
                Lb_Files.BackColor = TemaConfig.ColorPrimary;

                #endregion

                #region ForeColor

                ForeColor = TemaConfig.TextColorPrimary;
                Tb_Corpo.ForeColor = TemaConfig.TextColorPrimary;
                Tb_Destino.ForeColor = TemaConfig.TextColorPrimary;
                Tb_Titulo.ForeColor = TemaConfig.TextColorPrimary;

                Btn_Add_File.ForeColor = TemaConfig.TextColorPrimary;
                Btn_Enviar.ForeColor = TemaConfig.TextColorPrimary;
                Btn_LimparTudo.ForeColor = TemaConfig.TextColorPrimary;
                Btn_Remove_Files.ForeColor = TemaConfig.TextColorPrimary;
                Lb_Files.ForeColor = TemaConfig.TextColorPrimary;

                #endregion
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private async void Enviar()
        {
            try
            {
                Txt_Log.Text = "Enviando";
                Txt_Log.Visible = true;
                string titulo = Tb_Titulo.Text;
                string corpo = Tb_Corpo.Text;
                string destino = Tb_Destino.Text;

                if (titulo.Trim().Length == 0)
                {
                    Tb_Titulo.Focus();
                    return;
                }
                else if (destino.Trim().Length == 0)
                {
                    Tb_Destino.Focus();
                    return;
                }
                if (corpo == hint_mensagem)
                    corpo = "";

                try
                {
                    MailMessage mail = new MailMessage();
                    OrganizarEmailsDestino(mail, destino);
                    mail.From = new MailAddress(Import.Get.EmailEmpresa);
                    mail.Subject = titulo;
                    mail.Body = corpo;

                    foreach(var f in files)
                        mail.Attachments.Add(new Attachment(f));

                    SmtpClient client = new SmtpClient(Import.Get.SmtpClient, 587)
                    {
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(Import.Get.EmailEmpresa, Import.Get.SenhaEmailEmpresa),
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network
                    };
                    await client.SendMailAsync(mail);
                    client.Dispose();
                    Import.Alert(Txt_EMAIL, "Email enviado");
                    RestaurarCampos();
                }
                catch (Exception ex)
                {
                    Import.Alert(Txt_EMAIL, "Erro ao enviar email", true);
                    Log.Erro(TAG, ex, 2);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex, 1);
            }
        }

        private void OrganizarEmailsDestino(MailMessage mail, string emails)
        {
            try
            {
                string[] mails = emails.Split(';');
                foreach (var s in mails)
                    mail.To.Add(s);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        // Add Itens no ListBox
        private void AbrirDialog()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    Lb_Files.Items.Add(dialog.SafeFileName);
                    files.Add(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void RestaurarCampos()
        {
            try
            {
                Tb_Titulo.Text = "";
                Tb_Corpo.Text = "";
                Tb_Destino.Text = "";
                files.Clear();
                Lb_Files.Items.Clear();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        // Remove Itens do ListBox
        private void RemoverFiles()
        {
            try
            {
                if (Lb_Files.SelectedItem != null)
                {
                    files.Remove(files.Find(x => x.Contains(Lb_Files.SelectedItem.ToString())));
                    Lb_Files.Items.Remove(Lb_Files.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion
    }
}
