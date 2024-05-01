namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.histSearchBox = new System.Windows.Forms.TextBox();
            this.histSearchBtn = new System.Windows.Forms.Button();
            this.histDeleteBtn = new System.Windows.Forms.Button();
            this.histClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(161, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // histSearchBox
            // 
            this.histSearchBox.Location = new System.Drawing.Point(161, 106);
            this.histSearchBox.Name = "histSearchBox";
            this.histSearchBox.Size = new System.Drawing.Size(163, 20);
            this.histSearchBox.TabIndex = 1;
            this.histSearchBox.TextChanged += new System.EventHandler(this.histSearchBox_TextChanged);
            // 
            // histSearchBtn
            // 
            this.histSearchBtn.Location = new System.Drawing.Point(330, 103);
            this.histSearchBtn.Name = "histSearchBtn";
            this.histSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.histSearchBtn.TabIndex = 2;
            this.histSearchBtn.Text = "Search";
            this.histSearchBtn.UseVisualStyleBackColor = true;
            this.histSearchBtn.Click += new System.EventHandler(this.histSearchBtn_Click);
            // 
            // histDeleteBtn
            // 
            this.histDeleteBtn.Location = new System.Drawing.Point(411, 103);
            this.histDeleteBtn.Name = "histDeleteBtn";
            this.histDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.histDeleteBtn.TabIndex = 3;
            this.histDeleteBtn.Text = "Delete";
            this.histDeleteBtn.UseVisualStyleBackColor = true;
            this.histDeleteBtn.Click += new System.EventHandler(this.histDeleteBtn_Click);
            // 
            // histClearBtn
            // 
            this.histClearBtn.Location = new System.Drawing.Point(492, 104);
            this.histClearBtn.Name = "histClearBtn";
            this.histClearBtn.Size = new System.Drawing.Size(85, 23);
            this.histClearBtn.TabIndex = 4;
            this.histClearBtn.Text = "Clear History";
            this.histClearBtn.UseVisualStyleBackColor = true;
            this.histClearBtn.Click += new System.EventHandler(this.histClearBtn_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.histClearBtn);
            this.Controls.Add(this.histDeleteBtn);
            this.Controls.Add(this.histSearchBtn);
            this.Controls.Add(this.histSearchBox);
            this.Controls.Add(this.listBox1);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox histSearchBox;
        private System.Windows.Forms.Button histSearchBtn;
        private System.Windows.Forms.Button histDeleteBtn;
        private System.Windows.Forms.Button histClearBtn;
    }
}