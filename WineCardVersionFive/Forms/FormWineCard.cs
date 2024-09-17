using WineCardVersionFive.Service;

namespace WineCardVersionFive.Forms
{
    public partial class FormWineCard : Form
    {
        private readonly ServiceWineCard _serviceWineCard;
        public FormWineCard()
        {
            InitializeComponent();
            var context = new DbContextWineCardVersionFive();
            _serviceWineCard = new ServiceWineCard(context);

            dataGridViewWineCard.DataSource = _serviceWineCard.GetAllWinesFromTheWineCard(false, false);

            dataGridViewWineCard.Columns["WineId"].Visible = false;
            dataGridViewWineCard.Columns["WineCardId"].Visible = false;
            dataGridViewWineCard.Columns["VintageId"].Visible = false;
            dataGridViewWineCard.Columns["WineTypeId"].Visible = false;
            dataGridViewWineCard.Columns["GrapeVarietyId"].Visible = false;
            dataGridViewWineCard.Columns["WineryId"].Visible = false;
        }

        private void checkBoxWineType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWineType.Checked)
            {
                dataGridViewWineCard.DataSource = _serviceWineCard.GetAllWinesFromTheWineCard(true, false);
            }
        }

        private void checkBoxWineName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWineName.Checked == true)
            {
                dataGridViewWineCard.DataSource = _serviceWineCard.GetAllWinesFromTheWineCard(false, true);
            }
        }
    }
}
