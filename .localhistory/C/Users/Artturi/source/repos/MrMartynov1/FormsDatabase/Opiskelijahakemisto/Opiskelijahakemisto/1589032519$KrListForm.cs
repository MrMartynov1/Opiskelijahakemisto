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
    public partial class KrListForm : Form
    {
        public List<Opiskelija> kurssit;
        public string KrVar { get; set; }
        public string KridC;
        public string Kraltered;
        private string selectedKrId;
        public Opiskelija SelectedKurssi;
        public string SelectedKrId { get { return selectedKrId; } set { selectedKrId = value; } }

        public KrListForm(List<Opiskelija> Kr, string getkrvar, string Krcheck, string kralt)
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            KrVar = getkrvar;
            KridC = Krcheck;
            Kraltered = kralt;
            kurssit = db.HaeOpiskelijat(KrVar);
            UpdateBindingOp();
            kurssit = Kr;
        }

        public void UpdateBindingOp()
        {
            lsbKr.DataSource = kurssit;
            lsbKr.DisplayMember = "KrListInfo";
        }

        private void lsbKr_SelectedIndexChanged(object sender, EventArgs e)
        {
            KridC = lsbKr.SelectedItem.ToString();
            Kraltered = lsbKr.SelectedItems[0].ToString();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            if (KridC != null && Kraltered != null)
            {
                SelectedKrId = ((Opiskelijahakemisto.Kurssi)lsbKr.SelectedItem).Nimi;
                SelectedKurssi = (Opiskelijahakemisto.Kurssi)lsbKr.SelectedItem;
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
