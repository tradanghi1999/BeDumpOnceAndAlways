using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.IO;

namespace SuaLoiFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if(opd.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = opd.FileName;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string path="";
            if(textBox1.Text!=null)
            {
                path = textBox1.Text;
            }
            if(File.Exists(path))
            {
                StreamReader str = new StreamReader(path);
                if(File.Exists("E:\\home.html"))
                {
                    File.Delete("E:\\home.html");
                }
                StreamWriter strW = new StreamWriter("E:\\home.html", false, Encoding.UTF8);
                //

                char c;
                int dem = 0;
                while ((c = (char)str.Read()) != '\uffff')
                {
                    if(c==' ' && str.Peek() == ' ')
                    {
                        continue;
                    }
                    if (c=='<')
                    {
                        strW.WriteLine();
                        strW.Write(c);
                    }
                    else
                    {
                        strW.Write(c);
                    }
                    if (c == 'm' && str.Peek() == 'l')
                    {
                        dem++;
                        if(dem >= 2)
                        {
                            strW.Write("l");
                            strW.Write(">");
                            strW.Close();
                            str.Close();
                            return;
                        }
                        
                    }
                        
                }
            }
            MessageBox.Show("Error");

        }
    }
}
