using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.IO;
using System.Data.OleDb;


namespace FYP_GUI_v.__
{
    public partial class FrmMain : Form
    {
        int timer_variable = 0;             // used for timer 1 
        int form_width = 293;               // default width of the Form 1.cs
        int pointernumber = 0;
        int TotalNumber = 0;
        DataTable mytable;
        int CorrectRadio = 0;
        int RadioState = 0;
        string filePath = "";
        
        private const string strPageNum = "{0} of {1}";
        private string strTotalPage;

        public FrmMain(string strTableName, string strPath)
        {
           
            InitializeComponent();
           // CheckUser();
            filePath = strPath;
            pbCorrect.Image = null;
            CheckTotalQuestion(strTableName);

            this.Text = strTableName;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_variable++;


            if (form_width < 615)
            {
                form_width = form_width + 10;
                this.Size = new System.Drawing.Size(form_width, 342);
                 

                /*if (form_width > 615)
                {
                    timer1.Enabled = false;
                    timer_variable = 0;
                }*/
            }
             if (form_width > 615)
            {
                timer1.Enabled = false;
                timer_variable = 0;
            }
            

        }


        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }



        private void GenerateQuestion(int nQuestionNumber)
        {
            if (filePath == "")
            {
                //lblIsCorrect.Text = "Error!";
                pbCorrect.Image = Properties.Resources.eror; ;
            }
            else
            {
                pbCorrect.Image = null;
                RadioState = 0;

                Random random = new Random();
                int num = random.Next(7);

                if (nQuestionNumber <= TotalNumber)
                {
                    switch (num)
                    {
                        case 0:
                            ThirdChoice(nQuestionNumber);
                            break;
                        case 1:
                            FirstChoice(nQuestionNumber);
                            break;
                        case 2:
                            SecondChoice(nQuestionNumber);
                            break;
                        case 3:
                            ThirdChoice(nQuestionNumber);
                            break;
                        case 4:
                            FourChoice(nQuestionNumber);
                            break;
                        case 5:
                            FiveChoice(nQuestionNumber);
                            break;
                        case 6:
                            SixChoice(nQuestionNumber);
                            break;
                        default:
                            Console.WriteLine("Error occur!!");
                            break;
                    }
                    lblPageNum.Text = string.Format(strPageNum, nQuestionNumber.ToString(), strTotalPage);
                }
                else
                {
                    nQuestionNumber = 0;
                }
            }


        }




