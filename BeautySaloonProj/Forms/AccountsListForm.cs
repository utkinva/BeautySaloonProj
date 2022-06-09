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
    public partial class AccountsListForm : Form
    {
        public AccountsListForm()
        {
            InitializeComponent();
            CurrentUserLbl.Text = $"Вы авторизовались как {Program.currentUser.UserTypes.Title}";
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
            timer1.Start();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((Users)usersBindingSource.Current != null)
            {
                Users itemToDelete = (Users)usersBindingSource.Current;
                if (Program.currentUser.Login != itemToDelete.Login)
                {
                    DialogResult dialogResult = MessageBox.Show($"Удалить пользователя с логином {itemToDelete.Login}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Program.db.Users.Remove(itemToDelete);
                        Program.db.SaveChanges();
                        usersBindingSource.DataSource = Program.db.Users.ToList();
                    }
                    else
                        return;
                }
                else
                {
                    MessageBox.Show("Нельзя удалить собственную учетную запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show($"Не выбрана ни одна запись в таблице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AccountsListForm_Load(object sender, EventArgs e)
        {
            userTypesBindingSource.DataSource = Program.db.UserTypes.ToList();
            usersBindingSource.DataSource = Program.db.Users.ToList();
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
