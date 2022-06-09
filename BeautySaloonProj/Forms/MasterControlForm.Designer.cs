namespace BeautySaloonProj.Forms
{
    partial class MasterControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterControlForm));
            this.checkSchelduleBtn = new System.Windows.Forms.Button();
            this.checkOrdersBtn = new System.Windows.Forms.Button();
            this.checkArchiveBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TimeNowLbl = new System.Windows.Forms.Label();
            this.FormNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CurrentUserLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkSchelduleBtn
            // 
            this.checkSchelduleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkSchelduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSchelduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSchelduleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkSchelduleBtn.Location = new System.Drawing.Point(351, 153);
            this.checkSchelduleBtn.Name = "checkSchelduleBtn";
            this.checkSchelduleBtn.Size = new System.Drawing.Size(289, 56);
            this.checkSchelduleBtn.TabIndex = 6;
            this.checkSchelduleBtn.Text = "График работы";
            this.checkSchelduleBtn.UseVisualStyleBackColor = false;
            this.checkSchelduleBtn.Click += new System.EventHandler(this.checkSchelduleBtn_Click);
            // 
            // checkOrdersBtn
            // 
            this.checkOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOrdersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkOrdersBtn.Location = new System.Drawing.Point(351, 215);
            this.checkOrdersBtn.Name = "checkOrdersBtn";
            this.checkOrdersBtn.Size = new System.Drawing.Size(289, 56);
            this.checkOrdersBtn.TabIndex = 6;
            this.checkOrdersBtn.Text = "Записи клиентов";
            this.checkOrdersBtn.UseVisualStyleBackColor = false;
            this.checkOrdersBtn.Click += new System.EventHandler(this.checkOrdersBtn_Click);
            // 
            // checkArchiveBtn
            // 
            this.checkArchiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.checkArchiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkArchiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkArchiveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.checkArchiveBtn.Location = new System.Drawing.Point(351, 277);
            this.checkArchiveBtn.Name = "checkArchiveBtn";
            this.checkArchiveBtn.Size = new System.Drawing.Size(289, 56);
            this.checkArchiveBtn.TabIndex = 6;
            this.checkArchiveBtn.Text = "Архив заказов";
            this.checkArchiveBtn.UseVisualStyleBackColor = false;
            this.checkArchiveBtn.Click += new System.EventHandler(this.checkArchiveBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.logoutBtn.Location = new System.Drawing.Point(351, 458);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(289, 56);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Выйти из учетной записи";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.TimeNowLbl);
            this.HeaderPanel.Controls.Add(this.FormNameLbl);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1004, 147);
            this.HeaderPanel.TabIndex = 12;
            // 
            // TimeNowLbl
            // 
            this.TimeNowLbl.AutoSize = true;
            this.TimeNowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeNowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.TimeNowLbl.Location = new System.Drawing.Point(172, 40);
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
            this.FormNameLbl.Location = new System.Drawing.Point(653, 11);
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
            this.FooterPanel.Location = new System.Drawing.Point(0, 520);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1004, 97);
            this.FooterPanel.TabIndex = 13;
            // 
            // CurrentUserLbl
            // 
            this.CurrentUserLbl.AutoSize = true;
            this.CurrentUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.CurrentUserLbl.Location = new System.Drawing.Point(12, 31);
            this.CurrentUserLbl.Name = "CurrentUserLbl";
            this.CurrentUserLbl.Size = new System.Drawing.Size(468, 37);
            this.CurrentUserLbl.TabIndex = 2;
            this.CurrentUserLbl.Text = "Вы авторизовались как мастер";
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
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущая дата и время";
            // 
            // MasterControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(998, 614);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.checkArchiveBtn);
            this.Controls.Add(this.checkOrdersBtn);
            this.Controls.Add(this.checkSchelduleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MasterControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkSchelduleBtn;
        private System.Windows.Forms.Button checkOrdersBtn;
        private System.Windows.Forms.Button checkArchiveBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label TimeNowLbl;
        private System.Windows.Forms.Label FormNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label CurrentUserLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}