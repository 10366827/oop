namespace LibraryManagementSystem
{
    partial class BookForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelisbn = new System.Windows.Forms.Label();
            this.outputQuantity = new System.Windows.Forms.TextBox();
            this.outputPublisher = new System.Windows.Forms.TextBox();
            this.outputAuthor = new System.Windows.Forms.TextBox();
            this.outputTitle = new System.Windows.Forms.TextBox();
            this.outputISBN = new System.Windows.Forms.TextBox();
            this.outputCategory = new System.Windows.Forms.TextBox();
            this.outputAvailable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loanButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(173, 214);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(106, 23);
            this.closeButton.TabIndex = 55;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Author";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(10, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 46;
            this.labelTitle.Text = "Title";
            // 
            // labelisbn
            // 
            this.labelisbn.AutoSize = true;
            this.labelisbn.Location = new System.Drawing.Point(10, 15);
            this.labelisbn.Name = "labelisbn";
            this.labelisbn.Size = new System.Drawing.Size(32, 13);
            this.labelisbn.TabIndex = 47;
            this.labelisbn.Text = "ISBN";
            // 
            // outputQuantity
            // 
            this.outputQuantity.AccessibleDescription = "";
            this.outputQuantity.AccessibleName = "";
            this.outputQuantity.Location = new System.Drawing.Point(66, 116);
            this.outputQuantity.MaxLength = 10;
            this.outputQuantity.Name = "outputQuantity";
            this.outputQuantity.ReadOnly = true;
            this.outputQuantity.Size = new System.Drawing.Size(69, 20);
            this.outputQuantity.TabIndex = 52;
            // 
            // outputPublisher
            // 
            this.outputPublisher.AccessibleDescription = "";
            this.outputPublisher.AccessibleName = "";
            this.outputPublisher.Location = new System.Drawing.Point(66, 90);
            this.outputPublisher.MaxLength = 30;
            this.outputPublisher.Name = "outputPublisher";
            this.outputPublisher.ReadOnly = true;
            this.outputPublisher.Size = new System.Drawing.Size(367, 20);
            this.outputPublisher.TabIndex = 50;
            // 
            // outputAuthor
            // 
            this.outputAuthor.AccessibleDescription = "";
            this.outputAuthor.AccessibleName = "";
            this.outputAuthor.Location = new System.Drawing.Point(66, 64);
            this.outputAuthor.MaxLength = 200;
            this.outputAuthor.Name = "outputAuthor";
            this.outputAuthor.ReadOnly = true;
            this.outputAuthor.Size = new System.Drawing.Size(367, 20);
            this.outputAuthor.TabIndex = 49;
            // 
            // outputTitle
            // 
            this.outputTitle.AccessibleDescription = "";
            this.outputTitle.AccessibleName = "";
            this.outputTitle.Location = new System.Drawing.Point(66, 38);
            this.outputTitle.MaxLength = 60;
            this.outputTitle.Name = "outputTitle";
            this.outputTitle.ReadOnly = true;
            this.outputTitle.Size = new System.Drawing.Size(367, 20);
            this.outputTitle.TabIndex = 48;
            // 
            // outputISBN
            // 
            this.outputISBN.AccessibleDescription = "";
            this.outputISBN.AccessibleName = "";
            this.outputISBN.Location = new System.Drawing.Point(66, 12);
            this.outputISBN.MaxLength = 9;
            this.outputISBN.Name = "outputISBN";
            this.outputISBN.ReadOnly = true;
            this.outputISBN.Size = new System.Drawing.Size(367, 20);
            this.outputISBN.TabIndex = 40;
            // 
            // outputCategory
            // 
            this.outputCategory.Location = new System.Drawing.Point(66, 139);
            this.outputCategory.Name = "outputCategory";
            this.outputCategory.ReadOnly = true;
            this.outputCategory.Size = new System.Drawing.Size(174, 20);
            this.outputCategory.TabIndex = 56;
            // 
            // outputAvailable
            // 
            this.outputAvailable.Location = new System.Drawing.Point(66, 163);
            this.outputAvailable.Name = "outputAvailable";
            this.outputAvailable.ReadOnly = true;
            this.outputAvailable.Size = new System.Drawing.Size(69, 20);
            this.outputAvailable.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Available";
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(274, 116);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(159, 39);
            this.loanButton.TabIndex = 55;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(274, 161);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(159, 38);
            this.returnButton.TabIndex = 55;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 249);
            this.Controls.Add(this.outputAvailable);
            this.Controls.Add(this.outputCategory);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.loanButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelisbn);
            this.Controls.Add(this.outputQuantity);
            this.Controls.Add(this.outputPublisher);
            this.Controls.Add(this.outputAuthor);
            this.Controls.Add(this.outputTitle);
            this.Controls.Add(this.outputISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelisbn;
        private System.Windows.Forms.TextBox outputQuantity;
        private System.Windows.Forms.TextBox outputPublisher;
        private System.Windows.Forms.TextBox outputAuthor;
        private System.Windows.Forms.TextBox outputTitle;
        private System.Windows.Forms.TextBox outputISBN;
        private System.Windows.Forms.TextBox outputCategory;
        private System.Windows.Forms.TextBox outputAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loanButton;
        private System.Windows.Forms.Button returnButton;
    }
}