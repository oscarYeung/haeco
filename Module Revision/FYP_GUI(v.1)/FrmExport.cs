using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FYP_GUI_v.__
{
    public partial class FrmExport : Form
    {
        private Util.ListBoxItem[] m_items;
        public FrmExport(Util.ListBoxItem[] items)
        {
            InitializeComponent();
            m_items = items;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = txtPath.Text;
            fileDialog.Filter = "txt files (*.txt)|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
                btnEnter.PerformClick();

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            FileInfo t = new FileInfo(txtPath.Text);
            if (t.Exists || t.Directory.Exists)
            {
                StreamWriter Tex = t.CreateText();
                string strOutput = string.Empty;
                foreach (Util.ListBoxItem item in m_items)
                {
                    strOutput += item.GetExportString();
                }
                Tex.WriteLine(strOutput);
                Tex.Close();
                OpenFolder(t.DirectoryName);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fuck you directory is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void OpenFolder(string myDocspath)
        {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = myDocspath;
            prc.Start();
        }

        private void FrmExport_Load(object sender, EventArgs e)
        {
            txtPath.Text = Properties.Settings.Default.SaveFielDirectory;
        }

        private void FrmExport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["SaveFielDirectory"] = txtPath.Text ;
            Properties.Settings.Default.Save();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}