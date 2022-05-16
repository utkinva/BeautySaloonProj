using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonProj.ModelEF;

namespace BeautySaloonProj.Forms
{
    public partial class CurrentOrdersListForm : Form
    {
        public CurrentOrdersListForm()
        {
            InitializeComponent();
        }

        private void ClientOrdersForm_Load(object sender, EventArgs e)
        {
            if (Program.currentUser.UserTypeID == 3)
            {
                addBtn.Visible = true;
                editBtn.Visible = true;
                deleteBtn.Visible = true;
            }
            else
            {
                addBtn.Visible = false;
                editBtn.Visible = false;
                deleteBtn.Visible = false;
            }
            clientsBindingSource.DataSource = Program.db.Clients.ToList();
            servicesBindingSource.DataSource = Program.db.Services.ToList();
            mastersBindingSource.DataSource = Program.db.Masters.ToList();
            currentOrdersBindingSource.DataSource = Program.db.CurrentOrders.ToList();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            if ((CurrentOrders)currentOrdersBindingSource.Current != null)
            {
                DialogResult dialog = MessageBox.Show("Переместить выбранную запись в архив?", "Перенести в архив", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    CurrentOrders order = (CurrentOrders)currentOrdersBindingSource.Current;
                    OrderHistory archivedOrder = new OrderHistory();

                    archivedOrder.ClientID = order.ClientID;
                    archivedOrder.ServiceID = order.ServiceID;
                    archivedOrder.MasterID = order.MasterID;
                    archivedOrder.Date = order.Date;
                    archivedOrder.Time = order.Time;

                    Program.db.CurrentOrders.Remove(order);
                    Program.db.OrderHistory.Add(archivedOrder);

                    Program.db.SaveChanges();
                    currentOrdersBindingSource.DataSource = Program.db.CurrentOrders.ToList();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditOrderForm addOrder = new AddEditOrderForm(null);
            DialogResult dialog = addOrder.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                clientsBindingSource.DataSource = Program.db.Clients.ToList();
                currentOrdersBindingSource.DataSource = Program.db.CurrentOrders.ToList();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if ((CurrentOrders)currentOrdersBindingSource.Current != null)
            {
                AddEditOrderForm addOrder = new AddEditOrderForm((CurrentOrders)currentOrdersBindingSource.Current);
                DialogResult dialog = addOrder.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    clientsBindingSource.DataSource = Program.db.Clients.ToList();
                    currentOrdersBindingSource.DataSource = Program.db.CurrentOrders.ToList();
                }
            }
            else
            {
                MessageBox.Show($"Не выбрана ни одна запись в таблице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((CurrentOrders)currentOrdersBindingSource.Current != null)
            {
                DialogResult dialog = MessageBox.Show("Удалить выбранную запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    CurrentOrders order = (CurrentOrders)currentOrdersBindingSource.Current;
                    Program.db.CurrentOrders.Remove(order);
                    Program.db.SaveChanges();
                    currentOrdersBindingSource.DataSource = Program.db.CurrentOrders.ToList();
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

        private void currentOrdersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
