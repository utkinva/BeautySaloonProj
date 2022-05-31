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
    public partial class AddEditServiceForm : Form
    {
        Services service;
        public AddEditServiceForm(Services current)
        {
            InitializeComponent();
            if (current != null)
{
                service = current;
            }
            else
{
                service = new Services();
            }
        }

        private void AddEditServiceForm_Load(object sender, EventArgs e)
        {
            if (service != null)
            {
                servicesBindingSource.Add(service);
                this.Text = "Редактировать данные услуги";
            }
            else
            {
                servicesBindingSource.AddNew();
                this.Text = "Новая услуга";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (service.ID == 0)
            {
                Program.db.Services.Add(service);
                foreach (var item in Program.db.Services.ToList())
                {
                    if (item.Title == titleTextBox.Text)
                    {
                        MessageBox.Show($"Такая услуга уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            StringBuilder errorsLog = new StringBuilder();

            if (String.IsNullOrWhiteSpace(titleTextBox.Text))
                errorsLog.AppendLine("Заполните поле \"Полное имя\"");
            if (costTextBox.Text.Length == 0)
                errorsLog.AppendLine("Заполните поле \"Стоимость\"");



            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось сохранить изменения: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (service.ID == 0)
            {
                Program.db.Services.Add(service);
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

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
