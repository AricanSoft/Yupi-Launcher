/*
void senyaz()
{
    string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "senyaz.txt";
    if (File.Exists(dosya_dizini) == true)
    {
    }
    else
    {

    }

}
*/




using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Net;

namespace Minecraft_Launcher
{
    public partial class Anaekran : Form
    {   

        public Anaekran()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void Dosya_Olustur()
        {
            string dosya_full_yol = Application.StartupPath + @"\config3.txt";
            if (File.Exists(dosya_full_yol) == false)
            {
                using (StreamWriter sw = File.CreateText(dosya_full_yol));
            }
            else
            {
                File.Delete(dosya_full_yol);
            }
        }

        void Dosya_Olustur2()
        {
            string dosya_full_yol = Application.StartupPath + @"\config2.txt";
            if (File.Exists(dosya_full_yol) == false)
            {
                using (StreamWriter sw = File.CreateText(dosya_full_yol));
            }
            else
            {
                File.Delete(dosya_full_yol);
            }
        }

        void logined()
        {
            guna2TextBox1.Visible = false;
            guna2Button2.Visible = false;
            guna2HtmlLabel1.Visible = false;
            label3.Text = guna2TextBox1.Text;
            label3.Visible = true;
            guna2Button1.Visible = true;
            guna2PictureBox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = true;
            guna2PictureBox5.Visible = true;
            guna2HtmlLabel2.Visible = false;
            guna2ComboBox2.Visible = true;
            guna2RadioButton1.Visible = false;
            guna2HtmlLabel8.Visible = false;
            guna2Button3.Visible = false;
            guna2HtmlLabel4.Visible = false;
            guna2HtmlLabel5.Visible = false;
            guna2RadioButton2.Visible = false;
        }

        void settingsopen()
        {
            guna2TextBox1.Visible = false;
            guna2Button2.Visible = false;
            guna2HtmlLabel1.Visible = false;
            label3.Text = guna2TextBox1.Text;
            label3.Visible = false;
            guna2Button1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2ProgressBar1.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2PictureBox1.Visible = false;
            guna2HtmlLabel2.Visible = true;
            RAMseç.Visible = true;
            guna2HtmlLabel3.Visible = true;
            guna2PictureBox4.Visible = true;
            guna2PictureBox5.Visible = true;
            guna2ComboBox2.Visible = false;
            guna2RadioButton1.Visible = true;
            guna2HtmlLabel8.Visible = true;
            guna2Button3.Visible = true;
            guna2HtmlLabel4.Visible = true;
            guna2HtmlLabel5.Visible = true;
            guna2RadioButton2.Visible = true;
        }

        void settingsclose()
        {
            RAMseç.Visible = false;
            guna2HtmlLabel2.Visible = false;
            guna2HtmlLabel3.Visible = false;
            guna2TextBox1.Visible = false;
            guna2Button2.Visible = false;
            guna2HtmlLabel1.Visible = false;
            label3.Text = guna2TextBox1.Text;
            label3.Visible = true;
            guna2Button1.Visible = true;
            guna2PictureBox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = true;
            guna2PictureBox4.Visible = false;
            guna2PictureBox5.Visible = true;
            guna2HtmlLabel2.Visible = false;
            guna2ComboBox2.Visible = true;
            guna2RadioButton1.Visible = false;
            guna2HtmlLabel8.Visible = false;
            guna2Button3.Visible = false;
            guna2HtmlLabel4.Visible = false;
            guna2HtmlLabel5.Visible = false;
            guna2RadioButton2.Visible = false;
        }

        async Task YupioyunaçAsync()
        {
            YupioyunaçMucosoftordefualtAsync();
        }

        async Task YupioyunaçMucosoftordefualtAsync()
        {
            string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config2.txt";
            if (File.Exists(dosya_dizini) == true)
            {
                var path = new MinecraftPath();
                var launcher = new CMLauncher(path);

                var ayar = new MLaunchOption()
                {
                    MaximumRamMb = int.Parse(RAMseç.Text),
                    Session = MSession.GetOfflineSession(label3.Text),

                };
                var process = await launcher.CreateProcessAsync("1.12.2-forge1.12.2-14.23.5.2859", ayar);
                process.Start();
            }
            else
            {
                YupioyunaçPerfMods();

            }
        }

