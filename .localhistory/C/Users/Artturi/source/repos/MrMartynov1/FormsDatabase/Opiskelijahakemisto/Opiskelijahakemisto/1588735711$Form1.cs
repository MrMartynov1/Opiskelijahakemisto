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
        // add for more tbs
        public string Alt;
        

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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;

        }

        private void btnHakuOp_Click(object sender, EventArgs e)
        {
            if (tbOp.Text != "")
            {
                tbOp.Text = SukuVar;
                OpListForm opListForm = new OpListForm(Opiskelijat, SukuVar, idChecker, Alt);
                SukuVar = opListForm.SukuVar;
                opListForm.ShowDialog();
                this.Show();

                gbOp.Enabled = true;
                gbMuu.Enabled = true;
                gbKrHaku.Enabled = true;
                
                var So = opListForm.SelectedOpiskelija;
                populateForm(So);
            }
            //else if () {} NOT FOUND
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateForm(Opiskelija opiskelija)
        {
            lbOpID.Text = opiskelija.OpID.ToString();
            tbEtunimi.Text = opiskelija.Etunimi;
            tbEtunimi.Enabled = false;
            tbSukunimi.Text = opiskelija.Sukunimi;
            tbSukunimi.Enabled = false;
            tbHloT.Text = opiskelija.Hlotunnus;
            tbHloT.Enabled = false;
            tbMaa.Text = opiskelija.Maa;
            tbMaa.Enabled = false;
            tbOsoite.Text = opiskelija.Osoite;
            tbOsoite.Enabled = false;
            tbPostnum.Text = opiskelija.Postnum.ToString();
            tbPostnum.Enabled = false;
            tbKunta.Text = opiskelija.Kaupunki;
            tbKunta.Enabled = false;
            tbSaPo.Text = opiskelija.Sposti;
            tbSaPo.Enabled = false;
            tbSite.Text = opiskelija.Site;
            tbSite.Enabled = false;
            tbPuh.Text = opiskelija.Puh;
            tbPuh.Enabled = false;
            tbPuh2.Text = opiskelija.Puh2;
            tbPuh2.Enabled = false;
            tbYritys.Text = opiskelija.Yritys;
            tbYritys.Enabled = false;
            tbThNim.Text = opiskelija.Thnimike;
            tbThNim.Enabled = false;
        }

        private void btnHakuKur_Click(object sender, EventArgs e)
        {
            if (tbKr.Text != "" /*MAKE A PROPER CHECK*/)
            {
                gbKoe.Enabled = true;
            }
            //else if () {}
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHakuKoe_Click(object sender, EventArgs e)
        {
            if (tbKoe.Text != "" /*MAKE A PROPER CHECK*/)
            {
                
            }
            //else if () {}
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnIDPrev_Click(object sender, EventArgs e)
        {
            //tbOp.Text = ""; //REPLACE WITH CONTENT FROM THE DATABASE
            //tbMuu.Text = ""; //THIS ONE AS WELL
            //tbKr.Text = "";
            //tbKoe.Text = "";
            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKrHaku.Enabled = false;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //tbOp.Text = ""; //REPLACE WITH CONTENT FROM THE DATABASE
            //tbMuu.Text = ""; //THIS ONE AS WELL
            //tbKr.Text = "";
            //tbKoe.Text = "";
            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKrHaku.Enabled = false;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
        }

        private void btndelet_Click(object sender, EventArgs e)
        {

        }

        private void tbEtunimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSukunimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHloT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOsoite_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPostnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSaPo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSite_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPuh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPuh2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbYritys_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbThNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKrNimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKoeNimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOpett_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVaik_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKieli_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPvm_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTPO_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSPO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
