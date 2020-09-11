using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;

namespace Test
{
    public static class Lib
    {
        public static String Rainbow(Int32 numOfSteps, Int32 step)
        {
            var r = 0.0;
            var g = 0.0;
            var b = 0.0;
            var h = (Double)step / numOfSteps;
            var i = (Int32)(h * 6);
            var f = h * 6.0 - i;
            var q = 1 - f;

            switch (i % 6)
            {
                case 0:
                    r = 1;
                    g = f;
                    b = 0;
                    break;
                case 1:
                    r = q;
                    g = 1;
                    b = 0;
                    break;
                case 2:
                    r = 0;
                    g = 1;
                    b = f;
                    break;
                case 3:
                    r = 0;
                    g = q;
                    b = 1;
                    break;
                case 4:
                    r = f;
                    g = 0;
                    b = 1;
                    break;
                case 5:
                    r = 1;
                    g = 0;
                    b = q;
                    break;
            }
            return "#" + ((Int32)(r * 255)).ToString("X2") + ((Int32)(g * 255)).ToString("X2") + ((Int32)(b * 255)).ToString("X2");
        }
        public static Color GetRainbowColor(float progress)
        {
            float div = (Math.Abs(progress % 1) * 6);
            int ascending = (int)((div % 1) * 255);
            int descending = 255 - ascending;

            switch ((int)div)
            {
                case 0:
                    return Color.FromArgb(255, 255, ascending, 0);
                case 1:
                    return Color.FromArgb(255, descending, 255, 0);
                case 2:
                    return Color.FromArgb(255, 0, 255, ascending);
                case 3:
                    return Color.FromArgb(255, 0, descending, 255);
                case 4:
                    return Color.FromArgb(255, ascending, 0, 255);
                default: // case 5:
                    return Color.FromArgb(255, 255, 0, descending);
            }
        }

        public static void GetColor(this Label lbl, double p)
        {
            lbl.ForeColor = GetColorFromPercentage(p);
        }
        private static Color GetColorFromPercentage(double p)
        {
            //int _count = 90;
            int _red = 51;
            int _green = 245;
            int _blue = 2;
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
    }
    
}
