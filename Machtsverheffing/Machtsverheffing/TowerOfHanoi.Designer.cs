namespace Machtsverheffing
{
    partial class TowerOfHanoi
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
            this.recursiveButton = new System.Windows.Forms.Button();
            this.forLoopButton = new System.Windows.Forms.Button();
            this.machtsVerheffenButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // recursiveButton
            // 
            this.recursiveButton.Location = new System.Drawing.Point(393, 12);
            this.recursiveButton.Name = "recursiveButton";
            this.recursiveButton.Size = new System.Drawing.Size(152, 114);
            this.recursiveButton.TabIndex = 3;
            this.recursiveButton.Text = "Recursive";
            this.recursiveButton.UseVisualStyleBackColor = true;
            this.recursiveButton.Click += new System.EventHandler(this.recursiveButton_Click);
            // 
            // forLoopButton
            // 
            this.forLoopButton.Location = new System.Drawing.Point(32, 12);
            this.forLoopButton.Name = "forLoopButton";
            this.forLoopButton.Size = new System.Drawing.Size(157, 114);
            this.forLoopButton.TabIndex = 4;
            this.forLoopButton.Text = "ForLoop";
            this.forLoopButton.UseVisualStyleBackColor = true;
            this.forLoopButton.Click += new System.EventHandler(this.forLoopButton_Click);
            // 
            // machtsVerheffenButton
            // 
            this.machtsVerheffenButton.Location = new System.Drawing.Point(214, 12);
            this.machtsVerheffenButton.Name = "machtsVerheffenButton";
            this.machtsVerheffenButton.Size = new System.Drawing.Size(153, 114);
            this.machtsVerheffenButton.TabIndex = 6;
            this.machtsVerheffenButton.Text = "Machtsverheffen";
            this.machtsVerheffenButton.UseVisualStyleBackColor = true;
            this.machtsVerheffenButton.Click += new System.EventHandler(this.machtsVerheffenButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Machtsverheffing.Properties.Resources.TowersOfHanoi_1000;
            this.pictureBox1.Location = new System.Drawing.Point(3, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 174);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TowerOfHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(573, 394);
            this.Controls.Add(this.machtsVerheffenButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forLoopButton);
            this.Controls.Add(this.recursiveButton);
            this.Name = "TowerOfHanoi";
            this.Text = "TowerOfHanoi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button recursiveButton;
        private System.Windows.Forms.Button forLoopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button machtsVerheffenButton;
    }
}

