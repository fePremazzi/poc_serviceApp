using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc_serviceAppConfig
{
    public static class Settings
    {
        static string serviceName;
        static string batFilePath;

        public static string ServiceName { get => serviceName; set => serviceName = value; }
        public static string BatFilePath { get => batFilePath; set => batFilePath = value; }
    }
}
