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
        public List<Opiskelija> Opiskelijat = new List<Opiskelija>();

        //
        public string SukuVar { get { return tbOp.Text; } set { tbOp.Text = value; } }
        public string idChecker;
        public string fsd { get { return tbHloT.Text; } set { tbHloT.Text = value; } }
        // add for more tbs
        public string Alt;
        //

        public Form1()
        {
            InitializeComponent();
            tbHloT.Text = "";
            lbOpID.Text = "";
            lbEtu.Text = "";
            lbSuku.Text = "";
            lbHlotun.Text = "";
            lbOs.Text = "";
            lbPostnum.Text = "";
            lbMaa.Text = "";
            lbKunta.Text = "";
            lbSaPo.Text = "";
            lbWeb.Text = "";
            lbPuh1.Text = "";
            lbPuh2.Text = "";
            lbPuh2.Text = "";
            lbYrt.Text = "";
            lbThN.Text = "";
            lbKrID.Text = "";
            lbKrN.Text = "";
            lbKoID.Text = "";
            lbKoN.Text = "";
            lbOpt.Text = "";
            lbVaik.Text = "";
            lbKiel.Text = "";
            lbPvm.Text = "";
            lbReq.Text = "";
            lbPerc.Text = "";

        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MORE
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
            if (tbOp.Text != "" /*CHECK FOR EXISTENCE WILL BE MADE IN OPLISTFORM*/)
            {
                tbOp.Text = SukuVar;
                OpListForm opListForm = new OpListForm(Opiskelijat, SukuVar, idChecker, Alt);
                SukuVar = opListForm.SukuVar;
                opListForm.ShowDialog();
                this.Show();
                //try
                //{

                //}
                //catch
                //{

                //}
                //THE VOID FROM DATAACCESS


                //Opiskelijat = db.HaeOpiskelijat(lbSuku.Text);
                gbOp.Enabled = true;
                gbMuu.Enabled = true;
                gbKr.Enabled = true;

                this.populateForm();

            }
            //else if () {}
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateForm()
        {
            this.fsd = "aasdasd";
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
            tbOp.Text = ""; //REPLACE WITH CONTENT FROM THE DATABASE
            tbMuu.Text = ""; //THIS ONE AS WELL
            tbKr.Text = "";
            tbKoe.Text = "";
            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKr.Enabled = false;
            gbKoe.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbOp.Text = ""; //REPLACE WITH CONTENT FROM THE DATABASE
            tbMuu.Text = ""; //THIS ONE AS WELL
            tbKr.Text = "";
            tbKoe.Text = "";
            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKr.Enabled = false;
            gbKoe.Enabled = false;
        }

        private void lbEtu_Click(object sender, EventArgs e)
        {

        }

        private void lbSuku_Click(object sender, EventArgs e)
        {

        }

        private void lbHlotun_Click(object sender, EventArgs e)
        {

        }

        private void lbMaa_Click(object sender, EventArgs e)
        {

        }

        private void lbOs_Click(object sender, EventArgs e)
        {

        }

        private void lbPostnum_Click(object sender, EventArgs e)
        {

        }

        private void lbKunta_Click(object sender, EventArgs e)
        {

        }

        private void lbSaPo_Click(object sender, EventArgs e)
        {

        }

        private void lbWeb_Click(object sender, EventArgs e)
        {

        }

        private void lbPuh1_Click(object sender, EventArgs e)
        {

        }

        private void lbPuh2_Click(object sender, EventArgs e)
        {

        }

        private void lbYrt_Click(object sender, EventArgs e)
        {

        }

        private void lbThN_Click(object sender, EventArgs e)
        {

        }

        private void lbKrN_Click(object sender, EventArgs e)
        {

        }

        private void lbKoN_Click(object sender, EventArgs e)
        {

        }

        private void lbOpt_Click(object sender, EventArgs e)
        {

        }

        private void lbVaik_Click(object sender, EventArgs e)
        {

        }

        private void lbKiel_Click(object sender, EventArgs e)
        {

        }

        private void lbPvm_Click(object sender, EventArgs e)
        {

        }

        private void btndelet_Click(object sender, EventArgs e)
        {

        }
    }
}
