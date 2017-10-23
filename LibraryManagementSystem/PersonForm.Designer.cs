namespace LibraryManagementSystem
{
    partial class PersonForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputRole = new System.Windows.Forms.TextBox();
            this.outputAddress = new System.Windows.Forms.TextBox();
            this.outputPhone = new System.Windows.Forms.TextBox();
            this.outputEmail = new System.Windows.Forms.TextBox();
            this.outputID = new System.Windows.Forms.TextBox();
            this.outputName = new System.Windows.Forms.TextBox();
            this.outputPPSN = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPPSN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.booksBorrowedList = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputRole);
            this.groupBox1.Controls.Add(this.outputAddress);
            this.groupBox1.Controls.Add(this.outputPhone);
            this.groupBox1.Controls.Add(this.outputEmail);
            this.groupBox1.Controls.Add(this.outputID);
            this.groupBox1.Controls.Add(this.outputName);
            this.groupBox1.Controls.Add(this.outputPPSN);
            this.groupBox1.Controls.Add(this.labelRole);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelPPSN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Details";
            // 
            // outputRole
            // 
            this.outputRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRole.Location = new System.Drawing.Point(61, 132);
            this.outputRole.MaxLength = 20;
            this.outputRole.Name = "outputRole";
            this.outputRole.ReadOnly = true;
            this.outputRole.Size = new System.Drawing.Size(256, 13);
            this.outputRole.TabIndex = 1;
            // 
            // outputAddress
            // 
            this.outputAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAddress.Location = new System.Drawing.Point(61, 96);
            this.outputAddress.MaxLength = 200;
            this.outputAddress.Multiline = true;
            this.outputAddress.Name = "outputAddress";
            this.outputAddress.ReadOnly = true;
            this.outputAddress.Size = new System.Drawing.Size(272, 30);
            this.outputAddress.TabIndex = 1;
            // 
            // outputPhone
            // 
            this.outputPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPhone.Location = new System.Drawing.Point(61, 82);
            this.outputPhone.MaxLength = 100;
            this.outputPhone.Name = "outputPhone";
            this.outputPhone.ReadOnly = true;
            this.outputPhone.Size = new System.Drawing.Size(273, 13);
            this.outputPhone.TabIndex = 1;
            // 
            // outputEmail
            // 
            this.outputEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputEmail.Location = new System.Drawing.Point(61, 66);
            this.outputEmail.MaxLength = 100;
            this.outputEmail.Name = "outputEmail";
            this.outputEmail.ReadOnly = true;
            this.outputEmail.Size = new System.Drawing.Size(273, 13);
            this.outputEmail.TabIndex = 1;
            // 
            // outputID
            // 
            this.outputID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputID.Location = new System.Drawing.Point(61, 35);
            this.outputID.MaxLength = 100;
            this.outputID.Name = "outputID";
            this.outputID.ReadOnly = true;
            this.outputID.Size = new System.Drawing.Size(273, 13);
            this.outputID.TabIndex = 1;
            // 
            // outputName
            // 
            this.outputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputName.Location = new System.Drawing.Point(61, 53);
            this.outputName.MaxLength = 100;
            this.outputName.Name = "outputName";
            this.outputName.ReadOnly = true;
            this.outputName.Size = new System.Drawing.Size(273, 13);
            this.outputName.TabIndex = 1;
            // 
            // outputPPSN
            // 
            this.outputPPSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputPPSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPPSN.Location = new System.Drawing.Point(61, 16);
            this.outputPPSN.MaxLength = 200;
            this.outputPPSN.Name = "outputPPSN";
            this.outputPPSN.ReadOnly = true;
            this.outputPPSN.Size = new System.Drawing.Size(272, 13);
            this.outputPPSN.TabIndex = 1;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(16, 132);
            this.labelRole.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(32, 13);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Role:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(16, 96);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(17, 82);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(17, 66);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(17, 32);
            this.labelID.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 50);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelPPSN
            // 
            this.labelPPSN.AutoSize = true;
            this.labelPPSN.Location = new System.Drawing.Point(16, 16);
            this.labelPPSN.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelPPSN.Name = "labelPPSN";
            this.labelPPSN.Size = new System.Drawing.Size(39, 13);
            this.labelPPSN.TabIndex = 0;
            this.labelPPSN.Text = "PPSN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.returnBookButton);
            this.groupBox2.Controls.Add(this.booksBorrowedList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books Borrowed";
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(103, 114);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(163, 23);
            this.returnBookButton.TabIndex = 1;
            this.returnBookButton.Text = "Return Selected Book";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // booksBorrowedList
            // 
            this.booksBorrowedList.Font = new System.Drawing.Font("Courier New", 9.25F);
            this.booksBorrowedList.FormattingEnabled = true;
            this.booksBorrowedList.ItemHeight = 15;
            this.booksBorrowedList.Location = new System.Drawing.Point(7, 20);
            this.booksBorrowedList.Name = "booksBorrowedList";
            this.booksBorrowedList.Size = new System.Drawing.Size(362, 94);
            this.booksBorrowedList.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(150, 318);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 344);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox booksBorrowedList;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPPSN;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox outputPPSN;
        private System.Windows.Forms.TextBox outputPhone;
        private System.Windows.Forms.TextBox outputEmail;
        private System.Windows.Forms.TextBox outputName;
        private System.Windows.Forms.TextBox outputRole;
        private System.Windows.Forms.TextBox outputAddress;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.TextBox outputID;
        private System.Windows.Forms.Label labelID;
    }
}