using System;
using System.Collections.Generic;
using System.Text;

namespace FYP_GUI_v.__
{
    class Question
    {
        public string QuestionName;
        public string Answer1;
        public string Answer2;
        public string CorrectAnswer;
        public string DateOfUpdate;
        public string Explaination;

        public Question()
        {
            QuestionName = "";
            Answer1 = "";
            Answer2 = "";
            CorrectAnswer = "";
            DateOfUpdate = "";
            Explaination = "";
        }

        public string getQuestionName()
        {
            return QuestionName;
        }
        public string getAnswer1()
        {
            return Answer1;
        }
        public string getAnswer2()
        {
            return Answer2;
        }
        public string getCorrectAnswer()
        {
            return CorrectAnswer;
        }
        public string getDateOfUpdate()
        {
            return DateOfUpdate;
        }
        public string getExplaination()
        {
            return Explaination;
        }



        public void setQuestionName(string tempName)
        {
            QuestionName = tempName;
        }
        public void setAnswer1(string tempAnswer1)
        {
            Answer1 = tempAnswer1;
        }
        public void setAnswer2(string tempAnswer2)
        {
            Answer2 = tempAnswer2;
        }
        public void setCorrectAnswer(string tempCorrectAnswer)
        {
            CorrectAnswer = tempCorrectAnswer;
        }
        public void setDateOfUpdate(string tempDateOfUpdate)
        {
            DateOfUpdate = tempDateOfUpdate;
        }
        public void setExplaination(string tempExplaination)
        {
            Explaination = tempExplaination;
        }
    }
}
