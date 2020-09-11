using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocCsharpConsole
{
    class Program
    {
        static Form frm;
        static Button btn = null;
        static void Main(string[] args)
        {
            MainVersion2();
            frm = new Form();
            btn = new Button();
            frm.Controls.Add(btn);
            frm.ShowDialog();   
        }

        async static void MainVersion2()
        {
            //
            DoTask1();
            //DoTask2();
            
        }

        async static void DoTask1()
        {
            await Task.Run(() => {

                int s = 0;

                for (int i = 0; i < 10000000; i++)
                {
                    s += i;
                }
                if(btn!=null)
                btn.Text = "Alo";
            });
        }

        async static void DoTask2()
        {
            await Task.Run(() => {
                frm.ShowDialog();
                frm.Hide();
            });
        }

        static void MainVersion1()
        {
            Form frm = new Form();
            Button btn = new Button();
            frm.Controls.Add(btn);

            Thread thread1 = new Thread(() =>
            {
                Console.WriteLine("...1");
                //frm = new Form();
                frm.ShowDialog();
                //Thread.Sleep(10000);

            });
            //
            thread1.Start();

            Thread thread2 = new Thread(() =>
            {
                frm.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        btn.Text = "ALO";
                    }
                    ));
                //frm.Hide();
                Console.WriteLine("...2");
            });
            //
            thread2.Start();
            Console.ReadLine();
        }
    }

    
}
