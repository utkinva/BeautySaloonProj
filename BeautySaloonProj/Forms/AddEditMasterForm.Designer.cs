namespace BeautySaloonProj.Forms
{
    partial class AddEditMasterForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label specializationLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label weekdaysLabel;
            System.Windows.Forms.Label weekendLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMasterForm));
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.weekdaysTextBox = new System.Windows.Forms.TextBox();
            this.weekendTextBox = new System.Windows.Forms.TextBox();
            this.SchedulePanel = new System.Windows.Forms.Panel();
            this.endTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.startTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            specializationLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            weekdaysLabel = new System.Windows.Forms.Label();
            weekendLabel = new System.Windows.Forms.Label();
            this.SchedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            iDLabel.Location = new System.Drawing.Point(12, 18);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            nameLabel.Location = new System.Drawing.Point(12, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(104, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Полное имя:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            phoneLabel.Location = new System.Drawing.Point(12, 84);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(142, 20);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Номер телефона";
            // 
            // specializationLabel
            // 
            specializationLabel.AutoSize = true;
            specializationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            specializationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            specializationLabel.Location = new System.Drawing.Point(12, 117);
            specializationLabel.Name = "specializationLabel";
            specializationLabel.Size = new System.Drawing.Size(128, 20);
            specializationLabel.TabIndex = 7;
            specializationLabel.Text = "Специальность";
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.iDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.iDTextBox.Location = new System.Drawing.Point(228, 12);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(236, 26);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.nameTextBox.Location = new System.Drawing.Point(228, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.phoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(228, 78);
            this.phoneMaskedTextBox.Mask = "+7 (999) 000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(236, 26);
            this.phoneMaskedTextBox.TabIndex = 1;
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.specializationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specializationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "Specialization", true));
            this.specializationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.specializationTextBox.Location = new System.Drawing.Point(228, 111);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(236, 26);
            this.specializationTextBox.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cancelBtn.Location = new System.Drawing.Point(300, 311);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 43);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Закрыть";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.saveBtn.Location = new System.Drawing.Point(16, 311);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // weekdaysTextBox
            // 
            this.weekdaysTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.weekdaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Weekdays", true));
            this.weekdaysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekdaysTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.weekdaysTextBox.Location = new System.Drawing.Point(228, 3);
            this.weekdaysTextBox.Name = "weekdaysTextBox";
            this.weekdaysTextBox.Size = new System.Drawing.Size(236, 26);
            this.weekdaysTextBox.TabIndex = 19;
            // 
            // weekendTextBox
            // 
            this.weekendTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.weekendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Weekend", true));
            this.weekendTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekendTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.weekendTextBox.Location = new System.Drawing.Point(228, 35);
            this.weekendTextBox.Name = "weekendTextBox";
            this.weekendTextBox.Size = new System.Drawing.Size(236, 26);
            this.weekendTextBox.TabIndex = 21;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            endTimeLabel.Location = new System.Drawing.Point(12, 105);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(206, 20);
            endTimeLabel.TabIndex = 22;
            endTimeLabel.Text = "Время окончания работы:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            startTimeLabel.Location = new System.Drawing.Point(12, 73);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(181, 20);
            startTimeLabel.TabIndex = 23;
            startTimeLabel.Text = "Время начала работы:";
            // 
            // weekdaysLabel
            // 
            weekdaysLabel.AutoSize = true;
            weekdaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weekdaysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            weekdaysLabel.Location = new System.Drawing.Point(12, 9);
            weekdaysLabel.Name = "weekdaysLabel";
            weekdaysLabel.Size = new System.Drawing.Size(110, 20);
            weekdaysLabel.TabIndex = 24;
            weekdaysLabel.Text = "Рабочие дни:";
            // 
            // weekendLabel
            // 
            weekendLabel.AutoSize = true;
            weekendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weekendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            weekendLabel.Location = new System.Drawing.Point(12, 42);
            weekendLabel.Name = "weekendLabel";
            weekendLabel.Size = new System.Drawing.Size(91, 20);
            weekendLabel.TabIndex = 25;
            weekendLabel.Text = "Выходные:";
            // 
            // SchedulePanel
            // 
            this.SchedulePanel.Controls.Add(this.startTimeMaskedTextBox);
            this.SchedulePanel.Controls.Add(this.endTimeMaskedTextBox);
            this.SchedulePanel.Controls.Add(weekdaysLabel);
            this.SchedulePanel.Controls.Add(endTimeLabel);
            this.SchedulePanel.Controls.Add(this.weekendTextBox);
            this.SchedulePanel.Controls.Add(startTimeLabel);
            this.SchedulePanel.Controls.Add(this.weekdaysTextBox);
            this.SchedulePanel.Controls.Add(weekendLabel);
            this.SchedulePanel.Location = new System.Drawing.Point(0, 143);
            this.SchedulePanel.Name = "SchedulePanel";
            this.SchedulePanel.Size = new System.Drawing.Size(493, 150);
            this.SchedulePanel.TabIndex = 26;
            // 
            // endTimeMaskedTextBox
            // 
            this.endTimeMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.endTimeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "EndTime", true));
            this.endTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTimeMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.endTimeMaskedTextBox.Location = new System.Drawing.Point(228, 99);
            this.endTimeMaskedTextBox.Mask = "00:00";
            this.endTimeMaskedTextBox.Name = "endTimeMaskedTextBox";
            this.endTimeMaskedTextBox.Size = new System.Drawing.Size(236, 26);
            this.endTimeMaskedTextBox.TabIndex = 26;
            this.endTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // startTimeMaskedTextBox
            // 
            this.startTimeMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.startTimeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "StartTime", true));
            this.startTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimeMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.startTimeMaskedTextBox.Location = new System.Drawing.Point(228, 67);
            this.startTimeMaskedTextBox.Mask = "00:00";
            this.startTimeMaskedTextBox.Name = "startTimeMaskedTextBox";
            this.startTimeMaskedTextBox.Size = new System.Drawing.Size(236, 26);
            this.startTimeMaskedTextBox.TabIndex = 27;
            this.startTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Schedule);
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Masters);
            // 
            // AddEditMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(493, 366);
            this.Controls.Add(this.SchedulePanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(specializationLabel);
            this.Controls.Add(this.specializationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый мастер";
            this.Load += new System.EventHandler(this.AddEditMasterForm_Load);
            this.SchedulePanel.ResumeLayout(false);
            this.SchedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.TextBox weekdaysTextBox;
        private System.Windows.Forms.TextBox weekendTextBox;
        private System.Windows.Forms.Panel SchedulePanel;
        private System.Windows.Forms.MaskedTextBox startTimeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox endTimeMaskedTextBox;
    }
}