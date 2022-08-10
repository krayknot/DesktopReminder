using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmWallpaperChoice : Form
    {
        public frmWallpaperChoice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWallpaperChoice_Load(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo("wallpapers");
                FileInfo[] rgFiles = di.GetFiles("*.jpg");
                foreach (FileInfo fi in rgFiles)
                {
                    lstWallpapers.Items.Add(fi.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void lstWallpapers_Click(object sender, EventArgs e)
        {
            try
            {
                pictPreview.Image = System.Drawing.Image.FromFile("Wallpapers\\" + lstWallpapers.SelectedItem.ToString());  
            }
            catch (Exception)
            {                
            }
        }

        private void lstWallpapers_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lstWallpapers_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void lstWallpapers_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void lstWallpapers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                lstWallpapers_Click(sender, e);
            }
        }
    }
}
