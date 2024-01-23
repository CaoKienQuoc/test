namespace SalesManagement_WinApp
{
    partial class frmProductDetail
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
            lbFlowerID = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtFlowerID = new System.Windows.Forms.TextBox();
            txtFlowerName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            cbCategory = new System.Windows.Forms.ComboBox();
            cbSupplier = new System.Windows.Forms.ComboBox();
            btnAction = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            nupStock = new System.Windows.Forms.NumericUpDown();
            nupPrice = new System.Windows.Forms.NumericUpDown();
            panel1 = new System.Windows.Forms.Panel();
            rbtnInactive = new System.Windows.Forms.RadioButton();
            rbtnActive = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nupStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrice).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbFlowerID
            // 
            lbFlowerID.AutoSize = true;
            lbFlowerID.Location = new System.Drawing.Point(41, 68);
            lbFlowerID.Name = "lbFlowerID";
            lbFlowerID.Size = new System.Drawing.Size(68, 20);
            lbFlowerID.TabIndex = 0;
            lbFlowerID.Text = "FlowerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Flower Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(41, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(41, 226);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(40, 266);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "Unit In Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(41, 427);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 20);
            label6.TabIndex = 5;
            label6.Text = "Supplier";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(40, 374);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(41, 322);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(49, 20);
            label8.TabIndex = 7;
            label8.Text = "Status";
            // 
            // txtFlowerID
            // 
            txtFlowerID.Location = new System.Drawing.Point(190, 65);
            txtFlowerID.Name = "txtFlowerID";
            txtFlowerID.Size = new System.Drawing.Size(202, 27);
            txtFlowerID.TabIndex = 8;
            // 
            // txtFlowerName
            // 
            txtFlowerName.Location = new System.Drawing.Point(190, 109);
            txtFlowerName.Name = "txtFlowerName";
            txtFlowerName.Size = new System.Drawing.Size(202, 27);
            txtFlowerName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(190, 142);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(313, 76);
            txtDescription.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new System.Drawing.Point(187, 371);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new System.Drawing.Size(202, 28);
            cbCategory.TabIndex = 14;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new System.Drawing.Point(187, 419);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new System.Drawing.Size(202, 28);
            cbSupplier.TabIndex = 15;
            // 
            // btnAction
            // 
            btnAction.Location = new System.Drawing.Point(187, 471);
            btnAction.Name = "btnAction";
            btnAction.Size = new System.Drawing.Size(94, 29);
            btnAction.TabIndex = 16;
            btnAction.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(324, 471);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // nupStock
            // 
            nupStock.Location = new System.Drawing.Point(187, 264);
            nupStock.Name = "nupStock";
            nupStock.Size = new System.Drawing.Size(202, 27);
            nupStock.TabIndex = 18;
            // 
            // nupPrice
            // 
            nupPrice.Location = new System.Drawing.Point(187, 224);
            nupPrice.Name = "nupPrice";
            nupPrice.Size = new System.Drawing.Size(202, 27);
            nupPrice.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtnInactive);
            panel1.Controls.Add(rbtnActive);
            panel1.Location = new System.Drawing.Point(190, 313);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(202, 35);
            panel1.TabIndex = 20;
            // 
            // rbtnInactive
            // 
            rbtnInactive.AutoSize = true;
            rbtnInactive.Location = new System.Drawing.Point(118, 7);
            rbtnInactive.Name = "rbtnInactive";
            rbtnInactive.Size = new System.Drawing.Size(81, 24);
            rbtnInactive.TabIndex = 22;
            rbtnInactive.TabStop = true;
            rbtnInactive.Text = "Inactive";
            rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            rbtnActive.AutoSize = true;
            rbtnActive.Location = new System.Drawing.Point(3, 7);
            rbtnActive.Name = "rbtnActive";
            rbtnActive.Size = new System.Drawing.Size(71, 24);
            rbtnActive.TabIndex = 21;
            rbtnActive.TabStop = true;
            rbtnActive.Text = "Active";
            rbtnActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(262, 41);
            label1.TabIndex = 21;
            label1.Text = "FLOWER DETAILS";
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(535, 574);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(nupPrice);
            Controls.Add(nupStock);
            Controls.Add(button2);
            Controls.Add(btnAction);
            Controls.Add(cbSupplier);
            Controls.Add(cbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtFlowerName);
            Controls.Add(txtFlowerID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbFlowerID);
            Name = "frmProductDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Flower Details";
            ((System.ComponentModel.ISupportInitialize)nupStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrice).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbFlowerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFlowerID;
        private System.Windows.Forms.TextBox txtFlowerName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nupStock;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.Label label1;
    }
}