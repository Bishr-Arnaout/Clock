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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopWatchScreen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopWatchScreen
            // 
            this.StopWatchScreen.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.StopWatchScreen.Controls.Add(this.tabPage1);
            this.StopWatchScreen.Controls.Add(this.tabPage2);
            this.StopWatchScreen.Controls.Add(this.tabPage3);
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
            this.tabPage2.Location = new System.Drawing.Point(124, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(124, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Current Time";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl StopWatchScreen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
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
    }
}

