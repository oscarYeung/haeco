using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;

namespace FYP_GUI_v.__
{
    public partial class FrmMenu : Form
    {
        private DataTable m_dt;
        private string m_strFilePath = string.Empty;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnDlg = new OpenFileDialog();

            //if(File.Exists(@"C:\Documents and Settings\Administrator\My Documents\Module database\Module.mdb"))
            //    opnDlg.InitialDirectory = @"C:\Documents and Settings\Administrator\My Documents\Module database\Module.mdb";
            // select filter type
            opnDlg.Filter = "Database Files (*.mdb)|*.mdb|All Files (*.*)|*.*";
            if(Directory.Exists(txtPath.Text))
            opnDlg.FileName = txtPath.Text;
            
            if (opnDlg.ShowDialog(this) == DialogResult.OK)
            {
                // If file is in start folder remove path
                FileInfo f = new FileInfo(opnDlg.FileName);

                // use relative path if under application
                // starting directory
                if (f.DirectoryName == Application.StartupPath)
                    txtPath.Text = f.Name;  // only file name
                else if (f.DirectoryName.StartsWith(Application.StartupPath))
                    // relative path
                    txtPath.Text = f.FullName.Replace(Application.StartupPath, ".");
                else
                    txtPath.Text = f.FullName;  // Full path

                string filePath = f.FullName;
                m_strFilePath = filePath;
                LoadTablesName(filePath);
                InitListBox();
            }
        }


        private void LoadTablesName(string filePath)
        {

            try
            {
                //string connectionString =  "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath;
                //m_dt = new DataTable("Tables");
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = connection.CreateCommand();
                //    command.CommandText = "select table_name as Name from INFORMATION_SCHEMA.Tables where TABLE_TYPE = 'BASE TABLE'";
                //    connection.Open();
                //    m_dt.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
                //}


                // Microsoft Access provider factory
                DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

                m_dt = null;

                using (DbConnection connection = factory.CreateConnection())
                {
                    // c:\test\test.mdb
                    connection.ConnectionString =  "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath;
                    
                    // We only want user tables, not system tables
                    string[] restrictions = new string[4];
                    restrictions[3] = "Table";
                    
                    connection.Open();
                    
                    // Get list of user tables
                    m_dt = connection.GetSchema("Tables", restrictions);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Stack: " + ex.StackTrace);
            }
        
        }

        private void InitListBox()
        {
            listBox.Items.Clear();
            if (m_dt != null)
            {
                foreach (DataRow row in m_dt.Rows)
                {
                    listBox.Items.Add(row[2]);
                }  
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems == null || listBox.SelectedItems.Count != 1)
            {
                MessageBox.Show("Fuck you select only one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmMain frm = new FrmMain(listBox.SelectedItems[0].ToString(), m_strFilePath);
                frm.ShowDialog();
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            btnEnter.PerformClick();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtPath.Text = Properties.Settings.Default.DataBaseFileDirectory;
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["DataBaseFileDirectory"] = txtPath.Text;
            Properties.Settings.Default.Save();
        }
    }



}