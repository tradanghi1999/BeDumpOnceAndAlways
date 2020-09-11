using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT.Items
{
    public partial class ucQAfilter : UserControl
    {
        public void SetTeamFilter(string[] teams)
        {
            cbxTeam.Items.Clear();
            cbxTeam.Items.Add("(All)");
            cbxTeam.Items.Add(teams);
        }
        public void SetVongFilter(string[] vongs)
        {
            cbxVong.Items.Clear();
            cbxVong.Items.Add("(All)");
            cbxVong.Items.Add(vongs);
        }
        public void SetDiemFilter(string[] diems)
        {
            cbxDiem.Items.Clear();
            cbxDiem.Items.Add("(All)");
            cbxDiem.Items.Add(diems);
        }
        public void SetSTTfilter(string [] stts)
        {
            cbxSTT.Items.Clear();
            cbxSTT.Items.Add("(All)");
            cbxSTT.Items.Add(stts);
        }
        public void SetStatus()
        {
            cbxStatus.Items.Clear();
            cbxStatus.Items.Add("(All)");
            cbxStatus.Items.Add("Đúng");
            cbxStatus.Items.Add("Sai");
        }

        public string TeamSelected
        {
            get
            {
                return cbxTeam.SelectedText;
            }
        }

        public string VongSelected
        {
            get
            {
                return cbxVong.SelectedText;
            }
        }

        public string SttSelected
        {
            get
            {
                return cbxSTT.SelectedText;
            }
        }
        public string DiemSelected
        {
            get
            {
                return cbxDiem.SelectedText;
            }
        }

        public string StatusSelected
        {
            get
            {
                return cbxStatus.SelectedText;
            }
        }
        
        public event EventHandler FilterChanged;
        public ucQAfilter()
        {
            InitializeComponent();
            cbxTeam.Text = cbxVong.Text = cbxSTT.Text=cbxDiem.Text=cbxStatus.Text="(All)";
            SetStatus();

            cbxTeam.SelectedValueChanged += ChangeValue;
            cbxVong.SelectedValueChanged += ChangeValue;
            cbxSTT.SelectedValueChanged += ChangeValue;
            cbxDiem.SelectedValueChanged += ChangeValue;
            cbxStatus.SelectedValueChanged += ChangeValue;

        }
        private void ChangeValue(object sender, EventArgs e)
        {
            Invoke(FilterChanged);
        }
    }
}
