using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HippoKinectOverLoader {
    public partial class HippoKinectService : ServiceBase {
        public HippoKinectService() {
            InitializeComponent();
        }

        protected override void OnStart(string[] args) {
            string log_path = @"E:\\log.txt";
            StreamWriter sw;
            if (File.Exists(log_path)) {
                sw = File.AppendText(log_path);
            } else {
                sw = File.CreateText(log_path);
            }
            sw.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] : Service Startup.");
            sw.Close();
        }

        protected override void OnStop() {
            string log_path = @"E:\\log.txt";
            StreamWriter sw;
            if (File.Exists(log_path)) {
                sw = File.AppendText(log_path);
            } else {
                sw = File.CreateText(log_path);
            }
            sw.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] : Service Stop.");
            sw.Close();
        }
    }
}
