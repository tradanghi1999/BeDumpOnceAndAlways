using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC
{
    public class App
    {
        private MC_Controller _controller;
        private View _view;
        public App()
        {
            _view = new View();
            _controller = new MC_Controller(_view);
            _view.Controller = _controller;
            //
           
        }
        public App(View view)
        {
            _view = view;
            _controller = new MC_Controller(_view);
            _view.Controller = _controller;
        }
        public App(V_Start view)
        {
            _view = view;
            _controller = new MC_Start_Controller(view);
            _view.Controller = _controller;
        }
        public App(V_MC_Vong1 view)
        {
            _view = view;
            _controller = new MC_Vong1_Controller(view);
            _view.Controller = _controller;
        }
        public App(V_MC_Vong3 view)
        {
            _view = view;
            _controller = new MC_Vong3_Controller(view);
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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ////
            //MC_Controller ctrl = new MC_Controller();
            //V_Start view = new V_Start(ctrl);

            //Application.Run(view);
            //Application.Run(new V_Vong1_PendingStart());
            App app = new App(new V_Start());
            app.Load();
        }
    }
}
