using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Ookii.Dialogs.WinForms;
using Directory = System.IO.Directory;
using DirectoryInfo = Alphaleonis.Win32.Filesystem.DirectoryInfo;
using FileInfo = Alphaleonis.Win32.Filesystem.FileInfo;

namespace XmlFilesChecker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bFolder_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog browserDialog = new VistaFolderBrowserDialog();
            browserDialog.ShowNewFolderButton = false;
            if (browserDialog.ShowDialog()==DialogResult.OK)
            {
                tbRootFolder.Text = browserDialog.SelectedPath;
            }
        }

        private void listViewFiles_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            FileCheck fileCheck = (FileCheck)e.Model;
            if (!fileCheck.IsGood)
                e.Item.ForeColor = Color.Red;
        }

        private List<FileCheck> _fileCheckList;

        private async void bStart_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbRootFolder.Text))
            {
                _fileCheckList = new List<FileCheck>();
                listViewFiles.Items.Clear();
                bFolder.Enabled = false;
                bStart.Enabled = false;
                progressBar.Visible = true;
                bCopyBroken.Enabled = false;
                bCopyAll.Enabled = false;
                bOpenFolder.Enabled = false;
                chbOnlyBroken.Enabled = false;
                progressBar.Value = 0;
                try
                {
                    _fileCheckList = await CheckFiles();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.ToString());
                }
                FillListView(false);
                bFolder.Enabled = true;
                bStart.Enabled = true;
                progressBar.Visible = false;
                bCopyBroken.Enabled = true;
                bCopyAll.Enabled = true;
                chbOnlyBroken.Enabled = true;
                if (_fileCheckList.All(x => x.IsGood))
                {
                    MessageBox.Show("All files is normal!");
                }
            }
        }

        private Task<List<FileCheck>> CheckFiles()
        {
            return Task.Run(() =>
            {
                List<FileCheck> fileCheckList = new List<FileCheck>();
                DirectoryInfo directoryInfo = new DirectoryInfo(tbRootFolder.Text);
                var files = directoryInfo.EnumerateFiles("*.xml", SearchOption.AllDirectories).ToList();
                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Data", typeof(string));
                this.Invoke(new Action(() => progressBar.Maximum = files.Count()));
                int count = 0;
                foreach (FileInfo file in files)
                {
                    this.Invoke(new Action(() => progressBar.Value=count));
                    if (!file.Exists)
                    {
                        count++;
                        continue;
                    }
                    FileCheck fileCheck = new FileCheck();
                    fileCheck.FileInfo = file;
                    fileCheck.IsGood = true;
                    try
                    {
                        XDocument xd1 = new XDocument();
                        xd1 = XDocument.Load(file.FullName);
                    }
                    catch (XmlException)
                    {
                        fileCheck.IsGood = false;
                    }
                    fileCheckList.Add(fileCheck);
                    count++;
                }
                return fileCheckList;
            });
        }


        private void chbOnlyBroken_CheckedChanged(object sender, EventArgs e)
        {
            if (_fileCheckList != null)
            {
                if (chbOnlyBroken.Checked)
                {
                    FillListView(true);
                }
                else
                {
                    FillListView(false);
                }
            }
        }

        private void FillListView(bool onlyBroken)
        {
            listViewFiles.ClearObjects();
            if (onlyBroken)
            {
                listViewFiles.SetObjects(_fileCheckList.Where(x=>!x.IsGood));
            }
            else
            {
                listViewFiles.SetObjects(_fileCheckList);
            }
        }

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                bOpenFolder.Enabled = true;
            }
        }

        private void bOpenFolder_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedObject is FileCheck file)
            {
                string argument = "/select, \"" + file.ToString() + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
        }

        private void bCopyAll_Click(object sender, EventArgs e)
        {
            string combindedString = string.Join(Environment.NewLine, _fileCheckList.Select(x=>x.ToString()).ToArray());
            if (!string.IsNullOrEmpty(combindedString))
            {
                Clipboard.SetText(combindedString);
            }
            
        }

        private void bCopyBroken_Click(object sender, EventArgs e)
        {
            string combindedString = string.Join(Environment.NewLine, _fileCheckList.Where(x=>!x.IsGood).Select(x => x.ToString()).ToArray());
            if (!string.IsNullOrEmpty(combindedString))
            {
                Clipboard.SetText(combindedString);
            }
        }

        class FileCheck
        {
            public FileInfo FileInfo { get; set; }
            public bool IsGood { get; set; }
            public string FullPath => FileInfo.FullName;
            public string FileName => FileInfo.Name;
            public DateTime ModifyDate => FileInfo.LastWriteTime;
            public DateTime CreateDate => FileInfo.CreationTime;
            public override string ToString()
            {
                return FileInfo.FullName;
            }
        }

        
    }
}
