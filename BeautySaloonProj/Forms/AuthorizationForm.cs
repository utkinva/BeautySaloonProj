using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
            timer1.Start();

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

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process current = Process.GetCurrentProcess();
            current.Kill();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
