using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineCardVersionFive.Uc
{
    public partial class UcManageUserControls : UserControl
    {
        public UcManageUserControls()
        {
            InitializeComponent();

            tabPageImportCsv.Controls.Add(new UcImportCSV());
            tabPageWinery.Controls.Add(new UcWinery());
            tabPageVintage.Controls.Add(new UcVintage());
            tabPageWineCard.Controls.Add(new UcConfWineCard());
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageImportCsv)
            {
                tabPageImportCsv.Controls.Clear();
                tabPageImportCsv.Controls.Add(new UcImportCSV());
            }
            if (tabControlMain.SelectedTab == tabPageWinery)
            {
                tabPageWinery.Controls.Clear();
                tabPageWinery.Controls.Add(new UcWinery());
            }
            if (tabControlMain.SelectedTab == tabPageVintage)
            {
                tabPageVintage.Controls.Clear();
                tabPageVintage.Controls.Add(new UcVintage());
            }
            if (tabControlMain.SelectedTab == tabPageWineCard)
            {
                tabPageWineCard.Controls.Clear();
                tabPageWineCard.Controls.Add(new UcConfWineCard());
            }
        }
    }
}
