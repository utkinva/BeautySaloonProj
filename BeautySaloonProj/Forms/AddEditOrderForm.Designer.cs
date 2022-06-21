namespace BeautySaloonProj.Forms
{
    partial class AddEditOrderForm
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
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label masterIDLabel;
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label timeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditOrderForm));
            this.clientIDComboBox = new System.Windows.Forms.ComboBox();
            this.currentOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterIDComboBox = new System.Windows.Forms.ComboBox();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceIDComboBox = new System.Windows.Forms.ComboBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newClientBtn = new System.Windows.Forms.Button();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            clientIDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            masterIDLabel = new System.Windows.Forms.Label();
            serviceIDLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            clientIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            clientIDLabel.Location = new System.Drawing.Point(14, 87);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(69, 20);
            clientIDLabel.TabIndex = 1;
            clientIDLabel.Text = "Клиент:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            dateLabel.Location = new System.Drawing.Point(14, 19);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(52, 20);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Дата:";
            // 
            // masterIDLabel
            // 
            masterIDLabel.AutoSize = true;
            masterIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            masterIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            masterIDLabel.Location = new System.Drawing.Point(14, 156);
            masterIDLabel.Name = "masterIDLabel";
            masterIDLabel.Size = new System.Drawing.Size(70, 20);
            masterIDLabel.TabIndex = 7;
            masterIDLabel.Text = "Мастер:";
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            serviceIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            serviceIDLabel.Location = new System.Drawing.Point(14, 191);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(64, 20);
            serviceIDLabel.TabIndex = 9;
            serviceIDLabel.Text = "Услуга:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            timeLabel.Location = new System.Drawing.Point(14, 52);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(62, 20);
            timeLabel.TabIndex = 11;
            timeLabel.Text = "Время:";
            // 
            // clientIDComboBox
            // 
            this.clientIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.clientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currentOrdersBindingSource, "ClientID", true));
            this.clientIDComboBox.DataSource = this.clientsBindingSource;
            this.clientIDComboBox.DisplayMember = "Name";
            this.clientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clientIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.clientIDComboBox.FormattingEnabled = true;
            this.clientIDComboBox.Location = new System.Drawing.Point(128, 76);
            this.clientIDComboBox.Name = "clientIDComboBox";
            this.clientIDComboBox.Size = new System.Drawing.Size(363, 28);
            this.clientIDComboBox.TabIndex = 2;
            this.clientIDComboBox.TabStop = false;
            this.clientIDComboBox.ValueMember = "ID";
            // 
            // currentOrdersBindingSource
            // 
            this.currentOrdersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.CurrentOrders);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Clients);
            // 
            // masterIDComboBox
            // 
            this.masterIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.masterIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currentOrdersBindingSource, "MasterID", true));
            this.masterIDComboBox.DataSource = this.mastersBindingSource;
            this.masterIDComboBox.DisplayMember = "Name";
            this.masterIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.masterIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.masterIDComboBox.FormattingEnabled = true;
            this.masterIDComboBox.Location = new System.Drawing.Point(128, 148);
            this.masterIDComboBox.Name = "masterIDComboBox";
            this.masterIDComboBox.Size = new System.Drawing.Size(363, 28);
            this.masterIDComboBox.TabIndex = 8;
            this.masterIDComboBox.TabStop = false;
            this.masterIDComboBox.ValueMember = "ID";
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Masters);
            // 
            // serviceIDComboBox
            // 
            this.serviceIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.serviceIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currentOrdersBindingSource, "ServiceID", true));
            this.serviceIDComboBox.DataSource = this.servicesBindingSource;
            this.serviceIDComboBox.DisplayMember = "Title";
            this.serviceIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.serviceIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.serviceIDComboBox.FormattingEnabled = true;
            this.serviceIDComboBox.Location = new System.Drawing.Point(128, 183);
            this.serviceIDComboBox.Name = "serviceIDComboBox";
            this.serviceIDComboBox.Size = new System.Drawing.Size(363, 28);
            this.serviceIDComboBox.TabIndex = 10;
            this.serviceIDComboBox.TabStop = false;
            this.serviceIDComboBox.ValueMember = "ID";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Services);
            // 
            // timeMaskedTextBox
            // 
            this.timeMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.timeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentOrdersBindingSource, "Time", true));
            this.timeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.timeMaskedTextBox.Location = new System.Drawing.Point(128, 44);
            this.timeMaskedTextBox.Mask = "00:00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(363, 26);
            this.timeMaskedTextBox.TabIndex = 1;
            this.timeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cancelBtn.Location = new System.Drawing.Point(327, 217);
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
            this.saveBtn.Location = new System.Drawing.Point(128, 217);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newClientBtn
            // 
            this.newClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.newClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClientBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.newClientBtn.Location = new System.Drawing.Point(352, 113);
            this.newClientBtn.Name = "newClientBtn";
            this.newClientBtn.Size = new System.Drawing.Size(139, 29);
            this.newClientBtn.TabIndex = 14;
            this.newClientBtn.TabStop = false;
            this.newClientBtn.Text = "Новый клиент";
            this.newClientBtn.UseVisualStyleBackColor = false;
            this.newClientBtn.Click += new System.EventHandler(this.newClientBtn_Click);
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dateMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentOrdersBindingSource, "Date", true));
            this.dateMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.dateMaskedTextBox.Location = new System.Drawing.Point(128, 12);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(363, 26);
            this.dateMaskedTextBox.TabIndex = 0;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // AddEditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(503, 274);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.newClientBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(masterIDLabel);
            this.Controls.Add(this.masterIDComboBox);
            this.Controls.Add(serviceIDLabel);
            this.Controls.Add(this.serviceIDComboBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeMaskedTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая запись";
            this.Load += new System.EventHandler(this.AddEditOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource currentOrdersBindingSource;
        private System.Windows.Forms.ComboBox clientIDComboBox;
        private System.Windows.Forms.ComboBox masterIDComboBox;
        private System.Windows.Forms.ComboBox serviceIDComboBox;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newClientBtn;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
    }
}