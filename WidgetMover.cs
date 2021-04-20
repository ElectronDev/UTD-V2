using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeThing
{
    public partial class WidgetMoverClass : Form
    {
        public WidgetMoverClass()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WidgetPos == "TL")
            {
                TL.Enabled = false;
            }
            if (Properties.Settings.Default.WidgetPos == "TR")
            {
                TR.Enabled = false;
            }
            if (Properties.Settings.Default.WidgetPos == "BL")
            {
                BL.Enabled = false;
            }
            if (Properties.Settings.Default.WidgetPos == "BR")
            {
                BR.Enabled = false;
            }
        }
            private void TL_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WidgetPos = "TL";
            Properties.Settings.Default.Save();
            FreeButton.Enabled = true;
            FreeMoveLock.Checked = false;
            FreeMoveLock.Enabled = false;
            TL.Enabled = false;
            TR.Enabled = true;
            BL.Enabled = true;
            BR.Enabled = true;
            Program.WidgetForm.RestorePos();
        }

        private void TR_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WidgetPos = "TR";
            Properties.Settings.Default.Save();
            FreeButton.Enabled = true;
            FreeMoveLock.Checked = false;
            FreeMoveLock.Enabled = false;
            TL.Enabled = true;
            TR.Enabled = false;
            BL.Enabled = true;
            BR.Enabled = true;
            Program.WidgetForm.RestorePos();
        }

        private void BL_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WidgetPos = "BL";
            Properties.Settings.Default.Save();
            FreeButton.Enabled = true;
            FreeMoveLock.Checked = false;
            FreeMoveLock.Enabled = false;
            TL.Enabled = true;
            TR.Enabled = true;
            BL.Enabled = false;
            BR.Enabled = true;
            Program.WidgetForm.RestorePos();
        }

        private void BR_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WidgetPos = "BR";
            Properties.Settings.Default.Save();
            FreeButton.Enabled = true;
            FreeMoveLock.Checked = false;
            FreeMoveLock.Enabled = false;
            TL.Enabled = true;
            TR.Enabled = true;
            BL.Enabled = true;
            BR.Enabled = false;
            Program.WidgetForm.RestorePos();
        }

        private void FreeButton_Click(object sender, EventArgs e)
        {
            FreeButton.Enabled = false;
            FreeMoveLock.Enabled = true;
            FreeMoveLock.Checked = true;
            TL.Enabled = true;
            TR.Enabled = true;
            BL.Enabled = true;
            BR.Enabled = true;
        }

        private void FreeMoveLock_CheckedChanged(object sender, EventArgs e)
        {
            if (FreeMoveLock.Checked)
            {
                Program.WidgetForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                Program.WidgetForm.FormBorderStyle = FormBorderStyle.None;
            }
        }
    }
}
