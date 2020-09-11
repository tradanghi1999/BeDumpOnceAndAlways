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
    public partial class ucCheckConnection : UserControl
    {
        private bool _allisConnected =false;
        public bool AllisConnected
        {
            get
            {
                return _allisConnected;
            }
            private set
            {
                _allisConnected = value;
            }

        }
        private int _numberOfDeviceNotConnected = 0;
        public int NumberOfDeviceNotConnected
        {
            get
            {
                return _numberOfDeviceNotConnected;
            }
            private set
            {
                _numberOfDeviceNotConnected = value;
                lblNumberOfDevice.Text = _numberOfDeviceNotConnected + "";
            }
        }
        private Timer _timerCheckConnection;
        public ucCheckConnection()
        {
            InitializeComponent();
        }

        private void UcCheckConnection_Load(object sender, EventArgs e)
        {
            _timerCheckConnection = new Timer();
            _timerCheckConnection.Interval=1000;
            _timerCheckConnection.Start();
            _timerCheckConnection.Tick += delegate (object send, EventArgs ev)
            {
                CheckConnection();
            };

        }

        
        private void CheckConnection()
        {
            NumberOfDeviceNotConnected = (new BLL()).CheckAllHostConnection();
            if(NumberOfDeviceNotConnected==0)
            {
                AllisConnected = true;
                lblNumberOfDevice.ForeColor = Color.Green;
                return;
            }
            lblNumberOfDevice.ForeColor = Color.OrangeRed;
            AllisConnected = false;
        }
    }
}
