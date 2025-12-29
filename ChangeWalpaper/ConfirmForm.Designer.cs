namespace ChangeWalpaper
{
    partial class ConfirmForm
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
            this.pbNewWallpaper = new System.Windows.Forms.PictureBox();
            this.btnSetWallpaper = new System.Windows.Forms.Button();
            this.pbCurrentWallpaper = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewWallpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNewWallpaper
            // 
            this.pbNewWallpaper.Location = new System.Drawing.Point(54, 99);
            this.pbNewWallpaper.Name = "pbNewWallpaper";
            this.pbNewWallpaper.Size = new System.Drawing.Size(599, 369);
            this.pbNewWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewWallpaper.TabIndex = 0;
            this.pbNewWallpaper.TabStop = false;
            // 
            // btnSetWallpaper
            // 
            this.btnSetWallpaper.Location = new System.Drawing.Point(379, 492);
            this.btnSetWallpaper.Name = "btnSetWallpaper";
            this.btnSetWallpaper.Size = new System.Drawing.Size(610, 49);
            this.btnSetWallpaper.TabIndex = 1;
            this.btnSetWallpaper.Text = "Set Wallpaper";
            this.btnSetWallpaper.UseVisualStyleBackColor = true;
            this.btnSetWallpaper.Click += new System.EventHandler(this.btnSetWallpaper_Click);
            // 
            // pbCurrentWallpaper
            // 
            this.pbCurrentWallpaper.Location = new System.Drawing.Point(688, 99);
            this.pbCurrentWallpaper.Name = "pbCurrentWallpaper";
            this.pbCurrentWallpaper.Size = new System.Drawing.Size(599, 369);
            this.pbCurrentWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentWallpaper.TabIndex = 2;
            this.pbCurrentWallpaper.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Wallpaper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Wallpaper";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1342, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCurrentWallpaper);
            this.Controls.Add(this.btnSetWallpaper);
            this.Controls.Add(this.pbNewWallpaper);
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            this.Load += new System.EventHandler(this.ConfirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewWallpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNewWallpaper;
        private System.Windows.Forms.Button btnSetWallpaper;
        private System.Windows.Forms.PictureBox pbCurrentWallpaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}