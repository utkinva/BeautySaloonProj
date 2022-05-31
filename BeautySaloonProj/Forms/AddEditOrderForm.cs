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
    public partial class AddEditOrderForm : Form
    {
        CurrentOrders order;
        public AddEditOrderForm(CurrentOrders current)
        {
            InitializeComponent();
            if (current != null)
            {
                order = current;
            }
            else
            {
                order = new CurrentOrders();
            }
        }

        private void AddEditOrderForm_Load(object sender, EventArgs e)
        {
            clientsBindingSource.DataSource = Program.db.Clients.ToList();
            servicesBindingSource.DataSource = Program.db.Services.ToList();
            mastersBindingSource.DataSource = Program.db.Masters.ToList();

            if (order != null)
            {
                currentOrdersBindingSource.Add(order);
                this.Text = "Редактировать запись";
            }
            else
            {
                currentOrdersBindingSource.AddNew();
                this.Text = "Новая запись";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (order.ID == 0)
            {
                foreach (var item in Program.db.CurrentOrders.ToList())
                {
                    if (item.ClientID == int.Parse(clientIDComboBox.SelectedValue.ToString()) &&
                        item.ServiceID == int.Parse(serviceIDComboBox.SelectedValue.ToString()) &&
                        DateTime.Parse(item.Date.ToString()) == DateTime.Parse(dateMaskedTextBox.Text) &&
                        TimeSpan.Parse(item.Time.ToString()) == TimeSpan.Parse(timeMaskedTextBox.Text))
                    {
                        MessageBox.Show($"Клиент уже записан на услугу {serviceIDComboBox.Text} {dateMaskedTextBox.Text} в {timeMaskedTextBox.Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            Program.db.CurrentOrders.Add(order);
            StringBuilder errorsLog = new StringBuilder();
            if (masterIDComboBox.SelectedItem == null)
                errorsLog.AppendLine("Выберите мастера");
            if (clientIDComboBox.SelectedItem == null)
                errorsLog.AppendLine("Выберите клиента");
            if (serviceIDComboBox.SelectedItem == null)
                errorsLog.AppendLine("Выберите услугу");
            if (dateMaskedTextBox.Text.Length != 10)
                errorsLog.AppendLine("Выберите дату записи");
            if (timeMaskedTextBox.Text.Length != 5)
                errorsLog.AppendLine("Выберите время записи");



            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось сохранить изменения: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (order.ID == 0)
            {
                Program.db.CurrentOrders.Add(order);
            }

            try
            {
                Program.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void newClientBtn_Click(object sender, EventArgs e)
        {
            AddEditClientForm addClient = new AddEditClientForm(null);
            DialogResult dialog = addClient.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                clientsBindingSource.DataSource = Program.db.Clients.ToList();
            }
         }
    }
}
