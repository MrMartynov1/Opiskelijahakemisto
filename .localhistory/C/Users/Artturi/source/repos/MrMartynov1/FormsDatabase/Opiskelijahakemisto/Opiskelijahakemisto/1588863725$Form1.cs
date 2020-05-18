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
    public partial class Form1 : Form
    {
        DataAccess db = new DataAccess();
        public List<Opiskelija> Opiskelijat = new List<Opiskelija>();
        public string SukuVar { get { return tbOp.Text; } set { tbOp.Text = value; } }
        public string idChecker;
        public string Alt;
        //CONTAIN THE STUFF HERE
        public string OrgEN;
        public string OrgSN;
        public string OrgHLT;
        public string OrgM;
        public string OrgOS;
        public string OrgPST;
        public string OrgKU;
        public string OrgSP;
        public string OrgST;
        public string OrgPH1;
        public string OrgPH2;
        public string OrgYR;
        public string OrgTHN;
        public string OrgMU;

        public Form1()
        {
            InitializeComponent();

        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MORE (if hasn't saved, ask)
            Application.Exit();
        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opiskelijahakemisto\n© Artturi Martynov 2020", "Tietoja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //SEARCH

        private void btnHakuOp_Click(object sender, EventArgs e)
        {
            if (tbOp.Text != "")
            {
                tbOp.Text = SukuVar;
                OpListForm opListForm = new OpListForm(Opiskelijat, SukuVar, idChecker, Alt);
                SukuVar = opListForm.SukuVar;
                opListForm.ShowDialog();
                this.Show();
                try
                {
                    gbOp.Enabled = true;
                    gbMuu.Enabled = true;
                    gbKrHaku.Enabled = true;
                    var So = opListForm.SelectedOpiskelija;
                    populateForm(So);
                }
                catch
                {
                    gbOp.Enabled = false;
                    gbMuu.Enabled = false;
                    gbKrHaku.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void populateForm(Opiskelija opiskelija)
        {
            lbOpID.Text = opiskelija.OpID.ToString();
            tbEtunimi.Text = opiskelija.Etunimi;
            tbSukunimi.Text = opiskelija.Sukunimi;
            tbHloT.Text = opiskelija.Hlotunnus;
            tbMaa.Text = opiskelija.Maa;
            tbOsoite.Text = opiskelija.Osoite;
            tbPostnum.Text = opiskelija.Postnum.ToString();
            tbKunta.Text = opiskelija.Kaupunki;
            tbSaPo.Text = opiskelija.Sposti;
            tbSite.Text = opiskelija.Site;
            tbPuh.Text = opiskelija.Puh;
            tbPuh2.Text = opiskelija.Puh2;
            tbYritys.Text = opiskelija.Yritys;
            tbThNim.Text = opiskelija.Thnimike;
            tbMuu.Text = opiskelija.Muuta;

            OrgEN = opiskelija.Etunimi;
            OrgSN = opiskelija.Sukunimi;
            OrgHLT = opiskelija.Hlotunnus;
            OrgM = opiskelija.Maa;
            OrgOS = opiskelija.Osoite;
            OrgPST = opiskelija.Postnum.ToString();
            OrgKU = opiskelija.Kaupunki;
            OrgSP = opiskelija.Sposti;
            OrgST = opiskelija.Site;
            OrgPH1 = opiskelija.Puh;
            OrgPH2 = opiskelija.Puh2;
            OrgYR = opiskelija.Yritys;
            OrgTHN = opiskelija.Thnimike;
            OrgMU = opiskelija.Muuta;
        }

        private void btnHakuKur_Click(object sender, EventArgs e)
        {
            if (tbKr.Text != "")
            {
                gbKoe.Enabled = true;
            }
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHakuKoe_Click(object sender, EventArgs e)
        {
            if (tbKoe.Text != "")
            {
                
            }
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BUTTONS

        private void btnNew_Click(object sender, EventArgs e)
        {
            //btnResEmp.Enabled = true;

        }

        private void btnResEmp_Click(object sender, EventArgs e)
        {
            tbEtunimi.Text = OrgEN;
            tbSukunimi.Text = OrgSN;
            tbHloT.Text = OrgHLT;
            tbMaa.Text = OrgM;
            tbOsoite.Text = OrgOS;
            tbPostnum.Text = OrgPST;
            tbKunta.Text = OrgKU;
            tbSaPo.Text = OrgSP;
            tbSite.Text = OrgST;
            tbPuh.Text = OrgPH1;
            tbPuh2.Text = OrgPH2;
            tbYritys.Text = OrgYR;
            tbThNim.Text = OrgTHN;
            tbMuu.Text = OrgMU;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnIDPrev_Click(object sender, EventArgs e)
        {
            //REPLACE WITH THING BASED ON ID
            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKrHaku.Enabled = false;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //REPLACE WITH THING BASED ON ID
            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKrHaku.Enabled = false;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            //DataAccess Remove row (by id?)
        }

        //TEXTBOXES
        
        private void tbEtunimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbEtunimi.ReadOnly = false;
        }

        private void tbEtunimi_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbSukunimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbSukunimi.ReadOnly = false;
        }

        private void tbSukunimi_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
        }
    }
}
