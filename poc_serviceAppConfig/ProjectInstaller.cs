﻿using System;
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
        string[] dependencies = new string[1];

        public ProjectInstaller()
        {
            InitializeComponent();
            frInitialConfig confForm = new frInitialConfig();
            confForm.ShowDialog();
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
            serviceInstaller1.ServiceName = Properties.Settings.Default.ServiceName;
            serviceInstaller1.StartType = ServiceStartMode.Automatic;
            //dependencies[0] = Properties.Settings.Default.ServiceDependency;
            //serviceInstaller1.ServicesDependedOn = dependencies;
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {

        }
    }
}
