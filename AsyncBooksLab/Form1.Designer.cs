namespace AsyncBooksLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            btnBrowse = new Button();
            txtFile = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnExit = new Button();
            lstReport = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            lstReport2 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(466, 225);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(415, 64);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(107, 65);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(288, 31);
            txtFile.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(466, 323);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.Location = new Point(107, 168);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(288, 254);
            lstReport.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 5;
            label1.Text = "Book 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 65);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 6;
            label2.Text = "Book 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(662, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 31);
            textBox1.TabIndex = 7;
            // 
            // lstReport2
            // 
            lstReport2.FormattingEnabled = true;
            lstReport2.Location = new Point(662, 168);
            lstReport2.Name = "lstReport2";
            lstReport2.Size = new Size(288, 254);
            lstReport2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(978, 60);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 511);
            Controls.Add(button1);
            Controls.Add(lstReport2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstReport);
            Controls.Add(btnExit);
            Controls.Add(txtFile);
            Controls.Add(btnBrowse);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnBrowse;
        private TextBox txtFile;
        private OpenFileDialog openFileDialog1;
        private Button btnExit;
        private ListBox lstReport;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ListBox lstReport2;
        private Button button1;
    }
}
