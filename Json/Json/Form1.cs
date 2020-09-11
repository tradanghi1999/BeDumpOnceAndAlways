using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Json
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Item> items = new List<Item>();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Item itm = new Item();
            itm.Id = txbId.Text;
            itm.Ten = txbTen.Text;
            itm.Gia = double.Parse(txbGia.Text);

            items.Add(itm);

            txbKetQua.Text = Newtonsoft.Json.JsonConvert.SerializeObject(items);
        }
    }
}
