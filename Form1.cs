using System;
using System.Windows.Forms;
namespace TimeThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Twentyfourmodecheckbox.Checked = Properties.Settings.Default.twentyfourmode;
            Program.TM.Conversions.Add(0, "GMT, IBST, WET, Z, EGST");
            Program.TM.Conversions.Add(1, "BST, CET, DFT, IST, MET, WAT, WEDT, WEST");
            Program.TM.Conversions.Add(2, "CAT, CEDT, CEST, EET, HAEC, IST Israel, MEST, SAST, USZ1, WAST");
            Program.TM.Conversions.Add(3, "AST Arabia, EAT, EEDT, EEST, FET, IDT, IOT, MSK, SYOT");
            Program.TM.Conversions.Add(4, "AMT Armenia, AZT, GET, GST Gulf, MUT, RET, SAMT, SCT, VOLT");
            Program.TM.Conversions.Add(5, "HMT, MAWT, MVT, ORAT, PKT, TFT, TJT, TMT, UZT, YEKT");
            Program.TM.Conversions.Add(6, "BDT Bangladesh, BIOT, BST Bangladesh, BTT, KGT, OMST, VOST");
            Program.TM.Conversions.Add(7, "CXT, DAVT, HOVT, ICT, KRAT, THA, WIT");
            Program.TM.Conversions.Add(8, "ACT, AWST, BDT, CHOT, CIT, CST China, CT, HKT, IRKT, MYT, PST Philippine, SGT, SST, ULAT, WST");
            Program.TM.Conversions.Add(9, "AWDT, EIT, JST, KST, TLT, YAKT");
            Program.TM.Conversions.Add(10, "ChST, CHUT, DDUT, EST Australia, PGT, VLAT");
            Program.TM.Conversions.Add(11, "AEDT, BST Bougainville, KOST, LHST, MIST, NCT, PONT, SAKT, SBT, SRET, VUT, NFT");
            Program.TM.Conversions.Add(12, "FJT, GILT, MAGT, MHT, NZST, PETT, TBT, WAKT");
            Program.TM.Conversions.Add(13, "NZDT, PHOT, TKT, TOT");
            Program.TM.Conversions.Add(14, "LINT");
            Program.TM.Conversions.Add(-1, "AZOST, CVT, EGT");
            Program.TM.Conversions.Add(-2, "BRST, FNT, GST, PMDT, UYST");
            Program.TM.Conversions.Add(-3, "ADT, AMST, ART, BRT, CLST, FKST, FKST Summer, GFT, PMST, PYST, ROTT, SRT, UYT");
            Program.TM.Conversions.Add(-4, "AMT, AST, BOT, CDT Cuba, CLT, COST, ECT, EDT, FKT, GYT, PYT");
            Program.TM.Conversions.Add(-5, "ACT Acre, CDT, COT, CST Cuba, EASST, ECT Ecuador, EST, PET");
            Program.TM.Conversions.Add(-6, "CST, EAST, GALT, MDT");
            Program.TM.Conversions.Add(-7, "MST, PDT");
            Program.TM.Conversions.Add(-8, "AKDT, CIST, PST");
            Program.TM.Conversions.Add(-9, "AKST, GAMT, GIT, HADT");
            Program.TM.Conversions.Add(-10, "CKT, HAST, HST, TAHT");
            Program.TM.Conversions.Add(-11, "NUT, SST Samoa");
            Program.TM.Conversions.Add(-12, "BIT");
            LBTZ.Text = "Base Timezone: " + Properties.Settings.Default.BaseTimeZone.ToString() + " UTC";
            OBTZ.Text = "Offset Timezone: " + Properties.Settings.Default.OffsetTimeZone.ToString() + " UTC";
            LTZD.Text = Program.TM.Conversions[Properties.Settings.Default.BaseTimeZone];
            OTZD.Text = Program.TM.Conversions[Properties.Settings.Default.OffsetTimeZone];
            Program.TM.Startclock();
        }


        private void CurrentTime_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentTimeCheckBox.Checked)
            {
                UnixLabel.Visible = true;
                OffsetTrackBar.Enabled = false;
                LocalTrackBar.Enabled = false;
                ResetButton.Visible = false;
                WidgetOpen.Visible = true;
                Program.TM.Startclock();
            }
            else {
                UnixLabel.Visible = false;
                OffsetTrackBar.Enabled = true;
                LocalTrackBar.Enabled = true;
                ResetButton.Visible = true;
                WidgetOpen.Visible = false;
                Program.TM.Stopclock();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.TM.Stopclock();
            if (!Program.WidgetForm.IsDisposed) { Program.WidgetForm.Dispose(); }
            if (!Program.WidgetMover.IsDisposed) { Program.WidgetMover.Dispose(); }
            Program.PrimaryForm.Dispose();
        }

        private void Twentyfourmode_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.twentyfourmode = Twentyfourmodecheckbox.Checked;
            Properties.Settings.Default.Save();
            Program.TM.Refresh();
        }

        private void LocalTrackBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            Program.TM.lastdate = Program.TM.lastdate.Date.AddHours(Properties.Settings.Default.BaseTimeZone*-1).AddSeconds(LocalTrackBar.Value);
            Program.TM.Refresh();
        }
        private void OffsetTrackBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            Program.TM.lastdate = Program.TM.lastdate.Date.AddHours(Properties.Settings.Default.OffsetTimeZone * -1).AddSeconds(OffsetTrackBar.Value);
            Program.TM.Refresh();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Program.TM.lastdate = Program.TM.storeddate;
            Program.TM.Refresh();
        }


        private void BaseAddBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BaseTimeZone += 1;
            LBTZ.Text = "Base Timezone: " + Properties.Settings.Default.BaseTimeZone.ToString() + " UTC";
            LTZD.Text = Program.TM.Conversions[Properties.Settings.Default.BaseTimeZone];
            if (Properties.Settings.Default.BaseTimeZone >= 14) { BaseAddBtn.Enabled = false; }
            Properties.Settings.Default.Save();
            BaseSubBtn.Enabled = true;
            if (!CurrentTimeCheckBox.Checked) { Program.TM.Refresh(); }
        }

        private void BaseSubBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BaseTimeZone -= 1;
            LBTZ.Text = "Base Timezone: " + Properties.Settings.Default.BaseTimeZone.ToString() + " UTC";
            LTZD.Text = Program.TM.Conversions[Properties.Settings.Default.BaseTimeZone];
            if (Properties.Settings.Default.BaseTimeZone <= -12) { BaseSubBtn.Enabled = false; }
            Properties.Settings.Default.Save();
            BaseAddBtn.Enabled = true;
            if (!CurrentTimeCheckBox.Checked) { Program.TM.Refresh(); }
        }

        private void OffsetAddBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OffsetTimeZone += 1;
            OBTZ.Text = "Offset Timezone: " + Properties.Settings.Default.OffsetTimeZone.ToString() + " UTC";
            OTZD.Text = Program.TM.Conversions[Properties.Settings.Default.OffsetTimeZone];
            if (Properties.Settings.Default.OffsetTimeZone >= 14) { OffsetAddBtn.Enabled = false; }
            Properties.Settings.Default.Save();
            OffsetSubBtn.Enabled = true;
            if (!CurrentTimeCheckBox.Checked) { Program.TM.Refresh(); }
        }

        private void OffsetSubBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OffsetTimeZone -= 1;
            OBTZ.Text = "Offset Timezone: " + Properties.Settings.Default.OffsetTimeZone.ToString() + " UTC";
            OTZD.Text = Program.TM.Conversions[Properties.Settings.Default.OffsetTimeZone];
            if (Properties.Settings.Default.OffsetTimeZone <= -12) { OffsetSubBtn.Enabled = false; }
            Properties.Settings.Default.Save();
            OffsetAddBtn.Enabled = true;
            if (!CurrentTimeCheckBox.Checked) { Program.TM.Refresh(); }
        }

        private void ProgramName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://github.com/ElectronDevDude/UTD-V2") { UseShellExecute = true });
        }

        private void Copyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://github.com/ElectronDevDude/UTD-V2/blob/master/LICENSE") { UseShellExecute = true });
        }

        private void WidgetOpen_Click(object sender, EventArgs e)
        {
            Program.PrimaryForm.Hide();
            Program.WidgetForm = new WidgetFormClass();
            Program.WidgetForm.Show();
        }
    }
}
