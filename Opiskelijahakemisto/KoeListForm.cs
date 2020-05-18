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
    public partial class KoeListForm : Form
    {
        public List<Koe> kokeet;
        public string KoeVar { get; set; }
        public string KoeidC;
        public string Koealtered;
        private string selectedKoeId;
        public Koe SelectedKoe;
        public string SelectedKoeId { get { return selectedKoeId; } set { selectedKoeId = value; } }

        public KoeListForm(List<Koe> Ko, string getkoevar, string Koecheck, string koealt)
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            KoeVar = getkoevar;
            KoeidC = Koecheck;
            Koealtered = koealt;
            kokeet = db.HaeKoe(KoeVar);
            UpdateBindingKoe();
            kokeet = Ko;
        }

        public void UpdateBindingKoe()
        {
            lsbKoe.DataSource = kokeet;
            lsbKoe.DisplayMember = "KoeListInfo";
        }

        private void lsbKoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            KoeidC = lsbKoe.SelectedItem.ToString();
            Koealtered = lsbKoe.SelectedItems[0].ToString();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            if (KoeidC != null && Koealtered != null)
            {
                SelectedKoeId = ((Opiskelijahakemisto.Koe)lsbKoe.SelectedItem).Koenimi;
                SelectedKoe = (Opiskelijahakemisto.Koe)lsbKoe.SelectedItem;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ei valittu!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPeru_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
