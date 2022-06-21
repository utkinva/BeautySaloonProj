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
            System.Windows.Forms.Label masterIDLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label weekendLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditScheldule));
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterIDComboBox = new System.Windows.Forms.ComboBox();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.startTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.weekendTextBox = new System.Windows.Forms.TextBox();
            endTimeLabel = new System.Windows.Forms.Label();
            masterIDLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            weekendLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            endTimeLabel.Location = new System.Drawing.Point(8, 118);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(206, 20);
            endTimeLabel.TabIndex = 1;
            endTimeLabel.Text = "Время окончания работы:";
            // 
            // masterIDLabel
            // 
            masterIDLabel.AutoSize = true;
            masterIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            masterIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            masterIDLabel.Location = new System.Drawing.Point(8, 20);
            masterIDLabel.Name = "masterIDLabel";
            masterIDLabel.Size = new System.Drawing.Size(70, 20);
            masterIDLabel.TabIndex = 5;
            masterIDLabel.Text = "Мастер:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            startTimeLabel.Location = new System.Drawing.Point(8, 85);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(181, 20);
            startTimeLabel.TabIndex = 7;
            startTimeLabel.Text = "Время начала работы:";
            // 
            // weekendLabel
            // 
            weekendLabel.AutoSize = true;
            weekendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weekendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            weekendLabel.Location = new System.Drawing.Point(8, 52);
            weekendLabel.Name = "weekendLabel";
            weekendLabel.Size = new System.Drawing.Size(91, 20);
            weekendLabel.TabIndex = 11;
            weekendLabel.Text = "Выходные:";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Schedule);
            // 
            // masterIDComboBox
            // 
            this.masterIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.scheduleBindingSource, "MasterID", true));
            this.masterIDComboBox.DataSource = this.mastersBindingSource;
            this.masterIDComboBox.DisplayMember = "Name";
            this.masterIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIDComboBox.FormattingEnabled = true;
            this.masterIDComboBox.Location = new System.Drawing.Point(255, 12);
            this.masterIDComboBox.Name = "masterIDComboBox";
            this.masterIDComboBox.Size = new System.Drawing.Size(274, 28);
            this.masterIDComboBox.TabIndex = 6;
            this.masterIDComboBox.TabStop = false;
            this.masterIDComboBox.ValueMember = "ID";
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Masters);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.saveBtn.Location = new System.Drawing.Point(12, 160);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 36);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cancelBtn.Location = new System.Drawing.Point(365, 160);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 36);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // startTimeMaskedTextBox
            // 
            this.startTimeMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.startTimeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "StartTime", true));
            this.startTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimeMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.startTimeMaskedTextBox.Location = new System.Drawing.Point(255, 79);
            this.startTimeMaskedTextBox.Mask = "00:00";
            this.startTimeMaskedTextBox.Name = "startTimeMaskedTextBox";
            this.startTimeMaskedTextBox.Size = new System.Drawing.Size(274, 26);
            this.startTimeMaskedTextBox.TabIndex = 2;
            this.startTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // endTimeMaskedTextBox
            // 
            this.endTimeMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.endTimeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "EndTime", true));
            this.endTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTimeMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.endTimeMaskedTextBox.Location = new System.Drawing.Point(255, 112);
            this.endTimeMaskedTextBox.Mask = "00:00";
            this.endTimeMaskedTextBox.Name = "endTimeMaskedTextBox";
            this.endTimeMaskedTextBox.Size = new System.Drawing.Size(274, 26);
            this.endTimeMaskedTextBox.TabIndex = 3;
            this.endTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // weekendTextBox
            // 
            this.weekendTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.weekendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Weekend", true));
            this.weekendTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekendTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.weekendTextBox.Location = new System.Drawing.Point(255, 46);
            this.weekendTextBox.Name = "weekendTextBox";
            this.weekendTextBox.Size = new System.Drawing.Size(274, 26);
            this.weekendTextBox.TabIndex = 1;
            // 
            // AddEditScheldule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(542, 207);
            this.Controls.Add(this.endTimeMaskedTextBox);
            this.Controls.Add(this.startTimeMaskedTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(masterIDLabel);
            this.Controls.Add(this.masterIDComboBox);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(weekendLabel);
            this.Controls.Add(this.weekendTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox masterIDComboBox;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.MaskedTextBox startTimeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox endTimeMaskedTextBox;
        private System.Windows.Forms.TextBox weekendTextBox;
    }
}