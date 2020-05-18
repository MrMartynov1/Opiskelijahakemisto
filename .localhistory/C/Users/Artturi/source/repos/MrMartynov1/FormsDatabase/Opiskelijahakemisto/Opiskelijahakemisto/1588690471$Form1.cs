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
        public Array[] opiskelijaID = new Array[0];
        //
        public string SukuVar { get { return tbOp.Text; } set { tbOp.Text = value; } }
        public string selectedid { get; set; }
        public string idChecker;
        //public string fsd { get { return tbHloT.Text; } set { tbHloT.Text = value; } }
        // add for more tbs
        public string Alt;
        //

        public Form1()
        {
            InitializeComponent();

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
            Opiskelija cd = new Opiskelija();
            //this.fsd = "aasdasd";
            lbOpID.Text = cd.OpAllInfo.ToString();
            //lbOpID.Text = db.AvaaOpiskelija(0).ToString();
            tbEtunimi.Text = cd.OpEN.ToString();

            // FIX MORE
        }

        public void UpdateBindingOp()
        {
            //lbOpID.DataSource = opiskelijat;
            //lbOpID.DisplayMember = "OpListInfo";
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

        private void btndelet_Click(object sender, EventArgs e)
        {

        }
    }
}
