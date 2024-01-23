namespace SalesManagement_WinApp
{
    partial class frmAdmin
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            tsmiProduct = new System.Windows.Forms.ToolStripMenuItem();
            revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dtgvCustomer = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtCustomerID = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            Close = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiProduct, revenueToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(964, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiProduct
            // 
            tsmiProduct.Name = "tsmiProduct";
            tsmiProduct.Size = new System.Drawing.Size(74, 24);
            tsmiProduct.Text = "Product";
            tsmiProduct.Click += tsmiProduct_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            revenueToolStripMenuItem.Text = "Order";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Location = new System.Drawing.Point(12, 103);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.RowHeadersWidth = 51;
            dtgvCustomer.RowTemplate.Height = 29;
            dtgvCustomer.Size = new System.Drawing.Size(483, 360);
            dtgvCustomer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(522, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(522, 227);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(522, 189);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(522, 154);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 20);
            label4.TabIndex = 5;
            label4.Text = "Customer Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(522, 338);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 20);
            label6.TabIndex = 7;
            label6.Text = "Birth Day";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(522, 300);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(60, 20);
            label7.TabIndex = 8;
            label7.Text = "Country";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(522, 261);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(34, 20);
            label8.TabIndex = 9;
            label8.Text = "City";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(661, 151);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(250, 27);
            txtCustomerName.TabIndex = 10;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(661, 113);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(250, 27);
            txtCustomerID.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(661, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(250, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(661, 297);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(250, 27);
            txtCountry.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(661, 261);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(250, 27);
            txtCity.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(661, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(250, 27);
            txtPassword.TabIndex = 16;
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.Location = new System.Drawing.Point(661, 333);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new System.Drawing.Size(250, 27);
            dtpBirthDay.TabIndex = 17;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(522, 376);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(673, 376);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Close
            // 
            Close.Location = new System.Drawing.Point(817, 376);
            Close.Name = "Close";
            Close.Size = new System.Drawing.Size(94, 29);
            Close.TabIndex = 20;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.Highlight;
            label5.Location = new System.Drawing.Point(12, 41);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(403, 41);
            label5.TabIndex = 21;
            label5.Text = "CUSTOMER MANAGEMENT";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(964, 475);
            Controls.Add(label5);
            Controls.Add(Close);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dtpBirthDay);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerID);
            Controls.Add(txtCustomerName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgvCustomer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduct;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label5;
    }
}