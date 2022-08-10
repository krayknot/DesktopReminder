namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.btnAddReminders = new System.Windows.Forms.Button();
            this.btnSwitchWallpaper = new System.Windows.Forms.Button();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnAboutus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddReminders
            // 
            this.btnAddReminders.Location = new System.Drawing.Point(2, 1);
            this.btnAddReminders.Name = "btnAddReminders";
            this.btnAddReminders.Size = new System.Drawing.Size(107, 66);
            this.btnAddReminders.TabIndex = 0;
            this.btnAddReminders.Text = "Add | Delete Reminders";
            this.btnAddReminders.UseVisualStyleBackColor = true;
            this.btnAddReminders.Click += new System.EventHandler(this.btnAddReminders_Click);
            // 
            // btnSwitchWallpaper
            // 
            this.btnSwitchWallpaper.Location = new System.Drawing.Point(2, 68);
            this.btnSwitchWallpaper.Name = "btnSwitchWallpaper";
            this.btnSwitchWallpaper.Size = new System.Drawing.Size(107, 66);
            this.btnSwitchWallpaper.TabIndex = 1;
            this.btnSwitchWallpaper.Text = "Switch Wallpaper";
            this.btnSwitchWallpaper.UseVisualStyleBackColor = true;
            this.btnSwitchWallpaper.Click += new System.EventHandler(this.btnSwitchWallpaper_Click);
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(2, 135);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(107, 66);
            this.btnRender.TabIndex = 2;
            this.btnRender.Text = "Render Reminder(s)  on Wallpaper";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(2, 228);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 28);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAboutus
            // 
            this.btnAboutus.Location = new System.Drawing.Point(2, 203);
            this.btnAboutus.Name = "btnAboutus";
            this.btnAboutus.Size = new System.Drawing.Size(107, 23);
            this.btnAboutus.TabIndex = 4;
            this.btnAboutus.Text = "About";
            this.btnAboutus.UseVisualStyleBackColor = true;
            this.btnAboutus.Click += new System.EventHandler(this.btnAboutus_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(110, 257);
            this.ControlBox = false;
            this.Controls.Add(this.btnAboutus);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.btnSwitchWallpaper);
            this.Controls.Add(this.btnAddReminders);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Reminder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddReminders;
        private System.Windows.Forms.Button btnSwitchWallpaper;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAboutus;
    }
}