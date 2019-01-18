namespace ImageDiffLahiru
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
            this.imgCapture = new System.Windows.Forms.Button();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCapture
            // 
            this.imgCapture.Location = new System.Drawing.Point(586, 28);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(75, 23);
            this.imgCapture.TabIndex = 0;
            this.imgCapture.Text = "Capture";
            this.imgCapture.UseVisualStyleBackColor = true;
            this.imgCapture.Click += new System.EventHandler(this.imgCapture_Click);
            // 
            // imageDisplay
            // 
            this.imageDisplay.Location = new System.Drawing.Point(12, 12);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(541, 324);
            this.imageDisplay.TabIndex = 1;
            this.imageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 348);
            this.Controls.Add(this.imageDisplay);
            this.Controls.Add(this.imgCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imgCapture;
        private System.Windows.Forms.PictureBox imageDisplay;
    }
}

