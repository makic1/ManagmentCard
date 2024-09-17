using WineCardVersionFive.Forms;
using WineCardVersionFive.Uc;

namespace WineCardVersionFive
{
    public partial class FormMain : Form
    {
        private UcLogin _ucLogin;
        public FormMain()
        {
            InitializeComponent();

            if (_ucLogin is null)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UcLogin(this));
            }
            panelMain.Controls.Add(_ucLogin);
        }

        public void IsLoggedOn(bool Login)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new UcManageUserControls());
        }

        private void buttonWineCard_Click(object sender, EventArgs e)
        {
            var formWineCard = new FormWineCard();
            formWineCard.ShowDialog();
        }
    }
}
