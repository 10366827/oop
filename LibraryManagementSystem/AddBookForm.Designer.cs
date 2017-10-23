namespace LibraryManagementSystem
{
    partial class AddBookForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.inCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelisbn = new System.Windows.Forms.Label();
            this.inPublisher = new System.Windows.Forms.TextBox();
            this.inAuthor = new System.Windows.Forms.TextBox();
            this.inTitle = new System.Windows.Forms.TextBox();
            this.inISBN = new System.Windows.Forms.TextBox();
            this.inQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(10, 178);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(94, 178);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // inCategory
            // 
            this.inCategory.FormattingEnabled = true;
            this.inCategory.Items.AddRange(new object[] {
            "Drama",
            "Computer Science",
            "Engineering",
            "Linguistics",
            "Math",
            "Poetry",
            "Science "});
            this.inCategory.Location = new System.Drawing.Point(143, 145);
            this.inCategory.Name = "inCategory";
            this.inCategory.Size = new System.Drawing.Size(139, 21);
            this.inCategory.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Choose / Enter Category:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Publisher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Author:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(10, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 30;
            this.labelTitle.Text = "Title:";
            // 
            // labelisbn
            // 
            this.labelisbn.AutoSize = true;
            this.labelisbn.Location = new System.Drawing.Point(10, 11);
            this.labelisbn.Name = "labelisbn";
            this.labelisbn.Size = new System.Drawing.Size(35, 13);
            this.labelisbn.TabIndex = 31;
            this.labelisbn.Text = "ISBN:";
            // 
            // inPublisher
            // 
            this.inPublisher.AccessibleDescription = "";
            this.inPublisher.AccessibleName = "";
            this.inPublisher.Location = new System.Drawing.Point(75, 86);
            this.inPublisher.MaxLength = 50;
            this.inPublisher.Name = "inPublisher";
            this.inPublisher.Size = new System.Drawing.Size(207, 20);
            this.inPublisher.TabIndex = 3;
            // 
            // inAuthor
            // 
            this.inAuthor.AccessibleDescription = "";
            this.inAuthor.AccessibleName = "";
            this.inAuthor.Location = new System.Drawing.Point(75, 60);
            this.inAuthor.MaxLength = 40;
            this.inAuthor.Name = "inAuthor";
            this.inAuthor.Size = new System.Drawing.Size(207, 20);
            this.inAuthor.TabIndex = 2;
            // 
            // inTitle
            // 
            this.inTitle.AccessibleDescription = "";
            this.inTitle.AccessibleName = "";
            this.inTitle.Location = new System.Drawing.Point(75, 34);
            this.inTitle.MaxLength = 60;
            this.inTitle.Name = "inTitle";
            this.inTitle.Size = new System.Drawing.Size(207, 20);
            this.inTitle.TabIndex = 1;
            // 
            // inISBN
            // 
            this.inISBN.AccessibleDescription = "";
            this.inISBN.AccessibleName = "";
            this.inISBN.Location = new System.Drawing.Point(75, 8);
            this.inISBN.MaxLength = 13;
            this.inISBN.Name = "inISBN";
            this.inISBN.Size = new System.Drawing.Size(207, 20);
            this.inISBN.TabIndex = 0;
            // 
            // inQuantity
            // 
            this.inQuantity.Location = new System.Drawing.Point(75, 115);
            this.inQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inQuantity.Name = "inQuantity";
            this.inQuantity.Size = new System.Drawing.Size(57, 20);
            this.inQuantity.TabIndex = 4;
            this.inQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 213);
            this.Controls.Add(this.inQuantity);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.inCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelisbn);
            this.Controls.Add(this.inPublisher);
            this.Controls.Add(this.inAuthor);
            this.Controls.Add(this.inTitle);
            this.Controls.Add(this.inISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.inQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox inCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelisbn;
        private System.Windows.Forms.TextBox inPublisher;
        private System.Windows.Forms.TextBox inAuthor;
        private System.Windows.Forms.TextBox inTitle;
        private System.Windows.Forms.TextBox inISBN;
        private System.Windows.Forms.NumericUpDown inQuantity;
    }
}