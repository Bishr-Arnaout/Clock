﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        private byte _cSec = 0;
        private byte _Sec = 0;
        private byte _Min = 0;
        private byte _Hour = 0;
        private ulong _TotalTime = 0;
        private ulong _Time = 0;
        private int _Laps = 0;
        private Stopwatch MyStopWatch;
        private bool IsTimerRunning = false;
        TimeSpan CountDownTimer;
        public Form1()
        {
            InitializeComponent();

            MyStopWatch = new Stopwatch();
        }
        ulong GetTotalTime()
        {
            return (UInt64)((MyStopWatch.Elapsed.TotalSeconds) * 100);
        }
        string ConvertToTime(ulong Time)
        {
            byte cSec = 0;
            byte Sec = 0;
            byte Min = 0;
            byte Hour = 0;

            if (Time >= 360000)
            {
                Hour = (Byte)(Time / 100 / 60 / 60);
                Time -= (UInt64)(Hour * 60 * 60 * 100);
            }
            if (Time >= 6000)
            {
                Min = (Byte)(Time / 100 / 60);
                Time -= (UInt64)(Min * 60 * 100);
            }
            if (Time >= 100)
            {
                Sec = (Byte)(Time / 100);
                Time -= (UInt64)(Sec * 100);
            }

            cSec = (Byte)Time;

            string TotalTime = "";

            if (Hour < 10) TotalTime += "0" + Hour.ToString() + ":";
            else TotalTime += Hour.ToString() + ":";

            if (Min < 10) TotalTime += "0" + Min.ToString() + ":";
            else TotalTime += Min.ToString() + ":";

            if (Sec < 10) TotalTime += "0" + Sec.ToString() + ".";
            else TotalTime += Sec.ToString() + ".";

            if (cSec < 10) TotalTime += "0" + cSec.ToString();
            else TotalTime += cSec.ToString();

            return TotalTime;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            MyStopWatch.Start();
            btnStart.Visible = false;
            btnStop.Visible = true;
            btnLap.Visible = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            MyStopWatch.Reset();
            lsbLaps.Items.Clear();
            _cSec = 0;
            _Sec = 0;
            _Min = 0;
            _Hour = 0;
            btnStart.Visible = true;
            btnStop.Visible = false;
            btnContinue.Visible = false;
            btnReset.Visible = false;
            btnLap.Visible = false;
            lsbLaps.Visible = false;
            lsbLaps.Items.Add("lap        Time                     Total");
            lsbLaps.Items.Add("_________________________________");
            _Laps = 0;
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            MyStopWatch.Start();
            btnStop.Visible = true;
            btnContinue.Visible = false;
            btnReset.Visible = false;
            btnLap.Visible = true;
        }
        private void btnLap_Click(object sender, EventArgs e)
        {
            _Laps++;
            lsbLaps.Visible = true;

            if (_Laps == 1) _Time = GetTotalTime();
            else _Time = GetTotalTime() - _TotalTime;

            _TotalTime = GetTotalTime();

            string Time = ConvertToTime(_Time);
            string TotalTime = ConvertToTime(_TotalTime);

            if (_Laps < 10) lsbLaps.Items.Add("0" + _Laps.ToString() + "         " + Time + "          " + TotalTime);
            else lsbLaps.Items.Add(_Laps.ToString() + "         " + Time + "          " + TotalTime);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            MyStopWatch.Stop();
            btnStop.Visible = false;
            btnContinue.Visible = true;
            btnReset.Visible = true;
            btnLap.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", MyStopWatch.Elapsed);
        }
        private void ReduceTimer()
        {
            prbTimer.Value = (int)CountDownTimer.TotalSeconds - 1;
            prbTimer.Refresh();
        }
        private string GetTimerWatch()
        {
            string TimerWatch = "Total ";

            if (numHour.Value > 1) TimerWatch += numHour.Value.ToString() + " hours ";
            else if (numHour.Value == 1) TimerWatch += numHour.Value.ToString() + " hour ";

            if (numMin.Value > 1) TimerWatch += numMin.Value.ToString() + " minutes ";
            else if (numMin.Value == 1) TimerWatch += numMin.Value.ToString() + " minute ";

            if (numSec.Value > 1) TimerWatch += numSec.Value.ToString() + " seconds";
            else if (numSec.Value == 1) TimerWatch += numSec.Value.ToString() + " second";

            return TimerWatch;
        }
        private void ResetProgressBar()
        {
            prbTimer.Value = (int)CountDownTimer.TotalSeconds;
            prbTimer.Maximum = prbTimer.Value;
        }
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (numHour.Value == 0 && numMin.Value == 0 && numSec.Value == 0) return;

            CountDownTimer = new TimeSpan((byte)numHour.Value, (byte)numMin.Value, (byte)numSec.Value);
            lblTimerWatch.Text = CountDownTimer.ToString();

            IsTimerRunning = true;

            numHour.Visible = false;
            numMin.Visible = false;
            numSec.Visible = false;

            prbTimer.Visible = true;
            btnStartTimer.Visible = false;
            btnPauseTimer.Visible = true;
            btnResetTimer.Visible = true;

            ResetProgressBar();

            lblTimerTime.Text = GetTimerWatch();

            timer2.Start();
        }
        private void NotifyUser()
        {
            notifyTimer.Icon = SystemIcons.Application;
            notifyTimer.BalloonTipIcon = ToolTipIcon.Info;
            notifyTimer.BalloonTipTitle = "";
            notifyTimer.BalloonTipText = GetTimerWatch().Substring(6).Trim();
            notifyTimer.ShowBalloonTip(1000);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CountDownTimer.TotalSeconds == 1 && IsTimerRunning)
            {
                timer2.Stop();

                ReduceTimer();
                lblTimerWatch.Text = lblTimerWatch.Tag.ToString();
                this.Refresh();

                Thread.Sleep(300);

                NotifyUser();

                IsTimerRunning = false;

                numHour.Visible = true;
                numMin.Visible = true;
                numSec.Visible = true;

                prbTimer.Visible = false;
                btnStartTimer.Visible = true;
                btnPauseTimer.Visible = false;
                btnResetTimer.Visible = false;
                return;
            }

            if (IsTimerRunning)
            {
                ReduceTimer();
                CountDownTimer = CountDownTimer.Subtract(TimeSpan.FromSeconds(1));
                lblTimerWatch.Text = CountDownTimer.ToString();
            }
        }
        private void ResetTimer()
        {
            timer2.Stop();

            prbTimer.Visible = false;
            numHour.Visible = true;
            numMin.Visible = true;
            numSec.Visible = true;

            btnResetTimer.Visible = false;
            btnPauseTimer.Visible = false;
            btnContinueTimer.Visible = false;
            btnStartTimer.Visible = true;
        }
        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
        private void btnPauseTimer_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            btnPauseTimer.Visible = false;
            btnContinueTimer.Visible = true;
        }
        private void btnContinueTimer_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btnPauseTimer.Visible = true;
            btnContinueTimer.Visible = false;
        }
        private void RefreshCurrentTime()
        {
            lblCurrentTime.Text = DateTime.Now.TimeOfDay.ToString();
            lblCurrentTime.Text = lblCurrentTime.Text.Substring(0, lblCurrentTime.Text.Length - 8);

            lblCurrentDate.Text = "Current: " + DateTime.Now.ToShortDateString();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            RefreshCurrentTime();
        }
    }
}