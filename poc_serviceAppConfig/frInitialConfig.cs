using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poc_serviceAppConfig
{
    public partial class frInitialConfig : Form
    {
        public frInitialConfig()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServiceName = txtServiceName.Text.Trim();
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void txtServiceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtServiceName.Text.Trim().Length != 0 && txtBatPath.Text.Trim().Length != 0)            
                btnOK.Enabled = true;            
            else            
                btnOK.Enabled = false;            
        }
    }
}
