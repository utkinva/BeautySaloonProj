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
    public partial class AddEditClientForm : Form
    {
        Clients client;
        public AddEditClientForm(Clients current)
        {
            InitializeComponent();
            if (current != null)
            {
                client = current;
            }
            else
            {
                client = new Clients();
            }
        }
        private void AddEditClientForm_Load(object sender, EventArgs e)
        {
            if (client != null)
            {
                clientsBindingSource.Add(client);
                this.Text = "Редактировать данные клиента";
            }
            else
            {
                clientsBindingSource.AddNew();
                this.Text = "Новый клиент";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errorsLog = new StringBuilder();

            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
                errorsLog.AppendLine("Заполните поле \"Полное имя\"");
            if (phoneMaskedTextBox.Text.Length != 18)
                errorsLog.AppendLine("Заполните поле \"Номер телефона\"");
            if (emailTextBox.Text.Length > 0 && emailTextBox.Text.Contains("@") != true)
                errorsLog.AppendLine("Поле \"Email\" заполнено в неверном формате");


            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось сохранить изменения: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (client.ID == 0)
            {
                Program.db.Clients.Add(client);
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


    }
}
