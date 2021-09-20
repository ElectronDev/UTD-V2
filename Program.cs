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
        public static readonly string Version = "2.3.0b";
        private static WidgetFormClass widgetForm = new();
        private static readonly WidgetMoverClass WidgetMoverClass = new();
        private static CustomiserForm Cumform = new();
        private static FormattingHelp helpForm = new();
        private static TimeManager tM = new();

        public static Form1 PrimaryForm { get; set; }
        public static WidgetMoverClass WidgetMover { get; set; } = WidgetMoverClass;
        public static WidgetFormClass WidgetForm { get => widgetForm; set => widgetForm = value; }
        public static CustomiserForm CumForm { get => Cumform; set => Cumform = value; }
        public static TimeManager TM { get => tM; set => tM = value; }
        public static FormattingHelp HelpForm { get => helpForm; set => helpForm = value; }

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
        public string displayedunix;
        public DateTime lastdate;
        public DateTime storeddate;
        public Dictionary<double, string> Conversions = new();
        public void Refresh()
        {
            string formatmode;
            if (!Properties.Settings.Default.twentyfourmode) { formatmode = "ddd MMM %d | hh:mm:ss tt"; }
            else { formatmode = "ddd MMM %d | HH:mm:ss"; }
            DateTime basetime;
            DateTime offsettime;
            DateTimeOffset DT = new(lastdate);
            displayedunix = DT.ToUnixTimeSeconds().ToString();
            basetime = lastdate.AddHours(Properties.Settings.Default.BaseTimeZone);
            offsettime = lastdate.AddHours(Properties.Settings.Default.OffsetTimeZone);
            string unixsecs = "Displayed Unix Time: " + displayedunix; 
            string LTD = basetime.ToString(formatmode);
            int LTB = (int)basetime.TimeOfDay.TotalSeconds;
            string OTD = offsettime.ToString(formatmode);
            int OTB = (int)offsettime.TimeOfDay.TotalSeconds;
            if(!Program.CumForm.IsDisposed && Program.CumForm.PrimSelector.Color != Properties.Settings.Default.MainColour) 
            {
                Properties.Settings.Default.MainColour = Program.CumForm.PrimSelector.Color;
                Properties.Settings.Default.Save();
            }
            if (!Program.CumForm.IsDisposed && Program.CumForm.SecSelector.Color != Properties.Settings.Default.AccentColour)
            {
                Properties.Settings.Default.AccentColour = Program.CumForm.SecSelector.Color;
                Properties.Settings.Default.Save();
            }
            if (!Program.CumForm.IsDisposed && Program.CumForm.TC1Selector.Color != Properties.Settings.Default.DisplayTextColour)
            {
                Properties.Settings.Default.DisplayTextColour = Program.CumForm.TC1Selector.Color;
                Properties.Settings.Default.Save();
            }
            if (!Program.CumForm.IsDisposed && Program.CumForm.TC2Selector.Color != Properties.Settings.Default.TimesColour)
            {
                Properties.Settings.Default.TimesColour = Program.CumForm.TC2Selector.Color;
                Properties.Settings.Default.Save();
            }
            if (!Program.CumForm.IsDisposed && Program.CumForm.GTCSelector.Color != Properties.Settings.Default.TxtColour)
            {
                Properties.Settings.Default.TxtColour = Program.CumForm.GTCSelector.Color;
                Properties.Settings.Default.Save();
            }
            MethodInvoker PMinvoke = new(delegate () {
                Program.PrimaryForm.splitter1.BackColor = Properties.Settings.Default.AccentColour;
                Program.PrimaryForm.CurrentTimeCheckBox.ForeColor = Properties.Settings.Default.TimesColour;
                Program.PrimaryForm.BackColor = Properties.Settings.Default.MainColour;
                Program.PrimaryForm.UnixLabel.Text = unixsecs;
                Program.PrimaryForm.UnixLabel.ForeColor = Properties.Settings.Default.TimesColour;
                Program.PrimaryForm.LocalTimeDisplay.Text = LTD;
                Program.PrimaryForm.LocalTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
                Program.PrimaryForm.LocalTrackBar.Value = LTB;
                Program.PrimaryForm.OffsetTimeDisplay.Text = OTD;
                Program.PrimaryForm.OffsetTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
                Program.PrimaryForm.OffsetTrackBar.Value = OTB;
                Program.PrimaryForm.BaseDisplayText.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.PrimaryForm.OffsetDisplayText.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.PrimaryForm.LBTZ.ForeColor = Properties.Settings.Default.TxtColour;
                Program.PrimaryForm.OBTZ.ForeColor = Properties.Settings.Default.TxtColour;
                Program.PrimaryForm.LBTZ.BackColor = Properties.Settings.Default.AccentColour;
                Program.PrimaryForm.OBTZ.BackColor = Properties.Settings.Default.AccentColour;
                Program.PrimaryForm.LTZD.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.PrimaryForm.OTZD.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.PrimaryForm.Twentyfourmodecheckbox.ForeColor = Properties.Settings.Default.TxtColour;
                Program.PrimaryForm.Twentyfourmodecheckbox.BackColor = Properties.Settings.Default.AccentColour;
                Program.PrimaryForm.pictureBox1.BackColor = Properties.Settings.Default.AccentColour;
                Program.PrimaryForm.pictureBox2.BackColor = Properties.Settings.Default.AccentColour;
                Program.PrimaryForm.label1.ForeColor = Properties.Settings.Default.TxtColour;
                Program.PrimaryForm.label3.ForeColor = Properties.Settings.Default.TxtColour;
                Program.PrimaryForm.label1.BackColor = Properties.Settings.Default.AccentColour;
                Program.PrimaryForm.label3.BackColor = Properties.Settings.Default.AccentColour;
                if (!Program.PrimaryForm.CurrentTimeCheckBox.Checked) { 
                Program.PrimaryForm.BasePicker.Value = basetime;
                Program.PrimaryForm.OffsetPicker.Value = offsettime;
                }
            });
            MethodInvoker WFinvoke = new(delegate () {
                Program.WidgetForm.splitter1.BackColor = Properties.Settings.Default.AccentColour;
                Program.WidgetForm.BackColor = Properties.Settings.Default.MainColour;
                Program.WidgetForm.LocalTimeDisplay.Text = LTD;
                Program.WidgetForm.LocalTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
                Program.WidgetForm.LocalTrackBar.Value = LTB;
                Program.WidgetForm.OffsetTimeDisplay.Text = OTD;
                Program.WidgetForm.OffsetTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
                Program.WidgetForm.OffsetTrackBar.Value = OTB;
                Program.WidgetForm.BaseDisplayText.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.WidgetForm.OffsetDisplayText.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.WidgetForm.LBTZ.ForeColor = Properties.Settings.Default.TxtColour;
                Program.WidgetForm.OBTZ.ForeColor = Properties.Settings.Default.TxtColour;
                Program.WidgetForm.LBTZ.BackColor = Properties.Settings.Default.AccentColour;
                Program.WidgetForm.OBTZ.BackColor = Properties.Settings.Default.AccentColour;
            });
            MethodInvoker CFinvoke = new(delegate () {
                Program.CumForm.Prim.ForeColor = Properties.Settings.Default.MainColour;
                Program.CumForm.Sec.ForeColor = Properties.Settings.Default.AccentColour;
                Program.CumForm.TC1.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.CumForm.TC2.ForeColor = Properties.Settings.Default.TimesColour;
                Program.CumForm.Gen.ForeColor = Properties.Settings.Default.TxtColour;
            });
            MethodInvoker FHinvoke = new(delegate ()
            {
                Program.HelpForm.BackColor = Properties.Settings.Default.MainColour;
                Program.HelpForm.label1.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.HelpForm.label2.ForeColor = Properties.Settings.Default.AccentColour;
                Program.HelpForm.label3.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.HelpForm.label4.ForeColor = Properties.Settings.Default.DisplayTextColour;
                Program.HelpForm.label5.ForeColor = Properties.Settings.Default.DisplayTextColour;
            });
            if (!Program.PrimaryForm.IsDisposed && Program.PrimaryForm.Visible) { Program.PrimaryForm.Invoke(PMinvoke); }
            if (!Program.WidgetForm.IsDisposed && Program.WidgetForm.Visible) { Program.WidgetForm.Invoke(WFinvoke); }
            if (!Program.CumForm.IsDisposed && Program.CumForm.Visible) { Program.CumForm.Invoke(CFinvoke); }
            if (!Program.HelpForm.IsDisposed && Program.HelpForm.Visible) { Program.HelpForm.Invoke(FHinvoke); }
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
