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
    public partial class ServicesListForm : Form
    {
        public ServicesListForm()
        {
            InitializeComponent();
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
            CurrentUserLbl.Text = $"Вы авторизовались как {Program.currentUser.UserTypes.Title}";
            timer1.Start();
        }

        private void ServicesListForm_Load(object sender, EventArgs e)
        {
            servicesBindingSource.DataSource = Program.db.Services.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditServiceForm addService = new AddEditServiceForm(null);
            DialogResult dialogResult = addService.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                servicesBindingSource.DataSource = Program.db.Services.ToList();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((Services)servicesBindingSource.Current != null)
            {
                Services itemToDelete = (Services)servicesBindingSource.Current;
                DialogResult dialogResult = MessageBox.Show($"Удалить услугу \"{itemToDelete.Title}\"?\nУдаление услуги приведет к удалению всех заказов, где используется эта услуга, в том числе выполненных", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.db.Services.Remove(itemToDelete);
                    Program.db.SaveChanges();
                    servicesBindingSource.DataSource = Program.db.Services.ToList();
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show($"Не выбрана ни одна запись в таблице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if ((Services)servicesBindingSource.Current != null)
            {
                AddEditServiceForm editService = new AddEditServiceForm((Services)servicesBindingSource.Current);
                DialogResult dialogResult = editService.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    servicesBindingSource.DataSource = Program.db.Services.ToList();
                }
            }
            else
            {
                MessageBox.Show($"Не выбрана ни одна запись в таблице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }
    }
}
