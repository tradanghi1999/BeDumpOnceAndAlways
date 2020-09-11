using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Show_App;

namespace Test
{
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
            //Application.Run(new CountDownTimer());
            //App app = new App();
            //app.Load();
            //ManualSetFullScreen frm = new ManualSetFullScreen();
            //frm.ShowDialog();
            //TimerAndShowDialog frm = new TimerAndShowDialog();
            //frm.ShowDialog();
            //CountDownTimer tmr = new CountDownTimer();
            //tmr.ShowDialog();
            //FormToJson frm = new FormToJson();
            //frm.ShowDialog();
            TestBase64String frm = new TestBase64String();
            frm.ShowDialog();
        }
    }
}
