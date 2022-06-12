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
        Schedule schedule;
        public AddEditMasterForm(Masters current)
        {
            InitializeComponent();
            if (current != null)
            {
                master = current;
                this.Text = "Редактировать данные мастера";
                SchedulePanel.Visible = false;
            }
            else
            {
                master = new Masters();
                this.Text = "Новый мастер";
                SchedulePanel.Visible = true;
            }

        }

        private void AddEditMasterForm_Load(object sender, EventArgs e)
        {
            if (master != null)
            {
                mastersBindingSource.Add(master);

            }
            else
            {
                mastersBindingSource.AddNew();
                scheduleBindingSource.AddNew();

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
            if (String.IsNullOrWhiteSpace(specializationTextBox.Text))
                errorsLog.AppendLine("Заполните поле \"Специализация\"");
            if (phoneMaskedTextBox.Text.Length != 18)
                errorsLog.AppendLine("Заполните поле \"Номер телефона\"");
            if (SchedulePanel.Visible == true)
            {
                if (startTimeMaskedTextBox.Text.Length != 5)
                    errorsLog.AppendLine("Заполните время начала работы");
                if (endTimeMaskedTextBox.Text.Length != 5)
                    errorsLog.AppendLine("Заполните время окончания работы");
            }


            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось сохранить изменения: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

            List<Masters> mastersList = Program.db.Masters.ToList();
            int[] mastersArray = new int[mastersList.Count];

            for (int i = 0; i < mastersList.Count - 1; i++)
            {
                mastersArray[i] = mastersList[i].ID;
            }

            if (master.ID == 0)
            {
                Program.db.Masters.Add(master);
                if (SchedulePanel.Visible == true)
                {
                    schedule = new Schedule()
                    {
                        MasterID = int.Parse(mastersArray[mastersArray.Length - 1].ToString()) + 1,
                        Weekend = weekendTextBox.Text,
                        StartTime = TimeSpan.Parse(startTimeMaskedTextBox.Text),
                        EndTime = TimeSpan.Parse(endTimeMaskedTextBox.Text),
                        Masters = master
                    };
                    Program.db.Schedule.Add(schedule);
                }
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
