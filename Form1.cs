using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;
using System.IO;
//using Interop.WMPLib.dll;

namespace Timer
{
    public partial class Form1 : Form
    {
        StringBuilder format = new StringBuilder("hh:mm:ss");
        DateTime timeNow = DateTime.Now;
        StringBuilder stoptime = new StringBuilder();
        StringBuilder message = new StringBuilder();
        SoundPlayer ringtone = new SoundPlayer();

        int h = 0, m = 0, s = 0, ms = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ringtone.Stream = MyResource.alarm_007;
            if (this.stopwatchFunc.Checked)
            {
                if (this.start.Text.Equals("开始"))
                {
                    h = 0; m = 0; s = 0; ms = 0;
                    TimeLabel.Text = "00:00:00:00";
                    stopList.Items.Clear();
                    stopwatch.Enabled = true;
                    this.start.Text = "停止";
                    this.start.Top = this.start.Top - (recoderButton.Height + 4);
                    this.recoderButton.Visible = true;
                    AlarmFunc.Enabled = false;
                    TimerFunc.Enabled = false;
                    this.pauseButton.Left = this.pauseButton.Left - (this.pauseButton.Width + 4);
                    this.pauseButton.Visible = true;
                }
                else
                {
                    //MessageBox.Show("所有信息将要清零，确认停止吗？");
                    stoptime.Remove(0, stoptime.Length);
                    //h = 0; m = 0; s = 0; ms = 0;
                    //TimeLabel.Text = "00:00:00:00";
                    this.start.Text = "开始";
                    //if(this.pauseButton.Text.Equals("继续"))
                    this.pauseButton.Text = "暂停";             //重置暂停按钮
                    this.recoderButton.Enabled = true;
                    this.recoderButton.Visible = false;
                    this.start.Top = this.start.Top + (this.recoderButton.Height + 4);
                    AlarmFunc.Enabled = true;
                    TimerFunc.Enabled = true;
                    stoptime.Remove(0, stoptime.Length);
                    //stopList.Items.Clear();
                    this.pauseButton.Left = this.pauseButton.Left + (this.pauseButton.Width + 4);
                    this.pauseButton.Visible = true;
                    stopwatch.Enabled = false;
                }
            }
            else if (AlarmFunc.Checked)
            {
                if (start.Text.Equals("开始"))
                {
                    int hour = Convert.ToInt32(DateTime.Now.Hour);
                    int minute = Convert.ToInt32(DateTime.Now.Minute);

                    if (hourO.Value <= hour && minO.Value <= minute)
                    {
                        MessageBox.Show("设定的时间己过!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else if (hourO.Value >= hour || minO.Value > minute)
                    {
                        timer3.Enabled = true;
                        start.Text = "停止";
                        stopwatchFunc.Enabled = false;
                        TimerFunc.Enabled = false;
                        //if(!displayFun.Checked)
                        //label7.Visible = true;
                        //displayFun.Enabled = false;
                    }
                }
                else
                {
                    timer3.Enabled = false;
                    start.Text = "开始";
                    stopwatchFunc.Enabled = true;
                    TimerFunc.Enabled = true;
                    label7.Visible = false;
                    //displayFun.Enabled = true;
                }
            }
            else if (this.TimerFunc.Checked)
            {
                if (start.Text.Equals("开始"))
                {
                    if ((Timer_Hour.Value == 0) && (Timer_Min.Value == 0) && (Timer_Sec.Value == 0))
                    {
                        MessageBox.Show("请设定时间参数！","TimerWarning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                    h = 0; m = 0; s = 0;
                    start.Text = "停止";
                    start.Top -= (pauseButton.Height + 4);
                    recoderButton.Visible = false;
                    pauseButton.Visible = true;
                    h = Convert.ToInt32( this.Timer_Hour.Value);
                    m = Convert.ToInt32( this.Timer_Min.Value);
                    s = Convert.ToInt32( this.Timer_Sec.Value);
                    timer4.Enabled = true;
                    AlarmFunc.Enabled = false;
                    stopwatchFunc.Enabled = false;
                    Timer_Hour.Enabled = false;
                    Timer_Min.Enabled = false;
                    Timer_Sec.Enabled = false;
                    AlarmFunc.Enabled = false;
                    stopwatchFunc.Enabled = false;
                }
                else
                {
                    start.Text = "开始";
                    start.Top += (pauseButton.Height + 4);
                    pauseButton.Visible = false;
                    AlarmFunc.Enabled = true;
                    stopwatchFunc.Enabled = true;
                    timer4.Enabled = false;
                    Timer_Hour.Enabled = true;
                    Timer_Min.Enabled = true;
                    Timer_Sec.Enabled = true;
                    AlarmFunc.Enabled = true;
                    stopwatchFunc.Enabled = true;
                    this.pauseButton.Text = "暂停";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //format.Remove(0,format.Length);
            TimeLabel.Text = DateTime.Now.ToString(format.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString(format.ToString());
            functions.Visible = false;
            groupBox1.Visible = false;
            this.Icon = MyResource.icon;
            //if (Convert.ToInt32(this.timeNow.Hour) > 12)
            //{
            //    this.PMLabel.Enabled = true;
            //    this.AMLabel.Enabled = false;
            //}
            if (Convert.ToInt32(DateTime.Now.Hour) > 12)
            {
                this.PMLabel.Enabled = true;
                this.AMLabel.Enabled = false;
            }
            else if (Convert.ToInt32(DateTime.Now.Hour) < 12)
            {
                this.PMLabel.Enabled = false;
                this.AMLabel.Enabled = true;
            }
            this.Height = 210;             //XP&Win7:190; Win8-Win10: 210
            this.Width =  335;             //335
            this.functions.Height = 73;
            timer3.Enabled = false;
            timer4.Enabled = false;
            stopwatch.Enabled = false;
        }
        /// <summary>
        /// exchange_Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (exchange.Checked)
            {
                format.Remove(0, format.Length);
                format.Append("HH:mm:ss");
                AMLabel.Visible = false;
                PMLabel.Visible = false;
                timer2.Enabled = false;
            }
            else
            {
                format.Remove (0,format.Length);
                format.Append("hh:mm:ss");
                AMLabel.Visible = true;
                PMLabel.Visible = true;
                timer2.Enabled = true;
            }
        }
        /// <summary>
        /// AM&PM Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DateTime.Now.Hour) > 12)
            {
                this.PMLabel.Enabled = true;
                this.AMLabel.Enabled = false;
            }
            else if(Convert.ToInt32(DateTime.Now.Hour) < 12)
            {
                this.PMLabel.Enabled = false;
                this.AMLabel.Enabled = true;
            }
        }


        private void displayFun_CheckedChanged(object sender, EventArgs e)
        {
            if (displayFun.Checked)
            {
                if (moreSet.Text.Equals("展开"))
                {
                    this.Height = this.Height + 90;
                }
                else
                {
                    this.Height += 123; 
                }
                functions.Visible = true;

                if (timer3.Enabled == true)
                    label7.Visible = false;

                if (!timer3.Enabled && !stopwatchFunc.Checked && !AlarmFunc.Checked && !TimerFunc.Checked)   //如果timer3没有启动
                {
                    this.AlarmFunc.Checked = true;
                }
            }
            else
            {
                if (moreSet.Text.Equals("展开"))
                {
                    this.Height = this.Height - 90;
                }
                else
                {
                    this.Height -= 123;             //XP&Win7:190; Win8-Win10: 210
                }
                functions.Visible = false;
                if (timer3.Enabled == true)
                    label7.Visible = true;
            }
        }

        /// <summary>
        /// stopwatch_Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.stopwatchFunc.Checked)
            {
                this.Width = 516;

                //提醒事件
                if (moreSet.Text.Equals("收起"))
                {
                    this.Height -= 33;
                    this.functions.Height = 73;
                    noteText.Visible = false;
                    tipsLabel.Visible = false;    
                }
                moreSet.Visible = false;
                
                //end

                panel2.Visible = false;                //AlarmFunPanel
                timer1.Enabled = false;                //TimerFunc_Timer
                timer2.Enabled = false;
                TimeLabel.Text = "";
                PMLabel.Visible = false;
                AMLabel.Visible = false;
                //stopwatch.Enabled = true;
                panel1.Visible = false;
                this.TimeLabel.Text = "00:00:00:00";
                //stopwatchFunc.Top += 20;
               // AlarmFunc.Top += 20;
                //TimerFunc.Top += 20;
                recoderButton.Visible = true;
                //this.exchange.Checked = false;
                this.exchange.Enabled = false;
                groupBox1.Visible = true;

            }
            else
            {
                this.Width = 335;
                //panel1.Visible = true;
                //stopwatch.Enabled = false;
                this.TimeLabel.Text = "";
                stopList.Items.Clear();
                //stopwatchFunc.Top -= 20;
                //AlarmFunc.Top -= 20;
                //TimerFunc.Top -= 20;
                this.exchange.Enabled = true;
                groupBox1.Visible = false;
                
                //提醒事件
                if (moreSet.Text.Equals("收起"))
                {
                    this.Height += 33;
                    this.functions.Height += 33;
                    noteText.Visible = true ;
                    tipsLabel.Visible = true ;
                    moreSet.Visible = true ;
                }

            }
        }


        /// <summary>
        /// stopwatch_Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopwatch_Tick(object sender, EventArgs e)
        {
            stoptime.Remove(0,stoptime.Length);
            ms++;
            if (ms >= 99)
            {
                ms = 0;
                s++;
            }
            if (s >= 59)
            {
                s = 0;
                m++;
            }
            if (m >= 59)
            {
                m = 0;
                h++;
            }
            stoptime.AppendFormat("{0:00}:{1:00}:{2:00}:{3:00}",h,m,s,ms);
            TimeLabel.Text = stoptime.ToString();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.recoderButton.Text.Equals("记录"))
            {
                this.stopList.Items.Add(stoptime.ToString());
                if (this.pauseButton.Text.Equals("继续"))
                {
                    this.recoderButton.Enabled = false;
                    MessageBox.Show("在暂停状态只能记录一次喔……","提示",MessageBoxButtons.OK,MessageBoxIcon.Information );
                }
            }
        }

        /// <summary>
        /// AlarmFunc 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (AlarmFunc.Checked)
            {
                this.timer1.Enabled = true;
                this.timer2.Enabled = true;
                exchange.Enabled = true;
                this.hourO.Maximum = 23;
                this.minO.Maximum = 59;
                this.hourO.Value = Convert.ToInt32(DateTime.Now.Hour);
                this.minO.Value = Convert.ToInt32(DateTime.Now.Minute);
                timer1.Enabled = true;
                timer2.Enabled = true;
                PMLabel.Visible = true;
                AMLabel.Visible = true;
                panel1.Visible = false;                     //TimerFuncPanel
                panel2.Visible = true;

                //tips
                if (moreSet.Visible == false)
                    moreSet.Visible = true;
                //
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if ( (this.minO.Value <= Convert.ToInt32(DateTime.Now.Minute)) && (this.hourO.Value <= Convert.ToInt32(DateTime.Now.Hour)))
            {
                this.start.Text = "开始";
                timer3.Enabled = false;
           
                stopwatchFunc.Enabled = true;
                TimerFunc.Enabled = true;
                label7.Visible = false;
                //ringtone.Play();
                ringtone.PlayLooping();
                if (noteText.Text.Equals(""))
                {
                    MessageBox.Show("时间到！","Alarm Information",MessageBoxButtons.OK,MessageBoxIcon.Information );
                }
                else
                {
                    message.Remove(0,message.Length);
                    message.AppendFormat("时间到！您设有以下提醒：\n\n\t{0}", noteText.Text.Trim().ToString());
                    MessageBox.Show(message.ToString(),"Alarm Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                ringtone.Stop();
            }
        }


        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (this.pauseButton.Text.Equals("暂停"))
            {
                this.pauseButton.Text = "继续";
                if (stopwatchFunc.Checked)
                    this.stopwatch.Enabled = false;
                else
                    this.timer4.Enabled = false;
            }
            else
            {
                if (stopwatchFunc.Checked)
                    this.stopwatch.Enabled = true;
                else
                    this.timer4.Enabled = true;
                this.pauseButton.Text = "暂停";
                if (!this.recoderButton.Enabled)
                    this.recoderButton.Enabled = true;
            }
        }

        private void TimerFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (TimerFunc.Checked)
            {
                panel2.Visible = false;    //AlarmPanel 
                panel1.Visible = true;
                timer1.Enabled = false;                //TimerFunc_Timer
                timer2.Enabled = false;
                TimeLabel.Text = "00:00:00";
                PMLabel.Visible = false;
                AMLabel.Visible = false;
                this.exchange.Enabled = false;

                //tips
                if(moreSet.Visible == false)
                    moreSet.Visible = true;
                //end
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            #region
            //for (; h >= 0; h--)
            //{
            //    for (; m >= 0; m--)
            //    {
            //        for (; s >= 0; s--)
            //        {
            //            if (s = 0 && (m > 0))
            //                s = 59;
            //        }
            //    }
            //}
            //s--;
            //if (s <= 0)
            //{
            //    //s = 59;
            //    //if (h > 0 && m == 0)
            //    //{
            //    //    h--;
            //    //    m = 59;
            //    //}
            //    //else if (h > 0 && m > 0)
            //    //{
            //    //    m--;
            //    //}
            //    //else if (h == 0 && m > 0)
            //    //{
                   
            //    //}
            //}
            #endregion
            stoptime.Remove(0,stoptime.Length);
            if (h >= 0 || m >= 0)
            {
                s--;
                if (s <= 0 &&(m > 0 || h > 0))
                { 
                    s = 59;
                    if (m <= 0 && h > 0)
                    {
                        m = 59;
                        h--;
                    }
                    else
                        m--;
                }
                //else if (m <= 0 && h > 0)   //出现-1错误
                //{
                //    m = 59;
                //    h--;
                //}
                else if (m <= 0 && h <= 0)
                {
                    if (s <= 0)
                   {
                        timer4.Enabled = false;
                        Timer_Hour.Enabled = true;
                        Timer_Min.Enabled = true;
                        Timer_Sec.Enabled = true; 
                        
                        start.Text = "开始";
                        AlarmFunc.Enabled = true;
                        stopwatchFunc.Enabled = true;
                        pauseButton.Text = "暂停";
                        start.Top += (pauseButton.Height +4 );
                        AlarmFunc.Enabled = true;
                        stopwatchFunc.Enabled = true;
                        //ringtone.Play();
                        ringtone.PlayLooping();
                        if (noteText.Text.Equals(""))
                        {
                            MessageBox.Show("计时结束！", "Timer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            message.Remove(0, message.Length);
                            message.AppendFormat("计时结束！您设有以下提醒：\n\n\t{0}", noteText.Text.Trim().ToString());
                            MessageBox.Show(message.ToString(), "Timer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ringtone.Stop();
                    }
                }
            }
            TimeLabel.Text= (stoptime.AppendFormat("{0:00}:{1:00}:{2:00}",h,m,s).ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult close = new DialogResult();
            close = MessageBox.Show("是否关闭程序？","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (close == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500, "小提示", "最小化后我到这里了喔！",ToolTipIcon.Info);
                this.contextMenuStrip1.Items.Add(show);
            }
            else
            {
                //this.contextMenuStrip1.Items.Remove(show);
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void moreSet_Click(object sender, EventArgs e)
        {
            if (moreSet.Text.Equals("展开"))
            {
                this.Height += 33;
                functions.Height = 106;
                tipsLabel.Top = this.pauseButton.Top + 3;
                noteText.Top = this.pauseButton.Top;
                tipsLabel.Visible = true;
                noteText.Visible = true;
                moreSet.Text = "收起";
            }
            else if(moreSet.Text.Equals("收起"))
            {
                this.Height -= 33;
                functions.Height = 73;
                tipsLabel.Visible = false;
                noteText.Visible = false;
                moreSet.Text = "展开";
            }
        }
    }
}
