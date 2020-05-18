using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opiskelijahakemisto
{
    public partial class PvmForm : Form
    {
        public int Day;
        public int Month;
        public int Year;
        public string FinalDate;

        public PvmForm(int dy, int mt, int yr, string fdt)
        {
            InitializeComponent();
            Day = dy;
            Month = mt;
            Year = yr;
            //
        }

        private void nudPv_ValueChanged(object sender, EventArgs e)
        {
            nudPv.Minimum = 1;
            if (nudKk.Value == 1 | nudKk.Value == 3 | nudKk.Value == 5 | nudKk.Value == 7 | nudKk.Value == 8 | nudKk.Value == 10 | nudKk.Value == 12)
            {
                nudPv.Maximum = 31;
            }
            else if (nudKk.Value == 4 | nudKk.Value == 6 | nudKk.Value == 9 | nudKk.Value == 11)
            {
                nudPv.Maximum = 30;
            }
            else
            {
                nudPv.Maximum = 28;
            }
        }

        private void nudKk_ValueChanged(object sender, EventArgs e)
        {
            nudKk.Minimum = 1;
            nudKk.Maximum = 12;
        }

        private void nudV_ValueChanged(object sender, EventArgs e)
        {
            nudV.Minimum = 0;
            nudV.Maximum = 10000;
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            FinalDate = nudPv.Value.ToString() + "." + nudKk.Value.ToString() + "." + nudV.Value.ToString() + " 0.00.00";
            this.Close();
        }

        private void btnPeru_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
