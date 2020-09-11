using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using QuestionModel = DatabaseHandle.Model;
using TeamModel = PointScreen.Model;
//using Model = MC.MC_Model;
using static MC.MC_Model;
using System.Windows.Forms;

namespace MC
{
    public class MC_Controller
    {
        private RightNowInfo _info;
        private View _view;
        public MC_Controller(View view)
        {
            _view = view;
        }
        public void LoadView()
        {
            _view.ShowDialog();
        }
        internal void CheckOnStartUp()
        {
            _info = (new BLL()).GetRightNowInfo();
            int atRound = _info.AtRound;
            List<TeamModel.Team> teams = _info.TeamsRightNow;
            if(atRound == 1)
            {
                if (teams[0].Round1State == "examing")
                {
                    //throw new ApplicationException();
                    _view.Close();
                    MessageBox.Show("Vòng " +atRound +". \nKết nối trong khi có đội đang thi.\nTriển khai phương án dự phòng.", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (teams[0].Round1State == "yet")
                    return ;
                if(teams[0].Round1State =="pending")
                {
                    V_Vong1_PendingStart vV1Pending = new V_Vong1_PendingStart();
                    View preView = this._view;
                    //
                    vV1Pending.Controller = this;
                    this._view = vV1Pending;
                    //
                    preView.Close();

                    //vV1Pending.Show();
                    //vStart.Hide();
                    this._view.ShowDialog();
                    //
                    // vStart.tmr3dot.Stop();
                    //vStart.tmr3dot.Enabled = false;
                    //vStart.Hide();
                    return ;
                }
                throw new ApplicationException();
            }
            else if (atRound == 2)
            {
                return ;
            }
            else if(atRound ==3)
            {
                throw new NotImplementedException();
            }
            throw new InvalidOperationException();
            //throw new NotImplementedException();
        }

        internal void Check()
        {
            throw new NotImplementedException();
        }
    }
}
