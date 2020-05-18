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
    public partial class VastausListForm : Form
    {
        public List<Vastaukset> tulokset;
        public string TVar { get; set; }
        public int TVarN /*{ get; set; }*/;
        public string TOVar { get; set; }
        public int TOVarN /*{ get; set; }*/;
        public string VidC;
        public string Valtered;
        private string selectedVId;
        public Vastaukset SelectedV;
        public string SelectedVId { get { return selectedVId; } set { selectedVId = value; } }

        public VastausListForm(List<Vastaukset> VT, string getTvar, string getTOvar, string vcheck, string valt)
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            TVar = getTvar;
            TOVar = getTOvar;
            VidC = vcheck;
            Valtered = valt;
            int.TryParse(TVar, out TVarN);
            int.TryParse(TOVar, out TOVarN);
            tulokset = db.HaeTulos(TVarN, TOVarN);
            UpdateBindingVT();
            tulokset = VT;
        }

        public void UpdateBindingVT()
        {
            lsbV.DataSource = tulokset;
            lsbV.DisplayMember = "VListInfo";
        }

        private void lsbV_SelectedIndexChanged(object sender, EventArgs e)
        {
            VidC = lsbV.SelectedItem.ToString();
            Valtered = lsbV.SelectedItems[0].ToString();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            if (VidC != null && Valtered != null)
            {
                SelectedVId = ((Opiskelijahakemisto.Vastaukset)lsbV.SelectedItem).Koe.ToString();
                SelectedV = (Opiskelijahakemisto.Vastaukset)lsbV.SelectedItem;
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
