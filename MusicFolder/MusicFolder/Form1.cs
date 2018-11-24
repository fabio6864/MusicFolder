using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MusicFolder
{
    public partial class Form1 : Form
    {
        private List<songInfo> songsInfoList;

        public Form1()
        {
            InitializeComponent();
            Helper.RootFolder = txtRootFolder.Text;
            folderBrowserDialog.Description = "Select Folder where to save mp3 files";
        }

        private void btnSelectWinampPalylist_Click(object sender, EventArgs e)
        {
            if (fileList.ShowDialog() == DialogResult.OK)
            {
                txtPathFileList.Text = fileList.FileName;
                if (chkCreateSubFolder.Checked)
                {
                    string sExt = Path.GetExtension(fileList.FileName);
                    string sName = Path.GetFileName(fileList.FileName);
                    txtSubFolder.Text = sName.Replace(sExt, string.Empty);
                }
            }
        }

        private void btnOpenWinampPalylist_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(txtPathFileList.Text, Encoding.UTF8);
                foreach (string line in lines)
                {
                    if (!line.StartsWith("#"))
                    {
                        songInfo _songInfo = new songInfo(line);
                        lstFiles.Items.Add(_songInfo);
                        lstFiles.SetSelected(lstFiles.Items.Count - 1, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRootFolder_Leave(object sender, EventArgs e)
        {
            Helper.RootFolder = txtRootFolder.Text;
        }
        private void txtSubFolder_Leave(object sender, EventArgs e)
        {
            Helper.RootSubFolder = txtSubFolder.Text;
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 1;
                pBar.Value = 0;
                pBar.Maximum = lstFiles.SelectedItems.Count;

                string targetFolder = txtOutputFolder.Text;
                if (chkCreateSubFolder.Checked)
                {
                    targetFolder = Path.Combine(txtOutputFolder.Text, txtSubFolder.Text);
                }

                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                int iErrors = 0;
                foreach (var item in lstFiles.SelectedItems)
                {
                    songInfo song = (songInfo)item;
                    if (!copyToTarget(song, index, targetFolder))
                        iErrors++;

                    index++;
                    pBar.Value++;
                }
            }
            catch (System.IO.DirectoryNotFoundException dnfEx)
            {
                MessageBox.Show("Directory not found: " + dnfEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool copyToTarget(songInfo song, int index, string targetFolder)
        {
            bool bCopied = false;
            string targetFileName;
            try
            {
                if (chkPreserveFileOrder.Checked)
                {
                    string _fileName = index.ToString("000") + " " + song.FileName;
                    targetFileName = Path.Combine(targetFolder, _fileName);
                    index++;
                }
                else
                {
                    targetFileName = Path.Combine(targetFolder, song.FileName);
                }
                File.Copy(song.FullPath, targetFileName, true);
                bCopied = true;            
            }
            catch (Exception ex)
            {
                song.InError = ex.Message;
            }
            return bCopied;
        }        
    }


    public static class Helper
    {
        public static string RootFolder = string.Empty;
        public static string RootSubFolder = string.Empty;
    }

    sealed class songInfo
    {
        private string _path = string.Empty;
        public songInfo(string path)
        {
            _path = path;
            _fullPath = Path.Combine(Helper.RootFolder, _path);
        }

        private string _PartialPath = string.Empty;
        public string PartialPath
        {
            get { return _PartialPath; }
            set { _PartialPath = value; }
        }

        private string _fullPath = string.Empty;
        public string FullPath
        {
            get { return _fullPath; }
        }

        public string FileName
        {
            get { return getFileName(); }
        }

        public string InError { get; set; }

        private string getFileName()
        {
            return Path.GetFileName(_fullPath);
        }

        public override string ToString()
        {
            return _fullPath;
        }
    }
}
