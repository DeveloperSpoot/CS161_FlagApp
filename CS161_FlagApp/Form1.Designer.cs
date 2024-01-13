namespace CS161_FlagApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.finlandImage = new System.Windows.Forms.PictureBox();
            this.franceImage = new System.Windows.Forms.PictureBox();
            this.germanyImage = new System.Windows.Forms.PictureBox();
            this.flagNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(162, 9);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(442, 25);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Click A Flag To See The Name Of The Country.";
            // 
            // finlandImage
            // 
            this.finlandImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finlandImage.Image = ((System.Drawing.Image)(resources.GetObject("finlandImage.Image")));
            this.finlandImage.Location = new System.Drawing.Point(181, 70);
            this.finlandImage.Name = "finlandImage";
            this.finlandImage.Size = new System.Drawing.Size(131, 92);
            this.finlandImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandImage.TabIndex = 1;
            this.finlandImage.TabStop = false;
            this.finlandImage.Click += new System.EventHandler(this.finlandImage_Click);
            // 
            // franceImage
            // 
            this.franceImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.franceImage.Image = ((System.Drawing.Image)(resources.GetObject("franceImage.Image")));
            this.franceImage.Location = new System.Drawing.Point(316, 70);
            this.franceImage.Name = "franceImage";
            this.franceImage.Size = new System.Drawing.Size(131, 92);
            this.franceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.franceImage.TabIndex = 2;
            this.franceImage.TabStop = false;
            this.franceImage.Click += new System.EventHandler(this.franceImage_Click);
            // 
            // germanyImage
            // 
            this.germanyImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.germanyImage.Image = ((System.Drawing.Image)(resources.GetObject("germanyImage.Image")));
            this.germanyImage.Location = new System.Drawing.Point(451, 70);
            this.germanyImage.Name = "germanyImage";
            this.germanyImage.Size = new System.Drawing.Size(131, 92);
            this.germanyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanyImage.TabIndex = 3;
            this.germanyImage.TabStop = false;
            this.germanyImage.Click += new System.EventHandler(this.germanyImage_Click);
            // 
            // flagNameLabel
            // 
            this.flagNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flagNameLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flagNameLabel.Location = new System.Drawing.Point(270, 211);
            this.flagNameLabel.Name = "flagNameLabel";
            this.flagNameLabel.Size = new System.Drawing.Size(219, 47);
            this.flagNameLabel.TabIndex = 4;
            this.flagNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.flagNameLabel);
            this.Controls.Add(this.germanyImage);
            this.Controls.Add(this.franceImage);
            this.Controls.Add(this.finlandImage);
            this.Controls.Add(this.InstructionLabel);
            this.Name = "Form1";
            this.Text = "Flag App";
            ((System.ComponentModel.ISupportInitialize)(this.finlandImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.PictureBox finlandImage;
        private System.Windows.Forms.PictureBox franceImage;
        private System.Windows.Forms.PictureBox germanyImage;
        private System.Windows.Forms.Label flagNameLabel;
    }
}

