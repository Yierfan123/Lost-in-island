
namespace Lost_in_island
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1label = new System.Windows.Forms.Label();
            this.option2label = new System.Windows.Forms.Label();
            this.option3label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lost_in_island.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(24, 19);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(279, 29);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "You are lost n a island.";
            // 
            // option1label
            // 
            this.option1label.AutoSize = true;
            this.option1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1label.Location = new System.Drawing.Point(83, 224);
            this.option1label.Name = "option1label";
            this.option1label.Size = new System.Drawing.Size(37, 20);
            this.option1label.TabIndex = 2;
            this.option1label.Text = "Yes";
            this.option1label.Click += new System.EventHandler(this.option1label_Click);
            // 
            // option2label
            // 
            this.option2label.AutoSize = true;
            this.option2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2label.Location = new System.Drawing.Point(83, 259);
            this.option2label.Name = "option2label";
            this.option2label.Size = new System.Drawing.Size(29, 20);
            this.option2label.TabIndex = 3;
            this.option2label.Text = "No";
            this.option2label.Click += new System.EventHandler(this.option2label_Click);
            // 
            // option3label
            // 
            this.option3label.AccessibleDescription = "";
            this.option3label.AutoSize = true;
            this.option3label.Location = new System.Drawing.Point(84, 183);
            this.option3label.Name = "option3label";
            this.option3label.Size = new System.Drawing.Size(139, 13);
            this.option3label.TabIndex = 4;
            this.option3label.Text = "Do you want to go left side?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 301);
            this.Controls.Add(this.option3label);
            this.Controls.Add(this.option2label);
            this.Controls.Add(this.option1label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lost in island";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1label;
        private System.Windows.Forms.Label option2label;
        private System.Windows.Forms.Label option3label;
    }
}

