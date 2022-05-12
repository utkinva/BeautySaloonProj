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

            Program.currentUser = Program.db.Users.Find(loginTextBox.Text);

            if (Program.currentUser != null)
            {
                if (Program.currentUser.Login == Program.currentUser.Login)
                {
                    if (Program.currentUser.Password == Program.currentUser.Password)
                    {
                        MessageBox.Show($"Добро пожаловать, {Program.currentUser.Name}!");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        errorsLog.AppendLine("Неверный пароль");
                    }
                }
                else
                {
                    errorsLog.AppendLine("Пользователя с таким логином не существует");
                }
            }

            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось авторизоваться: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
