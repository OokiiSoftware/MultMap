using EasyTabs;
using MultMap.Telas.Exemplos;
using MultMap.Telas.ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultMap.Telas
{
    public partial class Tela_Ferramentas_Navegador_Control : Form
    {
        public Tela_Ferramentas_Navegador_Control()
        {
            InitializeComponent();

            AppContainer container = new AppContainer();
            container.TopLevel = false;
            Controls.Add(container);
            container.Show();

            //TitleBarTabsApplicationContext context = new TitleBarTabsApplicationContext
            //{
            //    MainForm = this
            //};
            //context.Start(container);
        }
    }
}
