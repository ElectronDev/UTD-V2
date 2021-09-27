using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace TimeThing
{
    public partial class CustomiserForm : Form
    {
        private readonly int[] CustomColours = new int[] { 3348992, 7877120, 12632256, 11382468, 11184810, 0xFFFFFF, 0xFFFFFF, 0xFFFFFF, 11909845, 6835543, 3498451, 7572842, 14075539 };
        private readonly List<string> dateformats = new() { "No Formatting", "dd/MM/yyyy", "dd MMMM yyyy", "HH:mm", "HH:mm:ss", "dd MMMM yyyy HH:mm", "dddd, dd MMMM yyyy HH:mm" };
        public bool loaded = false;
        public CustomiserForm()
        {
            InitializeComponent();
            Shown += CustomiserForm_Shown;
        }
        private void CustomiserForm_Shown(object sender, EventArgs e)
        {
            PrimSelector.Color = Properties.Settings.Default.MainColour;
            SecSelector.Color = Properties.Settings.Default.AccentColour;
            TC1Selector.Color = Properties.Settings.Default.TimesColour;
            TC2Selector.Color = Properties.Settings.Default.TxtColour;
            GTCSelector.Color = Properties.Settings.Default.DisplayTextColour;
            loaded = true;
            FormatBox.SelectedIndex = dateformats.IndexOf(Properties.Settings.Default.UnixFormat);
            Autorun.Checked = Properties.Settings.Default.AutoRun;
            MinimizeBox.Checked = Properties.Settings.Default.SystemTray;
            DiscordIntergrationStatus.Text = Program.Discordstatus;
        }
            private void PrimBtn_Click(object sender, EventArgs e)
        {
            PrimSelector.CustomColors = CustomColours;
            PrimSelector.ShowDialog();
        }

        private void SecBtn_Click(object sender, EventArgs e)
        {
            SecSelector.CustomColors = CustomColours;
            SecSelector.ShowDialog();
        }

        private void TC1Btn_Click(object sender, EventArgs e)
        {
            TC1Selector.CustomColors = CustomColours;
            TC1Selector.ShowDialog();
        }

        private void TC2Btn_Click(object sender, EventArgs e)
        {
            TC2Selector.CustomColors = CustomColours;
            TC2Selector.ShowDialog();
        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            GTCSelector.CustomColors = CustomColours;
            GTCSelector.ShowDialog();
        }

        private void FormatBox_ValueChanged(object sender, EventArgs e)
        {
            if (((string)FormatBox.Text != Properties.Settings.Default.UnixFormat) && dateformats.Contains((string)FormatBox.Text))
            {
                Properties.Settings.Default.UnixFormat = dateformats[FormatBox.SelectedIndex];
                Properties.Settings.Default.Save();
            }
            if (!dateformats.Contains((string)FormatBox.SelectedItem))
            {
                FormatBox.SelectedIndex = dateformats.IndexOf(Properties.Settings.Default.UnixFormat);
            }
        }

        private void FormattingHelp_Click(object sender, EventArgs e)
        {
            Program.HelpForm = new FormattingHelp();
            Program.HelpForm.Show();
        }

        private void Autorun_CheckedChanged(object sender, EventArgs e)
        {
            if (Autorun.Checked)
            {
            Properties.Settings.Default.AutoRun = true;
            WshShell wsh = new();
            IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\PS.lnk");
            shortcut.Description = "Autorun shortcut for UTD";
            shortcut.TargetPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            shortcut.Save();
            }
            else
            {
                try
                {
                    Properties.Settings.Default.AutoRun = false;
                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\PS.lnk");
                }
                catch {}
            }
            Properties.Settings.Default.Save();
        }

        private void DiscordIntToggle_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Discord)
            {
                Properties.Settings.Default.Discord = false;
                Program.Discordstatus = "Discord Intergration Status: Off";
                Program.TM.StopDiscordClock();
            }
            else
            {
                Properties.Settings.Default.Discord = true;
                if (!Program.TM.discordthreadactive) {
                Program.Discordstatus = "Discord Intergration Status: Starting";
                Program.TM.StartDiscordClock();
                }
            }
            Properties.Settings.Default.Save();
        }

        private void MinimizeBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SystemTray = MinimizeBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
