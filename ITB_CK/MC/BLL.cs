using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using QuestionModel = DatabaseHandle.Model;
using TeamModel = PointScreen.Model;
using DAL = MC.DAL;


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

        
    }
}
