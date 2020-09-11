using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Show_App
{
    public class App
    {
        private Controller _controller;
        private View _view;
        public App()
        {
            _view = new View();
            _controller = new Controller(_view);
            _view.Controller = _controller;
            //

        }
        public App(View view)
        {
            _view = view;
            _controller = new Controller(_view);
            _view.Controller = _controller;
        }
        public void Load()
        {
            _controller.LoadView();
        }
    }
}