        private void FirstChoice(int nQuestionNumber)
        {
            object temp_Question = mytable.Rows[nQuestionNumber]["Question"];
            object temp_Answer1 = mytable.Rows[nQuestionNumber]["Answer1"];
            object temp_Answer2 = mytable.Rows[nQuestionNumber]["Answer2"];
            object temp_Answer3 = mytable.Rows[nQuestionNumber]["CorrectAnswer"];
            tbQuestion.Text = Convert.ToString(temp_Question);
            rbAnswer1.Text = Convert.ToString(temp_Answer1);
            rbAnswer2.Text = Convert.ToString(temp_Answer2);
            rbAnswer3.Text = Convert.ToString(temp_Answer3);
            CorrectRadio = 3;
        }
        private void SecondChoice(int nQuestionNumber)
        {
            object temp_Question = mytable.Rows[nQuestionNumber]["Question"];
            object temp_Answer1 = mytable.Rows[nQuestionNumber]["Answer1"];
            object temp_Answer2 = mytable.Rows[nQuestionNumber]["Answer2"];
            object temp_Answer3 = mytable.Rows[nQuestionNumber]["CorrectAnswer"];
            tbQuestion.Text = Convert.ToString(temp_Question);
            rbAnswer1.Text = Convert.ToString(temp_Answer1);
            rbAnswer2.Text = Convert.ToString(temp_Answer3);
            rbAnswer3.Text = Convert.ToString(temp_Answer2);
            CorrectRadio = 2;

        }
        private void ThirdChoice(int nQuestionNumber)
        {
            object temp_Question = mytable.Rows[nQuestionNumber]["Question"];
            object temp_Answer1 = mytable.Rows[nQuestionNumber]["Answer1"];
            object temp_Answer2 = mytable.Rows[nQuestionNumber]["Answer2"];
            object temp_Answer3 = mytable.Rows[nQuestionNumber]["CorrectAnswer"];
            tbQuestion.Text = Convert.ToString(temp_Question);
            rbAnswer1.Text = Convert.ToString(temp_Answer2);
            rbAnswer2.Text = Convert.ToString(temp_Answer1);
            rbAnswer3.Text = Convert.ToString(temp_Answer3);
            CorrectRadio = 3;
            
        }
        private void FourChoice(int nQuestionNumber)
        {
            object temp_Question = mytable.Rows[nQuestionNumber]["Question"];
            object temp_Answer1 = mytable.Rows[nQuestionNumber]["Answer1"];
            object temp_Answer2 = mytable.Rows[nQuestionNumber]["Answer2"];
            object temp_Answer3 = mytable.Rows[nQuestionNumber]["CorrectAnswer"];
            tbQuestion.Text = Convert.ToString(temp_Question);
            rbAnswer1.Text = Convert.ToString(temp_Answer2);
            rbAnswer2.Text = Convert.ToString(temp_Answer3);
            rbAnswer3.Text = Convert.ToString(temp_Answer1);
            CorrectRadio = 2;

        }
        private void FiveChoice(int nQuestionNumber)
        {
            object temp_Question = mytable.Rows[nQuestionNumber]["Question"];
            object temp_Answer1 = mytable.Rows[nQuestionNumber]["Answer1"];
            object temp_Answer2 = mytable.Rows[nQuestionNumber]["Answer2"];
            object temp_Answer3 = mytable.Rows[nQuestionNumber]["CorrectAnswer"];
            tbQuestion.Text = Convert.ToString(temp_Question);
            rbAnswer1.Text = Convert.ToString(temp_Answer3);
            rbAnswer2.Text = Convert.ToString(temp_Answer1);
            rbAnswer3.Text = Convert.ToString(temp_Answer2);
            CorrectRadio = 1;
 
        }
        private void SixChoice(int nQuestionNumber)
        {
            object temp_Question = mytable.Rows[nQuestionNumber]["Question"];
            object temp_Answer1 = mytable.Rows[nQuestionNumber]["Answer1"];
            object temp_Answer2 = mytable.Rows[nQuestionNumber]["Answer2"];
            object temp_Answer3 = mytable.Rows[nQuestionNumber]["CorrectAnswer"];
            tbQuestion.Text = Convert.ToString(temp_Question);
            rbAnswer1.Text = Convert.ToString(temp_Answer3);
            rbAnswer2.Text = Convert.ToString(temp_Answer2);
            rbAnswer3.Text = Convert.ToString(temp_Answer1);
            CorrectRadio = 1;
 
        }

        private void GetAnswers(int nQuestionNumber, out string strQuestion, out string strCorrectAnswer, out string strWongAnswer1, out string strWongAnswer2)
        {
            strQuestion = mytable.Rows[nQuestionNumber]["Question"].ToString();
            strWongAnswer1 = mytable.Rows[nQuestionNumber]["Answer1"].ToString();
            strWongAnswer2 = mytable.Rows[nQuestionNumber]["Answer2"].ToString();
            strCorrectAnswer = mytable.Rows[nQuestionNumber]["CorrectAnswer"].ToString();
        }

        private void CheckRadio()
        {
            if (rbAnswer1.Checked == true)
            {
                RadioState = 1;
            }
            else if (rbAnswer2.Checked == true)
            {
                RadioState = 2;
            }
            else if (rbAnswer3.Checked == true)
            {
                RadioState = 3;
            }
            else
            {
                RadioState = 4;
            }

            if (RadioState == CorrectRadio)
            {
                //lblIsCorrect.Text = "Correct";
                pbCorrect.Image = Properties.Resources.tick;
            }
            else
            {
                //lblIsCorrect.Text = "Wrong";
                pbCorrect.Image = Properties.Resources.cross;
            }
           
        }
            


