namespace BeautySaloonProj.Forms
{
    partial class AdministratorControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorControlForm));
            this.logoutBtn = new System.Windows.Forms.Button();
            this.checkArchiveBtn = new System.Windows.Forms.Button();
            this.checkOrdersBtn = new System.Windows.Forms.Button();
            this.checkSchelduleBtn = new System.Windows.Forms.Button();
            this.checkClientListBtn = new System.Windows.Forms.Button();
            this.checkMastersListBtn = new System.Windows.Forms.Button();
            this.addNewAccountBtn = new System.Windows.Forms.Button();
            this.checkAccsBtn = new System.Windows.Forms.Button();
            this.checkServicesBtn = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeNowLbl = new System.Windows.Forms.Label();
            this.FormNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CurrentUserLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.logoutBtn.Location = new System.Drawing.Point(723, 26);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(312, 56);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Выйти из учетной записи";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // checkArchiveBtn
            // 
            this.checkArchiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkArchiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkArchiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkArchiveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkArchiveBtn.Location = new System.Drawing.Point(12, 272);
            this.checkArchiveBtn.Name = "checkArchiveBtn";
            this.checkArchiveBtn.Size = new System.Drawing.Size(507, 56);
            this.checkArchiveBtn.TabIndex = 8;
            this.checkArchiveBtn.Text = "Архив записей";
            this.checkArchiveBtn.UseVisualStyleBackColor = false;
            this.checkArchiveBtn.Click += new System.EventHandler(this.checkArchiveBtn_Click);
            // 
            // checkOrdersBtn
            // 
            this.checkOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOrdersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkOrdersBtn.Location = new System.Drawing.Point(12, 210);
            this.checkOrdersBtn.Name = "checkOrdersBtn";
            this.checkOrdersBtn.Size = new System.Drawing.Size(507, 56);
            this.checkOrdersBtn.TabIndex = 9;
            this.checkOrdersBtn.Text = "Текущие записи";
            this.checkOrdersBtn.UseVisualStyleBackColor = false;
            this.checkOrdersBtn.Click += new System.EventHandler(this.checkOrdersBtn_Click);
            // 
            // checkSchelduleBtn
            // 
            this.checkSchelduleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkSchelduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSchelduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSchelduleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkSchelduleBtn.Location = new System.Drawing.Point(718, 469);
            this.checkSchelduleBtn.Name = "checkSchelduleBtn";
            this.checkSchelduleBtn.Size = new System.Drawing.Size(312, 56);
            this.checkSchelduleBtn.TabIndex = 10;
            this.checkSchelduleBtn.Text = "График работы";
            this.checkSchelduleBtn.UseVisualStyleBackColor = false;
            this.checkSchelduleBtn.Click += new System.EventHandler(this.checkSchelduleBtn_Click);
            // 
            // checkClientListBtn
            // 
            this.checkClientListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkClientListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkClientListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkClientListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkClientListBtn.Location = new System.Drawing.Point(525, 210);
            this.checkClientListBtn.Name = "checkClientListBtn";
            this.checkClientListBtn.Size = new System.Drawing.Size(505, 56);
            this.checkClientListBtn.TabIndex = 8;
            this.checkClientListBtn.Text = "Список клиентов";
            this.checkClientListBtn.UseVisualStyleBackColor = false;
            this.checkClientListBtn.Click += new System.EventHandler(this.checkClientListBtn_Click);
            // 
            // checkMastersListBtn
            // 
            this.checkMastersListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkMastersListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMastersListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMastersListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkMastersListBtn.Location = new System.Drawing.Point(718, 407);
            this.checkMastersListBtn.Name = "checkMastersListBtn";
            this.checkMastersListBtn.Size = new System.Drawing.Size(312, 56);
            this.checkMastersListBtn.TabIndex = 8;
            this.checkMastersListBtn.Text = "Список мастеров";
            this.checkMastersListBtn.UseVisualStyleBackColor = false;
            this.checkMastersListBtn.Click += new System.EventHandler(this.checkMastersListBtn_Click);
            // 
            // addNewAccountBtn
            // 
            this.addNewAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.addNewAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.addNewAccountBtn.Location = new System.Drawing.Point(12, 469);
            this.addNewAccountBtn.Name = "addNewAccountBtn";
            this.addNewAccountBtn.Size = new System.Drawing.Size(312, 56);
            this.addNewAccountBtn.TabIndex = 8;
            this.addNewAccountBtn.Text = "Добавить новую учетную запись";
            this.addNewAccountBtn.UseVisualStyleBackColor = false;
            this.addNewAccountBtn.Click += new System.EventHandler(this.addNewAccountBtn_Click);
            // 
            // checkAccsBtn
            // 
            this.checkAccsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkAccsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAccsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAccsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkAccsBtn.Location = new System.Drawing.Point(12, 407);
            this.checkAccsBtn.Name = "checkAccsBtn";
            this.checkAccsBtn.Size = new System.Drawing.Size(312, 56);
            this.checkAccsBtn.TabIndex = 8;
            this.checkAccsBtn.Text = "Список учетных записей";
            this.checkAccsBtn.UseVisualStyleBackColor = false;
            this.checkAccsBtn.Click += new System.EventHandler(this.checkAccsBtn_Click);
            // 
            // checkServicesBtn
            // 
            this.checkServicesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkServicesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkServicesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkServicesBtn.Location = new System.Drawing.Point(525, 272);
            this.checkServicesBtn.Name = "checkServicesBtn";
            this.checkServicesBtn.Size = new System.Drawing.Size(505, 56);
            this.checkServicesBtn.TabIndex = 8;
            this.checkServicesBtn.Text = "Список услуг";
            this.checkServicesBtn.UseVisualStyleBackColor = false;
            this.checkServicesBtn.Click += new System.EventHandler(this.checkServicesBtn_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.TimeNowLbl);
            this.HeaderPanel.Controls.Add(this.FormNameLbl);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Location = new System.Drawing.Point(-5, -2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1060, 147);
            this.HeaderPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(172, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущая дата и время";
            // 
            // TimeNowLbl
            // 
            this.TimeNowLbl.AutoSize = true;
            this.TimeNowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeNowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.TimeNowLbl.Location = new System.Drawing.Point(172, 37);
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
            this.FormNameLbl.Location = new System.Drawing.Point(687, 11);
            this.FormNameLbl.Name = "FormNameLbl";
            this.FormNameLbl.Size = new System.Drawing.Size(348, 55);
            this.FormNameLbl.TabIndex = 2;
            this.FormNameLbl.Text = "Главное меню";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.FooterPanel.Controls.Add(this.CurrentUserLbl);
            this.FooterPanel.Controls.Add(this.logoutBtn);
            this.FooterPanel.Location = new System.Drawing.Point(-5, 620);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1060, 97);
            this.FooterPanel.TabIndex = 12;
            // 
            // CurrentUserLbl
            // 
            this.CurrentUserLbl.AutoSize = true;
            this.CurrentUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.CurrentUserLbl.Location = new System.Drawing.Point(17, 32);
            this.CurrentUserLbl.Name = "CurrentUserLbl";
            this.CurrentUserLbl.Size = new System.Drawing.Size(583, 37);
            this.CurrentUserLbl.TabIndex = 2;
            this.CurrentUserLbl.Text = "Вы авторизовались как администратор";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(10, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Клиенты, записи, услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(10, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Учетные записи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(709, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 51);
            this.label4.TabIndex = 5;
            this.label4.Text = "Мастера";
            // 
            // AdministratorControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1042, 714);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.addNewAccountBtn);
            this.Controls.Add(this.checkMastersListBtn);
            this.Controls.Add(this.checkAccsBtn);
            this.Controls.Add(this.checkServicesBtn);
            this.Controls.Add(this.checkClientListBtn);
            this.Controls.Add(this.checkArchiveBtn);
            this.Controls.Add(this.checkOrdersBtn);
            this.Controls.Add(this.checkSchelduleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministratorControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.AdministratorControlForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button checkArchiveBtn;
        private System.Windows.Forms.Button checkOrdersBtn;
        private System.Windows.Forms.Button checkSchelduleBtn;
        private System.Windows.Forms.Button checkClientListBtn;
        private System.Windows.Forms.Button checkMastersListBtn;
        private System.Windows.Forms.Button addNewAccountBtn;
        private System.Windows.Forms.Button checkAccsBtn;
        private System.Windows.Forms.Button checkServicesBtn;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label TimeNowLbl;
        private System.Windows.Forms.Label FormNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label CurrentUserLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}