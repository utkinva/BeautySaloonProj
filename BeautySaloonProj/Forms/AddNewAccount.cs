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
    public partial class AddNewAccount : Form
    {
        public AddNewAccount()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            userTypesBindingSource.DataSource = Program.db.UserTypes.ToList();
            usersBindingSource.AddNew();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Несохраненные изменения будут потеряны. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
                DialogResult = DialogResult.Cancel;
            else
                return;

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (Program.db.Users.Find(loginTextBox.Text) != null)
            {
                MessageBox.Show($"Пользователь с таким логином уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder errorsLog = new StringBuilder();
            if (String.IsNullOrWhiteSpace(loginTextBox.Text))
                errorsLog.AppendLine("Заполните поле логин");
            if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
                errorsLog.AppendLine("Заполните поле пароль");
            if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
                errorsLog.AppendLine("Заполните поле пароль");
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
                errorsLog.AppendLine("Заполните поле полное имя");
            if (passwordTextBox.Text != passwordConfirmTextBox.Text)
                errorsLog.AppendLine("Введенные пароли не совпадают");
            if (userTypeIDComboBox.SelectedItem == null)
                errorsLog.AppendLine("Выберите тип пользователя");

            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось зарегистрировать пользователя: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Program.db.Users.Add((Users)usersBindingSource.Current);
                Program.db.SaveChanges();
                MessageBox.Show("Учетная запись зарегистрирована", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла непредвиденная ошибка.\nДетали:\n{ex.Message}");
                return;
            }
        }
    }
}
