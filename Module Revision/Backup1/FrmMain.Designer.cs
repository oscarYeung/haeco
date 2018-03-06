namespace FYP_GUI_v.__
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlQuestionNum = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.txtPageNum = new System.Windows.Forms.TextBox();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.RichTextBox();
            this.gbxQuestion = new System.Windows.Forms.GroupBox();
            this.gbxAnswer = new System.Windows.Forms.GroupBox();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.pbCorrect = new System.Windows.Forms.PictureBox();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.pnlQuestionList = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlQuestionNum.SuspendLayout();
            this.gbxQuestion.SuspendLayout();
            this.gbxAnswer.SuspendLayout();
            this.pnlAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect)).BeginInit();
            this.pnlQuestionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlQuestionNum
            // 
            this.pnlQuestionNum.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuestionNum.Controls.Add(this.btnGo);
            this.pnlQuestionNum.Controls.Add(this.lblQuestionNum);
            this.pnlQuestionNum.Controls.Add(this.txtPageNum);
            this.pnlQuestionNum.Controls.Add(this.lblPageNum);
            this.pnlQuestionNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestionNum.Location = new System.Drawing.Point(210, 0);
            this.pnlQuestionNum.Name = "pnlQuestionNum";
            this.pnlQuestionNum.Size = new System.Drawing.Size(572, 26);
            this.pnlQuestionNum.TabIndex = 36;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(154, 1);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(33, 24);
            this.btnGo.TabIndex = 41;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNum.Location = new System.Drawing.Point(3, 5);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(97, 16);
            this.lblQuestionNum.TabIndex = 40;
            this.lblQuestionNum.Text = "Go to question:";
            // 
            // txtPageNum
            // 
            this.txtPageNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageNum.Location = new System.Drawing.Point(110, 3);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(38, 21);
            this.txtPageNum.TabIndex = 39;
            this.txtPageNum.Text = "0";
            this.txtPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPageNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum.Location = new System.Drawing.Point(205, 5);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(0, 16);
            this.lblPageNum.TabIndex = 38;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestion.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbQuestion.Location = new System.Drawing.Point(3, 22);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(566, 116);
            this.tbQuestion.TabIndex = 20;
            this.tbQuestion.Text = "";
            // 
            // gbxQuestion
            // 
            this.gbxQuestion.BackColor = System.Drawing.Color.Transparent;
            this.gbxQuestion.Controls.Add(this.tbQuestion);
            this.gbxQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQuestion.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbxQuestion.Location = new System.Drawing.Point(210, 26);
            this.gbxQuestion.Name = "gbxQuestion";
            this.gbxQuestion.Size = new System.Drawing.Size(572, 141);
            this.gbxQuestion.TabIndex = 19;
            this.gbxQuestion.TabStop = false;
            this.gbxQuestion.Text = "Question";
            // 
            // gbxAnswer
            // 
            this.gbxAnswer.BackColor = System.Drawing.Color.Transparent;
            this.gbxAnswer.Controls.Add(this.pnlAnswer);
            this.gbxAnswer.Controls.Add(this.rbAnswer3);
            this.gbxAnswer.Controls.Add(this.rbAnswer2);
            this.gbxAnswer.Controls.Add(this.rbAnswer1);
            this.gbxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAnswer.Location = new System.Drawing.Point(210, 167);
            this.gbxAnswer.Name = "gbxAnswer";
            this.gbxAnswer.Size = new System.Drawing.Size(572, 523);
            this.gbxAnswer.TabIndex = 37;
            this.gbxAnswer.TabStop = false;
            this.gbxAnswer.Text = "Answer";
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAnswer.Controls.Add(this.pbCorrect);
            this.pnlAnswer.Controls.Add(this.btnResume);
            this.pnlAnswer.Controls.Add(this.btnClear);
            this.pnlAnswer.Controls.Add(this.btnExport);
            this.pnlAnswer.Controls.Add(this.btnRestore);
            this.pnlAnswer.Controls.Add(this.btnPrevious);
            this.pnlAnswer.Controls.Add(this.btnCheck);
            this.pnlAnswer.Controls.Add(this.btnNext);
            this.pnlAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnswer.Location = new System.Drawing.Point(3, 241);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(566, 279);
            this.pnlAnswer.TabIndex = 35;
            // 
            // pbCorrect
            // 
            this.pbCorrect.ErrorImage = global::FYP_GUI_v.__.Properties.Resources.cross;
            this.pbCorrect.Image = global::FYP_GUI_v.__.Properties.Resources.eror;
            this.pbCorrect.Location = new System.Drawing.Point(297, 40);
            this.pbCorrect.Name = "pbCorrect";
            this.pbCorrect.Size = new System.Drawing.Size(182, 146);
            this.pbCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCorrect.TabIndex = 49;
            this.pbCorrect.TabStop = false;
            // 
            // btnResume
            // 
            this.btnResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResume.BackgroundImage")));
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResume.Location = new System.Drawing.Point(139, 216);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(60, 60);
            this.btnResume.TabIndex = 48;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(369, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 30);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(469, 246);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 30);
            this.btnExport.TabIndex = 46;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.BackgroundImage")));
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.Location = new System.Drawing.Point(205, 216);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(60, 60);
            this.btnRestore.TabIndex = 45;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.Location = new System.Drawing.Point(7, 216);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 60);
            this.btnPrevious.TabIndex = 42;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = global::FYP_GUI_v.__.Properties.Resources.monster;
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.Location = new System.Drawing.Point(3, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(192, 208);
            this.btnCheck.TabIndex = 40;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.MouseLeave += new System.EventHandler(this.btnCheck_MouseLeave);
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCheck_MouseDown);
            this.btnCheck.MouseHover += new System.EventHandler(this.btnCheck_MouseHover);
            this.btnCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCheck_MouseUp);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.ImageList = this.imageList;
            this.btnNext.Location = new System.Drawing.Point(73, 216);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 41;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "back.jpg");
            this.imageList.Images.SetKeyName(1, "next.jpg");
            this.imageList.Images.SetKeyName(2, "Refresh.jpg");
            this.imageList.Images.SetKeyName(3, "Save.jpg");
            this.imageList.Images.SetKeyName(4, "vincent_icon.jpg");
            this.imageList.Images.SetKeyName(5, "vincent_icon_2.jpg");
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAnswer3.Location = new System.Drawing.Point(3, 170);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(566, 71);
            this.rbAnswer3.TabIndex = 34;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "rbAnswer3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAnswer2.Location = new System.Drawing.Point(3, 95);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(566, 75);
            this.rbAnswer2.TabIndex = 33;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "rbAnswer2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbAnswer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAnswer1.Location = new System.Drawing.Point(3, 22);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(566, 73);
            this.rbAnswer1.TabIndex = 32;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "rbAnswer1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // pnlQuestionList
            // 
            this.pnlQuestionList.Controls.Add(this.listBox1);
            this.pnlQuestionList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlQuestionList.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestionList.Name = "pnlQuestionList";
            this.pnlQuestionList.Size = new System.Drawing.Size(200, 690);
            this.pnlQuestionList.TabIndex = 36;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 688);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(200, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 690);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 690);
            this.Controls.Add(this.gbxAnswer);
            this.Controls.Add(this.gbxQuestion);
            this.Controls.Add(this.pnlQuestionNum);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlQuestionList);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.pnlQuestionNum.ResumeLayout(false);
            this.pnlQuestionNum.PerformLayout();
            this.gbxQuestion.ResumeLayout(false);
            this.gbxAnswer.ResumeLayout(false);
            this.pnlAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect)).EndInit();
            this.pnlQuestionList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlQuestionNum;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblQuestionNum;
        private System.Windows.Forms.TextBox txtPageNum;
        private System.Windows.Forms.Label lblPageNum;
        private System.Windows.Forms.RichTextBox tbQuestion;
        private System.Windows.Forms.GroupBox gbxQuestion;
        private System.Windows.Forms.GroupBox gbxAnswer;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlQuestionList;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pbCorrect;
    }
}

