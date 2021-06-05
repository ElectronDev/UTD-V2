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
        private static WidgetFormClass widgetForm = new();
        private static readonly WidgetMoverClass widgetMoverClass = new();
        private static readonly TimeManager timeManager = new();
        private static TimeManager tM = timeManager;

        public static Form1 PrimaryForm { get; set; }
        public static WidgetMoverClass WidgetMover { get; set; } = widgetMoverClass;
        public static WidgetFormClass WidgetForm { get => widgetForm; set => widgetForm = value; }
        public static TimeManager TM { get => tM; set => tM = value; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TM.lastdate = DateTime.UtcNow;
            Application.Run(PrimaryForm = new Form1());
        }
    }
    public class TimeManager
    {
        private static Thread loopthread;
        private bool threadactive = false;
        public DateTime lastdate;
        public DateTime storeddate;
        public Dictionary<int, string> Conversions = new();
        public void Refresh()
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
            if (!Program.WidgetForm.IsDisposed && Program.WidgetForm.ColourPicker.Color != Properties.Settings.Default.WidgetBG) 
            {
                Properties.Settings.Default.WidgetBG = Program.WidgetForm.ColourPicker.Color;
                Properties.Settings.Default.Save();
            }
            MethodInvoker PMinvoke = new(delegate () {
                Program.PrimaryForm.UnixLabel.Text = unixsecs;
                Program.PrimaryForm.LocalTimeDisplay.Text = LTD;
                Program.PrimaryForm.LocalTrackBar.Value = LTB;
                Program.PrimaryForm.OffsetTimeDisplay.Text = OTD;
                Program.PrimaryForm.OffsetTrackBar.Value = OTB;
            });
            MethodInvoker WFinvoke = new(delegate () {
                Program.WidgetForm.LocalTimeDisplay.Text = LTD;
                Program.WidgetForm.BackColor = Properties.Settings.Default.WidgetBG;
                Program.WidgetForm.LocalTrackBar.Value = LTB;
                Program.WidgetForm.OffsetTimeDisplay.Text = OTD;
                Program.WidgetForm.OffsetTrackBar.Value = OTB;
            });
            if (!Program.PrimaryForm.IsDisposed && Program.PrimaryForm.Visible) { Program.PrimaryForm.Invoke(PMinvoke); }
            if (!Program.WidgetForm.IsDisposed && Program.WidgetForm.Visible) { Program.WidgetForm.Invoke(WFinvoke); }
        }
        private void Istartclock()
        {
            while (threadactive)
            {
                lastdate = DateTime.UtcNow;
                Refresh();
                Thread.Sleep(500);
            }
        }
        public void Startclock() 
        {
            threadactive = true;
            loopthread = new Thread(Istartclock);
            loopthread.Start();
        }

        public void Stopclock()
        {
            threadactive = false;
            lastdate = DateTime.UtcNow;
            storeddate = lastdate;
        }
    }
}
