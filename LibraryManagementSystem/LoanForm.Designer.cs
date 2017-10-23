namespace LibraryManagementSystem
{
    partial class LoanForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPersonSearch = new System.Windows.Forms.TextBox();
            this.personSearchBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(84, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "(double click person to loan them book)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "search";
            // 
            // inputPersonSearch
            // 
            this.inputPersonSearch.AccessibleName = "";
            this.inputPersonSearch.Location = new System.Drawing.Point(64, 12);
            this.inputPersonSearch.MaxLength = 50;
            this.inputPersonSearch.Name = "inputPersonSearch";
            this.inputPersonSearch.Size = new System.Drawing.Size(294, 20);
            this.inputPersonSearch.TabIndex = 10;
            this.inputPersonSearch.TextChanged += new System.EventHandler(this.inputPersonSearch_TextChanged);
            // 
            // personSearchBox
            // 
            this.personSearchBox.Font = new System.Drawing.Font("Courier New", 8.75F);
            this.personSearchBox.FormattingEnabled = true;
            this.personSearchBox.ItemHeight = 15;
            this.personSearchBox.Location = new System.Drawing.Point(12, 42);
            this.personSearchBox.Name = "personSearchBox";
            this.personSearchBox.Size = new System.Drawing.Size(346, 94);
            this.personSearchBox.Sorted = true;
            this.personSearchBox.TabIndex = 9;
            this.personSearchBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.personSearchBox_MouseDoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(142, 155);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 188);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPersonSearch);
            this.Controls.Add(this.personSearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPersonSearch;
        private System.Windows.Forms.ListBox personSearchBox;
        private System.Windows.Forms.Button closeButton;
    }
}