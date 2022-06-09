namespace BeautySaloonProj.Forms
{
    partial class OrdersHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersHistoryForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CurrentUserLbl = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TimeNowLbl = new System.Windows.Forms.Label();
            this.FormNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cancelBtn.Location = new System.Drawing.Point(1154, 582);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 43);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Закрыть";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.deleteBtn.Location = new System.Drawing.Point(12, 582);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(164, 43);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.AllowUserToAddRows = false;
            this.scheduleDataGridView.AllowUserToDeleteRows = false;
            this.scheduleDataGridView.AllowUserToResizeColumns = false;
            this.scheduleDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.scheduleDataGridView.AutoGenerateColumns = false;
            this.scheduleDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn});
            this.scheduleDataGridView.DataSource = this.orderHistoryBindingSource;
            this.scheduleDataGridView.Location = new System.Drawing.Point(12, 152);
            this.scheduleDataGridView.MultiSelect = false;
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.scheduleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.scheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleDataGridView.Size = new System.Drawing.Size(1306, 424);
            this.scheduleDataGridView.TabIndex = 8;
            this.scheduleDataGridView.TabStop = false;
            this.scheduleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.scheduleDataGridView_DataError);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 45;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // orderHistoryBindingSource
            // 
            this.orderHistoryBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.OrderHistory);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.FooterPanel.Controls.Add(this.CurrentUserLbl);
            this.FooterPanel.Location = new System.Drawing.Point(0, 631);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1336, 97);
            this.FooterPanel.TabIndex = 15;
            // 
            // CurrentUserLbl
            // 
            this.CurrentUserLbl.AutoSize = true;
            this.CurrentUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.CurrentUserLbl.Location = new System.Drawing.Point(12, 34);
            this.CurrentUserLbl.Name = "CurrentUserLbl";
            this.CurrentUserLbl.Size = new System.Drawing.Size(583, 37);
            this.CurrentUserLbl.TabIndex = 2;
            this.CurrentUserLbl.Text = "Вы авторизовались как администратор";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.TimeNowLbl);
            this.HeaderPanel.Controls.Add(this.FormNameLbl);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Location = new System.Drawing.Point(0, -1);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1336, 145);
            this.HeaderPanel.TabIndex = 16;
            // 
            // TimeNowLbl
            // 
            this.TimeNowLbl.AutoSize = true;
            this.TimeNowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeNowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.TimeNowLbl.Location = new System.Drawing.Point(169, 39);
            this.TimeNowLbl.Name = "TimeNowLbl";
            this.TimeNowLbl.Size = new System.Drawing.Size(71, 29);
            this.TimeNowLbl.TabIndex = 3;
            this.TimeNowLbl.Text = "18:50";
            // 
            // FormNameLbl
            // 
            this.FormNameLbl.AutoSize = true;
            this.FormNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.FormNameLbl.Location = new System.Drawing.Point(963, 11);
            this.FormNameLbl.Name = "FormNameLbl";
            this.FormNameLbl.Size = new System.Drawing.Size(355, 55);
            this.FormNameLbl.TabIndex = 2;
            this.FormNameLbl.Text = "Архив записей";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(169, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущая дата и время";
            // 
            // OrdersHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1330, 726);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.scheduleDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrdersHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Архив записей";
            this.Load += new System.EventHandler(this.OrdersHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.BindingSource orderHistoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn masterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label CurrentUserLbl;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label TimeNowLbl;
        private System.Windows.Forms.Label FormNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}