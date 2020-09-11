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

        public App(V_PointDetailTest view)
        {
            _view = view;
            _controller = new IT_Detail_Controller(view);
            _view.Controller = _controller;
        }

        public App(V_IT_Vong1_Thi view)
        {
            _view = view;
            _controller = new IT_Vong1Thi_Controller(view);
            _view.Controller = _controller;
        }

        public App(V_IT_Start view)
        {
            _view = view;
            _controller = new IT_Start_Controller(view);
            _view.Controller = _controller;
        }
        public App(V_IT_Vong1_ChonDoi view)
        {
            _view = view;
            _controller = new IT_Vong1_ChonDoi_Controller(view);
            _view.Controller = _controller;
        }
        public App(V_IT_Vong2_NhapDiem view)
        {
            _view = view;
            _controller = new IT_Vong2NhapDiem_Controller(view);
            _view.Controller = _controller;
        }
        public App(V_IT_Vong3 view)
        {
            _view = view;
            _controller = new IT_Vong3_Controller(view);
            _view.Controller = _controller;
        }
        public App(V_IT_Vong3_Ready view)
        {
            _view = view;
            _controller = new IT_Vong3_GetReady_Controller(view);
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
            //Form form = new V_PointDetailTest();
            //form.ShowDialog();


            //App app = new App(new V_PointDetailTest());
            //app.Load();

            //App app = new App(new V_IT_Vong1_Thi());
            //app.Load();
        }
    }
}
