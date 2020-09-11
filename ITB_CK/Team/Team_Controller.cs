using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;
namespace Team
{
    public class Team_Controller
    {
        private View _view;

        public Team_Controller(View view)
        {
            this._view = view;
        }

        internal void LoadView()
        {
            //throw new NotImplementedException();
            _view.ShowDialog();
        }
        internal void CheckConnection()
        {
            //throw new NotImplementedException();
            if ((new BLL()).CheckConnection() == 1)
                MessageBox.Show("Connection OK");
        }

    }
}
