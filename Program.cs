using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeThing
{
    public static class Program
    {
        public static Form1 PrimaryForm;
        public static TimeManager TM = new TimeManager();
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(PrimaryForm = new Form1());
        }
    }
    public class TimeManager
    {
        private static Thread loopthread;
        private bool threadactive = false;
        public DateTime lastdate;
        public DateTime storeddate;
        public Dictionary<int, string> Conversions = new Dictionary<int, string>();
        public void refresh()
        {
            string formatmode;
            if (!Properties.Settings.Default.twentyfourmode) { formatmode = "ddd MMM %d | hh:mm:ss tt"; }
            else { formatmode = "ddd MMM %d | HH:mm:ss"; }
            string unixsecs = ("Current Unix Time: " + DateTimeOffset.UtcNow.ToUnixTimeSeconds());
            DateTime basetime;
            DateTime offsettime;
            basetime = lastdate.AddHours(Properties.Settings.Default.BaseTimeZone);
            offsettime = lastdate.AddHours(Properties.Settings.Default.OffsetTimeZone);
            string LTD = basetime.ToString(formatmode);
            int LTB = (int)basetime.TimeOfDay.TotalSeconds;
            string OTD = offsettime.ToString(formatmode);
            int OTB = (int)offsettime.TimeOfDay.TotalSeconds;
            MethodInvoker getValues = new MethodInvoker(delegate () {
                Program.PrimaryForm.UnixLabel.Text = unixsecs;
                Program.PrimaryForm.LocalTimeDisplay.Text = LTD;
                Program.PrimaryForm.LocalTrackBar.Value = LTB;
                Program.PrimaryForm.OffsetTimeDisplay.Text = OTD;
                Program.PrimaryForm.OffsetTrackBar.Value = OTB;
            });
            Program.PrimaryForm.Invoke(getValues);
        }
        private void istartclock()
        {
            while (threadactive)
            {
                lastdate = DateTime.UtcNow;
                refresh();
                Thread.Sleep(500);
            }
        }
        public void startclock() 
        {
            threadactive = true;
            loopthread = new Thread(istartclock);
            loopthread.Start();
        }

        public void stopclock()
        {
            threadactive = false;
            lastdate = DateTime.UtcNow;
            storeddate = lastdate;
        }
    }
}
