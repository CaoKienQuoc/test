namespace SalesManagement_WinApp
{
    partial class frmOrderDetail
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
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            txtTotal = new System.Windows.Forms.TextBox();
            txtOrderStatus = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 20);
            label1.TabIndex = 8;
            label1.Text = "OrderID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(55, 113);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 20);
            label4.TabIndex = 9;
            label4.Text = "Customer Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(55, 151);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 20);
            label5.TabIndex = 10;
            label5.Text = "Order Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(55, 198);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 20);
            label6.TabIndex = 11;
            label6.Text = "Shipped Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(55, 242);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(55, 287);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 20);
            label8.TabIndex = 13;
            label8.Text = "OrderStatus";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new System.Drawing.Point(246, 66);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(250, 27);
            txtOrderID.TabIndex = 14;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(246, 106);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(250, 27);
            txtCustomerName.TabIndex = 17;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new System.Drawing.Point(246, 151);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new System.Drawing.Size(250, 27);
            dtpOrderDate.TabIndex = 18;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new System.Drawing.Point(246, 193);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new System.Drawing.Size(250, 27);
            dtpShippedDate.TabIndex = 19;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(246, 235);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(250, 27);
            txtTotal.TabIndex = 20;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new System.Drawing.Point(246, 280);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new System.Drawing.Size(250, 27);
            txtOrderStatus.TabIndex = 21;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(292, 324);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(402, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.Highlight;
            label2.Location = new System.Drawing.Point(22, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(243, 41);
            label2.TabIndex = 24;
            label2.Text = "ORDER DETAILS";
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(617, 404);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtTotal);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtCustomerName);
            Controls.Add(txtOrderID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "frmOrderDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Order Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
    }
}