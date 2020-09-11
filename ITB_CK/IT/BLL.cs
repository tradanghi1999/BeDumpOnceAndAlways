using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using static PointScreen.Model;
using PointScreen;

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
        public bool CheckAllHostConnection()
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


    }
}
