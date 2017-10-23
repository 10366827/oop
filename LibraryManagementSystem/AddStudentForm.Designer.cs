namespace LibraryManagementSystem
{
    partial class AddStudentForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inID = new System.Windows.Forms.TextBox();
            this.inEmail = new System.Windows.Forms.TextBox();
            this.inPhone = new System.Windows.Forms.TextBox();
            this.inAddress = new System.Windows.Forms.TextBox();
            this.inName = new System.Windows.Forms.TextBox();
            this.inPPSN = new System.Windows.Forms.TextBox();
            this.inGradStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gradstatus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "PPSN";
            // 
            // inID
            // 
            this.inID.AccessibleDescription = "";
            this.inID.AccessibleName = "";
            this.inID.Location = new System.Drawing.Point(77, 142);
            this.inID.MaxLength = 10;
            this.inID.Name = "inID";
            this.inID.Size = new System.Drawing.Size(100, 20);
            this.inID.TabIndex = 20;
            // 
            // inEmail
            // 
            this.inEmail.AccessibleDescription = "";
            this.inEmail.AccessibleName = "";
            this.inEmail.Location = new System.Drawing.Point(77, 116);
            this.inEmail.MaxLength = 100;
            this.inEmail.Name = "inEmail";
            this.inEmail.Size = new System.Drawing.Size(100, 20);
            this.inEmail.TabIndex = 19;
            // 
            // inPhone
            // 
            this.inPhone.AccessibleDescription = "";
            this.inPhone.AccessibleName = "";
            this.inPhone.Location = new System.Drawing.Point(77, 90);
            this.inPhone.MaxLength = 30;
            this.inPhone.Name = "inPhone";
            this.inPhone.Size = new System.Drawing.Size(100, 20);
            this.inPhone.TabIndex = 18;
            // 
            // inAddress
            // 
            this.inAddress.AccessibleDescription = "";
            this.inAddress.AccessibleName = "";
            this.inAddress.Location = new System.Drawing.Point(77, 64);
            this.inAddress.MaxLength = 200;
            this.inAddress.Name = "inAddress";
            this.inAddress.Size = new System.Drawing.Size(100, 20);
            this.inAddress.TabIndex = 16;
            // 
            // inName
            // 
            this.inName.AccessibleDescription = "";
            this.inName.AccessibleName = "";
            this.inName.Location = new System.Drawing.Point(77, 38);
            this.inName.MaxLength = 60;
            this.inName.Name = "inName";
            this.inName.Size = new System.Drawing.Size(100, 20);
            this.inName.TabIndex = 15;
            // 
            // inPPSN
            // 
            this.inPPSN.AccessibleDescription = "";
            this.inPPSN.AccessibleName = "";
            this.inPPSN.Location = new System.Drawing.Point(77, 12);
            this.inPPSN.MaxLength = 9;
            this.inPPSN.Name = "inPPSN";
            this.inPPSN.Size = new System.Drawing.Size(100, 20);
            this.inPPSN.TabIndex = 7;
            // 
            // inGradStatus
            // 
            this.inGradStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inGradStatus.FormattingEnabled = true;
            this.inGradStatus.Items.AddRange(new object[] {
            "Undergrad",
            "Postgrad"});
            this.inGradStatus.Location = new System.Drawing.Point(30, 181);
            this.inGradStatus.Name = "inGradStatus";
            this.inGradStatus.Size = new System.Drawing.Size(121, 21);
            this.inGradStatus.TabIndex = 21;
            this.inGradStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 208);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(96, 208);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 241);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.inGradStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inID);
            this.Controls.Add(this.inEmail);
            this.Controls.Add(this.inPhone);
            this.Controls.Add(this.inAddress);
            this.Controls.Add(this.inName);
            this.Controls.Add(this.inPPSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inID;
        private System.Windows.Forms.TextBox inEmail;
        private System.Windows.Forms.TextBox inPhone;
        private System.Windows.Forms.TextBox inAddress;
        private System.Windows.Forms.TextBox inName;
        private System.Windows.Forms.TextBox inPPSN;
        private System.Windows.Forms.ComboBox inGradStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}