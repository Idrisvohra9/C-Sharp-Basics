
namespace ClockApp
{
    partial class Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.Main = new System.Windows.Forms.TabControl();
            this.timeClock = new System.Windows.Forms.TabPage();
            this.ClockDisplay = new System.Windows.Forms.Label();
            this.Stopwatch = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SW = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.alarmMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hh = new System.Windows.Forms.NumericUpDown();
            this.mm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.setAlarm = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            this.timeClock.SuspendLayout();
            this.Stopwatch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.timeClock);
            this.Main.Controls.Add(this.Stopwatch);
            this.Main.Controls.Add(this.tabPage1);
            this.Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.HotTrack = true;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Multiline = true;
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(1178, 744);
            this.Main.TabIndex = 0;
            // 
            // timeClock
            // 
            this.timeClock.BackColor = System.Drawing.Color.Black;
            this.timeClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeClock.Controls.Add(this.ClockDisplay);
            this.timeClock.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeClock.Location = new System.Drawing.Point(4, 60);
            this.timeClock.Name = "timeClock";
            this.timeClock.Padding = new System.Windows.Forms.Padding(3);
            this.timeClock.Size = new System.Drawing.Size(1170, 680);
            this.timeClock.TabIndex = 0;
            this.timeClock.Text = "Clock";
            // 
            // ClockDisplay
            // 
            this.ClockDisplay.AutoSize = true;
            this.ClockDisplay.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockDisplay.Location = new System.Drawing.Point(488, 266);
            this.ClockDisplay.Name = "ClockDisplay";
            this.ClockDisplay.Size = new System.Drawing.Size(213, 85);
            this.ClockDisplay.TabIndex = 0;
            this.ClockDisplay.Text = "Clock";
            this.ClockDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.ClockDisplay_Paint_1);
            // 
            // Stopwatch
            // 
            this.Stopwatch.BackColor = System.Drawing.Color.Black;
            this.Stopwatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Stopwatch.Controls.Add(this.tableLayoutPanel1);
            this.Stopwatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stopwatch.Location = new System.Drawing.Point(4, 60);
            this.Stopwatch.Name = "Stopwatch";
            this.Stopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.Stopwatch.Size = new System.Drawing.Size(1170, 680);
            this.Stopwatch.TabIndex = 1;
            this.Stopwatch.Text = "Stopwatch";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.36634F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.63366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Controls.Add(this.SW, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RestartBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PauseBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.StartBtn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(214, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SW
            // 
            this.SW.AutoSize = true;
            this.SW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SW.Font = new System.Drawing.Font("Segoe Script", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SW.Location = new System.Drawing.Point(221, 0);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(279, 199);
            this.SW.TabIndex = 0;
            this.SW.Text = "0.00";
            this.SW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.Indigo;
            this.RestartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartBtn.Location = new System.Drawing.Point(3, 202);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(212, 194);
            this.RestartBtn.TabIndex = 1;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.Indigo;
            this.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PauseBtn.Location = new System.Drawing.Point(506, 202);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(249, 194);
            this.PauseBtn.TabIndex = 2;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Purple;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBtn.Location = new System.Drawing.Point(221, 202);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(279, 194);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.alarmMsg);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.hh);
            this.tabPage1.Controls.Add(this.mm);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.setAlarm);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 60);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1170, 680);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Alarm";
            // 
            // alarmMsg
            // 
            this.alarmMsg.AutoSize = true;
            this.alarmMsg.Location = new System.Drawing.Point(380, 555);
            this.alarmMsg.Name = "alarmMsg";
            this.alarmMsg.Size = new System.Drawing.Size(0, 51);
            this.alarmMsg.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(461, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 64);
            this.label3.TabIndex = 7;
            // 
            // hh
            // 
            this.hh.BackColor = System.Drawing.Color.Black;
            this.hh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hh.ForeColor = System.Drawing.Color.DarkBlue;
            this.hh.Location = new System.Drawing.Point(352, 240);
            this.hh.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(188, 94);
            this.hh.TabIndex = 4;
            this.hh.Tag = "hour";
            this.hh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hh.ValueChanged += new System.EventHandler(this.hh_ValueChanged);
            this.hh.Paint += new System.Windows.Forms.PaintEventHandler(this.hh_Paint);
            // 
            // mm
            // 
            this.mm.BackColor = System.Drawing.Color.Black;
            this.mm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mm.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mm.ForeColor = System.Drawing.Color.DarkBlue;
            this.mm.Location = new System.Drawing.Point(602, 240);
            this.mm.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(188, 94);
            this.mm.TabIndex = 5;
            this.mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mm.ValueChanged += new System.EventHandler(this.mm_ValueChanged);
            this.mm.Paint += new System.Windows.Forms.PaintEventHandler(this.mm_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(546, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 127);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // setAlarm
            // 
            this.setAlarm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.setAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setAlarm.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.setAlarm.ForeColor = System.Drawing.Color.Snow;
            this.setAlarm.Location = new System.Drawing.Point(476, 429);
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.Size = new System.Drawing.Size(188, 90);
            this.setAlarm.TabIndex = 2;
            this.setAlarm.Text = "Set Alarm";
            this.setAlarm.UseVisualStyleBackColor = false;
            this.setAlarm.Click += new System.EventHandler(this.setAlarm_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.6187561F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.37319F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(87, 162);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(0, 96);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 32F);
            this.label1.Location = new System.Drawing.Point(335, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a time:";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.Main);
            this.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clock";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Main.ResumeLayout(false);
            this.timeClock.ResumeLayout(false);
            this.timeClock.PerformLayout();
            this.Stopwatch.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage timeClock;
        private System.Windows.Forms.TabPage Stopwatch;
        public System.Windows.Forms.Label ClockDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label SW;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hh;
        private System.Windows.Forms.NumericUpDown mm;
        private System.Windows.Forms.Button setAlarm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label alarmMsg;
    }
}

