using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using QuestionModel = DatabaseHandle.Model;
using TeamModel = PointScreen.Model;
using DAL = MC.DAL;
using DatabaseHandle.Model;
using PointScreen;

namespace MC
{
    public class BLL
    {
        public MC_Model.RightNowInfo GetRightNowInfo()
        {
            MC_Model.RightNowInfo rightNowInfo = new MC_Model.RightNowInfo();
            //int atRound = 0;
            int year = DateTime.UtcNow.Year;
            List<TeamModel.Team> teams = (new DAL()).GetTeamState(year);
            try
            {
                TeamModel.Team team;
                team = teams.FirstOrDefault(x => x.Round1State != "done");
                if (team != null)
                {
                    rightNowInfo.TeamsRightNow = new List<TeamModel.Team>();
                    rightNowInfo.TeamsRightNow.Add(team);
                    rightNowInfo.AtRound = 1;
                    return rightNowInfo;

                }
                //
                team = teams.FirstOrDefault(x => x.Round2State != "done");
                if (team != null)
                {
                    //rightNowInfo.TeamRightNow = team;
                    //rightNowInfo.AtRound = 2;
                    //return rightNowInfo;
                    throw new NotImplementedException();

                }
                //
                team = teams.FirstOrDefault(x => x.Round3State != "done");
                if (team != null)
                {
                    throw new NotImplementedException();

                }

            }
            catch
            {
                throw;
            }
            //
            
            //
            //
            return null;
        }

        internal string GetVongDangThi()
        {
            //throw new NotImplementedException();
            return (new DAL()).GetVongDangThi();
        }

        internal string GetTeamIdExaming()
        {
            return (new DAL()).GetTeamIdExaming();
        }

        internal Question GetNextQuestion(string teamId, string questionId)
        {
            //throw new NotImplementedException();
            Question nextQuestion = (new DAL()).GetNextQuestion(teamId, questionId);
            //nextQuestion.AnswerKey = "";
            return nextQuestion;
        }

        internal bool TeamIsDone(string teamId)
        {
            return (new DAL()).TeamIsDone(teamId);
        }

        internal List<TeamModel.Team> GetTeams()
        {
            //throw new NotImplementedException();
            return (new PointScreen.DAL()).GetPoint(DateTime.UtcNow.Year);
        }

        internal Question GetNextQuestion(string questionId)
        {
            // throw new NotImplementedException();
            Question nextQuestion = (new DAL()).GetNextQuestion(questionId);
            //nextQuestion.AnswerKey = "";
            //if (nextQuestion != null)
            //{
            //    (new DAL()).SetAutoMode();
            //}
            return nextQuestion;
        }
    }
}
