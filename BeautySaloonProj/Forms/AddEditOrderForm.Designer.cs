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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label masterIDLabel;
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label timeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditOrderForm));
            this.clientIDComboBox = new System.Windows.Forms.ComboBox();
            this.currentOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.masterIDComboBox = new System.Windows.Forms.ComboBox();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceIDComboBox = new System.Windows.Forms.ComboBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newClientBtn = new System.Windows.Forms.Button();
            clientIDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
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
            clientIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            clientIDLabel.Location = new System.Drawing.Point(6, 119);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(68, 21);
            clientIDLabel.TabIndex = 1;
            clientIDLabel.Text = "Клиент:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.Location = new System.Drawing.Point(6, 51);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(54, 21);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Дата:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(6, 18);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(31, 21);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            // 
            // masterIDLabel
            // 
            masterIDLabel.AutoSize = true;
            masterIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            masterIDLabel.Location = new System.Drawing.Point(6, 154);
            masterIDLabel.Name = "masterIDLabel";
            masterIDLabel.Size = new System.Drawing.Size(77, 21);
            masterIDLabel.TabIndex = 7;
            masterIDLabel.Text = "Мастер:";
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            serviceIDLabel.Location = new System.Drawing.Point(6, 189);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(68, 21);
            serviceIDLabel.TabIndex = 9;
            serviceIDLabel.Text = "Услуга:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timeLabel.Location = new System.Drawing.Point(6, 84);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(65, 21);
            timeLabel.TabIndex = 11;
            timeLabel.Text = "Время:";
            // 
            // clientIDComboBox
            // 
            this.clientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currentOrdersBindingSource, "ClientID", true));
            this.clientIDComboBox.DataSource = this.clientsBindingSource;
            this.clientIDComboBox.DisplayMember = "Name";
            this.clientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientIDComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientIDComboBox.FormattingEnabled = true;
            this.clientIDComboBox.Location = new System.Drawing.Point(120, 111);
            this.clientIDComboBox.Name = "clientIDComboBox";
            this.clientIDComboBox.Size = new System.Drawing.Size(363, 29);
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
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentOrdersBindingSource, "Date", true));
            this.dateMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateMaskedTextBox.Location = new System.Drawing.Point(120, 45);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(363, 27);
            this.dateMaskedTextBox.TabIndex = 0;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentOrdersBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox.Location = new System.Drawing.Point(120, 12);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(363, 27);
            this.iDTextBox.TabIndex = 6;
            this.iDTextBox.TabStop = false;
            // 
            // masterIDComboBox
            // 
            this.masterIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currentOrdersBindingSource, "MasterID", true));
            this.masterIDComboBox.DataSource = this.mastersBindingSource;
            this.masterIDComboBox.DisplayMember = "Name";
            this.masterIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterIDComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIDComboBox.FormattingEnabled = true;
            this.masterIDComboBox.Location = new System.Drawing.Point(120, 146);
            this.masterIDComboBox.Name = "masterIDComboBox";
            this.masterIDComboBox.Size = new System.Drawing.Size(363, 29);
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
            this.serviceIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currentOrdersBindingSource, "ServiceID", true));
            this.serviceIDComboBox.DataSource = this.servicesBindingSource;
            this.serviceIDComboBox.DisplayMember = "Title";
            this.serviceIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceIDComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceIDComboBox.FormattingEnabled = true;
            this.serviceIDComboBox.Location = new System.Drawing.Point(120, 181);
            this.serviceIDComboBox.Name = "serviceIDComboBox";
            this.serviceIDComboBox.Size = new System.Drawing.Size(363, 29);
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
            this.timeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentOrdersBindingSource, "Time", true));
            this.timeMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMaskedTextBox.Location = new System.Drawing.Point(120, 78);
            this.timeMaskedTextBox.Mask = "00:00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(363, 27);
            this.timeMaskedTextBox.TabIndex = 1;
            this.timeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(319, 239);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 43);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Закрыть";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(120, 239);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newClientBtn
            // 
            this.newClientBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.newClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newClientBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClientBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newClientBtn.Location = new System.Drawing.Point(489, 111);
            this.newClientBtn.Name = "newClientBtn";
            this.newClientBtn.Size = new System.Drawing.Size(139, 29);
            this.newClientBtn.TabIndex = 14;
            this.newClientBtn.TabStop = false;
            this.newClientBtn.Text = "Новый клиент";
            this.newClientBtn.UseVisualStyleBackColor = false;
            this.newClientBtn.Click += new System.EventHandler(this.newClientBtn_Click);
            // 
            // AddEditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(636, 294);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.newClientBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
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
            this.Text = "Новый заказ";
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
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox masterIDComboBox;
        private System.Windows.Forms.ComboBox serviceIDComboBox;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newClientBtn;
    }
}