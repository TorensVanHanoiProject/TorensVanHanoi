namespace Machtsverheffing
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
            this.totalMovesLabel = new System.Windows.Forms.Label();
            this.totalDiscsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.discAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalMovesLabel
            // 
            this.totalMovesLabel.AutoSize = true;
            this.totalMovesLabel.Location = new System.Drawing.Point(13, 9);
            this.totalMovesLabel.Name = "totalMovesLabel";
            this.totalMovesLabel.Size = new System.Drawing.Size(85, 17);
            this.totalMovesLabel.TabIndex = 0;
            this.totalMovesLabel.Text = "Total Moves";
            // 
            // totalDiscsTextBox
            // 
            this.totalDiscsTextBox.Location = new System.Drawing.Point(66, 117);
            this.totalDiscsTextBox.Name = "totalDiscsTextBox";
            this.totalDiscsTextBox.Size = new System.Drawing.Size(194, 22);
            this.totalDiscsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(122, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(89, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // discAmountLabel
            // 
            this.discAmountLabel.AutoSize = true;
            this.discAmountLabel.Location = new System.Drawing.Point(74, 84);
            this.discAmountLabel.Name = "discAmountLabel";
            this.discAmountLabel.Size = new System.Drawing.Size(167, 17);
            this.discAmountLabel.TabIndex = 3;
            this.discAmountLabel.Text = "Input the number of discs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.discAmountLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalDiscsTextBox);
            this.Controls.Add(this.totalMovesLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalMovesLabel;
        private System.Windows.Forms.TextBox totalDiscsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label discAmountLabel;
    }
}