        async Task YupioyunaçPerfMods()
        {
            string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "config3.txt";
            if (File.Exists(dosya_dizini) == true)
            {
                var path = new MinecraftPath();


                string kaynak = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/mods/OptiFine_1.16.5_HD_U_G8.jar";
                string hedef = path + @"/mods/OptiFine_1.16.5_HD_U_G8.jar";

                File.Copy(kaynak, hedef, true);

                string kaynak2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/mods/nofog-1.16.2-5-forge-b1.jar";
                string hedef2 = path + @"/mods/nofog-1.16.2-5-forge-b1.jar";

                File.Copy(kaynak2, hedef2, true);

                string kaynak3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/mods/FPS-Reducer-Mod-1.16.5.jar";
                string hedef3 = path + @"/mods/FPS-Reducer-Mod-1.16.5.jar";

                File.Copy(kaynak3, hedef3, true);

                string kaynak4 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/mods/chunk-animator-1.16.5-1.2.4.jar";
                string hedef4 = path + @"/mods/chunk-animator-1.16.5-1.2.4.jar";

                File.Copy(kaynak4, hedef4, true);

                string kaynak5 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/mods/Chunk+Pregenerator-V1.16-3.2.1.jar";
                string hedef5 = path + @"/mods/Chunk+Pregenerator-V1.16-3.2.1.jar";

                File.Copy(kaynak5, hedef5, true);

                string kaynak6 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/mods/canvas-mc116-1.0.1511.jar";
                string hedef6 = path + @"/mods/canvas-mc116-1.0.1511.jar";

                File.Copy(kaynak6, hedef6, true);

                string kaynak7 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/mods/ai-improvements-1.16.5-0.4.0.jar";
                string hedef7 = path + @"/mods/ai-improvements-1.16.5-0.4.0.jar";

                File.Copy(kaynak7, hedef7, true);

                var path1 = new MinecraftPath();
                var launcher = new CMLauncher(path1);

                var ayar = new MLaunchOption()
                {
                    MaximumRamMb = int.Parse(RAMseç.Text),
                    Session = MSession.GetOfflineSession(label3.Text),

                };
                var process = await launcher.CreateProcessAsync("1.16.5-forge-36.2.20", ayar);
                process.Start();

            }
            else
            {
                var path = new MinecraftPath();
                var launcher = new CMLauncher(path);

                var ayar = new MLaunchOption()
                {
                    MaximumRamMb = int.Parse(RAMseç.Text),
                    Session = MSession.GetOfflineSession(label3.Text),

                };
                var process = await launcher.CreateProcessAsync(guna2ComboBox2.Text, ayar);
                process.Start();
            }

        }


        private DiscordRPC.EventHandlers handlers;
        private DiscordRPC.RichPresence presence;
        void RPC()
        {
            this.handlers = default(DiscordRPC.EventHandlers);
            DiscordRPC.Initialize("954707439314427934", ref this.handlers, true, null);
            this.presence.details = "Gelmis gecmis en iyi launcher!";
            this.presence.state = "aricansoft.wordpress.com";
            this.presence.largeImageKey = "logo-yupiclient";
            this.presence.largeImageText = "Yupi Launcher";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRPC.UpdatePresence(ref this.presence);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            RPC();

            guna2HtmlLabel2.Visible = true;
            RAMseç.Visible = false;
            guna2ProgressBar1.Visible = false;
            guna2HtmlLabel3.Visible = false;
            guna2PictureBox4.Visible = false;
            guna2PictureBox5.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2HtmlLabel2.Visible = false;
            guna2ComboBox2.Visible = false;
            guna2RadioButton1.Visible = false;
            guna2HtmlLabel8.Visible = false;
            guna2Button3.Visible = false;
            guna2HtmlLabel4.Visible = false;
            guna2HtmlLabel5.Visible = false;
            guna2RadioButton2.Visible = false;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(guna2TextBox1.Text))
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz");
            }
            else
            {
                logined();
            }
        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Text = "Açılıyor";
            guna2Button1.Enabled = false;

            Thread thread = new Thread(() => Yupioyunac());
            thread.IsBackground = true;
            thread.Start();
        }

        async private void Yupioyunac()
        {
            YupioyunaçAsync();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            settingsopen();


        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            settingsclose();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Dosya_Olustur();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://rentry.co/yupi/raw").Contains("1.0"))
                {
                    if (MessageBox.Show("Güncelleme var! Şimdi indirilsin mi?", "Güncelleme (Powered by Sufibyte)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start("Güncelleme.exe");
                            this.Close();
                        }
                }
            }
            catch
            {

            }
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Dosya_Olustur2();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://aricansoft.wordpress.com/uygulamalarimiz-sufi");
        }
    }
}