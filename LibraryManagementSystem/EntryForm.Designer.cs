namespace LibraryManagementSystem
{
    partial class EntryForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPanel = new System.Windows.Forms.Panel();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.studentsRadioButton = new System.Windows.Forms.RadioButton();
            this.lecturersRadioButton = new System.Windows.Forms.RadioButton();
            this.personDetailsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPersonSearch = new System.Windows.Forms.TextBox();
            this.personSearchBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bookDetailsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bookSearchBox = new System.Windows.Forms.ListBox();
            this.inputSearchBook = new System.Windows.Forms.TextBox();
            this.overdueBorrowers = new System.Windows.Forms.GroupBox();
            this.patronsOverdueBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.radioButtonPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.overdueBorrowers.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lecturer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addLecturerClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(385, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.overdueBorrowers);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(542, 360);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPanel);
            this.groupBox2.Controls.Add(this.personDetailsButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.inputPersonSearch);
            this.groupBox2.Controls.Add(this.personSearchBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 175);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Search";
            // 
            // radioButtonPanel
            // 
            this.radioButtonPanel.Controls.Add(this.allRadioButton);
            this.radioButtonPanel.Controls.Add(this.studentsRadioButton);
            this.radioButtonPanel.Controls.Add(this.lecturersRadioButton);
            this.radioButtonPanel.Location = new System.Drawing.Point(9, 142);
            this.radioButtonPanel.Name = "radioButtonPanel";
            this.radioButtonPanel.Size = new System.Drawing.Size(192, 23);
            this.radioButtonPanel.TabIndex = 2;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(3, 3);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 17);
            this.allRadioButton.TabIndex = 3;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // studentsRadioButton
            // 
            this.studentsRadioButton.AutoSize = true;
            this.studentsRadioButton.Location = new System.Drawing.Point(122, 3);
            this.studentsRadioButton.Name = "studentsRadioButton";
            this.studentsRadioButton.Size = new System.Drawing.Size(67, 17);
            this.studentsRadioButton.TabIndex = 5;
            this.studentsRadioButton.TabStop = true;
            this.studentsRadioButton.Text = "Students";
            this.studentsRadioButton.UseVisualStyleBackColor = true;
            this.studentsRadioButton.CheckedChanged += new System.EventHandler(this.studentsRadioButton_CheckedChanged);
            // 
            // lecturersRadioButton
            // 
            this.lecturersRadioButton.AutoSize = true;
            this.lecturersRadioButton.Location = new System.Drawing.Point(47, 3);
            this.lecturersRadioButton.Name = "lecturersRadioButton";
            this.lecturersRadioButton.Size = new System.Drawing.Size(69, 17);
            this.lecturersRadioButton.TabIndex = 4;
            this.lecturersRadioButton.Text = "Lecturers";
            this.lecturersRadioButton.UseVisualStyleBackColor = true;
            this.lecturersRadioButton.CheckedChanged += new System.EventHandler(this.lecturerRadioButton_CheckedChanged);
            // 
            // personDetailsButton
            // 
            this.personDetailsButton.Location = new System.Drawing.Point(259, 142);
            this.personDetailsButton.Name = "personDetailsButton";
            this.personDetailsButton.Size = new System.Drawing.Size(111, 23);
            this.personDetailsButton.TabIndex = 6;
            this.personDetailsButton.Text = "View Person";
            this.personDetailsButton.UseVisualStyleBackColor = true;
            this.personDetailsButton.Click += new System.EventHandler(this.personDetailsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "search";
            // 
            // inputPersonSearch
            // 
            this.inputPersonSearch.AccessibleName = "";
            this.inputPersonSearch.Location = new System.Drawing.Point(78, 19);
            this.inputPersonSearch.MaxLength = 50;
            this.inputPersonSearch.Name = "inputPersonSearch";
            this.inputPersonSearch.Size = new System.Drawing.Size(292, 20);
            this.inputPersonSearch.TabIndex = 0;
            this.inputPersonSearch.TextChanged += new System.EventHandler(this.inputPersonSearch_TextChanged);
            // 
            // personSearchBox
            // 
            this.personSearchBox.Font = new System.Drawing.Font("Courier New", 9.25F);
            this.personSearchBox.FormattingEnabled = true;
            this.personSearchBox.ItemHeight = 15;
            this.personSearchBox.Location = new System.Drawing.Point(7, 48);
            this.personSearchBox.Name = "personSearchBox";
            this.personSearchBox.Size = new System.Drawing.Size(363, 94);
            this.personSearchBox.Sorted = true;
            this.personSearchBox.TabIndex = 1;
            this.personSearchBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.personSearchBox_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bookDetailsButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bookSearchBox);
            this.groupBox3.Controls.Add(this.inputSearchBook);
            this.groupBox3.Location = new System.Drawing.Point(3, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 173);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Search";
            // 
            // bookDetailsButton
            // 
            this.bookDetailsButton.Location = new System.Drawing.Point(131, 144);
            this.bookDetailsButton.Name = "bookDetailsButton";
            this.bookDetailsButton.Size = new System.Drawing.Size(111, 23);
            this.bookDetailsButton.TabIndex = 14;
            this.bookDetailsButton.Text = "View Book";
            this.bookDetailsButton.UseVisualStyleBackColor = true;
            this.bookDetailsButton.Click += new System.EventHandler(this.bookDetailsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "search";
            // 
            // bookSearchBox
            // 
            this.bookSearchBox.Font = new System.Drawing.Font("Courier New", 9.25F);
            this.bookSearchBox.FormattingEnabled = true;
            this.bookSearchBox.ItemHeight = 15;
            this.bookSearchBox.Location = new System.Drawing.Point(6, 46);
            this.bookSearchBox.Name = "bookSearchBox";
            this.bookSearchBox.Size = new System.Drawing.Size(364, 94);
            this.bookSearchBox.Sorted = true;
            this.bookSearchBox.TabIndex = 13;
            this.bookSearchBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bookSearchBox_MouseDoubleClick);
            // 
            // inputSearchBook
            // 
            this.inputSearchBook.Location = new System.Drawing.Point(78, 19);
            this.inputSearchBook.MaxLength = 50;
            this.inputSearchBook.Name = "inputSearchBook";
            this.inputSearchBook.Size = new System.Drawing.Size(292, 20);
            this.inputSearchBook.TabIndex = 12;
            this.inputSearchBook.TextChanged += new System.EventHandler(this.inputSearchBook_TextChanged);
            // 
            // overdueBorrowers
            // 
            this.overdueBorrowers.Controls.Add(this.patronsOverdueBox);
            this.overdueBorrowers.Location = new System.Drawing.Point(385, 184);
            this.overdueBorrowers.Name = "overdueBorrowers";
            this.overdueBorrowers.Size = new System.Drawing.Size(153, 173);
            this.overdueBorrowers.TabIndex = 15;
            this.overdueBorrowers.TabStop = false;
            this.overdueBorrowers.Text = "Patrons Overdue";
            // 
            // patronsOverdueBox
            // 
            this.patronsOverdueBox.Font = new System.Drawing.Font("Courier New", 7.75F);
            this.patronsOverdueBox.FormattingEnabled = true;
            this.patronsOverdueBox.ItemHeight = 12;
            this.patronsOverdueBox.Location = new System.Drawing.Point(6, 22);
            this.patronsOverdueBox.Name = "patronsOverdueBox";
            this.patronsOverdueBox.Size = new System.Drawing.Size(141, 136);
            this.patronsOverdueBox.Sorted = true;
            this.patronsOverdueBox.TabIndex = 16;
            this.patronsOverdueBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.patronsOverdueBox_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "close application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 399);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System [10366827]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.radioButtonPanel.ResumeLayout(false);
            this.radioButtonPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.overdueBorrowers.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox personSearchBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox bookSearchBox;
        private System.Windows.Forms.GroupBox overdueBorrowers;
        private System.Windows.Forms.ListBox patronsOverdueBox;
        private System.Windows.Forms.TextBox inputPersonSearch;
        private System.Windows.Forms.TextBox inputSearchBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personDetailsButton;
        private System.Windows.Forms.Button bookDetailsButton;
        private System.Windows.Forms.Panel radioButtonPanel;
        private System.Windows.Forms.RadioButton studentsRadioButton;
        private System.Windows.Forms.RadioButton lecturersRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

