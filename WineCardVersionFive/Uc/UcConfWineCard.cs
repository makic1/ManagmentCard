using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineCardVersionFive.Entities;
using WineCardVersionFive.Service;

namespace WineCardVersionFive.Uc
{
    public partial class UcConfWineCard : UserControl
    {
        private readonly ServiceWineCard _serviceWineCard;
        private readonly ServiceWine _serviceWine;

        public UcConfWineCard()
        {
            InitializeComponent();
            var context = new DbContextWineCardVersionFive();
            _serviceWineCard = new ServiceWineCard(context);
            _serviceWine = new ServiceWine(context);

            LoadUi();
            ConfDataGrid();
        }

        private void ConfDataGrid()
        {
            dataGridViewWine.Columns["WineId"].Visible = false;
            dataGridViewWine.Columns["WineCardId"].Visible = false;
            dataGridViewWine.Columns["VintageId"].Visible = false;
            dataGridViewWine.Columns["WineTypeId"].Visible = false;
            dataGridViewWine.Columns["GrapeVarietyId"].Visible = false;
            dataGridViewWine.Columns["WineryId"].Visible = false;
        }

        private void LoadUi()
        {
            dataGridViewWine.DataSource = _serviceWineCard.GetAllWines();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            var wine = _serviceWineCard.FindWineById(CurrentWinecardId());

            wine.WineCardId = 1;

            if (_serviceWineCard.CountOfCards() > 9)
            {
                MessageBox.Show("sie haben schon 10 Weine ausgewählt");
                return;
            }

            _serviceWineCard.UpdateWineToWineCard(wine);
            LoadUi();

        }
        private int CurrentWinecardId()
        {
            return Convert.ToInt32(dataGridViewWine.SelectedRows[0].Cells[0].Value);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var wine = _serviceWineCard.FindWineById(CurrentWinecardId());

            wine.WineCardId = null;

            _serviceWineCard.UpdateWineToWineCard(wine);
            LoadUi();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewWine.DataSource = _serviceWineCard.SearchWineCards(textBoxWineType.Text, textBoxRegion.Text, textBoxCountry.Text,textBoxWinery.Text, textBoxGrapeVariety.Text,Convert.ToInt32(textBoxVintage.Text));
        }
    }
}
