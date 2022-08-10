using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void btnAddReminders_Click(object sender, EventArgs e)
        {
            frmReminders reminders = new frmReminders();
            reminders.ShowDialog();
        }

        private void btnSwitchWallpaper_Click(object sender, EventArgs e)
        {
            frmWallpaperChoice wallpaperChoice = new frmWallpaperChoice();
            wallpaperChoice.ShowDialog();

        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            frmWallpaperSet wallpaperSet = new frmWallpaperSet();
            wallpaperSet.ShowDialog();
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
    }
}
