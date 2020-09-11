using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DatabaseHandle.Model;
using PointScreen;
using static PointScreen.Model;

namespace LED
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

        internal Question GetNextQuestion(string questionId)
        {
            //throw new NotImplementedException();
            Question nextQuestion = (new DAL()).GetNextQuestion(questionId);
            //nextQuestion.AnswerKey = "";
            return nextQuestion;
        }
        public List<Team> GetTeams()
        {
            return (new PointScreen.DAL()).GetPoint(DateTime.UtcNow.Year);
        }

        internal LED_Model.CommandGotten GetCommandFromIT()
        {
            //throw new NotImplementedException();
            return (new DAL()).GetCommandFromIT();
        }

        internal bool CheckVong3Ready()
        {
            return (new DAL()).CheckVong3Ready();
        }

        internal string GetVongDangThi()
        {
            //throw new NotImplementedException();
            return (new DAL()).GetVongDangThi();
        }
    }
}
