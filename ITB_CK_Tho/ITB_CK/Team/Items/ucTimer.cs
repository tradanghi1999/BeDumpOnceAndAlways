using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team.Items
{
    public partial class ucTimer : UserControl
    {
        public event EventHandler TimerStopped;
        //public Color ProgressColor
        //{
        //    get
        //    {
        //       // return circularProgressBar1.InnerColor;
        //    }
        //    set
        //    {
        //      //  circularProgressBar1.InnerColor = value;
        //    }
        //}
        //public Color WholeColor
        //{
        //    get
        //    {
        //       // return circularProgressBar1.OuterColor;
        //    }
        //    set
        //    {
        //      //  circularProgressBar1.OuterColor = value;
        //    }
        //}
        //public Color BackGroundColor
        //{
        //    get
        //    {
        //       // return circularProgressBar1.BackColor;
        //    }
        //    set
        //    {
        //        //circularProgressBar1.BackColor = circularProgressBar1.InnerColor = value;
        //    }
        //}
        private int _count = 0;
        public void SetTimer(int i)
        {
            if (!(i > 0))
                return;
            _count = i;
            //circularProgressBar1.Value = i;
            //circularProgressBar1.Text = i + "";
        }
        public void StartTimer()
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
            int valueRoot = _count;
            //int valueAfter = circularProgressBar1.Value - 1;

            //if (valueAfter < 0)
            //{
            //    timer1.Stop();
            //    Invoke(TimerStopped);
            //    return;
            //}

            //circularProgressBar1.Value--;
            //circularProgressBar1.Text = valueAfter + "";
            //circularProgressBar1.ProgressColor = GetColorFromPercentage((valueRoot - valueAfter) * 1.0 / valueRoot);

        }

        //private int _count = 90;
        private int _red = 51;
        private int _green = 245;
        private int _blue = 2;
        private Color GetColorFromPercentage(double p)
        {
            if (!(p >= 0 && p <= 1))
            {
                return Color.Black;
            }
            int all = 49 + 4 * 243;
            if (p <= 49 * 1.0 / all)
            {
                _green = 245;
                _blue = 2;
                //
                double lg = (p * all);
                _red = 51 - (int)lg;

            }
            else if (p <= (49 + 243) * 1.0 / all)
            {
                _red = 2;
                _green = 245;
                _blue = 2 + ((int)(p * all) - 49);

            }
            else if (p <= (49 + 243 + 243) * 1.0 / all)
            {
                _red = 2;
                _blue = 245;
                _green = 245 - ((int)(p * all) - 49 - 243);
            }
            else if (p <= (49 + 243 * 3) * 1.0 / all)
            {
                _blue = 245;
                _green = 2;
                _red = 2 + ((int)(p * all) - 49 - 243 * 2);
            }
            else
            {
                _red = 245;
                _green = 2;
                _blue = 245 - ((int)(p * all) - 49 - 243 * 3);
            }
            return Color.FromArgb(_red, _green, _blue);
        }

        public ucTimer()
        {
            InitializeComponent();
            
        }
    }
}
