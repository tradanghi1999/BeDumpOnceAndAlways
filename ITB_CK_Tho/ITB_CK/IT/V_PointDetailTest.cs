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
using IT.Items;
namespace IT
{
    public partial class V_PointDetailTest : View
    {

        public V_PointDetailTest()
        {
            InitializeComponent();
            filter.FilterChanged += Filter_FilterChanged;
            flpItems.AutoScroll = true;
            flpItems.WrapContents = false;
        }

        private void Filter_FilterChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void V_PointDetailTest_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.WrapContents = false;
            //flowLayoutPanel1.AutoScroll = true;
            //ucQAheader head = new ucQAheader();
            //flowLayoutPanel1.Controls.Add(head);
            //ucQAfilter filt = new ucQAfilter();
            //flowLayoutPanel1.Controls.Add(filt);
            //for(int i = 1; i < 10; i++)
            //{
            //    ucQAdetail det = new ucQAdetail();
            //    det.Border = SystemColors.Control;
            //    flowLayoutPanel1.Controls.Add(det);
            //}
            if(_ctrl is IT_Detail_Controller)
            {
                IT_Detail_Controller myController = (IT_Detail_Controller)_ctrl;
                myController.LoadAllResultDetail();
            }
        }

        public void AddResultDetail(ucQAdetail detail)
        {
            flpItems.Controls.Add(detail);
        }
        public void ClearAllResultDetail()
        {
            flpItems.Controls.Clear();
        }
    }
}
