namespace BeautySaloonProj.Forms
{
    partial class AddEditScheldule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label masterIDLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label weekdaysLabel;
            System.Windows.Forms.Label weekendLabel;
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.masterIDComboBox = new System.Windows.Forms.ComboBox();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekdaysTextBox = new System.Windows.Forms.TextBox();
            this.weekendTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.startTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            endTimeLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            masterIDLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            weekdaysLabel = new System.Windows.Forms.Label();
            weekendLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endTimeLabel.Location = new System.Drawing.Point(12, 180);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(206, 20);
            endTimeLabel.TabIndex = 1;
            endTimeLabel.Text = "Время окончания работы:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(12, 18);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // masterIDLabel
            // 
            masterIDLabel.AutoSize = true;
            masterIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            masterIDLabel.Location = new System.Drawing.Point(12, 52);
            masterIDLabel.Name = "masterIDLabel";
            masterIDLabel.Size = new System.Drawing.Size(70, 20);
            masterIDLabel.TabIndex = 5;
            masterIDLabel.Text = "Мастер:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startTimeLabel.Location = new System.Drawing.Point(12, 147);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(181, 20);
            startTimeLabel.TabIndex = 7;
            startTimeLabel.Text = "Время начала работы:";
            // 
            // weekdaysLabel
            // 
            weekdaysLabel.AutoSize = true;
            weekdaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weekdaysLabel.Location = new System.Drawing.Point(12, 84);
            weekdaysLabel.Name = "weekdaysLabel";
            weekdaysLabel.Size = new System.Drawing.Size(110, 20);
            weekdaysLabel.TabIndex = 9;
            weekdaysLabel.Text = "Рабочие дни:";
            // 
            // weekendLabel
            // 
            weekendLabel.AutoSize = true;
            weekendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weekendLabel.Location = new System.Drawing.Point(12, 116);
            weekendLabel.Name = "weekendLabel";
            weekendLabel.Size = new System.Drawing.Size(91, 20);
            weekendLabel.TabIndex = 11;
            weekendLabel.Text = "Выходные:";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Schedule);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox.Location = new System.Drawing.Point(259, 12);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(274, 26);
            this.iDTextBox.TabIndex = 4;
            // 
            // masterIDComboBox
            // 
            this.masterIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.scheduleBindingSource, "MasterID", true));
            this.masterIDComboBox.DataSource = this.mastersBindingSource;
            this.masterIDComboBox.DisplayMember = "Name";
            this.masterIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIDComboBox.FormattingEnabled = true;
            this.masterIDComboBox.Location = new System.Drawing.Point(259, 44);
            this.masterIDComboBox.Name = "masterIDComboBox";
            this.masterIDComboBox.Size = new System.Drawing.Size(274, 28);
            this.masterIDComboBox.TabIndex = 6;
            this.masterIDComboBox.ValueMember = "ID";
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Masters);
            // 
            // weekdaysTextBox
            // 
            this.weekdaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Weekdays", true));
            this.weekdaysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekdaysTextBox.Location = new System.Drawing.Point(259, 78);
            this.weekdaysTextBox.Name = "weekdaysTextBox";
            this.weekdaysTextBox.Size = new System.Drawing.Size(274, 26);
            this.weekdaysTextBox.TabIndex = 10;
            // 
            // weekendTextBox
            // 
            this.weekendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Weekend", true));
            this.weekendTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekendTextBox.Location = new System.Drawing.Point(259, 110);
            this.weekendTextBox.Name = "weekendTextBox";
            this.weekendTextBox.Size = new System.Drawing.Size(274, 26);
            this.weekendTextBox.TabIndex = 12;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(12, 221);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 36);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(369, 221);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 36);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // startTimeMaskedTextBox
            // 
            this.startTimeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "StartTime", true));
            this.startTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimeMaskedTextBox.Location = new System.Drawing.Point(259, 142);
            this.startTimeMaskedTextBox.Mask = "00:00";
            this.startTimeMaskedTextBox.Name = "startTimeMaskedTextBox";
            this.startTimeMaskedTextBox.Size = new System.Drawing.Size(274, 26);
            this.startTimeMaskedTextBox.TabIndex = 14;
            // 
            // endTimeMaskedTextBox
            // 
            this.endTimeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "EndTime", true));
            this.endTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTimeMaskedTextBox.Location = new System.Drawing.Point(259, 174);
            this.endTimeMaskedTextBox.Mask = "00:00";
            this.endTimeMaskedTextBox.Name = "endTimeMaskedTextBox";
            this.endTimeMaskedTextBox.Size = new System.Drawing.Size(274, 26);
            this.endTimeMaskedTextBox.TabIndex = 15;
            // 
            // AddEditScheldule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(570, 277);
            this.Controls.Add(this.endTimeMaskedTextBox);
            this.Controls.Add(this.startTimeMaskedTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(masterIDLabel);
            this.Controls.Add(this.masterIDComboBox);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(weekdaysLabel);
            this.Controls.Add(this.weekdaysTextBox);
            this.Controls.Add(weekendLabel);
            this.Controls.Add(this.weekendTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddEditScheldule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить график работы";
            this.Load += new System.EventHandler(this.AddEditScheldule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox masterIDComboBox;
        private System.Windows.Forms.TextBox weekdaysTextBox;
        private System.Windows.Forms.TextBox weekendTextBox;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.MaskedTextBox startTimeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox endTimeMaskedTextBox;
    }
}