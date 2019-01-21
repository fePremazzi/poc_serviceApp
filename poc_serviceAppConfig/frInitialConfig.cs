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
            cbDependencies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDependencies.DataSource = Utils.PopulateComboBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            throw new Exception("Cancelando operação");
            //Properties.Settings.Default.ServiceName = "00MyWinService";
            //Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServiceName = txtServiceName.Text.Trim();
            Properties.Settings.Default.BatFilePath = txtBatPath.Text.Trim();
            Properties.Settings.Default.ServiceDependency = cbDependencies.Text.Trim();
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void txtServiceName_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }

        private void txtBatPath_TextChanged(object sender, EventArgs e)
        {
            if (txtServiceName.Text.Trim().Length != 0 && txtBatPath.Text.Trim().Length != 0)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }
    }
}
