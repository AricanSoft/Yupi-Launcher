using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace Güncelleme
{
    public partial class Güncelleme : Form
    {
        public Güncelleme()
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                File.Delete(@".\Yupi Launcher.exe");
                client.DownloadFile("https://github.com/AricanSoft/Yupi-Launcher/releases/download/Yupi-Launcher/Yupi_Launcher.zip", @"Yupi_Launcher.zip");
                string zipPath = @".\Yupi_Launcher.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\Yupi_Launcher.zip");
                Process.Start(@".\Yupi_Kurucu.exe");
                this.Close();
            }
            catch
            {
                Process.Start("Yupi Launcher.exe");
                this.Close();

            }

        }



    }
}
