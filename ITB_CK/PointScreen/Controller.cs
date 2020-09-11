using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;

namespace PointScreen
{
    public class PointScreenController: PointScreen.IV_PointScreen_Adapter, PointScreen.Model.ITeamAdapter
    {
        private Model.Team _preGottenTeam = null;
        
        public void GetAndUpdateTeam(V_PointScreen viewVong1)
        {
            BLL myBLL = new BLL();
            Model.Team team = myBLL.GetTeam();
            if(team!=null)
            {
                if(_preGottenTeam == null)
                {
                    viewVong1.Diem = team.Score;
                    viewVong1.TenDoi = team.Name;
                    //
                    _preGottenTeam = team;

                }
                else
                {
                    if(team.Score != _preGottenTeam.Score)
                    {
                        viewVong1.Diem = team.Score;
                        viewVong1.TenDoi = team.Name;
                    }
                    _preGottenTeam = team;
                }
            }
        }
    }
}
