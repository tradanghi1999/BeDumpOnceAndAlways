using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED
{
    public class App
    {
        private LED_Controller _controller;
        private View _view;
        //public App()
        //{
        //    _view = new View();
        //    _controller = new LED_Controller(_view);
        //    _view.Controller = _controller;
        //    //

        //}
        //public App(View view)
        //{
        //    _view = view;
        //    _controller = new LED_Controller(_view);
        //    _view.Controller = _controller;
        //}
        public App(V_LED_Vong3 view)
        {
            _view = view;
            _controller = new LED_Vong3_Controller(_view);
            _view.Controller = _controller;
        }
        public App(V_Led_Vong1 view)
        {
            _view = view;
            _controller = new LED_Vong1_Controller(_view);
            _view.Controller = _controller;
        }
        public App(V_Start v)
        {
            _view = v;
            _controller = new LED_Start_Controller(v);
            _view.Controller = _controller;
        }

        public App(V_LED_HienDiem v)
        {
            _view = v;
            _controller = new LED_HienDiem_Controller(v);
            _view.Controller = _controller;
        }
        public void Load()
        {
            _controller.LoadView();
        }
        public void Load(Form frmParent)
        {
            _controller.LoadView(frmParent);
            
            
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
            //Application.Run(new V_Led_Vong1());
            //App app = new App(new V_Start());
            //app.Load(null);
            //View view = new V_Led_Vong1();
            //view.ShowDialog();
            App app = new App(new V_LED_HienDiem());
            app.Load(null);
        }
    }
}
