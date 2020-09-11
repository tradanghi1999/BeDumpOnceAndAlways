using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using DatabaseHandle;

namespace Test
{
    public partial class TestBase64String : Form
    {
        public TestBase64String()
        {
            InitializeComponent();
        }

        private void TxbDuongDan_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if(opd.ShowDialog()== DialogResult.OK)
            {
                txbDuongDan.Text = opd.FileName;

                
            }
        }

        private void BtnGetFile_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(txbDuongDan.Text);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                rtbKQ.Text = base64ImageRepresentation;

                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64ImageRepresentation)));
                pictureBox1.Image = img;
            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void BtnGet1Question_Click(object sender, EventArgs e)
        {
            DatabaseHandle.Model.Question question = new DatabaseHandle.DAL.dbConnection().GetQuestion("2019100001");
            if (question == null)
                return;
            try
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(question.Image64String)));
                pictureBox2.Image = img;
            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
        }
    }
}
