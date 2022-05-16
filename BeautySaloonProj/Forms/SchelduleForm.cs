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
    public partial class SchelduleForm : Form
    {
        public SchelduleForm()
        {
            InitializeComponent();
        }

        private void SchelduleForm_Load(object sender, EventArgs e)
        {
            if (Program.currentUser.UserTypeID == 3)
            {
                addBtn.Visible = true;
                editBtn.Visible = true;
                deleteBtn.Visible = true;
            }
            else
            {
                addBtn.Visible = false;
                editBtn.Visible = false;
                deleteBtn.Visible = false;
            }

            mastersBindingSource.DataSource = Program.db.Masters.ToList();
            scheduleBindingSource.DataSource = Program.db.Schedule.ToList();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditScheldule editScheldule = new AddEditScheldule(null);
            DialogResult dialogResult = editScheldule.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                scheduleBindingSource.DataSource = Program.db.Schedule.ToList();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((Schedule)scheduleBindingSource.Current != null)
            {
                Schedule itemToDelete = (Schedule)scheduleBindingSource.Current;
                DialogResult dialogResult = MessageBox.Show($"Удалить график №{itemToDelete.ID}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.db.Schedule.Remove(itemToDelete);
                    Program.db.SaveChanges();
                    scheduleBindingSource.DataSource = Program.db.Schedule.ToList();
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
            if ((Schedule)scheduleBindingSource.Current != null)
            {
                AddEditScheldule editScheldule = new AddEditScheldule((Schedule)scheduleBindingSource.Current);
                DialogResult dialogResult = editScheldule.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    scheduleBindingSource.DataSource = Program.db.Schedule.ToList();
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
    }
}
