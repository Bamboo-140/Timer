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
using System.Management;
using Microsoft.Win32;
//using global::Timer.MyResource.MediaPlayer;

namespace Timer
{
    public partial class Form1 : Form
    {
        StringBuilder format = new StringBuilder("hh:mm:ss");
        DateTime timeNow = DateTime.Now;
        StringBuilder stoptime = new StringBuilder();
        StringBuilder message = new StringBuilder();
        SoundPlayer ringtone = new SoundPlayer();
        NumericUpDown currentBox;    //用于开启手动输入
        int i = 0;
        //int before = 0;

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
                        MessageBox.Show("设定的时间己过!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("请设定时间参数！", "TimerWarning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    h = 0; m = 0; s = 0;
                    start.Text = "停止";
                    start.Top -= (pauseButton.Height + 4);
                    recoderButton.Visible = false;
                    pauseButton.Visible = true;
                    h = Convert.ToInt32(this.Timer_Hour.Value);
                    m = Convert.ToInt32(this.Timer_Min.Value);
                    s = Convert.ToInt32(this.Timer_Sec.Value);
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
            this.Height = 210;             //XP&Win7:190; Win8-Win10: 210
            this.Width = 345;             //335
            this.functions.Height = 73;
            timer3.Enabled = false;
            timer4.Enabled = false;
            stopwatch.Enabled = false;
            AMLabel.Enabled = false;
            PMLabel.Enabled = false;
            #region 用下面的函数代替了
            //if (Convert.ToInt32(this.timeNow.Hour) > 12)
            //{
            //    this.PMLabel.Enabled = true;
            //    this.AMLabel.Enabled = false;
            //}
            //if (Convert.ToInt32(DateTime.Now.Hour) > 12)
            //{
            //    this.PMLabel.Enabled = true;
            //    this.AMLabel.Enabled = false;
            //}
            //else if (Convert.ToInt32(DateTime.Now.Hour) < 12)
            //{
            //    this.PMLabel.Enabled = false;
            //    this.AMLabel.Enabled = true;
            //}
            #endregion
            funcAMPM(exchange.Checked);
        }
        /// <summary>
        /// exchange_Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            #region 用下面的函数代替了
            //if (exchange.Checked)
            //{
            //    format.Remove(0, format.Length);
            //    format.Append("HH:mm:ss");
            //    //AMLabel.Visible = false;
            //    //PMLabel.Visible = false;
            //    //timer2.Enabled = false;
            //}
            //else
            //{
            //    format.Remove (0,format.Length);
            //    format.Append("hh:mm:ss");
            //    //AMLabel.Visible = true;
            //    //PMLabel.Visible = true;
            //    //timer2.Enabled = true;
            //}
            #endregion
            funcAMPM(exchange.Checked);
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
            else if (Convert.ToInt32(DateTime.Now.Hour) < 12)
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
                this.Width = 525;

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
                this.chk_Shutdown.Enabled = false;
            }
            else
            {
                this.Width = 345;
                //panel1.Visible = true;
                //stopwatch.Enabled = false;
                this.TimeLabel.Text = "";
                stopList.Items.Clear();
                //stopwatchFunc.Top -= 20;
                //AlarmFunc.Top -= 20;
                //TimerFunc.Top -= 20;
                this.exchange.Enabled = true;
                groupBox1.Visible = false;
                this.chk_Shutdown.Enabled = true;

                //提醒事件
                if (moreSet.Text.Equals("收起"))
                {
                    this.Height += 33;
                    this.functions.Height += 33;
                    noteText.Visible = true;
                    tipsLabel.Visible = true;
                    moreSet.Visible = true;
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
            stoptime.Remove(0, stoptime.Length);
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
            stoptime.AppendFormat("{0:00}:{1:00}:{2:00}:{3:00}", h, m, s, ms);
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
                    MessageBox.Show("在暂停状态只能记录一次喔……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



                panel1.Visible = false;                     //TimerFuncPanel
                panel2.Visible = true;

                //tips
                if (moreSet.Visible == false)
                    moreSet.Visible = true;

                #region 用下面的funcAMPM代替了
                //timer2.Enabled = true;
                //PMLabel.Visible = true;
                //AMLabel.Visible = true;
                #endregion
                funcAMPM(exchange.Checked);
                //
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if ((this.minO.Value <= Convert.ToInt32(DateTime.Now.Minute)) && (this.hourO.Value <= Convert.ToInt32(DateTime.Now.Hour)))
            {
                this.start.Text = "开始";
                timer3.Enabled = false;

                stopwatchFunc.Enabled = true;
                TimerFunc.Enabled = true;
                label7.Visible = false;
                //ringtone.Play();

                SetTop();

                if (this.chk_Shutdown.Checked)
                {
                    ShutDown();
                }
                else if (noteText.Text.Equals(""))
                {
                    ringtone.PlayLooping();
                    MessageBox.Show("时间到！", "Alarm Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ringtone.Stop();
                }
                else
                {
                    ringtone.PlayLooping();
                    message.Remove(0, message.Length);
                    message.AppendFormat("时间到！您设有以下提醒：\n\n\t{0}", noteText.Text.Trim().ToString());
                    MessageBox.Show(message.ToString(), "Alarm Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ringtone.Stop();
                }


                SetTop2();
            }
        }

        private void ShutdownWindows()
        {

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
                if (moreSet.Visible == false)
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
            stoptime.Remove(0, stoptime.Length);
            if (h >= 0 || m >= 0)
            {
                s--;
                if (s <= 0 && (m > 0 || h > 0))
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
                        start.Top += (pauseButton.Height + 4);
                        AlarmFunc.Enabled = true;
                        stopwatchFunc.Enabled = true;
                        //ringtone.Play();

                        SetTop();
                        if (chk_Shutdown.Checked)
                        {
                            this.ShutDown();
                        }
                        else if (noteText.Text.Equals(""))
                        {
                            ringtone.PlayLooping();
                            MessageBox.Show("计时结束！", "Timer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ringtone.Stop();
                        }
                        else
                        {
                            ringtone.PlayLooping();
                            message.Remove(0, message.Length);
                            message.AppendFormat("计时结束！您设有以下提醒：\n\n\t{0}", noteText.Text.Trim().ToString());
                            MessageBox.Show(message.ToString(), "Timer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ringtone.Stop();
                        }
                        SetTop2();
                    }
                }
            }
            TimeLabel.Text = (stoptime.AppendFormat("{0:00}:{1:00}:{2:00}", h, m, s).ToString());
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult close = new DialogResult();
            close = MessageBox.Show("是否关闭程序？", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (close == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }


        private void show_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                //notifyIcon1.Visible = false;
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
                //notifyIcon1.Visible = true;
                this.contextMenuStrip1.Items.Add(show);
                if (i <= 1)
                    notifyIcon1.ShowBalloonTip(500, "小提示", "最小化后我到这里了喔！", ToolTipIcon.Info);
                i++;
            }
            else
            {
                this.contextMenuStrip1.Items.Remove(show);
                this.ShowInTaskbar = true;
                //notifyIcon1.Visible = false;
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
            else if (moreSet.Text.Equals("收起"))
            {
                this.Height -= 33;
                functions.Height = 73;
                tipsLabel.Visible = false;
                noteText.Visible = false;
                moreSet.Text = "展开";
            }
        }


        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseClick = (MouseEventArgs)e;

            if (mouseClick.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                    //notifyIcon1.Visible = false;
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                    //notifyIcon1.Visible = true;
                }
            }
        }



        /// <summary>
        /// 显示上午下午标签
        /// </summary>
        /// <param name="exchange">是否勾选24小时制</param>
        void funcAMPM(bool exchange)
        {
            if (!exchange)   //如果没有选中
            {
                PMLabel.Visible = true;
                AMLabel.Visible = true;
                timer2.Enabled = true;
                format.Remove(0, format.Length);
                format.Append("hh:mm:ss");
                if (Convert.ToInt32(DateTime.Now.Hour) >= 12)
                {
                    this.PMLabel.Enabled = true;
                    this.AMLabel.Enabled = false;
                }
                else if (Convert.ToInt32(DateTime.Now.Hour) < 12)
                {
                    this.PMLabel.Enabled = false;
                    this.AMLabel.Enabled = true;
                }
            }
            else    //选中了
            {
                format.Remove(0, format.Length);
                format.Append("HH:mm:ss");
                this.PMLabel.Visible = false;
                this.AMLabel.Visible = false;
                timer2.Enabled = false;
            }
        }

        private void ManualInput_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl.GetType().Equals(this.hourO.GetType()))
            {
                currentBox = (NumericUpDown)(this.ActiveControl);
                //before = Convert.ToInt32(currentBox.Value);
                currentBox.ReadOnly = false;
                ManualInput.Enabled = false;
                CancelInput.Enabled = true;

            }
            else
                return;
        }


        private void CancelInput_Click(object sender, EventArgs e)
        {
            //currentBox.Value = before;
            CancelInput.Enabled = false;
            ManualInput.Enabled = true;
            currentBox.ReadOnly = true;
        }

        //private void MinValue_Click(object sender, EventArgs e)
        //{
        //    currentBox.Value = currentBox.Minimum;
        //}

        //private void MaxValue_Click(object sender, EventArgs e)
        //{
        //    currentBox.Value = currentBox.Maximum;
        //}

        private void Timer_Hour_Leave(object sender, EventArgs e)
        {
            LoseFocus(Timer_Hour.ReadOnly);
            Timer_Hour.ReadOnly = true;

        }

        void LoseFocus(bool readOnly)
        {
            if (!readOnly)
            {
                Timer_Hour.ReadOnly = true;
                ManualInput.Enabled = true;
                CancelInput.Enabled = false;
            }
        }

        private void Timer_Min_Leave(object sender, EventArgs e)
        {
            LoseFocus(Timer_Min.ReadOnly);
            Timer_Min.ReadOnly = true;
        }

        private void Timer_Sec_Leave(object sender, EventArgs e)
        {
            LoseFocus(Timer_Sec.ReadOnly);
            Timer_Sec.ReadOnly = true;
        }

        private void minO_Leave(object sender, EventArgs e)
        {
            LoseFocus(minO.ReadOnly);
            minO.ReadOnly = true;
        }

        private void hourO_Leave(object sender, EventArgs e)
        {
            LoseFocus(hourO.ReadOnly);
            hourO.ReadOnly = true;
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            this.contextMenuStrip2.Items.Remove(MinValue);
            this.contextMenuStrip2.Items.Remove(MaxValue);
        }


        #region 可能用到的代码
        private void Timer_Hour_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseEventArgs mouseClick = (MouseEventArgs)e;
            //if (mouseClick.Button == MouseButtons.Right)
            //{
            Timer_Hour.Focus();
            //    //if (Timer_Hour.Value > 0)
            //    //{
            //    //    Timer_Hour.Value = Timer_Hour.Minimum;
            //    //}
            //    //else
            //    //{
            //    //    Timer_Hour.Value = Timer_Hour.Maximum;
            //    //}
            //}
        }

