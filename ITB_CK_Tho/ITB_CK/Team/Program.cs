using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team
{
    public class App
    {
        private Team_Controller _controller;
        private View _view;
        public App()
        {
            _view = new View();
            _controller = new Team_Controller(_view);
            _view.Controller = _controller;
            //

        }
        public App(View view)
        {
            _view = view;
            _controller = new Team_Controller(_view);
            _view.Controller = _controller;
        }
        //test
        public App(V_Vong1_Thi view)
        {
            _view = view;
            _controller = new Team_Vong1_Controller(_view);
            _view.Controller = _controller;
        }
        public App(V_Start v)
        {
            _view = v;
            _controller = new Team_Start_Controller(v);
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
        /// 
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new V_Start());
            //

            App app = new App(new V_Start());
            app.Load();
        }
    }
}
