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
        //
        public List<Opiskelija> Opiskelijat = new List<Opiskelija>();
        public string SukuVar { get { return tbOp.Text; } set { tbOp.Text = value; } }
        public string idChecker;
        public string Alt;
        //
        public List<Kurssi> Kurssit = new List<Kurssi>();
        public string KrVar { get { return tbKr.Text; } set { tbKr.Text = value; } }
        public string KridC;
        public string KrAlt;
        //
        public List<Koe> Kokeet = new List<Koe>();
        public string KoeVar { get { return tbKoe.Text; } set { tbKoe.Text = value; } }
        public string KoeidC;
        public string KoeAlt;
        //
        public List<Vastaukset> Tulokset = new List<Vastaukset>();
        public string TVar { get { return lbKoID.Text; } set { lbKoID.Text = value; } }
        public string TOVar { get { return lbOpID.Text; } set { lbOpID.Text = value; } }
        public string VidC;
        public string VAlt;
        //
        public int day;
        public int month;
        public int year;
        public string fdate;
        //
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
        public string OrgN;
        public string OrgKN;
        public string OrgOp;
        public string OrgVk;
        public string OrgKl;
        public string OrgPvm;
        public string OrgTPO;
        public string OrgSPO;
        //

        public Form1()
        {
            InitializeComponent();
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MORE (if hasn't saved, ask)
            if (btnSave.Enabled == true)
            {
                //Are you sure?-msgbox(?)
                //if (yes)
                //{
                //To SaveForm
                //}
                //else
                //{
                //}
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
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
                    btnTyh.Enabled = true;
                    var So = opListForm.SelectedOpiskelija;
                    populateForm(So);
                    //
                    gbKr.Enabled = false;
                    lbKrID.Text = "Kurssin ID";
                    tbKrNimi.Text = null;
                    tbKrNimi.ReadOnly = true;
                    gbKoeHaku.Enabled = false;
                    gbKoe.Enabled = false;
                    lbKoID.Text = "Kokeen ID";
                    tbKoeNimi.Text = null;
                    tbKoeNimi.ReadOnly = true;
                    tbKoeNimi.BackColor = SystemColors.Control;
                    tbOpett.Text = null;
                    tbOpett.ReadOnly = true;
                    tbOpett.BackColor = SystemColors.Control;
                    tbVaik.Text = null;
                    tbVaik.ReadOnly = true;
                    tbVaik.BackColor = SystemColors.Control;
                    tbKieli.Text = null;
                    tbKieli.ReadOnly = true;
                    tbKieli.BackColor = SystemColors.Control;
                    tbPvm.Text = null;
                    tbPvm.ReadOnly = true;
                    tbPvm.BackColor = SystemColors.Control;
                    tbTPO.Text = null;
                    tbTPO.ReadOnly = true;
                    tbTPO.BackColor = SystemColors.Control;
                    tbSPO.Text = null;
                    tbSPO.ReadOnly = true;
                    tbSPO.BackColor = SystemColors.Control;
                    //
                }
                catch
                {
                    gbOp.Enabled = false;
                    gbMuu.Enabled = false;
                    gbKrHaku.Enabled = false;
                    btnTyh.Enabled = false;
                    //
                    gbKr.Enabled = false;
                    lbKrID.Text = "Kurssin ID";
                    tbKrNimi.Text = null;
                    tbKrNimi.ReadOnly = true;
                    gbKoeHaku.Enabled = false;
                    gbKoe.Enabled = false;
                    lbKoID.Text = "Kokeen ID";
                    lbVID.Text = "Vastaus ID";
                    tbKoeNimi.Text = null;
                    tbKoeNimi.ReadOnly = true;
                    tbKoeNimi.BackColor = SystemColors.Control;
                    tbOpett.Text = null;
                    tbOpett.ReadOnly = true;
                    tbOpett.BackColor = SystemColors.Control;
                    tbVaik.Text = null;
                    tbVaik.ReadOnly = true;
                    tbVaik.BackColor = SystemColors.Control;
                    tbKieli.Text = null;
                    tbKieli.ReadOnly = true;
                    tbKieli.BackColor = SystemColors.Control;
                    tbPvm.Text = null;
                    tbPvm.ReadOnly = true;
                    tbPvm.BackColor = SystemColors.Control;
                    tbTPO.Text = null;
                    tbTPO.ReadOnly = true;
                    tbTPO.BackColor = SystemColors.Control;
                    tbSPO.Text = null;
                    tbSPO.ReadOnly = true;
                    tbSPO.BackColor = SystemColors.Control;
                    //
                }
            }
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void populateForm(Opiskelija opiskelija)
        {
            btndelet.Enabled = true;

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

        //

        private void btnHakuKur_Click(object sender, EventArgs e)
        {
            if (tbKr.Text != "")
            {
                tbKr.Text = KrVar;
                KrListForm krListForm = new KrListForm(Kurssit, KrVar, KridC, KrAlt);
                KrVar = krListForm.KrVar;
                krListForm.ShowDialog();
                this.Show();
                try
                {
                    gbKr.Enabled = true;
                    gbKoeHaku.Enabled = true;
                    var Sk = krListForm.SelectedKurssi;
                    populateFormKr(Sk);
                    //
                    gbKoe.Enabled = false;
                    lbKoID.Text = "Kokeen ID";
                    lbVID.Text = "Vastaus ID";
                    tbKoeNimi.Text = null;
                    tbKoeNimi.ReadOnly = true;
                    tbKoeNimi.BackColor = SystemColors.Control;
                    tbOpett.Text = null;
                    tbOpett.ReadOnly = true;
                    tbOpett.BackColor = SystemColors.Control;
                    tbVaik.Text = null;
                    tbVaik.ReadOnly = true;
                    tbVaik.BackColor = SystemColors.Control;
                    tbKieli.Text = null;
                    tbKieli.ReadOnly = true;
                    tbKieli.BackColor = SystemColors.Control;
                    tbPvm.Text = null;
                    tbPvm.ReadOnly = true;
                    tbPvm.BackColor = SystemColors.Control;
                    tbTPO.Text = null;
                    tbTPO.ReadOnly = true;
                    tbTPO.BackColor = SystemColors.Control;
                    tbSPO.Text = null;
                    tbSPO.ReadOnly = true;
                    tbSPO.BackColor = SystemColors.Control;
                }
                catch
                {
                    gbKr.Enabled = false;
                    gbKoeHaku.Enabled = false;
                    //
                    gbKoe.Enabled = false;
                    lbKoID.Text = "Kokeen ID";
                    lbVID.Text = "Vastaus ID";
                    tbKoeNimi.Text = null;
                    tbKoeNimi.ReadOnly = true;
                    tbKoeNimi.BackColor = SystemColors.Control;
                    tbOpett.Text = null;
                    tbOpett.ReadOnly = true;
                    tbOpett.BackColor = SystemColors.Control;
                    tbVaik.Text = null;
                    tbVaik.ReadOnly = true;
                    tbVaik.BackColor = SystemColors.Control;
                    tbKieli.Text = null;
                    tbKieli.ReadOnly = true;
                    tbKieli.BackColor = SystemColors.Control;
                    tbPvm.Text = null;
                    tbPvm.ReadOnly = true;
                    tbPvm.BackColor = SystemColors.Control;
                    tbTPO.Text = null;
                    tbTPO.ReadOnly = true;
                    tbTPO.BackColor = SystemColors.Control;
                    tbSPO.Text = null;
                    tbSPO.ReadOnly = true;
                    tbSPO.BackColor = SystemColors.Control;
                }
            }
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void populateFormKr(Kurssi kurssi)
        {
            btndelet.Enabled = true;

            lbKrID.Text = kurssi.KurssiID.ToString();
            tbKrNimi.Text = kurssi.Nimi;
            OrgN = kurssi.Nimi;
        }

        //

        private void btnHakuKoe_Click(object sender, EventArgs e)
        {
            if (tbKoe.Text != "")
            {
                tbKoe.Text = KoeVar;
                KoeListForm koeListForm = new KoeListForm(Kokeet, KoeVar, KoeidC, KoeAlt);
                KoeVar = koeListForm.KoeVar;
                koeListForm.ShowDialog();
                this.Show();
                try
                {
                    gbKoe.Enabled = true;
                    var Sko = koeListForm.SelectedKoe;
                    populateFormKoe(Sko);
                    //
                    try
                    {
                        tbKoeNimi.Text = TVar;
                        lbOpID.Text = TOVar;
                        VastausListForm vastausListForm = new VastausListForm(Tulokset, TVar, TOVar, VidC, VAlt);
                        TVar = vastausListForm.TVar;
                        TOVar = vastausListForm.TOVar;
                        vastausListForm.ShowDialog();
                        this.Show();
                        var Sv = vastausListForm.SelectedV;
                        populateFormV(Sv);
                    }
                    catch
                    {
                        lbVID.Text = null;
                        tbSPO.Text = null;
                        tbSPO.ReadOnly = false;
                    }
                }
                catch
                {
                    gbKoe.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Haku on tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void populateFormKoe(Koe koe)
        {
            btndelet.Enabled = true;

            lbKoID.Text = koe.KoeID.ToString();
            tbKoeNimi.Text = koe.Koenimi;
            tbOpett.Text = koe.Opettaja;
            tbVaik.Text = koe.Vaikeus.ToString();
            tbKieli.Text = koe.Kieli;
            tbPvm.Text = koe.Pvm;
            tbTPO.Text = koe.Prosenttitavoite.ToString();
            OrgKN = koe.Koenimi;
            OrgOp = koe.Opettaja;
            OrgVk = koe.Vaikeus.ToString();
            OrgKl = koe.Kieli;
            OrgPvm = koe.Pvm; //ADD CHECK//
            OrgTPO = koe.Prosenttitavoite.ToString();
        }

        public void populateFormV(Vastaukset tulos)
        {
            btndelet.Enabled = true;
            tbSPO.Text = tulos.ProsenttiMaara.ToString();
            lbVID.Text = tulos.Id.ToString();
            OrgSPO = tulos.ProsenttiMaara.ToString();
        }

        //

        //BUTTONS

        private void btnNew_Click(object sender, EventArgs e)
        {
            //USABLE
            gbOp.Enabled = true;
            gbMuu.Enabled = true;
            gbKrHaku.Enabled = true;
            lbOpID.Text = null;
            tbEtunimi.Text = null;
            tbEtunimi.ReadOnly = false;
            tbEtunimi.BackColor = SystemColors.Window;
            tbSukunimi.Text = null;
            tbSukunimi.ReadOnly = false;
            tbSukunimi.BackColor = SystemColors.Window;
            tbHloT.Text = null;
            tbHloT.ReadOnly = false;
            tbHloT.BackColor = SystemColors.Window;
            tbMaa.Text = null;
            tbMaa.ReadOnly = false;
            tbMaa.BackColor = SystemColors.Window;
            tbOsoite.Text = null;
            tbOsoite.ReadOnly = false;
            tbOsoite.BackColor = SystemColors.Window;
            tbPostnum.Text = null;
            tbPostnum.ReadOnly = false;
            tbPostnum.BackColor = SystemColors.Window;
            tbKunta.Text = null;
            tbKunta.ReadOnly = false;
            tbKunta.BackColor = SystemColors.Window;
            tbSaPo.Text = null;
            tbSaPo.ReadOnly = false;
            tbSaPo.BackColor = SystemColors.Window;
            tbSite.Text = null;
            tbSite.ReadOnly = false;
            tbSite.BackColor = SystemColors.Window;
            tbPuh.Text = null;
            tbPuh.ReadOnly = false;
            tbPuh.BackColor = SystemColors.Window;
            tbPuh2.Text = null;
            tbPuh2.ReadOnly = false;
            tbPuh2.BackColor = SystemColors.Window;
            tbYritys.Text = null;
            tbYritys.ReadOnly = false;
            tbYritys.BackColor = SystemColors.Window;
            tbThNim.Text = null;
            tbThNim.ReadOnly = false;
            tbThNim.BackColor = SystemColors.Window;
            tbMuu.Text = null;
            tbMuu.ReadOnly = false;
            tbMuu.BackColor = SystemColors.Window;
            //DISABLED
            gbKr.Enabled = false;
            lbKrID.Text = "Kurssin ID";
            tbKrNimi.Text = null;
            tbKrNimi.ReadOnly = true;
            tbKrNimi.BackColor = SystemColors.Control;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
            lbKoID.Text = "Kokeen ID";
            lbVID.Text = "Vastaus ID";
            tbKoeNimi.Text = null;
            tbKoeNimi.ReadOnly = true;
            tbKoeNimi.BackColor = SystemColors.Control;
            tbOpett.Text = null;
            tbOpett.ReadOnly = true;
            tbOpett.BackColor = SystemColors.Control;
            tbVaik.Text = null;
            tbVaik.ReadOnly = true;
            tbVaik.BackColor = SystemColors.Control;
            tbKieli.Text = null;
            tbKieli.ReadOnly = true;
            tbKieli.BackColor = SystemColors.Control;
            tbPvm.Text = null;
            tbPvm.BackColor = SystemColors.Control;
            tbTPO.Text = null;
            tbTPO.ReadOnly = true;
            tbTPO.BackColor = SystemColors.Control;
            tbSPO.Text = null;
            tbSPO.ReadOnly = true;
            tbSPO.BackColor = SystemColors.Control;
            //
            btnResEmp.Enabled = false;
            btndelet.Enabled = false;
            btnSave.Enabled = false;
            btnTyh.Enabled = true;
            //ID shit (ONLY WHEN SAVING -> INSERT)
        }

        private void btnKrU_Click(object sender, EventArgs e)
        {
            gbKr.Enabled = true;
            gbKoeHaku.Enabled = true;
            gbKoe.Enabled = false;
            lbKrID.Text = null;
            tbKrNimi.Text = null;
            tbKrNimi.ReadOnly = false;
            tbKrNimi.BackColor = SystemColors.Window;
            lbKoID.Text = "Kokeen ID";
            lbVID.Text = "Vastaus ID";
            tbKoeNimi.Text = null;
            tbKoeNimi.ReadOnly = true;
            tbKoeNimi.BackColor = SystemColors.Control;
            tbOpett.Text = null;
            tbOpett.ReadOnly = true;
            tbOpett.BackColor = SystemColors.Control;
            tbVaik.Text = null;
            tbVaik.ReadOnly = true;
            tbVaik.BackColor = SystemColors.Control;
            tbKieli.Text = null;
            tbKieli.ReadOnly = true;
            tbKieli.BackColor = SystemColors.Control;
            tbPvm.Text = null;
            tbPvm.BackColor = SystemColors.Control;
            tbTPO.Text = null;
            tbTPO.ReadOnly = true;
            tbTPO.BackColor = SystemColors.Control;
            tbSPO.Text = null;
            tbSPO.ReadOnly = true;
            tbSPO.BackColor = SystemColors.Control;
            btnResEmp.Enabled = false;
            btndelet.Enabled = false;
            btnSave.Enabled = false;
            btnTyh.Enabled = true;
            //ID shit (ONLY WHEN SAVING -> INSERT)
        }

        private void btnKoeU_Click(object sender, EventArgs e)
        {
            gbKoe.Enabled = true;
            lbKoID.Text = null;
            lbVID.Text = null;
            tbKoeNimi.Text = null;
            tbKoeNimi.ReadOnly = false;
            tbKoeNimi.BackColor = SystemColors.Window;
            tbOpett.Text = null;
            tbOpett.ReadOnly = false;
            tbOpett.BackColor = SystemColors.Window;
            tbVaik.Text = null;
            tbVaik.ReadOnly = false;
            tbVaik.BackColor = SystemColors.Window;
            tbKieli.Text = null;
            tbKieli.ReadOnly = false;
            tbKieli.BackColor = SystemColors.Window;
            tbPvm.Text = null;
            tbPvm.BackColor = SystemColors.Window;
            tbTPO.Text = null;
            tbTPO.ReadOnly = false;
            tbTPO.BackColor = SystemColors.Window;
            tbSPO.Text = null;
            tbSPO.ReadOnly = false;
            tbSPO.BackColor = SystemColors.Window;
            btnResEmp.Enabled = false;
            btndelet.Enabled = false;
            btnSave.Enabled = false;
            btnTyh.Enabled = true;
            //ID shit (ONLY WHEN SAVING -> INSERT)
        }

        private void btnResEmp_Click(object sender, EventArgs e)
        {
            tbEtunimi.ReadOnly = true;
            tbEtunimi.Text = OrgEN;
            tbEtunimi.BackColor = SystemColors.Control;
            tbSukunimi.ReadOnly = true;
            tbSukunimi.Text = OrgSN;
            tbSukunimi.BackColor = SystemColors.Control;
            tbHloT.ReadOnly = true;
            tbHloT.Text = OrgHLT;
            tbHloT.BackColor = SystemColors.Control;
            tbMaa.ReadOnly = true;
            tbMaa.Text = OrgM;
            tbMaa.BackColor = SystemColors.Control;
            tbOsoite.ReadOnly = true;
            tbOsoite.Text = OrgOS;
            tbOsoite.BackColor = SystemColors.Control;
            tbPostnum.ReadOnly = true;
            tbPostnum.Text = OrgPST;
            tbPostnum.BackColor = SystemColors.Control;
            tbKunta.ReadOnly = true;
            tbKunta.Text = OrgKU;
            tbKunta.BackColor = SystemColors.Control;
            tbSaPo.ReadOnly = true;
            tbSaPo.Text = OrgSP;
            tbSaPo.BackColor = SystemColors.Control;
            tbSite.ReadOnly = true;
            tbSite.Text = OrgST;
            tbSite.BackColor = SystemColors.Control;
            tbPuh.ReadOnly = true;
            tbPuh.Text = OrgPH1;
            tbPuh.BackColor = SystemColors.Control;
            tbPuh2.ReadOnly = true;
            tbPuh2.Text = OrgPH2;
            tbPuh2.BackColor = SystemColors.Control;
            tbYritys.ReadOnly = true;
            tbYritys.Text = OrgYR;
            tbYritys.BackColor = SystemColors.Control;
            tbThNim.ReadOnly = true;
            tbThNim.Text = OrgTHN;
            tbThNim.BackColor = SystemColors.Control;
            tbMuu.ReadOnly = true;
            tbMuu.Text = OrgMU;
            tbMuu.BackColor = SystemColors.Control;
            tbKrNimi.ReadOnly = true;
            tbKrNimi.Text = OrgN;
            tbKrNimi.BackColor = SystemColors.Control;
            tbKoeNimi.ReadOnly = true;
            tbKoeNimi.Text = OrgKN;
            tbKoeNimi.BackColor = SystemColors.Control;
            tbOpett.ReadOnly = true;
            tbOpett.Text = OrgOp;
            tbOpett.BackColor = SystemColors.Control;
            tbVaik.ReadOnly = true;
            tbVaik.Text = OrgVk;
            tbVaik.BackColor = SystemColors.Control;
            tbKieli.ReadOnly = true;
            tbKieli.Text = OrgKl;
            tbKieli.BackColor = SystemColors.Control;
            tbPvm.Text = OrgPvm;
            tbPvm.BackColor = SystemColors.Control;
            tbTPO.ReadOnly = true;
            tbTPO.Text = OrgTPO;
            tbTPO.BackColor = SystemColors.Control;
            tbSPO.ReadOnly = true;
            tbSPO.Text = OrgSPO;
            tbSPO.BackColor = SystemColors.Control;
            btnResEmp.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnTyh_Click(object sender, EventArgs e)
        {
            gbOp.Enabled = false;
            gbMuu.Enabled = false;
            gbKrHaku.Enabled = false;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
            lbOpID.Text = "ID";
            lbKrID.Text = "Kurssin ID";
            lbKoID.Text = "Kokeen ID";
            lbVID.Text = "Vastaus ID";
            tbOp.Text = "";
            tbKr.Text = "";
            tbKoe.Text = "";
            tbEtunimi.ReadOnly = true;
            tbEtunimi.Text = "";
            tbEtunimi.BackColor = SystemColors.Control;
            tbSukunimi.ReadOnly = true;
            tbSukunimi.Text = "";
            tbSukunimi.BackColor = SystemColors.Control;
            tbHloT.ReadOnly = true;
            tbHloT.Text = "";
            tbHloT.BackColor = SystemColors.Control;
            tbMaa.ReadOnly = true;
            tbMaa.Text = "";
            tbMaa.BackColor = SystemColors.Control;
            tbOsoite.ReadOnly = true;
            tbOsoite.Text = "";
            tbOsoite.BackColor = SystemColors.Control;
            tbPostnum.ReadOnly = true;
            tbPostnum.Text = "";
            tbPostnum.BackColor = SystemColors.Control;
            tbKunta.ReadOnly = true;
            tbKunta.Text = "";
            tbKunta.BackColor = SystemColors.Control;
            tbSaPo.ReadOnly = true;
            tbSaPo.Text = "";
            tbSaPo.BackColor = SystemColors.Control;
            tbSite.ReadOnly = true;
            tbSite.Text = "";
            tbSite.BackColor = SystemColors.Control;
            tbPuh.ReadOnly = true;
            tbPuh.Text = "";
            tbPuh.BackColor = SystemColors.Control;
            tbPuh2.ReadOnly = true;
            tbPuh2.Text = "";
            tbPuh2.BackColor = SystemColors.Control;
            tbYritys.ReadOnly = true;
            tbYritys.Text = "";
            tbYritys.BackColor = SystemColors.Control;
            tbThNim.ReadOnly = true;
            tbThNim.Text = "";
            tbThNim.BackColor = SystemColors.Control;
            tbMuu.ReadOnly = true;
            tbMuu.Text = "";
            tbMuu.BackColor = SystemColors.Control;
            tbKrNimi.ReadOnly = true;
            tbKrNimi.Text = "";
            tbKrNimi.BackColor = SystemColors.Control;
            tbKoeNimi.ReadOnly = true;
            tbKoeNimi.Text = "";
            tbKoeNimi.BackColor = SystemColors.Control;
            tbOpett.ReadOnly = true;
            tbOpett.Text = "";
            tbOpett.BackColor = SystemColors.Control;
            tbVaik.ReadOnly = true;
            tbVaik.Text = "";
            tbVaik.BackColor = SystemColors.Control;
            tbKieli.ReadOnly = true;
            tbKieli.Text = "";
            tbKieli.BackColor = SystemColors.Control;
            tbPvm.Text = "";
            tbPvm.BackColor = SystemColors.Control;
            tbTPO.ReadOnly = true;
            tbTPO.Text = "";
            tbTPO.BackColor = SystemColors.Control;
            tbSPO.ReadOnly = true;
            tbSPO.Text = "";
            tbSPO.BackColor = SystemColors.Control;
            btnResEmp.Enabled = false;
            btnSave.Enabled = false;
            btndelet.Enabled = false;
            btnTyh.Enabled = false;
            //
            OrgEN = null;
            OrgSN = null;
            OrgHLT = null;
            OrgM = null;
            OrgOS = null;
            OrgPST = null;
            OrgKU = null;
            OrgSP = null;
            OrgST = null;
            OrgPH1 = null;
            OrgPH2 = null;
            OrgYR = null;
            OrgTHN = null;
            OrgMU = null;
            OrgN = null;
            OrgKN = null;
            OrgOp = null;
            OrgVk = null;
            OrgKl = null;
            OrgPvm = null;
            OrgTPO = null;
            OrgSPO = null;
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SaveForm
            //Stored Procedures

        }

        private void btnIDPrev_Click(object sender, EventArgs e)
        {
            //REPLACE WITH THING BASED ON ID
            gbOp.Enabled = true;
            gbMuu.Enabled = true;
            gbKrHaku.Enabled = true;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
            // Reset all from Kr
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //REPLACE WITH THING BASED ON ID
            gbOp.Enabled = true;
            gbMuu.Enabled = true;
            gbKrHaku.Enabled = true;
            gbKr.Enabled = false;
            gbKoeHaku.Enabled = false;
            gbKoe.Enabled = false;
            // Reset all from Kr
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            //DataAccess Remove row (by id?) STORED PROCEDURES
            //MORE (if hasn't saved, ask)
            //DeleteForm

        }

        //TEXTBOXES
        
        private void tbEtunimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbEtunimi.ReadOnly = false;
        }

        private void tbEtunimi_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbEtunimi.BackColor = SystemColors.Window;
        }

        private void tbSukunimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbSukunimi.ReadOnly = false;
        }

        private void tbSukunimi_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbSukunimi.BackColor = SystemColors.Window;
        }

        private void tbHloT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbHloT.ReadOnly = false;
        }

        private void tbHloT_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbHloT.BackColor = SystemColors.Window;
        }

        private void tbMaa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbMaa.ReadOnly = false;
        }

        private void tbMaa_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbMaa.BackColor = SystemColors.Window;
        }

        private void tbOsoite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbOsoite.ReadOnly = false;
        }

        private void tbOsoite_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbOsoite.BackColor = SystemColors.Window;
        }

        private void tbPostnum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbPostnum.ReadOnly = false;
        }

        private void tbPostnum_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbPostnum.BackColor = SystemColors.Window;
        }

        private void tbKunta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbKunta.ReadOnly = false;
        }

        private void tbKunta_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbKunta.BackColor = SystemColors.Window;
        }

        private void tbSaPo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbSaPo.ReadOnly = false;
        }

        private void tbSaPo_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbSaPo.BackColor = SystemColors.Window;
        }

        private void tbSite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbSite.ReadOnly = false;
        }

        private void tbSite_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbSite.BackColor = SystemColors.Window;
        }

        private void tbPuh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbPuh.ReadOnly = false;
        }

        private void tbPuh_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbPuh.BackColor = SystemColors.Window;
        }

        private void tbPuh2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbPuh2.ReadOnly = false;
        }

        private void tbPuh2_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbPuh2.BackColor = SystemColors.Window;
        }

        private void tbYritys_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbYritys.ReadOnly = false;
        }

        private void tbYritys_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbYritys.BackColor = SystemColors.Window;
        }

        private void tbThNim_ReadOnlyChanged(object sender, EventArgs e)
        {
            tbThNim.ReadOnly = false;
        }

        private void tbThNim_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbThNim.BackColor = SystemColors.Window;
        }

        //

        private void tbKrNimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbKrNimi.ReadOnly = false;
        }

        private void tbKrNimi_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbKrNimi.BackColor = SystemColors.Window;
        }

        //

        private void tbKoeNimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbKoeNimi.ReadOnly = false;
        }

        private void tbKoeNimi_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbKoeNimi.BackColor = SystemColors.Window;
        }

        private void tbOpett_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbOpett.ReadOnly = false;
        }

        private void tbOpett_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbOpett.BackColor = SystemColors.Window;
        }

        private void tbVaik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbVaik.ReadOnly = false;
        }

        private void tbVaik_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbVaik.BackColor = SystemColors.Window;
        }

        private void tbKieli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbKieli.ReadOnly = false;
        }

        private void tbKieli_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbKoeNimi.BackColor = SystemColors.Window;
        }

        private void tbPvm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tbPvm.Text == "")
            {
                PvmForm pvmForm = new PvmForm(day,month,year, fdate);
                day = pvmForm.Day;
                month = pvmForm.Month;
                year = pvmForm.Year;
                pvmForm.ShowDialog();
                this.Show();
                tbPvm.Text = pvmForm.FinalDate;
                btnResEmp.Enabled = false;
                btnSave.Enabled = false;
                
            }
            else
            {
                //YOU GET NOTHING, YOU LOSE, GOOD DAY SIR!
            }
        }

        private void tbPvm_ReadOnlyChanged(object sender, EventArgs e)
        {
            //DELETE
        }

        private void tbTPO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbTPO.ReadOnly = false;
        }

        private void tbTPO_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbTPO.BackColor = SystemColors.Window;
        }

        private void tbSPO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbSPO.ReadOnly = false;
        }

        private void tbSPO_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnResEmp.Enabled = true;
            btnSave.Enabled = true;
            tbSPO.BackColor = SystemColors.Window;
        }
    }
}
