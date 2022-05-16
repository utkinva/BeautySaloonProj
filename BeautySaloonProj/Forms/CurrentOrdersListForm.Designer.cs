namespace BeautySaloonProj.Forms
{
    partial class CurrentOrdersListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentOrdersListForm));
            this.currentOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.archiveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // currentOrdersDataGridView
            // 
            this.currentOrdersDataGridView.AllowUserToAddRows = false;
            this.currentOrdersDataGridView.AllowUserToDeleteRows = false;
            this.currentOrdersDataGridView.AllowUserToResizeColumns = false;
            this.currentOrdersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentOrdersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.currentOrdersDataGridView.AutoGenerateColumns = false;
            this.currentOrdersDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.currentOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentOrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.Time,
            this.serviceIDDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn});
            this.currentOrdersDataGridView.DataSource = this.currentOrdersBindingSource;
            this.currentOrdersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.currentOrdersDataGridView.MultiSelect = false;
            this.currentOrdersDataGridView.Name = "currentOrdersDataGridView";
            this.currentOrdersDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentOrdersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.currentOrdersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currentOrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentOrdersDataGridView.Size = new System.Drawing.Size(975, 457);
            this.currentOrdersDataGridView.TabIndex = 8;
            this.currentOrdersDataGridView.TabStop = false;
            this.currentOrdersDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.currentOrdersDataGridView_DataError);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 45;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.DataSource = this.clientsBindingSource;
            this.clientIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.clientIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clientIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Clients);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 80;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 80;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.DataSource = this.servicesBindingSource;
            this.serviceIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.serviceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.serviceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Services);
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "MasterID";
            this.masterIDDataGridViewTextBoxColumn.DataSource = this.mastersBindingSource;
            this.masterIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.masterIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.masterIDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            this.masterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.masterIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.masterIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.masterIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Masters);
            // 
            // currentOrdersBindingSource
            // 
            this.currentOrdersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.CurrentOrders);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(823, 475);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 43);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Закрыть";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(12, 475);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(164, 43);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(352, 475);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(164, 43);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(182, 475);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(164, 43);
            this.editBtn.TabIndex = 12;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // archiveBtn
            // 
            this.archiveBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.archiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.archiveBtn.Location = new System.Drawing.Point(653, 475);
            this.archiveBtn.Name = "archiveBtn";
            this.archiveBtn.Size = new System.Drawing.Size(164, 43);
            this.archiveBtn.TabIndex = 11;
            this.archiveBtn.Text = "В архив";
            this.archiveBtn.UseVisualStyleBackColor = false;
            this.archiveBtn.Click += new System.EventHandler(this.archiveBtn_Click);
            // 
            // CurrentOrdersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(999, 530);
            this.Controls.Add(this.currentOrdersDataGridView);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.archiveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CurrentOrdersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Текущие записи клиентов";
            this.Load += new System.EventHandler(this.ClientOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView currentOrdersDataGridView;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.BindingSource currentOrdersBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.Button archiveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn masterIDDataGridViewTextBoxColumn;
    }
}