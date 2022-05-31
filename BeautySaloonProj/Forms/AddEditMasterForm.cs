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
    public partial class AddEditMasterForm : Form
    {
        Masters master;
        public AddEditMasterForm(Masters current)
        {
            InitializeComponent();
            if (current != null)
            {
                master = current;
            }
            else
            {
                master = new Masters();
            }
        }

        private void AddEditMasterForm_Load(object sender, EventArgs e)
        {
            if (master != null)
            {
                mastersBindingSource.Add(master);
                this.Text = "Редактировать данные мастера";
            }
            else
            {
                mastersBindingSource.AddNew();
                this.Text = "Новый мастер";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (master.ID == 0)
            {
                foreach (var item in Program.db.Masters.ToList())
                {
                    if (item.Name == nameTextBox.Text &&
                        item.Phone == phoneMaskedTextBox.Text)
                    {
                        MessageBox.Show($"Такой мастер уже зарегистрирован в системе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


            StringBuilder errorsLog = new StringBuilder();

            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
                errorsLog.AppendLine("Заполните поле \"Полное имя\"");
            if (String.IsNullOrWhiteSpace(specializationTextBox.Text))
                errorsLog.AppendLine("Заполните поле \"Специализация\"");
            if (phoneMaskedTextBox.Text.Length != 18)
                errorsLog.AppendLine("Заполните поле \"Номер телефона\"");




            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось сохранить изменения: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (master.ID == 0)
            {
                Program.db.Masters.Add(master);
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
