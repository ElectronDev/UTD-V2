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
        public bool IsFloating = false;
        public WidgetFormClass()
        {
            InitializeComponent();
            Shown += Widget_Shown;
        }
        private void Widget_Shown(object sender, EventArgs e)
        {
            if (!IsFloating) {
            RestorePos();
            }
            splitter1.Visible = false;
            ReturnBtn.Visible = false;
            Twentyfourmodecheckbox.Visible = false;
            OBTZ.Visible = false;
            LBTZ.Visible = false;
            Reposition.Visible = false;
            Program.WidgetForm.Size = new Size(550, 200);
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
            int sizex = 550;
            int sizey = 244;
            if (Program.WidgetMover.FreeButton.Enabled)
            {
                Program.WidgetForm.Location = new Point(xLocation, yLocation);
            }
            if (!Program.WidgetMover.FreeButton.Enabled && Program.WidgetMover.FreeMoveLock.Checked)
            {
                sizex = 566;
                sizey = 283;
            }
            Program.WidgetForm.Size = new Size(sizex, sizey);
            Program.WidgetForm.Opacity = 1.00;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Program.PrimaryForm.Invoke(new MethodInvoker(delegate () { Program.PrimaryForm.Twentyfourmodecheckbox.Checked = Properties.Settings.Default.twentyfourmode; }));
            Program.PrimaryForm.Show();
            Program.WidgetMover.FreeMoveLock.Checked = false;
            Program.WidgetMover.Dispose();
            Program.WidgetForm.Dispose();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            static bool MouseIsOverControl(Form frm) => frm.ClientRectangle.Contains(frm.PointToClient(Cursor.Position));
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
                int sizex = 550;
                int sizey = 200;
                if (Program.WidgetMover.FreeButton.Enabled)
                {
                    Program.WidgetForm.Location = new Point(xLocation, yLocation);
                }
                if (!Program.WidgetMover.FreeButton.Enabled && Program.WidgetMover.FreeMoveLock.Checked)
                {
                    sizex = 566;
                    sizey = 239;
                }
                Program.WidgetForm.Size = new Size(sizex, sizey);
                Program.WidgetForm.Opacity = 0.65;
            }
        }
        public static void RestorePos()
        {
            Program.WidgetForm.FormBorderStyle = FormBorderStyle.None;
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
            Program.TM.Refresh();
        }

        private void Reposition_Click(object sender, EventArgs e)
        {
            if (!Program.WidgetMover.Visible)
            {
            Program.WidgetMover = new WidgetMoverClass();
            Program.WidgetMover.Show();
            }
            else 
            {
                Program.WidgetMover.Focus();
            }
        }
    }
}
