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
    public partial class CustomiserForm : Form
    {
        private readonly int[] CustomColours = new int[] { 11909845, 6835543, 3498451, 7572842, 14075539 };
        public CustomiserForm()
        {
            InitializeComponent();
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
    }
}
