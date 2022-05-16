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
    public partial class MastersListForm : Form
    {
        public MastersListForm()
        {
            InitializeComponent();
        }


        private void MastersListForm_Load(object sender, EventArgs e)
        {
            mastersBindingSource.DataSource = Program.db.Masters.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditMasterForm editMaster = new AddEditMasterForm(null);
            DialogResult dialogResult = editMaster.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                mastersBindingSource.DataSource = Program.db.Masters.ToList();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((Masters)mastersBindingSource.Current != null)
            {
                Masters itemToDelete = (Masters)mastersBindingSource.Current;
                DialogResult dialogResult = MessageBox.Show($"Удалить мастера №{itemToDelete.ID}?\nУдаление мастера приведет к удалению всех его заказов, графика работы и всех выполненных заказов", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.db.Masters.Remove(itemToDelete);
                    Program.db.SaveChanges();
                    mastersBindingSource.DataSource = Program.db.Masters.ToList();
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
            if ((Masters)mastersBindingSource.Current != null)
            {
                AddEditMasterForm editMaster = new AddEditMasterForm((Masters)mastersBindingSource.Current);
                DialogResult dialogResult = editMaster.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    mastersBindingSource.DataSource = Program.db.Masters.ToList();
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
