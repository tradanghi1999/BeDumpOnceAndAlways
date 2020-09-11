using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public class App
        {
            private LED_Controller _controller;
            private View _view;
            public App()
            {
                _view = new View();
                _controller = new LED_Controller(_view);
                _view.Controller = _controller;
                //

            }
            public App(View view)
            {
                _view = view;
                _controller = new LED_Controller(_view);
                _view.Controller = _controller;
            }
            public void Load()
            {
                _controller.LoadView();
            }

        }
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new V_Led_Vong1());
            App app = new App(new V_Start());
            app.Load();
        }
    }
}
