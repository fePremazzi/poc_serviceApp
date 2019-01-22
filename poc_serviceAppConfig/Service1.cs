using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace poc_serviceAppConfig
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Utils.ExecuteCmd(Properties.Settings.Default.BatFilePath);
            string cmd = @"C:\integrated-reports\integrated_reports_backend\target\startup.bat";
            string c = @"java -jar -DBACKEND_SERVER_PORT="+"8090"+" -DMACHINE_LEARNING_GENERATE_REPORT_URL="+"http://localhost:9099/api/generateIReport"+" -DBACKEND_IMAGES_OUTPUT_FOLDER="+"C:\\IntegratedReports\\Integrated Reports Backend\\images\\prod\\"+" -DBACKEND_DATABASE_DATASOURCE_URL="+"jdbc:mysql://localhost:3306/integratedreport?serverTimezone=America/Sao_Paulo&useSSL=false"+" -DBACKEND_DATABASE_DATASOURCE_USERNAME="+"root"+" -DBACKEND_DATABASE_DATASOURCE_PASSWORD="+"mysql21!2"+" -DBACKEND_CARESTREAM_CLIENT_URL="+"http://svw8intr01:9191/ConsultaImagens"+" -DBACKEND_TESI_CLIENT_URL="+"http://svw12app10:9191/ConsultaImagens/"+" -DBACKEND_CARESTREAM_CLIENT_ISSUE="+"3"+" -DBACKEND_TOP_APPROVERS_LIMIT="+"5"+ @" C:\integrated-reports\integrated_reports_backend\target\IntegratedReportBackend-1.0-SNAPSHOT.jar";
            //System.Diagnostics.Process.Start(c);
            Utils.ExecuteCmd(c);
        }

        protected override void OnStop()
        {
        }
    }
}
