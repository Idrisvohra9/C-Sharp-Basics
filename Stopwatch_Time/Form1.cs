using System;
using System.Media;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ClockApp
{
    public partial class Clock : Form
    {
        public Timer t1 = new Timer
        {
            Interval = 1000
        };
        // Global Variables:
        public static int milisecs = 1;

        public Timer t2 = new Timer
        {
            Interval = milisecs
        };

        public double StopWatch = 0.00;

        public int click = 0;



        // Clock Coding:
        public Clock()
        {
            InitializeComponent();
        }
        public void DisplayClock()
        {
            t1.Start();
            t1.Tick += T1_Tick;
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            ClockDisplay.Text = $"{DateTime.Now:HH:mm:ss tt}";
        }

        private void ClockDisplay_Paint_1(object sender, PaintEventArgs e)
        {
            DisplayClock();
        }
        // Code End..

        // Timer Coding:
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Start_SW();
            PauseBtn.Enabled = true;
        }

        void Start_SW()
        {
            t2.Start();
            t2.Tick += T2_Tick;
            StartBtn.Enabled = false;
        }
        private void T2_Tick(object sender, EventArgs e)
        {
            StopWatch += 0.01;
            SW.Text = String.Format("{0:0.00}", StopWatch);
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                t2.Stop();
                StartBtn.Enabled = true;
            }
            else
            {
                t2.Start();
            }
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            StopWatch = 0;
            SW.Text = String.Format("{0:0.00}", StopWatch);
            StartBtn.Enabled = true;
        }

        public int hour = DateTime.Now.Hour;
        public int minute = DateTime.Now.Minute;

        private void hh_Paint(object sender, PaintEventArgs e)
        {
            hh.Value = hour;
        }

        private void mm_Paint(object sender, PaintEventArgs e)
        {
            mm.Value = minute;
        }

        private void hh_ValueChanged(object sender, EventArgs e)
        {
            // This will make them auto counter:
            if (hh.Value > 23)
            {
                hh.Value = 0;
            }
            if (hh.Value < 0)
            {
                hh.Value = 23;
            }
        }

        private void mm_ValueChanged(object sender, EventArgs e)
        {
            if (mm.Value > 59)
            {
                mm.Value = 0;
            }
            if (mm.Value < 0)
            {
                mm.Value = 59;
            }
        }

        public Timer alarmTimer = new Timer()
        {
            Interval = 1000
        };
        public int totalSecs = 0;
        private void setAlarm_Click(object sender, EventArgs e)
        {
            setAlarm.Enabled = false;
            int intervalHrs = (int)(hh.Value - hour);
            int intervalMins = (int)(mm.Value - minute);

            int HrsToSecs = intervalHrs * 3600;
            int MinsToSecs = intervalMins * 60;
            totalSecs = HrsToSecs + MinsToSecs;

            if (intervalHrs < 0 || intervalMins < 0)
            {
                alarmMsg.Text = String.Format("Alarm is set for {0}hrs and {1}mins -> (next day) {2}:{3}", -0-intervalHrs, -0-intervalMins, (hour + intervalHrs), (minute + intervalMins));
            }
            else { 
            
                alarmMsg.Text = String.Format("Alarm is set for {0}hrs and {1}mins -> {2}:{3}", intervalHrs, intervalMins, (hour + intervalHrs), (minute + intervalMins));
            }

            alarmTimer.Start();
            alarmTimer.Tick += AlarmTimer_Tick;
        }
        int secs = 0;
        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            if (secs == totalSecs)
            {
                alarmMsg.Text = "The alarm!!";
                alarmTimer.Stop();
                SoundPlayer player = new SoundPlayer(@"D:\C#\Main\Stopwatch_Time\retro-city.wav");
                player.Play();
                setAlarm.Enabled = true;
            }
            else
            {
                secs++;
            }
        }

        // Code End..
    }
}
