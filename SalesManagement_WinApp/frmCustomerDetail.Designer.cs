namespace SalesManagement_WinApp
{
    partial class frmCustomerDetail
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
            lbCustomerID = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtCustomerID = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            txtCity = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnAction = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new System.Drawing.Point(69, 63);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new System.Drawing.Size(107, 20);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "Customer ID(*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 143);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name(*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(69, 220);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "City(*)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(69, 182);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Password(*)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(69, 260);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Country(*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(69, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Email(*)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(69, 302);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Birth Day";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(244, 60);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(250, 27);
            txtCustomerID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(244, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(250, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(244, 140);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(250, 27);
            txtCustomerName.TabIndex = 9;
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.Location = new System.Drawing.Point(244, 297);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new System.Drawing.Size(250, 27);
            dtpBirthDay.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(244, 217);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(250, 27);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(244, 257);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(250, 27);
            txtCountry.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(244, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(250, 27);
            txtPassword.TabIndex = 13;
            // 
            // btnAction
            // 
            btnAction.Location = new System.Drawing.Point(275, 339);
            btnAction.Name = "btnAction";
            btnAction.Size = new System.Drawing.Size(94, 29);
            btnAction.TabIndex = 14;
            btnAction.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(400, 339);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(26, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 41);
            label1.TabIndex = 16;
            label1.Text = "INFORMATION";
            // 
            // frmCustomerDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(619, 411);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(dtpBirthDay);
            Controls.Add(txtCustomerName);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbCustomerID);
            Name = "frmCustomerDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Customer Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}