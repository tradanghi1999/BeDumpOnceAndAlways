using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseHandle.Controller;
//
using DatabaseHandle.DAL;

namespace DatabaseHandle.View
{
    public partial class V_ImportToDatabase : Form
    {
        public V_ImportToDatabase()
        {
            InitializeComponent();
            //
            var tbgTitle = (tabControl1 as TabControl).SelectedTab.Text;
            lblHeaderCon.Text = tbgTitle;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tbgTitle = (sender as TabControl).SelectedTab.Text;
            lblHeaderCon.Text = tbgTitle;
        }

        private void TxbPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog())
            {
                opd.Filter = "Excel Files(*.xls, *.xlsx, ...) | *.xlsx;*.xls | All files(*.*) | *.*";
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    txbPath.Text = opd.FileName;
                }
            }
            
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            DatabaseHandler_Ctrl.Result result = new DatabaseHandler_Ctrl().ImportExcelFile(txbPath.Text);
            MessageBox.Show("Get " + result.GottenQuestions.Count + "Questions and Not Get" + result.NotGottenQuestion.Count + " Questions");

            //
            dbConnection dbCon = new dbConnection();
            if (dbCon.InsertQuestions(result.GottenQuestions) == 1)
                MessageBox.Show("OK");
            else
                MessageBox.Show("Hay");
        }
    }
}
