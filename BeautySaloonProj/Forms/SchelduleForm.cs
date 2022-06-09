using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautySaloonProj.ModelEF;


namespace BeautySaloonProj.Forms
{
    public partial class SchelduleForm : Form
    {
        public SchelduleForm()
        {
            InitializeComponent();
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
            CurrentUserLbl.Text = $"Вы авторизовались как {Program.currentUser.UserTypes.Title}";
            timer1.Start();
        }

        private void SchelduleForm_Load(object sender, EventArgs e)
        {
            if (Program.currentUser.UserTypeID == 3)
            {
                editBtn.Visible = true;
                deleteBtn.Visible = true;
            }
            else
            {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNowLbl.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void ExcelExportBtn_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Экспорт_график_работы.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Не удалось сохранить файл" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = scheduleDataGridView.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[scheduleDataGridView.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                if (i==5)
                                {
                                    columnNames += scheduleDataGridView.Columns[i].HeaderText.ToString();
                                    break;
                                }
                                columnNames += scheduleDataGridView.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < scheduleDataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    if (j == 5)
                                    {
                                        outputCsv[i] += scheduleDataGridView.Rows[i - 1].Cells[j].Value.ToString();
                                        break;
                                    }
                                    outputCsv[i] += scheduleDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            DialogResult dr = MessageBox.Show("График работы успешно выгружен. Открыть созданный файл?", "Успешно", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                Process.Start(sfd.FileName);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет данных для выгрузки", "Ошибка");
            }
        }
    }
}
