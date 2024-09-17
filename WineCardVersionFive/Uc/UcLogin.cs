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
    public partial class UcLogin : UserControl
    {
        private FormMain _formMain;
        private readonly ServiceAccount _serviceAccount;
        public UcLogin(FormMain formMain)
        {
            InitializeComponent();
            var context = new DbContextWineCardVersionFive();
            _serviceAccount = new ServiceAccount(context);
            _formMain = formMain;

            textBoxPassword.PasswordChar = '*';

            // todo: am schluss entfernen
            textBoxPassword.Text = "admin";
            textBoxUsername.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginmodel = new LoginModel
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
            };

            var account = _serviceAccount.FindAccount(loginmodel.Username);

            if(account is not null && BCrypt.Net.BCrypt.Verify(loginmodel.Password, account.HashPassword))
            {
                AuthService.Instance.Login(account.Username);
                _formMain.IsLoggedOn(true);
            }
        }
    }
}
