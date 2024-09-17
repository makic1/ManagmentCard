using WineCardVersionFive.Entities;
using WineCardVersionFive.Service;

namespace WineCardVersionFive.Uc
{
    public partial class UcVintage : UserControl
    {
        private readonly ServiceVintage _serviceVintage;
        private IsEdit _addOrEdit;
        public UcVintage()
        {
            InitializeComponent();
            var context = new DbContextWineCardVersionFive();
            _serviceVintage = new ServiceVintage(context);

            LoadUi();
            ConfDataGridAndDateTimePicker();
        }

        private void ConfDataGridAndDateTimePicker()
        {
            dateTimePickerVintage.Format = DateTimePickerFormat.Custom;
            dateTimePickerVintage.CustomFormat = "yyyy";

            dataGridViewVintage.Columns["VintageId"].Visible = false;
            dataGridViewVintage.Columns["Wines"].Visible = false;

            dataGridViewVintage.Columns["Year"].HeaderText = "Jahr";


        }

        private void LoadUi()
        {
            dataGridViewVintage.DataSource = _serviceVintage.GetAllVintages();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var vintage = new Vintage
            {
                Year = dateTimePickerVintage.Value.Year,
            };
            if (_addOrEdit == IsEdit.Add)
            {
                if (_serviceVintage.CheckOfDuplicateVintage(vintage))
                {
                    MessageBox.Show("Diesen Jahrgang gibt es schon");
                    return;
                }
                _serviceVintage.AddVintage(vintage);
            }
            else if (_addOrEdit == IsEdit.Edit)
            {
                vintage.VintageId = CurrentVintageId();
                _serviceVintage.UpdateVintage(vintage);
            }
            LoadUi();
            groupBoxVintage.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxVintage.Visible = true;

            dateTimePickerVintage.Value = DateTime.Now;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxVintage.Visible = true;

            var vintage = _serviceVintage.FindVintageById(CurrentVintageId());

            dateTimePickerVintage.Value = new DateTime(vintage.Year,1,1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogreslt = MessageBox.Show("Sind sie sich sicher das die diesen Jahrgang löschen möchten?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogreslt == DialogResult.Yes)
            {
                _serviceVintage.RemoveVintageById(CurrentVintageId());
                LoadUi();
            }
        }

        private int CurrentVintageId()
        {
            return Convert.ToInt32(dataGridViewVintage.SelectedRows[0].Cells[0].Value);
        }

        public enum IsEdit
        {
            Add,
            Edit,
        }
    }
}
