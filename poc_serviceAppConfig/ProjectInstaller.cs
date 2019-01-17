using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace poc_serviceAppConfig
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            frInitialConfig confForm = new frInitialConfig();
            confForm.ShowDialog();
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
            serviceInstaller1.ServiceName = Settings.ServiceName;
            serviceInstaller1.StartType = ServiceStartMode.Automatic;            
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {

        }
    }
}
