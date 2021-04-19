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
    public partial class WidgetFormClass : Form
    {
        public WidgetFormClass()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            RestorePos();
            LBTZ.Text = "Base Timezone: " + Properties.Settings.Default.BaseTimeZone.ToString() + " UTC";
            OBTZ.Text = "Offset Timezone: " + Properties.Settings.Default.OffsetTimeZone.ToString() + " UTC";
        }
            private void Form1_MouseHover(object sender, EventArgs e)
        {
            Screen myscreen = Screen.FromControl(Program.WidgetForm);
            Rectangle area = myscreen.WorkingArea;
            splitter1.Visible=true;
            ReturnBtn.Visible=true;
            OBTZ.Visible=true;
            LBTZ.Visible=true;
            Reposition.Visible = true;
            Twentyfourmodecheckbox.Visible = true;
            Program.WidgetForm.Size = new Size(550, 244);
            int xLocation = 0;
            int yLocation = 0;
            if (area.Left > 0)
            {
                xLocation = myscreen.Bounds.Width - myscreen.WorkingArea.Width;
            }
            if (area.Top > 0) 
            {
                yLocation = myscreen.Bounds.Height - myscreen.WorkingArea.Height;
            }
            if (!Properties.Settings.Default.WidgetPos.StartsWith("T"))
            {
                yLocation += area.Size.Height - 244;
            }
            if (Properties.Settings.Default.WidgetPos.EndsWith("R"))
            {
                xLocation += area.Size.Width - 550;
            }
            Program.WidgetForm.Location = new Point(xLocation, yLocation);
            Program.WidgetForm.Opacity = 1.00;
        }

        private void return_Click(object sender, EventArgs e)
        {
            Program.PrimaryForm.Invoke(new MethodInvoker(delegate () { Program.PrimaryForm.Twentyfourmodecheckbox.Checked = Properties.Settings.Default.twentyfourmode; }));
            Program.PrimaryForm.Show();
            Program.WidgetMover.Dispose();
            Program.WidgetForm.Dispose();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            bool MouseIsOverControl(Form frm) => frm.ClientRectangle.Contains(frm.PointToClient(Cursor.Position));
            if (!MouseIsOverControl(Program.WidgetForm))
            {
                Screen myscreen = Screen.FromControl(Program.WidgetForm);
                Rectangle area = myscreen.WorkingArea;
                int xLocation = 0;
                int yLocation = 0;
                if (area.Left > 0)
                {
                    xLocation = myscreen.Bounds.Width - myscreen.WorkingArea.Width;
                }
                if (area.Top > 0)
                {
                    yLocation = myscreen.Bounds.Height - myscreen.WorkingArea.Height;
                }
                if (!Properties.Settings.Default.WidgetPos.StartsWith("T")) {
                    yLocation += area.Size.Height - 200;
                }
                if (Properties.Settings.Default.WidgetPos.EndsWith("R"))
                {
                    xLocation += area.Size.Width - 550;
                }
                splitter1.Visible=false;
                ReturnBtn.Visible=false;
                Twentyfourmodecheckbox.Visible = false;
                OBTZ.Visible=false;
                LBTZ.Visible=false;
                Reposition.Visible = false;
                Program.WidgetForm.Size = new Size(550, 200);
                Program.WidgetForm.Location = new Point( xLocation, yLocation);
                Program.WidgetForm.Opacity = 0.65;
            }
        }
        public void RestorePos()
        {
            Screen myscreen = Screen.FromControl(Program.WidgetForm);
            Rectangle area = myscreen.WorkingArea;
            int xLocation = 0;
            int yLocation = 0;
            if (area.Left > 0)
            {
                xLocation = myscreen.Bounds.Width - myscreen.WorkingArea.Width;
            }
            if (area.Top > 0)
            {
                yLocation = myscreen.Bounds.Height - myscreen.WorkingArea.Height;
            }
            if (!Properties.Settings.Default.WidgetPos.StartsWith("T"))
            {
                yLocation += area.Size.Height - 200;
            }
            if (Properties.Settings.Default.WidgetPos.EndsWith("R"))
            {
                xLocation += area.Size.Width - 550;
            }
            Program.WidgetForm.Location = new Point(xLocation, yLocation);
        }
        private void WidgetFormClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.PrimaryForm.Show();
            Program.WidgetMover.Dispose();
        }
        private void Twentyfourmodecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.twentyfourmode = Twentyfourmodecheckbox.Checked;
            Properties.Settings.Default.Save();
            Program.TM.refresh();
        }

        private void Reposition_Click(object sender, EventArgs e)
        {
            Program.WidgetMover = new WidgetMoverClass();
            Program.WidgetMover.Show();
        }
    }
}
