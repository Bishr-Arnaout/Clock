namespace Clock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StopWatchScreen = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsbLaps = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLap = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnContinue = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnReset = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnStart = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.prbTimer = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblTimerTime = new System.Windows.Forms.Label();
            this.lblTimerWatch = new System.Windows.Forms.Label();
            this.btnContinueTimer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPauseTimer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnResetTimer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnStartTimer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.numSec = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numMin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numHour = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.CurrentTimeScreen = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyTimer = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.StopWatchScreen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.prbTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.CurrentTimeScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopWatchScreen
            // 
            this.StopWatchScreen.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.StopWatchScreen.Controls.Add(this.tabPage1);
            this.StopWatchScreen.Controls.Add(this.tabPage2);
            this.StopWatchScreen.Controls.Add(this.CurrentTimeScreen);
            this.StopWatchScreen.ItemSize = new System.Drawing.Size(120, 121);
            this.StopWatchScreen.Location = new System.Drawing.Point(0, 0);
            this.StopWatchScreen.Name = "StopWatchScreen";
            this.StopWatchScreen.SelectedIndex = 0;
            this.StopWatchScreen.Size = new System.Drawing.Size(709, 456);
            this.StopWatchScreen.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopWatchScreen.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopWatchScreen.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StopWatchScreen.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.StopWatchScreen.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopWatchScreen.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.StopWatchScreen.TabButtonIdleState.FillColor = System.Drawing.Color.MidnightBlue;
            this.StopWatchScreen.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StopWatchScreen.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.StopWatchScreen.TabButtonIdleState.InnerColor = System.Drawing.Color.MidnightBlue;
            this.StopWatchScreen.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.StopWatchScreen.TabButtonSelectedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.StopWatchScreen.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StopWatchScreen.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopWatchScreen.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopWatchScreen.TabButtonSize = new System.Drawing.Size(120, 121);
            this.StopWatchScreen.TabIndex = 0;
            this.StopWatchScreen.TabMenuBackColor = System.Drawing.Color.MidnightBlue;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.lsbLaps);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnLap);
            this.tabPage1.Controls.Add(this.btnContinue);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StopWatch";
            // 
            // lsbLaps
            // 
            this.lsbLaps.BackColor = System.Drawing.Color.Black;
            this.lsbLaps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbLaps.ForeColor = System.Drawing.Color.White;
            this.lsbLaps.FormattingEnabled = true;
            this.lsbLaps.ItemHeight = 16;
            this.lsbLaps.Items.AddRange(new object[] {
            "lap        Time                     Total",
            "_________________________________"});
            this.lsbLaps.Location = new System.Drawing.Point(144, 32);
            this.lsbLaps.Name = "lsbLaps";
            this.lsbLaps.Size = new System.Drawing.Size(345, 112);
            this.lsbLaps.TabIndex = 50;
            this.lsbLaps.TabStop = false;
            this.lsbLaps.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(218, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(272, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "sec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(166, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "hr";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(149, 177);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(199, 38);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "00:00:00.00";
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::Clock.Properties.Resources.Pause;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop.FillColor = System.Drawing.Color.Transparent;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(270, 296);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStop.Size = new System.Drawing.Size(70, 70);
            this.btnStop.TabIndex = 31;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLap
            // 
            this.btnLap.BackgroundImage = global::Clock.Properties.Resources.Lap;
            this.btnLap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLap.FillColor = System.Drawing.Color.Transparent;
            this.btnLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLap.ForeColor = System.Drawing.Color.White;
            this.btnLap.Location = new System.Drawing.Point(138, 296);
            this.btnLap.Name = "btnLap";
            this.btnLap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLap.Size = new System.Drawing.Size(70, 70);
            this.btnLap.TabIndex = 30;
            this.btnLap.Visible = false;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackgroundImage = global::Clock.Properties.Resources.Continue;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContinue.FillColor = System.Drawing.Color.Transparent;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(270, 296);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnContinue.Size = new System.Drawing.Size(70, 70);
            this.btnContinue.TabIndex = 29;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Clock.Properties.Resources.Reset;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(138, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReset.Size = new System.Drawing.Size(70, 70);
            this.btnReset.TabIndex = 28;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::Clock.Properties.Resources.Continue;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(205, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStart.Size = new System.Drawing.Size(70, 70);
            this.btnStart.TabIndex = 27;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.prbTimer);
            this.tabPage2.Controls.Add(this.btnContinueTimer);
            this.tabPage2.Controls.Add(this.btnPauseTimer);
            this.tabPage2.Controls.Add(this.btnResetTimer);
            this.tabPage2.Controls.Add(this.btnStartTimer);
            this.tabPage2.Controls.Add(this.numSec);
            this.tabPage2.Controls.Add(this.numMin);
            this.tabPage2.Controls.Add(this.numHour);
            this.tabPage2.Location = new System.Drawing.Point(124, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timer";
            // 
            // prbTimer
            // 
            this.prbTimer.AnimationSpeed = 1000F;
            this.prbTimer.Controls.Add(this.lblTimerTime);
            this.prbTimer.Controls.Add(this.lblTimerWatch);
            this.prbTimer.FillColor = System.Drawing.Color.MidnightBlue;
            this.prbTimer.FillThickness = 18;
            this.prbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.prbTimer.ForeColor = System.Drawing.Color.White;
            this.prbTimer.Location = new System.Drawing.Point(107, 8);
            this.prbTimer.Minimum = 0;
            this.prbTimer.Name = "prbTimer";
            this.prbTimer.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prbTimer.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prbTimer.ProgressThickness = 18;
            this.prbTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prbTimer.Size = new System.Drawing.Size(337, 337);
            this.prbTimer.TabIndex = 29;
            this.prbTimer.Value = 1;
            this.prbTimer.Visible = false;
            // 
            // lblTimerTime
            // 
            this.lblTimerTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTime.Location = new System.Drawing.Point(31, 148);
            this.lblTimerTime.Name = "lblTimerTime";
            this.lblTimerTime.Size = new System.Drawing.Size(297, 46);
            this.lblTimerTime.TabIndex = 1;
            this.lblTimerTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerWatch
            // 
            this.lblTimerWatch.AutoSize = true;
            this.lblTimerWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerWatch.Location = new System.Drawing.Point(94, 110);
            this.lblTimerWatch.Name = "lblTimerWatch";
            this.lblTimerWatch.Size = new System.Drawing.Size(151, 38);
            this.lblTimerWatch.TabIndex = 0;
            this.lblTimerWatch.Tag = "00:00:00";
            this.lblTimerWatch.Text = "00:00:00";
            // 
            // btnContinueTimer
            // 
            this.btnContinueTimer.BackgroundImage = global::Clock.Properties.Resources.Continue;
            this.btnContinueTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinueTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContinueTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContinueTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContinueTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContinueTimer.FillColor = System.Drawing.Color.Transparent;
            this.btnContinueTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnContinueTimer.ForeColor = System.Drawing.Color.White;
            this.btnContinueTimer.Location = new System.Drawing.Point(312, 351);
            this.btnContinueTimer.Name = "btnContinueTimer";
            this.btnContinueTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnContinueTimer.Size = new System.Drawing.Size(70, 70);
            this.btnContinueTimer.TabIndex = 32;
            this.btnContinueTimer.Visible = false;
            this.btnContinueTimer.Click += new System.EventHandler(this.btnContinueTimer_Click);
            // 
            // btnPauseTimer
            // 
            this.btnPauseTimer.BackgroundImage = global::Clock.Properties.Resources.Pause;
            this.btnPauseTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPauseTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPauseTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPauseTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPauseTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPauseTimer.FillColor = System.Drawing.Color.Transparent;
            this.btnPauseTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPauseTimer.ForeColor = System.Drawing.Color.White;
            this.btnPauseTimer.Location = new System.Drawing.Point(312, 351);
            this.btnPauseTimer.Name = "btnPauseTimer";
            this.btnPauseTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPauseTimer.Size = new System.Drawing.Size(70, 70);
            this.btnPauseTimer.TabIndex = 31;
            this.btnPauseTimer.Visible = false;
            this.btnPauseTimer.Click += new System.EventHandler(this.btnPauseTimer_Click);
            // 
            // btnResetTimer
            // 
            this.btnResetTimer.BackgroundImage = global::Clock.Properties.Resources.Reset;
            this.btnResetTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetTimer.FillColor = System.Drawing.Color.Transparent;
            this.btnResetTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetTimer.ForeColor = System.Drawing.Color.White;
            this.btnResetTimer.Location = new System.Drawing.Point(160, 351);
            this.btnResetTimer.Name = "btnResetTimer";
            this.btnResetTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnResetTimer.Size = new System.Drawing.Size(70, 70);
            this.btnResetTimer.TabIndex = 30;
            this.btnResetTimer.Visible = false;
            this.btnResetTimer.Click += new System.EventHandler(this.btnResetTimer_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackgroundImage = global::Clock.Properties.Resources.Continue;
            this.btnStartTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartTimer.FillColor = System.Drawing.Color.Transparent;
            this.btnStartTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Location = new System.Drawing.Point(236, 351);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStartTimer.Size = new System.Drawing.Size(70, 70);
            this.btnStartTimer.TabIndex = 28;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // numSec
            // 
            this.numSec.BackColor = System.Drawing.Color.Transparent;
            this.numSec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numSec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSec.FillColor = System.Drawing.Color.Black;
            this.numSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSec.ForeColor = System.Drawing.Color.White;
            this.numSec.Location = new System.Drawing.Point(356, 189);
            this.numSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(96, 58);
            this.numSec.TabIndex = 2;
            this.numSec.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numSec.UpDownButtonForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // numMin
            // 
            this.numMin.BackColor = System.Drawing.Color.Transparent;
            this.numMin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numMin.FillColor = System.Drawing.Color.Black;
            this.numMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMin.ForeColor = System.Drawing.Color.White;
            this.numMin.Location = new System.Drawing.Point(225, 189);
            this.numMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(96, 58);
            this.numMin.TabIndex = 1;
            this.numMin.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // numHour
            // 
            this.numHour.BackColor = System.Drawing.Color.Transparent;
            this.numHour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numHour.FillColor = System.Drawing.Color.Black;
            this.numHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHour.ForeColor = System.Drawing.Color.White;
            this.numHour.Location = new System.Drawing.Point(94, 189);
            this.numHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(96, 58);
            this.numHour.TabIndex = 0;
            this.numHour.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numHour.UpDownButtonForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // CurrentTimeScreen
            // 
            this.CurrentTimeScreen.BackColor = System.Drawing.Color.Black;
            this.CurrentTimeScreen.Controls.Add(this.lblCurrentDate);
            this.CurrentTimeScreen.Controls.Add(this.lblCurrentTime);
            this.CurrentTimeScreen.Location = new System.Drawing.Point(124, 4);
            this.CurrentTimeScreen.Name = "CurrentTimeScreen";
            this.CurrentTimeScreen.Padding = new System.Windows.Forms.Padding(3);
            this.CurrentTimeScreen.Size = new System.Drawing.Size(581, 448);
            this.CurrentTimeScreen.TabIndex = 2;
            this.CurrentTimeScreen.Text = "Current Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyTimer
            // 
            this.notifyTimer.Text = "notifyIcon1";
            this.notifyTimer.Visible = true;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(157, 95);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 52);
            this.lblCurrentTime.TabIndex = 0;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDate.Location = new System.Drawing.Point(188, 153);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentDate.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 447);
            this.Controls.Add(this.StopWatchScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clock";
            this.StopWatchScreen.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.prbTimer.ResumeLayout(false);
            this.prbTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.CurrentTimeScreen.ResumeLayout(false);
            this.CurrentTimeScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl StopWatchScreen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage CurrentTimeScreen;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2CircleButton btnStop;
        private Guna.UI2.WinForms.Guna2CircleButton btnLap;
        private Guna.UI2.WinForms.Guna2CircleButton btnContinue;
        private Guna.UI2.WinForms.Guna2CircleButton btnReset;
        private Guna.UI2.WinForms.Guna2CircleButton btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbLaps;
        private Guna.UI2.WinForms.Guna2NumericUpDown numHour;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSec;
        private Guna.UI2.WinForms.Guna2NumericUpDown numMin;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prbTimer;
        private Guna.UI2.WinForms.Guna2CircleButton btnStartTimer;
        private System.Windows.Forms.Label lblTimerWatch;
        private System.Windows.Forms.Label lblTimerTime;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2CircleButton btnPauseTimer;
        private Guna.UI2.WinForms.Guna2CircleButton btnResetTimer;
        private Guna.UI2.WinForms.Guna2CircleButton btnContinueTimer;
        private System.Windows.Forms.NotifyIcon notifyTimer;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblCurrentDate;
    }
}

