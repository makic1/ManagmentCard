using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineCardVersionFive.Service;

namespace WineCardVersionFive.Uc
{
    public partial class UcImportCSV : UserControl
    {
        private readonly ServiceImportCsv _serviceImportCsv;
        public UcImportCSV()
        {
            InitializeComponent();
            var context = new DbContextWineCardVersionFive();
            _serviceImportCsv = new ServiceImportCsv(context);
        }

        private void buttonImportCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            _serviceImportCsv.ImportCsv(openFileDialog.FileName);
        }
    }
}
