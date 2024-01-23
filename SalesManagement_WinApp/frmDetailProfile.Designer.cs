namespace SalesManagement_WinApp
{
    partial class frmDetailProfile
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnChangePassword = new System.Windows.Forms.Button();
            Infomation = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(58, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(58, 253);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(58, 209);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 20);
            label3.TabIndex = 4;
            label3.Text = "Customer Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(58, 166);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 20);
            label4.TabIndex = 5;
            label4.Text = "Customer Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(58, 122);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 20);
            label5.TabIndex = 6;
            label5.Text = "Customer Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(58, 345);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 20);
            label6.TabIndex = 7;
            label6.Text = "Birth Day";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(58, 300);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(127, 20);
            label7.TabIndex = 8;
            label7.Text = "Customer Country";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(248, 80);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(250, 27);
            txtID.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(248, 253);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(250, 27);
            txtCity.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new System.Drawing.Point(248, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(250, 27);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(248, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(250, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(248, 119);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(250, 27);
            txtName.TabIndex = 13;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(248, 297);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(250, 27);
            txtCountry.TabIndex = 15;
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.Location = new System.Drawing.Point(248, 345);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new System.Drawing.Size(250, 27);
            dtpBirthDay.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(404, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(304, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new System.Drawing.Point(353, 424);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new System.Drawing.Size(145, 29);
            btnChangePassword.TabIndex = 19;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // Infomation
            // 
            Infomation.AutoSize = true;
            Infomation.Font = new System.Drawing.Font("Segoe UI Historic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Infomation.ForeColor = System.Drawing.SystemColors.Highlight;
            Infomation.Location = new System.Drawing.Point(31, 9);
            Infomation.Name = "Infomation";
            Infomation.Size = new System.Drawing.Size(213, 50);
            Infomation.TabIndex = 20;
            Infomation.Text = "Infomation";
            // 
            // frmDetailProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(573, 472);
            Controls.Add(Infomation);
            Controls.Add(btnChangePassword);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(dtpBirthDay);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDetailProfile";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Profile Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label Infomation;
    }
}