        private void Timer_Min_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseEventArgs mouseClick = (MouseEventArgs)e;
            //if (mouseClick.Button == MouseButtons.Right)
            //{
            Timer_Min.Focus();
            //    //if (Timer_Min.Value > 0)
            //    //{
            //    //    Timer_Min.Value = Timer_Min.Minimum;
            //    //}
            //    //else
            //    //{
            //    //    Timer_Min.Value = Timer_Min.Maximum;
            //    //}
            //}
        }

        private void Timer_Sec_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseEventArgs mouseClick = (MouseEventArgs)e;
            //if (mouseClick.Button == MouseButtons.Right)
            //{
            Timer_Sec.Focus();
            //    //if (Timer_Sec.Value > 0)
            //    //{
            //    //    Timer_Sec.Value = Timer_Sec.Minimum;
            //    //}
            //    //else
            //    //{
            //    //    Timer_Sec.Value = Timer_Sec.Maximum;
            //    //}
            //}
        }

        private void minO_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseEventArgs mouseClick = (MouseEventArgs)e;
            //if (mouseClick.Button == MouseButtons.Right)
            //{
            minO.Focus();
            //    //if (minO.Value > 0)
            //    //{
            //    //    minO.Value = minO.Minimum;
            //    //}
            //    //else
            //    //{
            //    //    minO.Value = minO.Maximum;
            //    //}
            //}
        }

        private void hourO_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseEventArgs mouseClick = (MouseEventArgs)e;
            //if (mouseClick.Button == MouseButtons.Right)
            //{

            hourO.Focus();

            //if (hourO.Value > 0)
            //{
            //    hourO.Value = hourO.Minimum;
            //}
            //else
            //{
            //    hourO.Value = hourO.Maximum;
            //}
            //}
        }

        #endregion

        private void Timer_Hour_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (Timer_Hour.Value > 0)
            //{
            //    Timer_Hour.Value = Timer_Hour.Minimum;
            //}
            //else
            //{
            //    Timer_Hour.Value = Timer_Hour.Maximum;
            //}

        }

        private void Timer_Min_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (Timer_Min.Value > 0)
            //{
            //    Timer_Min.Value = Timer_Min.Minimum;
            //}
            //else
            //{
            //    Timer_Min.Value = Timer_Min.Maximum;
            //}

        }

        private void Timer_Sec_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (Timer_Sec.Value > 0)
            //{
            //    Timer_Sec.Value = Timer_Sec.Minimum;
            //}
            //else
            //{
            //    Timer_Sec.Value = Timer_Sec.Maximum;
            //}

        }

        private void minO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (minO.Value > 0)
            //{
            //    minO.Value = minO.Minimum;
            //}
            //else
            //{
            //    minO.Value = minO.Maximum;
            //}
        }

        private void hourO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (hourO.Value > 0)
            //{
            //    hourO.Value = hourO.Minimum;
            //}
            //else
            //{
            //    hourO.Value = hourO.Maximum;
            //}


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void chk_Shutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Shutdown.Checked)
            {
                this.noteText.Enabled = false;
            }
            else
            {
                this.noteText.Enabled = true;
            }

        }

        void SetTop()
        {
            if (checkBox1.Checked)
            {
                this.TopMost = false;
            }
        }
        void SetTop2()
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
        }
        private void ShutDown()
        {
            //DialogResult question = new DialogResult();
            ////question = MessageBox.Show("时间到是否关闭计算机?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //question = 
            //if (question == DialogResult.OK)
            //{

            //}
            Frm_Question frm = new Frm_Question();
            frm._controlString = this.cmb_ShutDownOption.Text.Trim();
            frm.ShowDialog();
        }
    }
}
