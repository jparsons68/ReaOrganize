namespace ReaOrganize
{
    partial class Form1
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
            this.fileFieldAndBrowser1 = new IERSInterface.FileFieldAndBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileFieldAndBrowser1
            // 
            this.fileFieldAndBrowser1.AllowDrop = true;
            this.fileFieldAndBrowser1.BrowseFoldersOnly = true;
            this.fileFieldAndBrowser1.CheckFileExists = true;
            this.fileFieldAndBrowser1.FileName = "";
            this.fileFieldAndBrowser1.Filter = "All Files|*.*";
            this.fileFieldAndBrowser1.FilterIndex = 1;
            this.fileFieldAndBrowser1.Location = new System.Drawing.Point(9, 9);
            this.fileFieldAndBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.fileFieldAndBrowser1.Multiselect = false;
            this.fileFieldAndBrowser1.Name = "fileFieldAndBrowser1";
            this.fileFieldAndBrowser1.RecentFileRegistry = null;
            this.fileFieldAndBrowser1.Size = new System.Drawing.Size(512, 25);
            this.fileFieldAndBrowser1.TabIndex = 0;
            this.fileFieldAndBrowser1.TextOffset = 94;
            this.fileFieldAndBrowser1.TextWidth = 343;
            this.fileFieldAndBrowser1.Title = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 272);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 350);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileFieldAndBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IERSInterface.FileFieldAndBrowser fileFieldAndBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

