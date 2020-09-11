using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointScreen
{
    public class BLL
    {
        
        public Model.Team GetTeam(string teamID)
        {
            int year = DateTime.UtcNow.Year;
            List<Model.Team> teams = (new DAL()).GetPoint(year);
            Model.Team myTeam = teams.Find(x => x.ID == teamID);
            return myTeam;
        }
    }
}
