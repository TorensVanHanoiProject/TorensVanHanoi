﻿namespace Machtsverheffing
{
    partial class Recursive
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
            this.amountStepsLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.amountDiscsTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(73, 109);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // amountStepsLabel
            // 
            this.amountStepsLabel.AutoSize = true;
            this.amountStepsLabel.Location = new System.Drawing.Point(12, 9);
            this.amountStepsLabel.Name = "amountStepsLabel";
            this.amountStepsLabel.Size = new System.Drawing.Size(96, 17);
            this.amountStepsLabel.TabIndex = 9;
            this.amountStepsLabel.Text = "Amount Steps";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(43, 61);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(166, 17);
            this.inputLabel.TabIndex = 8;
            this.inputLabel.Text = "Input the amount of discs";
            // 
            // amountDiscsTextbox
            // 
            this.amountDiscsTextbox.Location = new System.Drawing.Point(36, 81);
            this.amountDiscsTextbox.Name = "amountDiscsTextbox";
            this.amountDiscsTextbox.Size = new System.Drawing.Size(173, 22);
            this.amountDiscsTextbox.TabIndex = 7;
            // 
            // Recursive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(278, 209);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amountStepsLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.amountDiscsTextbox);
            this.Name = "Recursive";
            this.Text = "Recursive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label amountStepsLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox amountDiscsTextbox;
    }
}