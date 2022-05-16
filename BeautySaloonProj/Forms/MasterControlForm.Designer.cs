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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterControlForm));
            this.checkSchelduleBtn = new System.Windows.Forms.Button();
            this.checkOrdersBtn = new System.Windows.Forms.Button();
            this.checkArchiveBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkSchelduleBtn
            // 
            this.checkSchelduleBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.checkSchelduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSchelduleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSchelduleBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSchelduleBtn.Location = new System.Drawing.Point(12, 12);
            this.checkSchelduleBtn.Name = "checkSchelduleBtn";
            this.checkSchelduleBtn.Size = new System.Drawing.Size(289, 56);
            this.checkSchelduleBtn.TabIndex = 6;
            this.checkSchelduleBtn.Text = "График работы";
            this.checkSchelduleBtn.UseVisualStyleBackColor = false;
            this.checkSchelduleBtn.Click += new System.EventHandler(this.checkSchelduleBtn_Click);
            // 
            // checkOrdersBtn
            // 
            this.checkOrdersBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.checkOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOrdersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOrdersBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkOrdersBtn.Location = new System.Drawing.Point(12, 74);
            this.checkOrdersBtn.Name = "checkOrdersBtn";
            this.checkOrdersBtn.Size = new System.Drawing.Size(289, 56);
            this.checkOrdersBtn.TabIndex = 6;
            this.checkOrdersBtn.Text = "Записи клиентов";
            this.checkOrdersBtn.UseVisualStyleBackColor = false;
            this.checkOrdersBtn.Click += new System.EventHandler(this.checkOrdersBtn_Click);
            // 
            // checkArchiveBtn
            // 
            this.checkArchiveBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.checkArchiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkArchiveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkArchiveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkArchiveBtn.Location = new System.Drawing.Point(12, 136);
            this.checkArchiveBtn.Name = "checkArchiveBtn";
            this.checkArchiveBtn.Size = new System.Drawing.Size(289, 56);
            this.checkArchiveBtn.TabIndex = 6;
            this.checkArchiveBtn.Text = "Архив заказов";
            this.checkArchiveBtn.UseVisualStyleBackColor = false;
            this.checkArchiveBtn.Click += new System.EventHandler(this.checkArchiveBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutBtn.Location = new System.Drawing.Point(12, 271);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(289, 56);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Выйти из учетной записи";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // MasterControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(313, 339);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.checkArchiveBtn);
            this.Controls.Add(this.checkOrdersBtn);
            this.Controls.Add(this.checkSchelduleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MasterControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления мастера";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkSchelduleBtn;
        private System.Windows.Forms.Button checkOrdersBtn;
        private System.Windows.Forms.Button checkArchiveBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}