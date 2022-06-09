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
    public partial class ClientsListForm : Form
    {
        public ClientsListForm()
        {
            InitializeComponent();
            CurrentUserLbl.Text = $"Вы авторизовались как {Program.currentUser.UserTypes.Title}";
            timer1.Start();
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void ClientsListForm_Load(object sender, EventArgs e)
        {
            clientsBindingSource.DataSource = Program.db.Clients.ToList();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((Clients)clientsBindingSource.Current != null)
            {
                Clients itemToDelete = (Clients)clientsBindingSource.Current;
                DialogResult dialogResult = MessageBox.Show($"Удалить клиента №{itemToDelete.ID}?\nУдаление клиента приведет к удалению всех его текущих записей, а также истории выполненных заказов этого клиента", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.db.Clients.Remove(itemToDelete);
                    Program.db.SaveChanges();
                    clientsBindingSource.DataSource = Program.db.Clients.ToList();
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
            if ((Clients)clientsBindingSource.Current != null)
            {
                AddEditClientForm editClient = new AddEditClientForm((Clients)clientsBindingSource.Current);
                DialogResult dialog = editClient.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    clientsBindingSource.DataSource = Program.db.Clients.ToList();
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
            AddEditClientForm addClient = new AddEditClientForm(null);
            DialogResult dialog = addClient.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                clientsBindingSource.DataSource = Program.db.Clients.ToList();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }
    }
}
