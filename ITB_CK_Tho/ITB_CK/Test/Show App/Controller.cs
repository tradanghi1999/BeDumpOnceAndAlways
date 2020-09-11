using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Show_App
{
    public class Controller
    {
        private View _view;
        public Controller (View view)
        {
            _view = view;
        }

        internal void LoadView()
        {
            //throw new NotImplementedException();
            _view.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            _view.ShowDialog();
        }

        internal void OpenNew()
        {
            //throw new NotImplementedException();
            View preview = _view;
            preview.Controller = null;
            preview.Hide();
            preview.Close();

            _view = new View();
            _view.Controller = this;
            this.LoadView();

            

        }
    }
}
