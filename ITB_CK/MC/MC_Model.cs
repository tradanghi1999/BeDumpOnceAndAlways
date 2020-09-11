using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using QuestionModel = DatabaseHandle.Model;
using TeamModel = PointScreen.Model;

namespace MC
{
    public class MC_Model
    {
        public class RightNowInfo
        {
            public List<TeamModel.Team> TeamsRightNow { get; set; }
            public int AtRound { get; set; }
        }
    }
}
