using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class CountDownTimer : Form
    {
        
        public CountDownTimer()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            tmr90s.Enabled = true;
            tmr90s.Interval = 1000;
            tmr90s.Start();
        }

        private void Tmr90s_Tick(object sender, EventArgs e)
        {
            //if(_count == 0)
            //{
            //    tmr90s.Stop();
            //    return;
            //}
            //_count--;
            //lblTime.Text = _count + "";
            //lblTime.GetColor(((90-_count)*1.0/90));
        }

        //private Color GetColorFromPercentage(double p)
        //{
        //    if(!(p >= 0 && p <= 1))
        //    {
        //        return Color.Black;
        //    }
        //    int all = 49 + 4 * 243;
        //    if(p <= 49*1.0/all)
        //    {
        //        _green = 245;
        //        _blue = 2;
        //        //
        //        double lg = (p * all);
        //        _red = 51 - (int)lg;
                
        //    }
        //    else if (p <= (49+243)*1.0/all)
        //    {
        //        _red = 2;
        //        _green = 245;
        //        _blue = 2 + ((int)(p * all) - 49) ;

        //    }
        //    else if(p <= (49+243+243)*1.0/all)
        //    {
        //        _red = 2;
        //        _blue = 245;
        //        _green = 245 -((int)(p * all) - 49 - 243);
        //    }
        //    else if (p <= (49 + 243 * 3) *1.0/ all)
        //    {
        //        _blue = 245;
        //        _green = 2;
        //        _red = 2 + ((int)(p * all) - 49 - 243 * 2);
        //    }
        //    else
        //    {
        //        _red = 245;
        //        _green = 2;
        //        _blue = 245 - ((int)(p * all) - 49 - 243 * 3);
        //    }
        //    return Color.FromArgb(_red, _green, _blue);
        //}
    }
}
