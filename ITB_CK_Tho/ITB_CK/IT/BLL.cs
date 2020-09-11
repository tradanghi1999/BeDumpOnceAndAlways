using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using static PointScreen.Model;
using PointScreen;
using static IT.IT_Model;
using DatabaseHandle.Model;

namespace IT
{
    public class BLL
    {
        public int CheckConnection()
        {
            DAL dAL = new DAL();
            dAL.CloseConnection();
            return 1;
        }
        public int CheckAllHostConnection()
        {
            DAL dAL = new DAL();
            return dAL.CheckAllHostConnected();
        }

        public string MakeTeamsPending()
        {
            return (new DAL()).MakeTeamsPending();
        }
        public List<Team> GetTeams()
        {
            return (new PointScreen.DAL()).GetPoint(DateTime.UtcNow.Year);
        }

        public List<ResultDetail> GetAllResultDetails()
        {
            return (new IT.DAL()).GetAllResultDetail();
        }
        public List<ResultDetail> GetResultDetailsWithQuesId(string questionID)
        {
            return (new IT.DAL()).GetResultDetailsWithQuesId(questionID);
        }

        internal string GetTeamIdExaming()
        {
            //throw new NotImplementedException();
            return (new DAL()).GetTeamIdExaming();
        }

        internal Question GetNextQuestion(string teamId, string questionId)
        {
            //throw new NotImplementedException();
            Question nextQuestion = (new DAL()).GetNextQuestion(teamId,questionId);
            //nextQuestion.AnswerKey = "";
            return nextQuestion;
        }
        internal Question GetNextQuestion(string questionId)
        {
            Question nextQuestion = (new DAL()).GetNextQuestion(questionId);
            //nextQuestion.AnswerKey = "";
            if(nextQuestion!=null)
            {
                (new DAL()).SetAutoMode();
            }
            return nextQuestion;
        }

        internal string CheckTeamNumberOfRightAnswerRound1(string teamId)
        {
            return (new DAL()).CheckTeamNumberOfRightAnswerRound1(teamId);
        }

        internal void SetRight(string teamId, string quesId)
        {
            //throw new NotImplementedException();
            (new DAL()).InsertResultDetail(teamId, quesId, true);
        }

        internal void SetWrong(string teamId, string quesId)
        {
            //throw new NotImplementedException();
            (new DAL()).InsertResultDetail(teamId, quesId, false);
        }

        internal bool MakeExaming(string teamID)
        {
            //
            return (new DAL()).MakeExaming(teamID);
        }

        internal bool MakeTeamDone(string teamId)
        {
            return (new DAL()).MakeTeamDone(teamId);
            
        }

        internal bool InsertPointRound2(string teamId, int point)
        {
            //throw new NotImplementedException();
            return (new DAL()).InsertPointRound2(teamId, point);
        }

        internal Question GetPreQuestion(string questionId)
        {
            Question nextQuestion = (new DAL()).GetPreQuestion(questionId);
            //nextQuestion.AnswerKey = "";
            return nextQuestion;
        }

        internal void UpdateResultDetail(string quesionId, string teamIdDoiDauTienTraLoi, bool? doiDauTienState, string teamIdDoiDauThuHaiTraLoi, bool? doiThuHaiState)
        {
            //throw new NotImplementedException();
            if(teamIdDoiDauTienTraLoi == null)
            {
                (new DAL()).UpdateResultDetail(quesionId, "", doiDauTienState, "", doiThuHaiState);
            }
            else if(teamIdDoiDauTienTraLoi !=null && teamIdDoiDauThuHaiTraLoi == null)
            {
                //1 doi tra loi duy nhat
                (new DAL()).UpdateResultDetail(quesionId, teamIdDoiDauTienTraLoi, doiDauTienState, "", doiThuHaiState);
            }
            else
            {
                (new DAL()).UpdateResultDetail(quesionId, teamIdDoiDauTienTraLoi, doiDauTienState, teamIdDoiDauThuHaiTraLoi, doiThuHaiState);
            }
        }

        internal void ShowKey()
        {
            (new DAL()).ShowKey();
        }

        internal void MakeTeamRound3Ready()
        {
            (new DAL()).MakeTeamRound3Ready();
        }
    }
}
