namespace LibraryManagementSystem
{
    partial class ReturnForm
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
            this.borrowedBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(128, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "(double click person to return)";
            // 
            // borrowedBox
            // 
            this.borrowedBox.Font = new System.Drawing.Font("Courier New", 8.55F);
            this.borrowedBox.FormattingEnabled = true;
            this.borrowedBox.ItemHeight = 14;
            this.borrowedBox.Location = new System.Drawing.Point(12, 12);
            this.borrowedBox.Name = "borrowedBox";
            this.borrowedBox.Size = new System.Drawing.Size(391, 102);
            this.borrowedBox.Sorted = true;
            this.borrowedBox.TabIndex = 13;
            this.borrowedBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.borrowersBox_MouseDoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(163, 133);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 166);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.borrowedBox);
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox borrowedBox;
        private System.Windows.Forms.Button closeButton;
    }
}