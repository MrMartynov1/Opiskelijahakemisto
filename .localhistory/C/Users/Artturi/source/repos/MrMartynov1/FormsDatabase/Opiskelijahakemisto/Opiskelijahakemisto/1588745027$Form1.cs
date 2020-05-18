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
        OpListForm opListForm = new OpListForm(Opiskelijat, SukuVar, idChecker, Alt);


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
            tbMuu.Text = opiskelija.Muuta;
            tbMuu.Enabled = false;
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
            var So = opListForm.SelectedOpiskelija;
            populateForm(So);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnIDPrev_Click(object sender, EventArgs e)
        {
            //REPLACE WITH CONTENT FROM THE DATABASE
            //THIS ONE AS WELL

            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKrHaku.Enabled = false;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //REPLACE WITH CONTENT FROM THE DATABASE
            //THIS ONE AS WELL
            
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
            btnResEmp.Enabled = true;
        }

        private void tbSukunimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbHloT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbMaa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbOsoite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbPostnum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbKunta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbSaPo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbSite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbPuh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbPuh2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbYritys_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbThNim_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbMuu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbKrNimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbKoeNimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbOpett_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbVaik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbKieli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbPvm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbTPO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }

        private void tbSPO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
        }
    }
}
