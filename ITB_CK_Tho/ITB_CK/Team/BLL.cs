using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DatabaseHandle.Model;

namespace Team
{
    public class BLL
    {
        public int CheckConnection()
        {
            DAL dAL = new DAL();
            dAL.CloseConnection();
            return 1;
        }

        internal Question GetNextQuestion(string teamId, string questionId)
        {
            //throw new NotImplementedException();
            Question nextQuestion = (new DAL()).GetNextQuestion(teamId, questionId);
            //nextQuestion.AnswerKey = "";
            return nextQuestion;
        }
        internal string GetTeamIdExaming()
        {
            //throw new NotImplementedException();
            return (new DAL()).GetTeamIdExaming();
        }

        internal bool TeamIsDone(string teamId)
        {
            return (new DAL()).TeamIsDone(teamId);
        }
    }
}
