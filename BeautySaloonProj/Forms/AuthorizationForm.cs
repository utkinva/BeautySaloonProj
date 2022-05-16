using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloonProj.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            DialogResult dialogResult = login.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                switch (Program.currentUser.UserTypeID)
                {
                    case 2:
                        MasterControlForm masterPanel = new MasterControlForm();
                        masterPanel.Show();
                        this.Hide();
                        break;
                    case 3:
                        AdministratorControlForm adminPanel = new AdministratorControlForm();
                        adminPanel.Show();
                        this.Hide();
                        break;
                }
                this.Hide();
            }
            else
                MessageBox.Show("Авторизация отменена");
        }
    }
}
