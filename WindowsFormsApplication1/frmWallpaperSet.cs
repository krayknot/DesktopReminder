using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    enum location
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Centre
    };   

    public partial class frmWallpaperSet : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, String pvParam, UInt32 fWinIni);
        private static UInt32 SPI_SETDESKWALLPAPER = 20;
        private static UInt32 SPIF_UPDATEINIFILE = 0x1;
        //private String imageFileName = "c:\\sample.bmp";

        public void SetImage(string filename)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, filename, SPIF_UPDATEINIFILE);
        }

        public frmWallpaperSet()
        {
            InitializeComponent();
        }

        private void frmWallpaperSet_Load(object sender, EventArgs e)
        {
            try
            {
                pictTopRight.Image = System.Drawing.Image.FromFile(GetCurrentWallpaperPath());
                pictTopLeft.Image = System.Drawing.Image.FromFile(GetCurrentWallpaperPath());
                pictBottomLeft.Image = System.Drawing.Image.FromFile(GetCurrentWallpaperPath());
                pictBottomRight.Image = System.Drawing.Image.FromFile(GetCurrentWallpaperPath());
                pictCenter.Image = System.Drawing.Image.FromFile(GetCurrentWallpaperPath());
            }
            catch (Exception)
            {                
                throw;
            }            
        }

        /// <summary>
        /// Gets the current wallpaper path.
        /// </summary>
        /// <returns>the wallpaper path</returns>
        private static string GetCurrentWallpaperPath()
        {
            RegistryKey wallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false);
            string WallpaperPath = wallPaper.GetValue("WallPaper").ToString();
            wallPaper.Close();
            return WallpaperPath;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    RewriteImagewithReminders(GetCurrentWallpaperPath(), location.TopRight);
                }
                else if (radioButton2.Checked)
                {
                    RewriteImagewithReminders(GetCurrentWallpaperPath(), location.TopLeft);
                }
                else if (radioButton3.Checked)
                {
                    RewriteImagewithReminders(GetCurrentWallpaperPath(), location.BottomRight);
                }
                else if (radioButton4.Checked)
                {
                    RewriteImagewithReminders(GetCurrentWallpaperPath(), location.BottomLeft);
                }
                else if (radioButton5.Checked)
                {
                    RewriteImagewithReminders(GetCurrentWallpaperPath(), location.Centre);
                }

                MessageBox.Show("Information rendered on Wallpaper successfully.", "Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void RewriteImagewithReminders(string imagePath, location textLocation)
        {
            //Software creates temporary images in the Temp folder to write the text on that is of no use
            //after setting up the wallpaper, but we cannt delete these temporary images on the fly after the 
            //setting of the wallpaper as these are in use by some File objects hence we delete these temp images
            //at the startup.
            //====================================================================================================
            EmptyFolder(new DirectoryInfo("Temp"));
            EmptyFolder(new DirectoryInfo("CurrentWallpaper"));
            //====================================================================================================

            //Make a copy and use that copy for the operation
            FileInfo fInfo = new FileInfo(imagePath);
            string newFileName = "Temp\\" + fInfo.Name.Replace(fInfo.Extension, "") + "new" + fInfo.Extension;
            
            //Create a random name for the current wallpaper
            Random rnd = new Random();
            string newFileNameWallpaper = "CurrentWallpaper\\CurrentWallpaper" + rnd.Next(1000,2000).ToString() + fInfo.Extension;

            File.Copy(imagePath, newFileName, true);
            
            //Load the Image to be written on.
            Image imag = Image.FromFile(newFileName);
            Bitmap bitMapImage = new System.Drawing.Bitmap(imag);
            Graphics graphicImage = Graphics.FromImage(bitMapImage);

            //Smooth graphics is nice.
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;

            //Write your text from the xml file.
            DataSet dst = new DataSet();
            int yCoordinate = 0;
            
            //Setting up of the coordinates
            int xCoordinate = 0;
            
            if (textLocation == location.TopRight)
            {
                xCoordinate = 500;
                yCoordinate = 20;
            }
            else if (textLocation == location.TopLeft)
            {
                xCoordinate = 50;
                yCoordinate = 20;
            }
            else if (textLocation == location.BottomRight)
            {
                xCoordinate = 500;
                yCoordinate = 400;
            }
            else if (textLocation == location.BottomLeft)
            {
                xCoordinate = 50;
                yCoordinate = 400;
            }
            else if (textLocation == location.Centre)
            {
                xCoordinate = 300;
                yCoordinate = 250;
            }
            
            //writing the xml content on the image
            dst.ReadXml("Reminders.xml");
            for (int i = 0; i <= dst.Tables["Reminders"].Rows.Count - 1; i++)
            {
                graphicImage.DrawString(dst.Tables["Reminders"].Rows[i][0].ToString(), new Font("Tahoma", 8, FontStyle.Regular), SystemBrushes.ButtonFace, new Point(xCoordinate, yCoordinate));
                yCoordinate = yCoordinate + 15;
            }            

            SetImage("Wallpapers\\style.jpg"); //Setting up the temporary wallpaper
            bitMapImage.Save(newFileNameWallpaper, ImageFormat.Bmp);
            SetImage(newFileNameWallpaper); //Set up the Permanent wallpaper
            
            //Clean objects
            graphicImage.Dispose();
            bitMapImage.Dispose();
        }

        private void EmptyFolder(DirectoryInfo directoryInfo)
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (Exception)
                {                    
                }                
            }

            foreach (DirectoryInfo subfolder in directoryInfo.GetDirectories())
            {
                EmptyFolder(subfolder);
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictTopRight.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictTopRight.BorderStyle = BorderStyle.None;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictTopLeft.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictTopLeft.BorderStyle = BorderStyle.None;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                pictBottomLeft.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictBottomLeft.BorderStyle = BorderStyle.None;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictBottomRight.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictBottomRight.BorderStyle = BorderStyle.None;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                pictCenter.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictCenter.BorderStyle = BorderStyle.None;
            }
        }

        private void pictTopRight_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictTopLeft_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictBottomLeft_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void pictBottomRight_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictCenter_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }
    }
}
