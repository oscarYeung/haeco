using System;
using System.Collections.Generic;
using System.Text;

namespace FYP_GUI_v.__.Util
{
    public class ListBoxItem
    {
        private string m_strQuestionNumber;

        public string StrQuestionNumber
        {
            get { return m_strQuestionNumber; }
            set { m_strQuestionNumber = value; }
        }

        private string m_strQuestion;

        public string StrQuestion
        {
            get { return m_strQuestion; }
            set { m_strQuestion = value; }
        }

        private string m_strCorrectAnswer;

        public string StrCorrectAnswer
        {
            get { return m_strCorrectAnswer; }
            set { m_strCorrectAnswer = value; }
        }

        private string m_strWongAnswer1;

        public string StrWongAnswer1
        {
            get { return m_strWongAnswer1; }
            set { m_strWongAnswer1 = value; }
        }

        private string m_strWongAnswer2;

        public string StrWongAnswer2
        {
            get { return m_strWongAnswer2; }
            set { m_strWongAnswer2 = value; }
        }

        public ListBoxItem(string strQuestionNumber, string strQuestion, string strCorrectAnswer, string strWongAnswer1, string strWongAnswer2)
        {
            m_strQuestionNumber = strQuestionNumber;
            m_strQuestion = strQuestion;
            m_strWongAnswer1 = strWongAnswer1;
            m_strWongAnswer2 = strWongAnswer2;
            m_strCorrectAnswer = strCorrectAnswer;
        }

        public override string ToString()
        {
            return m_strQuestionNumber + "." +  m_strQuestion ;
        }

        public string GetExportString()
        {
            string strRtn = string.Empty;
            strRtn += m_strQuestionNumber + "," + m_strQuestion + "\r\n";
            strRtn += "Correct Answer: " +  m_strCorrectAnswer + "\r\n";
            strRtn += "Wong Answer 1: " + m_strWongAnswer1 + "\r\n";
            strRtn += "Wong Answer 2: " + m_strWongAnswer2 + "\r\n";
            strRtn += "´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯´¼»Ùª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯ª¯\r\n";
            return strRtn;
        }
    }
}
