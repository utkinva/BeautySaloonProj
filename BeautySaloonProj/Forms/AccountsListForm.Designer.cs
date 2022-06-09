namespace BeautySaloonProj.Forms
{
    partial class AccountsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsListForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TimeNowLbl = new System.Windows.Forms.Label();
            this.FormNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CurrentUserLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cancelBtn.Location = new System.Drawing.Point(916, 576);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 43);
            this.cancelBtn.TabIndex = 13;
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
            this.deleteBtn.Location = new System.Drawing.Point(12, 576);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(164, 43);
            this.deleteBtn.TabIndex = 14;
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
            this.loginDataGridViewTextBoxColumn,
            this.userTypeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.scheduleDataGridView.DataSource = this.usersBindingSource;
            this.scheduleDataGridView.Location = new System.Drawing.Point(12, 149);
            this.scheduleDataGridView.MultiSelect = false;
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.scheduleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.scheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleDataGridView.Size = new System.Drawing.Size(1068, 421);
            this.scheduleDataGridView.TabIndex = 12;
            this.scheduleDataGridView.TabStop = false;
            this.scheduleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.scheduleDataGridView_DataError);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeIDDataGridViewTextBoxColumn
            // 
            this.userTypeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UserTypeID";
            this.userTypeIDDataGridViewTextBoxColumn.DataSource = this.userTypesBindingSource;
            this.userTypeIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.userTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.userTypeIDDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.userTypeIDDataGridViewTextBoxColumn.Name = "userTypeIDDataGridViewTextBoxColumn";
            this.userTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // userTypesBindingSource
            // 
            this.userTypesBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.UserTypes);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 180;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(BeautySaloonProj.ModelEF.Users);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.TimeNowLbl);
            this.HeaderPanel.Controls.Add(this.FormNameLbl);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Location = new System.Drawing.Point(-4, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1104, 143);
            this.HeaderPanel.TabIndex = 15;
            // 
            // TimeNowLbl
            // 
            this.TimeNowLbl.AutoSize = true;
            this.TimeNowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeNowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.TimeNowLbl.Location = new System.Drawing.Point(169, 52);
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
            this.FormNameLbl.Location = new System.Drawing.Point(503, 11);
            this.FormNameLbl.Name = "FormNameLbl";
            this.FormNameLbl.Size = new System.Drawing.Size(581, 55);
            this.FormNameLbl.TabIndex = 2;
            this.FormNameLbl.Text = "Список учетных записей";
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
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.FooterPanel.Controls.Add(this.CurrentUserLbl);
            this.FooterPanel.Location = new System.Drawing.Point(-4, 625);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1104, 97);
            this.FooterPanel.TabIndex = 16;
            // 
            // CurrentUserLbl
            // 
            this.CurrentUserLbl.AutoSize = true;
            this.CurrentUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.CurrentUserLbl.Location = new System.Drawing.Point(16, 33);
            this.CurrentUserLbl.Name = "CurrentUserLbl";
            this.CurrentUserLbl.Size = new System.Drawing.Size(583, 37);
            this.CurrentUserLbl.TabIndex = 2;
            this.CurrentUserLbl.Text = "Вы авторизовались как администратор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(169, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущая дата и время";
            // 
            // AccountsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1090, 720);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.scheduleDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список учетных записей";
            this.Load += new System.EventHandler(this.AccountsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource userTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label TimeNowLbl;
        private System.Windows.Forms.Label FormNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label CurrentUserLbl;
        private System.Windows.Forms.Label label1;
    }
}