using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
   
    public partial class Frm_Question : Form
    {
        public string _controlString = "";
        int i = 30;
        public Frm_Question()
        {
            InitializeComponent();
        }

        private void tim_shutDownStopWatch_Tick(object sender, EventArgs e)
        {
            this.lab_time.Text = i.ToString();
            --i;
            if (i <= 0)
            {
                ExecShutDown();
            }
        }
        private void ExecShutDown()
        {
            //引用自百度   https://jingyan.baidu.com/article/dca1fa6fa33a05f1a4405220.html
            var startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            var myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo = startInfo;
            myProcess.Start();
            switch(_controlString.Trim())
            {
               
                case "休眠":
                    myProcess.StandardInput.WriteLine("shutdown /h /f -t 0");
                    Application.Exit();
                    break;
                case "重启":
                    myProcess.StandardInput.WriteLine("shutdown /r -t 0");
                    Application.Exit();
                    break;
               default:
                    myProcess.StandardInput.WriteLine("shutdown /s /f -t 0");
                    Application.Exit();
                    break;
            }
           
        }
        private void CancelShutDown()
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            var myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo = startInfo;
            myProcess.Start();
            myProcess.StandardInput.WriteLine("shutdown -a");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ExecShutDown();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            tim_shutDownStopWatch.Enabled = false;
            this.Close();
        }
    }
}
