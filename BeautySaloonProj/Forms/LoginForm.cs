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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
        } 
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errorsLog = new StringBuilder();
            if (String.IsNullOrWhiteSpace(loginTextBox.Text))
                errorsLog.AppendLine("Заполните поле логин");
            if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
                errorsLog.AppendLine("Заполните поле пароль");

            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось авторизоваться: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.currentUser = Program.db.Users.Find(loginTextBox.Text);

            if (Program.currentUser != null)
            {
                if (Program.currentUser.Password == passwordTextBox.Text)
                {
                    MessageBox.Show($"Добро пожаловать, {Program.currentUser.Name}!");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
