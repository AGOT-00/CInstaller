using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Windows.Forms;
using System.IO;

namespace CPPFormApp
{

    public partial class App : Form
    {

        HttpDownloader Downloader;
        public String Url = "https://github.com/AGOT-00/others/raw/master/Mingw.zip";

        public App()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (Downloader == null)
                {
                    Downloader = new HttpDownloader(Url, "./Mingw.zip");

                    Downloader.DownloadCompleted += Downloader_DownloadCompleted;
                    Downloader.ProgressChanged += Downloader_DownloadProgressChanged;

                    Downloader.Start();

                    Down.Text = "Downloading the required files.";
                }
                else
                {
                    Down.Text = "Already Downloading Kindly Wait.";
                }
            }
            catch(Exception en)
            {
                Down.Text = en.Message;
            }
            
        }

        private void Downloader_DownloadCompleted(object sender, EventArgs e)
        {
            if (Downloader != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Down.Text = "Downloading Completed.";
                    DownloadBar.Value = 100;
                }
           );
                this.extractzipfile();
            }
        }
        private void Downloader_DownloadProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            DownloadBar.Value = (int)e.Progress;
            DSpeed.Text = String.Format("{0} MB/sec", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
        }
        
        public void extractzipfile()
        {
            this.Invoke((MethodInvoker)delegate
            {
                Down.Text = "Downloading Completed.Unzipping the Zip Files.";
            }
            );
            try
            {
                ZipFile.ExtractToDirectory("./Mingw.zip", "./");
                this.Invoke((MethodInvoker)delegate
                {
                    Down.Text = "Unzipping Completed.";
                }
                );
            }
            catch (Exception e)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Down.Text = "Unzipping Error. MayBe Folder Already exists.";
                }
                );
            }

            string sourceDirName = @"./Mingw";
            string destDirName = @"C:\Mingw";
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Down.Text = "Moving Files to Required Directory.";
                }
                );

                Directory.Move(sourceDirName, destDirName);

                this.Invoke((MethodInvoker)delegate
                {
                    Down.Text = "Moving Files Completed.";
                }
                );
            }
            catch (IOException exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                var name = "PATH";
                var scope = EnvironmentVariableTarget.Machine;
                var oldValue = Environment.GetEnvironmentVariable(name, scope);

                var newValue = oldValue + ";" + destDirName + @"\bin\";
                Environment.SetEnvironmentVariable(name, newValue, scope);

                this.Invoke((MethodInvoker)delegate
                {
                    Down.Text = "Installation Completed.";
                }
               );
            }
            catch(Exception e)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Down.Text = "Error Occur While Setting Environment.";
                }
               );
            }
        }

        private void DownloadBar_Click(object sender, EventArgs e)
        {

        }
    }
}
