namespace WindowsFormsApp1
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
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.seconfNumTextBox = new System.Windows.Forms.TextBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(26, 52);
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumTextBox.TabIndex = 0;
            // 
            // seconfNumTextBox
            // 
            this.seconfNumTextBox.Location = new System.Drawing.Point(26, 91);
            this.seconfNumTextBox.Name = "seconfNumTextBox";
            this.seconfNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.seconfNumTextBox.TabIndex = 1;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(26, 133);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(35, 13);
            this.sumLabel.TabIndex = 2;
            this.sumLabel.Text = "label1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(188, 70);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.seconfNumTextBox);
            this.Controls.Add(this.firstNumTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.TextBox seconfNumTextBox;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button addButton;
    }
}

