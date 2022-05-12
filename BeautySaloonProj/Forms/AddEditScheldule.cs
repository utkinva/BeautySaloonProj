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
    public partial class AddEditScheldule : Form
    {
        Schedule currentScheldule { get; set; } = null;
        public AddEditScheldule(Schedule scheduleParam)
        {
            InitializeComponent();
            if (scheduleParam != null)
            {
                currentScheldule = scheduleParam;
                //scheduleBindingSource.Add(currentScheldule);
                //this.Text = "Редактировать график работы";
            }
            else
            {
                currentScheldule = new Schedule();
                //scheduleBindingSource.AddNew();
                //this.Text = "Создать график работы";
            }
        }

        private void AddEditScheldule_Load(object sender, EventArgs e)
        {
            mastersBindingSource.DataSource = Program.db.Masters.ToList();
            if (currentScheldule != null)
            {
                scheduleBindingSource.Add(currentScheldule);
                this.Text = "Редактировать график работы";
            }
            else
            {
                scheduleBindingSource.AddNew();
                this.Text = "Создать график работы";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errorsLog = new StringBuilder();
            if (masterIDComboBox.SelectedItem == null)
                errorsLog.AppendLine("Выберите мастера");
            if (String.IsNullOrWhiteSpace(weekdaysTextBox.Text))
                errorsLog.AppendLine("Заполните рабочие дни");
            if (startTimeMaskedTextBox.Text.Length < 5)
                errorsLog.AppendLine("Время начала работы имеет неверный формат");
            if (endTimeMaskedTextBox.Text.Length < 5)
                errorsLog.AppendLine("Время окончания работы имеет неверный формат");


            if (errorsLog.Length != 0)
            {
                MessageBox.Show($"Не удалось сохранить изменения: \n{errorsLog}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentScheldule.ID == 0)
            {
                Program.db.Schedule.Add(currentScheldule);
            }

            try
            {
                Program.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
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
