using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyDirectory.Helpers;
using CopyDirectoryBLL;

namespace CopyDirectory
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            columnHeader.Width = -2;
        }

        private void Source_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Source.Text = fbd.SelectedPath;

                }
            }
        }

        private void Target_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Target.Text = fbd.SelectedPath;
                }
            }
        }

        private async void CopyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Source.Text) && !string.IsNullOrEmpty(Target.Text))
            {
                DirectoryInfo source = new DirectoryInfo(Source.Text);
                DirectoryInfo target = new DirectoryInfo(Target.Text);

                string result = "";
                CopyButton.Enabled = false;

                await Task.Run(() => CopyTask());
                void CopyTask()
                {
                    CopyFunctions copyFunc = new CopyFunctions();
                    copyFunc.FileUpdate += AddProgressToListView;
                    result = copyFunc.CopyDirectory(source, target);
                }
                ListViewItem lvi = new ListViewItem();

                if (result == "Success")
                {
                    lvi.Text = "Copying completed.";
                    LogsList.Items.Add(lvi);
                }
                else if (result == "Same directory")
                {
                    lvi.Text = "The directories chosen are the same.";
                    LogsList.Items.Add(lvi);
                }
                else if (result == "Error")
                {
                    lvi.Text = "There was an error.";
                    LogsList.Items.Add(lvi);
                }
            }
            else
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "Folder not chosen.";
                LogsList.Items.Add(lvi);
            }
            CopyButton.Enabled = true;
        }

        delegate void AddListViewItemCallback(string text);

        public void AddProgressToListView(string message)
        {
            ThreadHelper.AddViewItem(this,LogsList, message);
        }
    }
}
