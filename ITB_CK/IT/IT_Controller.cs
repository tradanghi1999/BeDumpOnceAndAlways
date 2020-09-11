using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//static IT.IT_Model;
using System.Windows.Forms;
using static PointScreen.Model;


namespace IT
{
    public class IT_Controller
    {
        private View _view;

        public IT_Controller(View view)
        {
            this._view = view;
        }

        internal void LoadView()
        {
            //throw new NotImplementedException();
            _view.ShowDialog();
        }

        internal void VoVong1()
        {
            //throw new NotImplementedException();
            if (!CheckAllHostConnected())
            {
                MessageBox.Show("Có máy chưa connected");
                return;
            }
            //throw new NotImplementedException();
            MessageBox.Show("OK");
            //
            View preView = this._view;
            preView.Close();
            //
            this._view = new V_IT_Vong1_ChonDoi();
            this._view.Controller = this;
            this._view.ShowDialog();
            //
            //this.
        }
        private bool CheckAllHostConnected()
        {
            return (new BLL()).CheckAllHostConnection();
        }

        internal void CheckConnection()
        {
            //throw new NotImplementedException();
            if ((new BLL()).CheckConnection() == 1)
                MessageBox.Show("Connection OK");
        }

        internal void MakeTeamsPending()
        {
            //throw new NotImplementedException();
            string teamIdGetPending = null;
            if((teamIdGetPending = (new BLL()).MakeTeamsPending()) != null)
            {
                MessageBox.Show(teamIdGetPending);
            }
            else
            {
                MessageBox.Show("All Done");
            }
        }

        internal void GetDoiThiVong1(string tenDoi1)
        {
            throw new NotImplementedException();
        }

        internal void GetTeams()
        {
            if (!(_view is V_IT_Vong1_ChonDoi))
                return;
            int year = DateTime.UtcNow.Year;
            List<Team> teams = (new BLL()).GetTeams();
            V_IT_Vong1_ChonDoi view = _view as V_IT_Vong1_ChonDoi;
            view.TenDoi1 = teams[0].Name;
            view.TenDoi2 = teams[1].Name;
            view.TenDoi3 = teams[2].Name;
        }
    }
}
