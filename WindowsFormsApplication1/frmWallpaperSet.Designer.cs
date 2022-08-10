namespace WindowsFormsApplication1
{
    partial class frmWallpaperSet
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictTopRight = new System.Windows.Forms.PictureBox();
            this.pictTopLeft = new System.Windows.Forms.PictureBox();
            this.pictBottomLeft = new System.Windows.Forms.PictureBox();
            this.pictBottomRight = new System.Windows.Forms.PictureBox();
            this.pictCenter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictCenter);
            this.groupBox1.Controls.Add(this.pictBottomRight);
            this.groupBox1.Controls.Add(this.pictBottomLeft);
            this.groupBox1.Controls.Add(this.pictTopLeft);
            this.groupBox1.Controls.Add(this.pictTopRight);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the position of Reminders list on the Wallpaper";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Top Right";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Top Left";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(386, 97);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Bottom Right";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(264, 97);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Bottom Left";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(511, 97);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(58, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Center";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(454, 138);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(536, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictTopRight
            // 
            this.pictTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictTopRight.Location = new System.Drawing.Point(12, 20);
            this.pictTopRight.Name = "pictTopRight";
            this.pictTopRight.Size = new System.Drawing.Size(100, 71);
            this.pictTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictTopRight.TabIndex = 5;
            this.pictTopRight.TabStop = false;
            this.pictTopRight.Click += new System.EventHandler(this.pictTopRight_Click);
            // 
            // pictTopLeft
            // 
            this.pictTopLeft.Location = new System.Drawing.Point(138, 20);
            this.pictTopLeft.Name = "pictTopLeft";
            this.pictTopLeft.Size = new System.Drawing.Size(100, 71);
            this.pictTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictTopLeft.TabIndex = 6;
            this.pictTopLeft.TabStop = false;
            this.pictTopLeft.Click += new System.EventHandler(this.pictTopLeft_Click);
            // 
            // pictBottomLeft
            // 
            this.pictBottomLeft.Location = new System.Drawing.Point(264, 20);
            this.pictBottomLeft.Name = "pictBottomLeft";
            this.pictBottomLeft.Size = new System.Drawing.Size(100, 71);
            this.pictBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBottomLeft.TabIndex = 7;
            this.pictBottomLeft.TabStop = false;
            this.pictBottomLeft.Click += new System.EventHandler(this.pictBottomLeft_Click);
            // 
            // pictBottomRight
            // 
            this.pictBottomRight.Location = new System.Drawing.Point(386, 20);
            this.pictBottomRight.Name = "pictBottomRight";
            this.pictBottomRight.Size = new System.Drawing.Size(100, 71);
            this.pictBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBottomRight.TabIndex = 8;
            this.pictBottomRight.TabStop = false;
            this.pictBottomRight.Click += new System.EventHandler(this.pictBottomRight_Click);
            // 
            // pictCenter
            // 
            this.pictCenter.Location = new System.Drawing.Point(511, 20);
            this.pictCenter.Name = "pictCenter";
            this.pictCenter.Size = new System.Drawing.Size(100, 71);
            this.pictCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCenter.TabIndex = 9;
            this.pictCenter.TabStop = false;
            this.pictCenter.Click += new System.EventHandler(this.pictCenter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(89, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 29);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(144, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 29);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(270, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 29);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(462, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 29);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(552, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 29);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // frmWallpaperSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 167);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmWallpaperSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpaper and Position Setting";
            this.Load += new System.EventHandler(this.frmWallpaperSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictCenter;
        private System.Windows.Forms.PictureBox pictBottomRight;
        private System.Windows.Forms.PictureBox pictBottomLeft;
        private System.Windows.Forms.PictureBox pictTopLeft;
        private System.Windows.Forms.PictureBox pictTopRight;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}