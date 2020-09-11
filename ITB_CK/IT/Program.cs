using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT
{
    public class App
    {
        private IT_Controller _controller;
        private View _view;
        public App()
        {
            _view = new View();
            _controller = new IT_Controller(_view);
            _view.Controller = _controller;
            //

        }
        public App(View view)
        {
            _view = view;
            _controller = new IT_Controller(_view);
            _view.Controller = _controller;
        }
        public void Load()
        {
            _controller.LoadView();
        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            App app = new App(new V_IT_Start());
            app.Load();
        }
    }
}
