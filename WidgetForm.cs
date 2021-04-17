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
            Screen myscreen = Screen.FromControl(Program.WidgetForm);
            Rectangle area = myscreen.WorkingArea;
            int wextras = 0;
            int hextras = 0;
            if (area.Left > 0)
            {
                wextras = myscreen.Bounds.Width - myscreen.WorkingArea.Width;
            }
            if (area.Top > 0)
            {
                hextras = myscreen.Bounds.Height - myscreen.WorkingArea.Height;
            }
            Program.WidgetForm.Location = new Point(area.Size.Width-550+wextras,area.Size.Height-200+hextras);
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
            Twentyfourmodecheckbox.Visible = true;
            Program.WidgetForm.Size = new Size(550, 244);
            int wextras = 0;
            int hextras = 0;
            if (area.Left > 0)
            {
                wextras = myscreen.Bounds.Width - myscreen.WorkingArea.Width;
            }
            if (area.Top > 0) 
            {
                hextras = myscreen.Bounds.Height - myscreen.WorkingArea.Height;
            }
            Program.WidgetForm.Location = new Point(area.Size.Width - 550 + wextras, area.Size.Height - 244 + hextras);
            Program.WidgetForm.Opacity = 1.00;
        }

        private void return_Click(object sender, EventArgs e)
        {
            Program.PrimaryForm.Invoke(new MethodInvoker(delegate () { Program.PrimaryForm.Twentyfourmodecheckbox.Checked = Properties.Settings.Default.twentyfourmode; }));
            Program.PrimaryForm.Show();
            Program.WidgetForm.Dispose();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            bool MouseIsOverControl(Form frm) => frm.ClientRectangle.Contains(frm.PointToClient(Cursor.Position));
            if (!MouseIsOverControl(Program.WidgetForm))
            {
                Screen myscreen = Screen.FromControl(Program.WidgetForm);
                Rectangle area = myscreen.WorkingArea;
                int wextras = 0;
                int hextras = 0;
                if (area.Left > 0)
                {
                    wextras = myscreen.Bounds.Width - myscreen.WorkingArea.Width;
                }
                if (area.Top > 0)
                {
                    hextras = myscreen.Bounds.Height - myscreen.WorkingArea.Height;
                }
                splitter1.Visible=false;
                ReturnBtn.Visible=false;
                Twentyfourmodecheckbox.Visible = false;
                OBTZ.Visible=false;
                LBTZ.Visible=false;
                Program.WidgetForm.Size = new Size(550, 200);
                Program.WidgetForm.Location = new Point(area.Size.Width - 550+wextras, area.Size.Height - 200+hextras);
                Program.WidgetForm.Opacity = 0.65;
            }
        }

        private void WidgetFormClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.PrimaryForm.Show();
            Program.WidgetForm.Dispose();
        }
        private void Twentyfourmodecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.twentyfourmode = Twentyfourmodecheckbox.Checked;
            Properties.Settings.Default.Save();
            Program.TM.refresh();
        }
    }
}
