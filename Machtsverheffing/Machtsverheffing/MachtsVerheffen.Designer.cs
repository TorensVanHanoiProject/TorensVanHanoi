namespace Machtsverheffing
{
    partial class MachtsVerheffen
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalDiscsTextBox = new System.Windows.Forms.TextBox();
            this.discAmountLabel = new System.Windows.Forms.Label();
            this.totalMovesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(68, 110);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(108, 35);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalDiscsTextBox
            // 
            this.totalDiscsTextBox.Location = new System.Drawing.Point(27, 82);
            this.totalDiscsTextBox.Name = "totalDiscsTextBox";
            this.totalDiscsTextBox.Size = new System.Drawing.Size(194, 22);
            this.totalDiscsTextBox.TabIndex = 4;
            // 
            // discAmountLabel
            // 
            this.discAmountLabel.AutoSize = true;
            this.discAmountLabel.Location = new System.Drawing.Point(37, 62);
            this.discAmountLabel.Name = "discAmountLabel";
            this.discAmountLabel.Size = new System.Drawing.Size(167, 17);
            this.discAmountLabel.TabIndex = 5;
            this.discAmountLabel.Text = "Input the number of discs";
            // 
            // totalMovesLabel
            // 
            this.totalMovesLabel.AutoSize = true;
            this.totalMovesLabel.Location = new System.Drawing.Point(12, 9);
            this.totalMovesLabel.Name = "totalMovesLabel";
            this.totalMovesLabel.Size = new System.Drawing.Size(85, 17);
            this.totalMovesLabel.TabIndex = 6;
            this.totalMovesLabel.Text = "Total Moves";
            // 
            // TowerOfHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 209);
            this.Controls.Add(this.totalMovesLabel);
            this.Controls.Add(this.discAmountLabel);
            this.Controls.Add(this.totalDiscsTextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "TowerOfHanoi";
            this.Text = "TowerOfHanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox totalDiscsTextBox;
        private System.Windows.Forms.Label discAmountLabel;
        private System.Windows.Forms.Label totalMovesLabel;
    }
}