        private void CheckTotalQuestion(string strTableName)
        {

            string strAccessConn = "Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + filePath;

            string strAccessSelect = "Select * From " + strTableName;

            DataSet myDataSet = new DataSet();
            OleDbConnection myAccessConn = null;
            try
            {

                myAccessConn = new OleDbConnection(strAccessConn);
         
                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);
                myAccessConn.Open();
                myDataAdapter.Fill(myDataSet, strTableName);
     
                mytable = myDataSet.Tables[0];

                TotalNumber = mytable.Rows.Count - 1;

                strTotalPage = TotalNumber.ToString();

                if(mytable.Rows.Count > 0)
                {
                    int nPageNumber = 0;
                    txtPageNum.Text = nPageNumber.ToString();
                    btnGo_Click(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Stack: " + ex.StackTrace);
            }
            finally
            {
                myAccessConn.Close();
            }
        }

       

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                //lblIsCorrect.Text = "Error!";
                pbCorrect.Image = Properties.Resources.eror;
            }
            else
            {
                CheckRadio();
                int temp_number = pointernumber;
                object temp_Answer3 = mytable.Rows[temp_number]["CorrectAnswer"];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pointernumber + 1 <= TotalNumber)
            {
                pointernumber++;
                GenerateQuestion(pointernumber);
            }
              
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                //lblIsCorrect.Text = "Error!";
                pbCorrect.Image = Properties.Resources.eror;
            }
            else
            {
                if (pointernumber == 1 || pointernumber == 0)
                {
                    pointernumber = 0;
                    GenerateQuestion(pointernumber);
                }
                else  if (pointernumber -1  >= 0)
                {

                    pointernumber = pointernumber - 1;
                    GenerateQuestion(pointernumber);
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPageNum.Text == "")
                {
                    //lblIsCorrect.Text = "Error!";
                    pbCorrect.Image = Properties.Resources.eror;
                }
                else
                {
                    pointernumber = Convert.ToInt16(txtPageNum.Text);
                    if (pointernumber > TotalNumber)
                        throw new Exception();
                    else
                    {
                        GenerateQuestion(pointernumber);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fuck you, your input number is invalid", "Kick Ass Adrian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Width = Properties.Settings.Default.FormWidth;
            this.Height = Properties.Settings.Default.FormHeight;
            this.Top = Properties.Settings.Default.FormTop;
            this.Height = Properties.Settings.Default.FormHeight;
            this.splitter2.SplitPosition = Properties.Settings.Default.SplitterPos;

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["FormWidth"] = this.Width;
            Properties.Settings.Default["FormHeight"] = this.Height;
            Properties.Settings.Default["FormTop"] = this.Top;
            Properties.Settings.Default["FormHeight"] = this.Height;
            Properties.Settings.Default["SplitterPos"] = this.splitter2.SplitPosition;
            Properties.Settings.Default.Save();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            if (!CheckItemExist(pointernumber.ToString()))
            {
                int nQuestionNumber = pointernumber;
                string strQuestion;
                string strWongAnswer1;
                string strWongAnswer2;
                string strCorrectAnswer;
                GetAnswers(nQuestionNumber, out strQuestion, out strCorrectAnswer, out strWongAnswer1, out strWongAnswer2);
                Util.ListBoxItem item = new Util.ListBoxItem(pointernumber.ToString(), strQuestion, strCorrectAnswer, strWongAnswer1, strWongAnswer2);

                listBox1.Items.Add(item);
            }
        }

        private bool CheckItemExist(string strKey)
        {
            foreach (Util.ListBoxItem item in listBox1.Items)
            {
                if (item.StrQuestionNumber == strKey)
                    return true;

            }
            return false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<Util.ListBoxItem> itemList = new List<FYP_GUI_v.__.Util.ListBoxItem>();
            foreach (Util.ListBoxItem item in listBox1.Items)
                itemList.Add(item);
            FrmExport frmexport = new FrmExport(itemList.ToArray());
            frmexport.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                Util.ListBoxItem item = (Util.ListBoxItem)listBox1.SelectedItem;
                GenerateQuestion(Convert.ToInt16(item.StrQuestionNumber));
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            GenerateQuestion(pointernumber);
        }

        private void btnCheck_MouseDown(object sender, MouseEventArgs e)
        {
            btnCheck.BackgroundImage = Properties.Resources.vincent_icon_2;
        }

        private void btnCheck_MouseUp(object sender, MouseEventArgs e)
        {
           // btnCheck.BackgroundImage = Properties.Resources.monster;
        }

        private void btnCheck_MouseHover(object sender, EventArgs e)
        {
            btnCheck.BackgroundImage = Properties.Resources.vincent_icon;
        }

        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            btnCheck.BackgroundImage = Properties.Resources.monster;
        }

 




 
        
    }
}