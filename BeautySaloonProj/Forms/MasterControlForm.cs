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
    public partial class MasterControlForm : Form
    {
        public MasterControlForm()
        {
            InitializeComponent();
        }

        private void checkSchelduleBtn_Click(object sender, EventArgs e)
        {
            SchelduleForm schelduleForm = new SchelduleForm();
            schelduleForm.ShowDialog();
        }

        private void checkOrdersBtn_Click(object sender, EventArgs e)
        {
            CurrentOrdersListForm clientOrdersForm = new CurrentOrdersListForm();
            clientOrdersForm.ShowDialog();
        }

        private void checkArchiveBtn_Click(object sender, EventArgs e)
        {
            OrdersHistoryForm ordersHistory = new OrdersHistoryForm();
            ordersHistory.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Выйти из учетной записи", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Program.currentUser = null;
                this.Close();
                AuthorizationForm authorizationForm = new AuthorizationForm();
                authorizationForm.Show();
            }
            else
            {
                return;
            }

        }
    }
}
