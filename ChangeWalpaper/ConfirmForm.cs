using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeWalpaper
{
    public partial class ConfirmForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(
          uint action, uint uparam, StringBuilder vparam, uint winInt);

        const uint SPI_GETDESKWALLPAPER = 0x73;



        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(
           uint action, uint uparam, string vparam, uint winInt);

        public static readonly uint SPI_SETDESKWALLPAPER = 0x14;
        public static readonly uint SPIF_UPDATEINIFILE = 0x01;
        public static readonly uint SPIF_SENDCHANGE = 0x02;
        string _ImagePath;
        public ConfirmForm(string ImagePath)
        {
            InitializeComponent();

            _ImagePath = ImagePath;
        }
        private void ChangeWalpaper(string path)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
            MessageBox.Show("Wallpaper Changed Successfully!");
        }
        private void GetCurrentWallpaper()
        {
            StringBuilder sb = new StringBuilder(260); // MAX_PATH
            SystemParametersInfo(SPI_GETDESKWALLPAPER, (uint)sb.Capacity, sb, 0);
            string currentWallpaper = sb.ToString();

           pbCurrentWallpaper.ImageLocation = currentWallpaper.ToString();
        }
        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_ImagePath))
                return;

            GetCurrentWallpaper();
            pbNewWallpaper.ImageLocation = _ImagePath;
        }

        private void btnSetWallpaper_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to set this image as your wallpaper?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            ChangeWalpaper(_ImagePath);

            GetCurrentWallpaper();
            Thread.Sleep(4000);
            this.Close();
        }
    }
}
