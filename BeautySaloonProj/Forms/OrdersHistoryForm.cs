using BeautySaloonProj.ModelEF;
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
    public partial class OrdersHistoryForm : Form
    {
        public OrdersHistoryForm()
        {
            InitializeComponent();
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
            CurrentUserLbl.Text = $"Вы авторизовались как {Program.currentUser.UserTypes.Title}";
            timer1.Start();
        }

        private void OrdersHistoryForm_Load(object sender, EventArgs e)
        {
            clientsBindingSource.DataSource = Program.db.Clients.ToList();
            servicesBindingSource.DataSource = Program.db.Services.ToList();
            mastersBindingSource.DataSource = Program.db.Masters.ToList();
            orderHistoryBindingSource.DataSource = Program.db.OrderHistory.ToList();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((OrderHistory)orderHistoryBindingSource.Current != null)
            {
                DialogResult dialog = MessageBox.Show("Удалить выбранную запись из архива?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    OrderHistory order = (OrderHistory)orderHistoryBindingSource.Current;
                    Program.db.OrderHistory.Remove(order);
                    Program.db.SaveChanges();
                    orderHistoryBindingSource.DataSource = Program.db.OrderHistory.ToList();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Не выбрана ни одна запись в таблице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void scheduleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }
    }
}
