namespace ForLoop
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
            this.amountRingsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountMovesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountRingsComboBox
            // 
            this.amountRingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amountRingsComboBox.FormattingEnabled = true;
            this.amountRingsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.amountRingsComboBox.Location = new System.Drawing.Point(142, 157);
            this.amountRingsComboBox.Name = "amountRingsComboBox";
            this.amountRingsComboBox.Size = new System.Drawing.Size(121, 24);
            this.amountRingsComboBox.TabIndex = 1;
            this.amountRingsComboBox.SelectedIndexChanged += new System.EventHandler(this.amountRingsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aantal ringen:";
            // 
            // amountMovesLabel
            // 
            this.amountMovesLabel.AutoSize = true;
            this.amountMovesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountMovesLabel.Location = new System.Drawing.Point(278, 157);
            this.amountMovesLabel.Name = "amountMovesLabel";
            this.amountMovesLabel.Size = new System.Drawing.Size(132, 25);
            this.amountMovesLabel.TabIndex = 3;
            this.amountMovesLabel.Text = "Aantal zetten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountMovesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountRingsComboBox);
            this.Name = "Form1";
            this.Text = "ForLoop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox amountRingsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountMovesLabel;
        private System.Windows.Forms.Label label2;
    }
}

