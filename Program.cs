using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace TimeThing
{
    public class DiscordSys {
        public Discord.Discord discord;
        public void Setup()
        {
            try {
            discord = new(869621858016829561, (UInt64)Discord.CreateFlags.NoRequireDiscord);
            }
            catch
            {
                Program.Discordstatus = "Discord Intergration Status: Error";
            }
        }
        public Discord.Activity activity = new()
        {
            Assets =
            {
                LargeImage = "utd_logo1by1",
                LargeText = $"UTD - Version: {Program.Version}",
                SmallImage = "dev-icon",
                SmallText = "Made by ElectronDevDude on github!",
            },
            Instance = false,
        };
        public void RunActivityUpdates(DateTime currenttime) 
        {
            if (Program.DS.discord == null)
            {
                return;
            }
            string timeformatmode = "hh:mm tt";
            DateTime basetime;
            basetime = currenttime.AddHours(Properties.Settings.Default.BaseTimeZone);
            if (Properties.Settings.Default.twentyfourmode) { timeformatmode = "HH:mm"; }
            Program.DS.activity.State = $"Time: {basetime.ToString(timeformatmode)} | Date: {basetime:ddd MMM % d}";
            Program.DS.activity.Details = $"Current Timezone: UTC {Properties.Settings.Default.BaseTimeZone}";
            Program.DS.discord.GetActivityManager().UpdateActivity(Program.DS.activity, result =>
            {
                if (result == Discord.Result.Ok)
                {
                    Program.Discordstatus = "Discord Intergration Status: Operational";
                }
                else if (result != Discord.Result.TransactionAborted)
                {
                    Program.Discordstatus = "Discord Intergration Status: " + result.ToString();
                }
            }

        );
        }
        
    }
    public static class Program
    {
        public const string DiscordDLLDir = "c:\\UTD\\dgsdk.dll";
        public static readonly string Version = "2.3.0";
        private static string discordstatus = "Discord Intergration Status: Off";
        private static WidgetFormClass widgetForm = new();
        private static readonly WidgetMoverClass WidgetMoverClass = new();
        private static CustomiserForm Cumform = new();
        private static FormattingHelp helpForm = new();
        private static TimeManager tM = new();
        private static DiscordSys dS;

        public static Form1 PrimaryForm { get; set; }
        public static WidgetMoverClass WidgetMover { get; set; } = WidgetMoverClass;
        public static WidgetFormClass WidgetForm { get => widgetForm; set => widgetForm = value; }
        public static CustomiserForm CumForm { get => Cumform; set => Cumform = value; }
        public static TimeManager TM { get => tM; set => tM = value; }
        public static FormattingHelp HelpForm { get => helpForm; set => helpForm = value; }
        public static string Discordstatus { get => discordstatus; set => discordstatus = value; }
        public static DiscordSys DS { get => dS; set => dS = value; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!System.IO.File.Exists(DiscordDLLDir)) 
            {
                if (!System.IO.Directory.Exists("c:\\UTD"))
                { System.IO.Directory.CreateDirectory("c:\\UTD"); }
                System.IO.File.WriteAllBytes(DiscordDLLDir, Properties.Resources.discord_game_sdk);
            }
            TM.lastdate = DateTime.UtcNow;
            Application.Run(PrimaryForm = new Form1());

        }
    }

    public class TimeManager
    {
        private static Thread loopthread;
        private static Thread discordloopthread;
        private static Thread mainLoopThread;
        private bool threadactive = false;
        public bool discordthreadactive = false;
        private bool mainLoopActive = false;
        private int prevmin = -1;
        public string displayedunix;
        public DateTime lastdate;
        public DateTime storeddate;
        public Dictionary<double, string> Conversions = new();
        public void DiscordClock()
        {
        while (discordthreadactive)
            {
                DateTime currenttime = DateTime.UtcNow;
                if (prevmin != currenttime.Minute)
                {
                    prevmin = currenttime.Minute;
                    Program.DS.RunActivityUpdates(currenttime);
                    
                }
                Thread.Sleep(1000);
            }
        }


        public void MainRefresh()
        {
            while (mainLoopActive)
            {
                if (!Program.CumForm.IsDisposed && Program.CumForm.loaded && Program.CumForm.PrimSelector.Color != Properties.Settings.Default.MainColour)
                {
                    Properties.Settings.Default.MainColour = Program.CumForm.PrimSelector.Color;
                    Properties.Settings.Default.Save();
                }
                if (!Program.CumForm.IsDisposed && Program.CumForm.loaded && Program.CumForm.SecSelector.Color != Properties.Settings.Default.AccentColour)
                {
                    Properties.Settings.Default.AccentColour = Program.CumForm.SecSelector.Color;
                    Properties.Settings.Default.Save();
                }
                if (!Program.CumForm.IsDisposed && Program.CumForm.loaded && Program.CumForm.TC1Selector.Color != Properties.Settings.Default.DisplayTextColour)
                {
                    Properties.Settings.Default.DisplayTextColour = Program.CumForm.TC1Selector.Color;
                    Properties.Settings.Default.Save();
                }
                if (!Program.CumForm.IsDisposed && Program.CumForm.loaded && Program.CumForm.TC2Selector.Color != Properties.Settings.Default.TimesColour)
                {
                    Properties.Settings.Default.TimesColour = Program.CumForm.TC2Selector.Color;
                    Properties.Settings.Default.Save();
                }
                if (!Program.CumForm.IsDisposed && Program.CumForm.loaded && Program.CumForm.GTCSelector.Color != Properties.Settings.Default.TxtColour)
                {
                    Properties.Settings.Default.TxtColour = Program.CumForm.GTCSelector.Color;
                    Properties.Settings.Default.Save();
                }
                MethodInvoker CFinvoke = new(delegate ()
                {
                    Program.CumForm.Prim.ForeColor = Properties.Settings.Default.MainColour;
                    Program.CumForm.Sec.ForeColor = Properties.Settings.Default.AccentColour;
                    Program.CumForm.TC1.ForeColor = Properties.Settings.Default.DisplayTextColour;
                    Program.CumForm.TC2.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.CumForm.Gen.ForeColor = Properties.Settings.Default.TxtColour;
                    Program.CumForm.DiscordIntergrationStatus.Text = Program.Discordstatus;
                });
                MethodInvoker PMinvoke = new(delegate ()
                {
                    Program.PrimaryForm.splitter1.BackColor = Properties.Settings.Default.AccentColour;
                    Program.PrimaryForm.CurrentTimeCheckBox.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.PrimaryForm.BackColor = Properties.Settings.Default.MainColour;
                    Program.PrimaryForm.UnixLabel.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.PrimaryForm.LocalTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.PrimaryForm.OffsetTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
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
                    Program.PrimaryForm.label3.ForeColor = Properties.Settings.Default.TxtColour;
                    Program.PrimaryForm.label3.BackColor = Properties.Settings.Default.AccentColour;
                });
                MethodInvoker FHinvoke = new(delegate ()
                {
                    Program.HelpForm.BackColor = Properties.Settings.Default.MainColour;
                    Program.HelpForm.label1.ForeColor = Properties.Settings.Default.DisplayTextColour;
                    Program.HelpForm.label2.ForeColor = Properties.Settings.Default.AccentColour;
                    Program.HelpForm.label3.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.HelpForm.label4.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.HelpForm.label5.ForeColor = Properties.Settings.Default.TimesColour;
                });
                MethodInvoker WFinvoke = new(delegate ()
                {
                    Program.WidgetForm.splitter1.BackColor = Properties.Settings.Default.AccentColour;
                    Program.WidgetForm.BackColor = Properties.Settings.Default.MainColour;
                    Program.WidgetForm.LocalTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.WidgetForm.OffsetTimeDisplay.ForeColor = Properties.Settings.Default.TimesColour;
                    Program.WidgetForm.BaseDisplayText.ForeColor = Properties.Settings.Default.DisplayTextColour;
                    Program.WidgetForm.OffsetDisplayText.ForeColor = Properties.Settings.Default.DisplayTextColour;
                    Program.WidgetForm.LBTZ.ForeColor = Properties.Settings.Default.TxtColour;
                    Program.WidgetForm.OBTZ.ForeColor = Properties.Settings.Default.TxtColour;
                    Program.WidgetForm.LBTZ.BackColor = Properties.Settings.Default.AccentColour;
                    Program.WidgetForm.OBTZ.BackColor = Properties.Settings.Default.AccentColour;
                });
                if (discordthreadactive == true)
                {
                    try {
                    Program.DS.discord.RunCallbacks();
                    }
                    catch
                    {
                        Program.Discordstatus = "Discord Intergration Status: Error running Callbacks";
                    }
                }
                try
                {
                    if (!Program.CumForm.IsDisposed && Program.CumForm.Visible) { Program.CumForm.Invoke(CFinvoke); }
                    if (!Program.PrimaryForm.IsDisposed && Program.PrimaryForm.Visible) { Program.PrimaryForm.Invoke(PMinvoke); }
                    if (!Program.HelpForm.IsDisposed && Program.HelpForm.Visible) { Program.HelpForm.Invoke(FHinvoke); }
                    if (!Program.WidgetForm.IsDisposed && Program.WidgetForm.Visible) { Program.WidgetForm.Invoke(WFinvoke); }
                    Thread.Sleep(500);
                }
                catch (System.ObjectDisposedException) { }
            }
        }

        public void TimeRefresh()
        {
            string formatmode;
            if (!Properties.Settings.Default.twentyfourmode) { formatmode = "ddd MMM %d | hh:mm:ss tt"; }
            else { formatmode = "ddd MMM %d | HH:mm:ss"; }
            DateTime basetime;
            DateTime offsettime;
            DateTimeOffset DT= new(lastdate);
            displayedunix = DT.ToUnixTimeSeconds().ToString();
            basetime = lastdate.AddHours(Properties.Settings.Default.BaseTimeZone);
            offsettime = lastdate.AddHours(Properties.Settings.Default.OffsetTimeZone);
            string unixsecs = "Displayed Unix Time: " + displayedunix; 
            string LTD = basetime.ToString(formatmode);
            int LTB = (int)basetime.TimeOfDay.TotalSeconds;
            string OTD = offsettime.ToString(formatmode);
            int OTB = (int)offsettime.TimeOfDay.TotalSeconds;

            MethodInvoker PMinvoke = new(delegate () {
                Program.PrimaryForm.UnixLabel.Text = unixsecs;
                Program.PrimaryForm.LocalTimeDisplay.Text = LTD;
                Program.PrimaryForm.LocalTrackBar.Value = LTB;
                Program.PrimaryForm.OffsetTimeDisplay.Text = OTD;
                Program.PrimaryForm.OffsetTrackBar.Value = OTB;
                if (!Program.PrimaryForm.CurrentTimeCheckBox.Checked) { 
                Program.PrimaryForm.BasePicker.Value = basetime;
                Program.PrimaryForm.OffsetPicker.Value = offsettime;
                }
            });
            MethodInvoker WFinvoke = new(delegate () {
                Program.WidgetForm.LocalTimeDisplay.Text = LTD;
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
                TimeRefresh();
                Thread.Sleep(500);
            }
        }
        public void StartTimeclock() 
        {
            threadactive = true;
            loopthread = new Thread(Istartclock);
            loopthread.Start();
        }
        public void StartDiscordClock()
        {
            Program.DS = new();
            Program.DS.Setup();
            discordthreadactive = true;
            discordloopthread = new Thread(DiscordClock);
            discordloopthread.Start();
        }
        public void StartMainLoop()
        {
            mainLoopActive = true;
            mainLoopThread = new Thread(MainRefresh);
            mainLoopThread.Start();
        }
        public void StopTimeclock()
        {
            threadactive = false;
            lastdate = DateTime.UtcNow;
            storeddate = lastdate;
        }
        public void StopDiscordClock()
        {
            discordthreadactive = false;
            prevmin = -1;
            try {
            Program.DS.discord.Dispose();
            }
            catch {}
        }
        public void StopMainLoop()
        {
            mainLoopActive = false;
        }
    }
}
