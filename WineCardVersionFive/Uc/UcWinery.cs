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
    public partial class UcWinery : UserControl
    {
        private readonly ServiceWinery _serviceWinery;
        private readonly ServiceRegion _serviceRegion;
        private IsEdit _addOrEdit;
        public UcWinery()
        {
            InitializeComponent();
            var context = new DbContextWineCardVersionFive();
            _serviceRegion = new ServiceRegion(context);
            _serviceWinery = new ServiceWinery(context);

            LoadUi();
            ConfDataGrid();
            groupBoxWinery.Visible = false;
        }

        private void ConfDataGrid()
        {
            dataGridViewWinery.Columns["WineryId"].Visible = false;
            dataGridViewWinery.Columns["Wines"].Visible = false;
            dataGridViewWinery.Columns["RegionId"].Visible = false;
        }

        private void LoadUi()
        {
            dataGridViewWinery.DataSource = _serviceWinery.GetAllWineries();
            comboBoxRegion.DataSource = _serviceRegion.GetAllRegions();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateWinery().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateWinery()), "Vallidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var region = (Entities.Region)comboBoxRegion.SelectedItem;

            var winery = new Winery
            {
                Name = textBoxName.Text,
                RegionId = region.RegionId
            };
            if (_addOrEdit == IsEdit.Add)
            {
                if (_serviceWinery.CheckOfDuplicateWineries(winery))
                {
                    MessageBox.Show("Diesen Weingüter gibt es schon");
                    return;
                }
                _serviceWinery.AddWinery(winery);
            }
            else if (_addOrEdit == IsEdit.Edit)
            {
                winery.WineryId = CurrentWineryId();
                _serviceWinery.UpdateWinery(winery);
            }
            LoadUi();
            groupBoxWinery.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxWinery.Visible = true;

            textBoxName.Clear();
            comboBoxRegion.SelectedItem = null;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxWinery.Visible = true;

            var winery = _serviceWinery.FindWineryById(CurrentWineryId());

            textBoxName.Text = winery.Name;
            comboBoxRegion.SelectedItem = winery.Region;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das sie diesen Weingüter löschen möchten?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult == DialogResult.Yes)
            {
                _serviceWinery.RemoveWineryById(CurrentWineryId());
                LoadUi();
            }
        }

        public List<string> ValidateWinery()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errors.Add("Geben sie Bitte den Namen vom Weingüter ein");
            }
            if (comboBoxRegion.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte eine Region aus");
            }

            return errors;
        }

        private int CurrentWineryId()
        {
            return Convert.ToInt32(dataGridViewWinery.SelectedRows[0].Cells[0].Value);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back);
        }

        public enum IsEdit
        {
            Add,
            Edit
        }
    }
}
