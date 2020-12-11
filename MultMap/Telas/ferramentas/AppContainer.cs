using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultMap.Telas.ferramentas
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            //AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            FormBorderStyle = FormBorderStyle.None;
            //Dock = DockStyle.Fill;
            //Icon = Properties.Resources.ic_branco_browser;
            Tabs.Add(CreateTab());
            SelectedTabIndex = 0;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Tela_Ferramentas_Navegador { Text = "Nova Aba" }
            };
        }
    }
}
