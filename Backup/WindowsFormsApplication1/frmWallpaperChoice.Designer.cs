namespace WindowsFormsApplication1
{
    partial class frmWallpaperChoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstWallpapers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictPreview = new System.Windows.Forms.PictureBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstWallpapers);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wallpapers";
            // 
            // lstWallpapers
            // 
            this.lstWallpapers.FormattingEnabled = true;
            this.lstWallpapers.Location = new System.Drawing.Point(3, 16);
            this.lstWallpapers.Name = "lstWallpapers";
            this.lstWallpapers.Size = new System.Drawing.Size(239, 251);
            this.lstWallpapers.TabIndex = 0;
            this.lstWallpapers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstWallpapers_MouseDown);
            this.lstWallpapers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstWallpapers_KeyPress);
            this.lstWallpapers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstWallpapers_KeyUp);
            this.lstWallpapers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstWallpapers_KeyDown);
            this.lstWallpapers.Click += new System.EventHandler(this.lstWallpapers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictPreview);
            this.groupBox2.Location = new System.Drawing.Point(257, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // pictPreview
            // 
            this.pictPreview.Location = new System.Drawing.Point(6, 44);
            this.pictPreview.Name = "pictPreview";
            this.pictPreview.Size = new System.Drawing.Size(260, 185);
            this.pictPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPreview.TabIndex = 0;
            this.pictPreview.TabStop = false;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(363, 278);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(444, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmWallpaperChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmWallpaperChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Wallpaper";
            this.Load += new System.EventHandler(this.frmWallpaperChoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstWallpapers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictPreview;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnClose;
    }
}