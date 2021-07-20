namespace HowToDeleteObjects
{
    partial class MainForm
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
            this.removeObjects = new System.Windows.Forms.Button();
            this.btnCreatePictures = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.picSelected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // removeObjects
            // 
            this.removeObjects.Enabled = false;
            this.removeObjects.Location = new System.Drawing.Point(304, 154);
            this.removeObjects.Name = "removeObjects";
            this.removeObjects.Size = new System.Drawing.Size(191, 23);
            this.removeObjects.TabIndex = 0;
            this.removeObjects.Text = "removeObjects";
            this.removeObjects.UseVisualStyleBackColor = true;
            this.removeObjects.Click += new System.EventHandler(this.RemoveObjects_Click);
            // 
            // btnCreatePictures
            // 
            this.btnCreatePictures.Location = new System.Drawing.Point(327, 58);
            this.btnCreatePictures.Name = "btnCreatePictures";
            this.btnCreatePictures.Size = new System.Drawing.Size(137, 23);
            this.btnCreatePictures.TabIndex = 1;
            this.btnCreatePictures.Text = "Create Images";
            this.btnCreatePictures.UseVisualStyleBackColor = true;
            this.btnCreatePictures.Click += new System.EventHandler(this.BtnCreatePictures_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.Control;
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(404, 251);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">>>";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.Control;
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(332, 251);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<<<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // picSelected
            // 
            this.picSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSelected.Location = new System.Drawing.Point(-1, 0);
            this.picSelected.Name = "picSelected";
            this.picSelected.Size = new System.Drawing.Size(800, 367);
            this.picSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelected.TabIndex = 2;
            this.picSelected.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnCreatePictures);
            this.Controls.Add(this.removeObjects);
            this.Controls.Add(this.picSelected);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeObjects;
        private System.Windows.Forms.Button btnCreatePictures;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.PictureBox picSelected;
    }
}