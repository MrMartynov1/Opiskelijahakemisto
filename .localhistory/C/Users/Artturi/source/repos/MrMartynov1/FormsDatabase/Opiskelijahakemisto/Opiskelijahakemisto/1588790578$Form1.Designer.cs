namespace Opiskelijahakemisto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOp = new System.Windows.Forms.TextBox();
            this.btnHakuOp = new System.Windows.Forms.Button();
            this.gbOp = new System.Windows.Forms.GroupBox();
            this.tbThNim = new System.Windows.Forms.TextBox();
            this.tbYritys = new System.Windows.Forms.TextBox();
            this.tbPuh2 = new System.Windows.Forms.TextBox();
            this.tbPuh = new System.Windows.Forms.TextBox();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.tbSaPo = new System.Windows.Forms.TextBox();
            this.tbKunta = new System.Windows.Forms.TextBox();
            this.tbPostnum = new System.Windows.Forms.TextBox();
            this.tbOsoite = new System.Windows.Forms.TextBox();
            this.tbMaa = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbHloT = new System.Windows.Forms.TextBox();
            this.lbThN = new System.Windows.Forms.Label();
            this.lbYrt = new System.Windows.Forms.Label();
            this.lbPuh2 = new System.Windows.Forms.Label();
            this.lbPuh1 = new System.Windows.Forms.Label();
            this.lbWeb = new System.Windows.Forms.Label();
            this.lbSaPo = new System.Windows.Forms.Label();
            this.lbPostnum = new System.Windows.Forms.Label();
            this.lbKunta = new System.Windows.Forms.Label();
            this.lbOs = new System.Windows.Forms.Label();
            this.lbMaa = new System.Windows.Forms.Label();
            this.lbHlotun = new System.Windows.Forms.Label();
            this.lbSuku = new System.Windows.Forms.Label();
            this.lbEtu = new System.Windows.Forms.Label();
            this.lbOpID = new System.Windows.Forms.Label();
            this.gbMuu = new System.Windows.Forms.GroupBox();
            this.tbMuu = new System.Windows.Forms.TextBox();
            this.gbKr = new System.Windows.Forms.GroupBox();
            this.tbKrNimi = new System.Windows.Forms.TextBox();
            this.lbKrN = new System.Windows.Forms.Label();
            this.lbKrID = new System.Windows.Forms.Label();
            this.btnHakuKur = new System.Windows.Forms.Button();
            this.tbKr = new System.Windows.Forms.TextBox();
            this.gbKoe = new System.Windows.Forms.GroupBox();
            this.tbVaik = new System.Windows.Forms.TextBox();
            this.tbKieli = new System.Windows.Forms.TextBox();
            this.tbPvm = new System.Windows.Forms.TextBox();
            this.tbSPO = new System.Windows.Forms.TextBox();
            this.tbTPO = new System.Windows.Forms.TextBox();
            this.tbOpett = new System.Windows.Forms.TextBox();
            this.tbKoeNimi = new System.Windows.Forms.TextBox();
            this.lbPerc = new System.Windows.Forms.Label();
            this.lbReq = new System.Windows.Forms.Label();
            this.lbPvm = new System.Windows.Forms.Label();
            this.lbKiel = new System.Windows.Forms.Label();
            this.lbVaik = new System.Windows.Forms.Label();
            this.lbOpt = new System.Windows.Forms.Label();
            this.lbKoN = new System.Windows.Forms.Label();
            this.lbKoID = new System.Windows.Forms.Label();
            this.btnHakuKoe = new System.Windows.Forms.Button();
            this.tbKoe = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnResEmp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbHakuOp = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palautaTyhjennäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIDPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.gbKrHaku = new System.Windows.Forms.GroupBox();
            this.gbKoeHaku = new System.Windows.Forms.GroupBox();
            this.gbOp.SuspendLayout();
            this.gbMuu.SuspendLayout();
            this.gbKr.SuspendLayout();
            this.gbKoe.SuspendLayout();
            this.gbHakuOp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbKrHaku.SuspendLayout();
            this.gbKoeHaku.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOp
            // 
            this.tbOp.Location = new System.Drawing.Point(6, 28);
            this.tbOp.Name = "tbOp";
            this.tbOp.Size = new System.Drawing.Size(209, 20);
            this.tbOp.TabIndex = 0;
            this.tbOp.TabStop = false;
            // 
            // btnHakuOp
            // 
            this.btnHakuOp.Location = new System.Drawing.Point(221, 26);
            this.btnHakuOp.Name = "btnHakuOp";
            this.btnHakuOp.Size = new System.Drawing.Size(75, 23);
            this.btnHakuOp.TabIndex = 1;
            this.btnHakuOp.TabStop = false;
            this.btnHakuOp.Text = "Haku";
            this.btnHakuOp.UseVisualStyleBackColor = true;
            this.btnHakuOp.Click += new System.EventHandler(this.btnHakuOp_Click);
            // 
            // gbOp
            // 
            this.gbOp.Controls.Add(this.tbThNim);
            this.gbOp.Controls.Add(this.tbYritys);
            this.gbOp.Controls.Add(this.tbPuh2);
            this.gbOp.Controls.Add(this.tbPuh);
            this.gbOp.Controls.Add(this.tbSite);
            this.gbOp.Controls.Add(this.tbSaPo);
            this.gbOp.Controls.Add(this.tbKunta);
            this.gbOp.Controls.Add(this.tbPostnum);
            this.gbOp.Controls.Add(this.tbOsoite);
            this.gbOp.Controls.Add(this.tbMaa);
            this.gbOp.Controls.Add(this.tbSukunimi);
            this.gbOp.Controls.Add(this.tbEtunimi);
            this.gbOp.Controls.Add(this.tbHloT);
            this.gbOp.Controls.Add(this.lbThN);
            this.gbOp.Controls.Add(this.lbYrt);
            this.gbOp.Controls.Add(this.lbPuh2);
            this.gbOp.Controls.Add(this.lbPuh1);
            this.gbOp.Controls.Add(this.lbWeb);
            this.gbOp.Controls.Add(this.lbSaPo);
            this.gbOp.Controls.Add(this.lbPostnum);
            this.gbOp.Controls.Add(this.lbKunta);
            this.gbOp.Controls.Add(this.lbOs);
            this.gbOp.Controls.Add(this.lbMaa);
            this.gbOp.Controls.Add(this.lbHlotun);
            this.gbOp.Controls.Add(this.lbSuku);
            this.gbOp.Controls.Add(this.lbEtu);
            this.gbOp.Controls.Add(this.lbOpID);
            this.gbOp.Enabled = false;
            this.gbOp.Location = new System.Drawing.Point(29, 110);
            this.gbOp.Name = "gbOp";
            this.gbOp.Size = new System.Drawing.Size(306, 378);
            this.gbOp.TabIndex = 2;
            this.gbOp.TabStop = false;
            this.gbOp.Text = "Opiskelija";
            // 
            // tbThNim
            // 
            this.tbThNim.Location = new System.Drawing.Point(153, 289);
            this.tbThNim.Name = "tbThNim";
            this.tbThNim.Size = new System.Drawing.Size(139, 20);
            this.tbThNim.TabIndex = 26;
            this.tbThNim.TabStop = false;
            this.tbThNim.TextChanged += new System.EventHandler(this.tbThNim_TextChanged);
            // 
            // tbYritys
            // 
            this.tbYritys.Location = new System.Drawing.Point(29, 290);
            this.tbYritys.Name = "tbYritys";
            this.tbYritys.Size = new System.Drawing.Size(118, 20);
            this.tbYritys.TabIndex = 25;
            this.tbYritys.TabStop = false;
            this.tbYritys.TextChanged += new System.EventHandler(this.tbYritys_TextChanged);
            // 
            // tbPuh2
            // 
            this.tbPuh2.Location = new System.Drawing.Point(153, 250);
            this.tbPuh2.Name = "tbPuh2";
            this.tbPuh2.Size = new System.Drawing.Size(139, 20);
            this.tbPuh2.TabIndex = 24;
            this.tbPuh2.TabStop = false;
            this.tbPuh2.TextChanged += new System.EventHandler(this.tbPuh2_TextChanged);
            // 
            // tbPuh
            // 
            this.tbPuh.Location = new System.Drawing.Point(29, 251);
            this.tbPuh.Name = "tbPuh";
            this.tbPuh.Size = new System.Drawing.Size(118, 20);
            this.tbPuh.TabIndex = 23;
            this.tbPuh.TabStop = false;
            this.tbPuh.TextChanged += new System.EventHandler(this.tbPuh_TextChanged);
            // 
            // tbSite
            // 
            this.tbSite.Location = new System.Drawing.Point(153, 212);
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(139, 20);
            this.tbSite.TabIndex = 22;
            this.tbSite.TabStop = false;
            this.tbSite.TextChanged += new System.EventHandler(this.tbSite_TextChanged);
            // 
            // tbSaPo
            // 
            this.tbSaPo.Location = new System.Drawing.Point(29, 212);
            this.tbSaPo.Name = "tbSaPo";
            this.tbSaPo.Size = new System.Drawing.Size(118, 20);
            this.tbSaPo.TabIndex = 21;
            this.tbSaPo.TabStop = false;
            this.tbSaPo.TextChanged += new System.EventHandler(this.tbSaPo_TextChanged);
            // 
            // tbKunta
            // 
            this.tbKunta.Location = new System.Drawing.Point(153, 173);
            this.tbKunta.Name = "tbKunta";
            this.tbKunta.Size = new System.Drawing.Size(139, 20);
            this.tbKunta.TabIndex = 20;
            this.tbKunta.TabStop = false;
            this.tbKunta.TextChanged += new System.EventHandler(this.tbKunta_TextChanged);
            // 
            // tbPostnum
            // 
            this.tbPostnum.Location = new System.Drawing.Point(29, 173);
            this.tbPostnum.Name = "tbPostnum";
            this.tbPostnum.Size = new System.Drawing.Size(118, 20);
            this.tbPostnum.TabIndex = 19;
            this.tbPostnum.TabStop = false;
            this.tbPostnum.TextChanged += new System.EventHandler(this.tbPostnum_TextChanged);
            // 
            // tbOsoite
            // 
            this.tbOsoite.Location = new System.Drawing.Point(29, 134);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(263, 20);
            this.tbOsoite.TabIndex = 18;
            this.tbOsoite.TabStop = false;
            this.tbOsoite.TextChanged += new System.EventHandler(this.tbOsoite_TextChanged);
            // 
            // tbMaa
            // 
            this.tbMaa.Location = new System.Drawing.Point(183, 93);
            this.tbMaa.Name = "tbMaa";
            this.tbMaa.Size = new System.Drawing.Size(109, 20);
            this.tbMaa.TabIndex = 17;
            this.tbMaa.TabStop = false;
            this.tbMaa.TextChanged += new System.EventHandler(this.tbMaa_TextChanged);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(183, 49);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(109, 20);
            this.tbSukunimi.TabIndex = 16;
            this.tbSukunimi.TabStop = false;
            this.tbSukunimi.TextChanged += new System.EventHandler(this.tbSukunimi_TextChanged);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(68, 49);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.ReadOnly = true;
            this.tbEtunimi.Size = new System.Drawing.Size(109, 20);
            this.tbEtunimi.TabIndex = 15;
            this.tbEtunimi.TabStop = false;
            this.tbEtunimi.ReadOnlyChanged += new System.EventHandler(this.tbEtunimi_ReadOnlyChanged);
            this.tbEtunimi.TextChanged += new System.EventHandler(this.tbEtunimi_TextChanged);
            this.tbEtunimi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseDoubleClick);
            // 
            // tbHloT
            // 
            this.tbHloT.Location = new System.Drawing.Point(68, 93);
            this.tbHloT.Name = "tbHloT";
            this.tbHloT.Size = new System.Drawing.Size(109, 20);
            this.tbHloT.TabIndex = 14;
            this.tbHloT.TabStop = false;
            this.tbHloT.TextChanged += new System.EventHandler(this.tbHloT_TextChanged);
            // 
            // lbThN
            // 
            this.lbThN.AutoSize = true;
            this.lbThN.Location = new System.Drawing.Point(150, 273);
            this.lbThN.Name = "lbThN";
            this.lbThN.Size = new System.Drawing.Size(77, 13);
            this.lbThN.TabIndex = 13;
            this.lbThN.Text = "Tehtävänimike";
            // 
            // lbYrt
            // 
            this.lbYrt.AutoSize = true;
            this.lbYrt.Location = new System.Drawing.Point(26, 274);
            this.lbYrt.Name = "lbYrt";
            this.lbYrt.Size = new System.Drawing.Size(32, 13);
            this.lbYrt.TabIndex = 12;
            this.lbYrt.Text = "Yritys";
            // 
            // lbPuh2
            // 
            this.lbPuh2.AutoSize = true;
            this.lbPuh2.Location = new System.Drawing.Point(150, 235);
            this.lbPuh2.Name = "lbPuh2";
            this.lbPuh2.Size = new System.Drawing.Size(95, 13);
            this.lbPuh2.TabIndex = 11;
            this.lbPuh2.Text = "(2. Puhelinnumero)";
            // 
            // lbPuh1
            // 
            this.lbPuh1.AutoSize = true;
            this.lbPuh1.Location = new System.Drawing.Point(26, 235);
            this.lbPuh1.Name = "lbPuh1";
            this.lbPuh1.Size = new System.Drawing.Size(77, 13);
            this.lbPuh1.TabIndex = 10;
            this.lbPuh1.Text = "Puhelinnumero";
            // 
            // lbWeb
            // 
            this.lbWeb.AutoSize = true;
            this.lbWeb.Location = new System.Drawing.Point(150, 199);
            this.lbWeb.Name = "lbWeb";
            this.lbWeb.Size = new System.Drawing.Size(47, 13);
            this.lbWeb.TabIndex = 9;
            this.lbWeb.Text = "Kotisivut";
            // 
            // lbSaPo
            // 
            this.lbSaPo.AutoSize = true;
            this.lbSaPo.Location = new System.Drawing.Point(26, 196);
            this.lbSaPo.Name = "lbSaPo";
            this.lbSaPo.Size = new System.Drawing.Size(88, 13);
            this.lbSaPo.TabIndex = 8;
            this.lbSaPo.Text = "Sähköpostiosoite";
            // 
            // lbPostnum
            // 
            this.lbPostnum.AutoSize = true;
            this.lbPostnum.Location = new System.Drawing.Point(26, 157);
            this.lbPostnum.Name = "lbPostnum";
            this.lbPostnum.Size = new System.Drawing.Size(65, 13);
            this.lbPostnum.TabIndex = 7;
            this.lbPostnum.Text = "Postinumero";
            // 
            // lbKunta
            // 
            this.lbKunta.AutoSize = true;
            this.lbKunta.Location = new System.Drawing.Point(150, 157);
            this.lbKunta.Name = "lbKunta";
            this.lbKunta.Size = new System.Drawing.Size(67, 13);
            this.lbKunta.TabIndex = 6;
            this.lbKunta.Text = "Paikkakunta";
            // 
            // lbOs
            // 
            this.lbOs.AutoSize = true;
            this.lbOs.Location = new System.Drawing.Point(26, 122);
            this.lbOs.Name = "lbOs";
            this.lbOs.Size = new System.Drawing.Size(37, 13);
            this.lbOs.TabIndex = 5;
            this.lbOs.Text = "Osoite";
            // 
            // lbMaa
            // 
            this.lbMaa.AutoSize = true;
            this.lbMaa.Location = new System.Drawing.Point(180, 77);
            this.lbMaa.Name = "lbMaa";
            this.lbMaa.Size = new System.Drawing.Size(69, 13);
            this.lbMaa.TabIndex = 4;
            this.lbMaa.Text = "Kansalaisuus";
            // 
            // lbHlotun
            // 
            this.lbHlotun.AutoSize = true;
            this.lbHlotun.Location = new System.Drawing.Point(65, 77);
            this.lbHlotun.Name = "lbHlotun";
            this.lbHlotun.Size = new System.Drawing.Size(75, 13);
            this.lbHlotun.TabIndex = 3;
            this.lbHlotun.Text = "Henkilötunnus";
            // 
            // lbSuku
            // 
            this.lbSuku.AutoSize = true;
            this.lbSuku.Location = new System.Drawing.Point(180, 33);
            this.lbSuku.Name = "lbSuku";
            this.lbSuku.Size = new System.Drawing.Size(50, 13);
            this.lbSuku.TabIndex = 2;
            this.lbSuku.Text = "Sukunimi";
            // 
            // lbEtu
            // 
            this.lbEtu.AutoSize = true;
            this.lbEtu.Location = new System.Drawing.Point(65, 33);
            this.lbEtu.Name = "lbEtu";
            this.lbEtu.Size = new System.Drawing.Size(41, 13);
            this.lbEtu.TabIndex = 1;
            this.lbEtu.Text = "Etunimi";
            // 
            // lbOpID
            // 
            this.lbOpID.AutoSize = true;
            this.lbOpID.Location = new System.Drawing.Point(26, 44);
            this.lbOpID.Name = "lbOpID";
            this.lbOpID.Size = new System.Drawing.Size(18, 13);
            this.lbOpID.TabIndex = 0;
            this.lbOpID.Text = "ID";
            // 
            // gbMuu
            // 
            this.gbMuu.Controls.Add(this.tbMuu);
            this.gbMuu.Enabled = false;
            this.gbMuu.Location = new System.Drawing.Point(341, 42);
            this.gbMuu.Name = "gbMuu";
            this.gbMuu.Size = new System.Drawing.Size(324, 87);
            this.gbMuu.TabIndex = 3;
            this.gbMuu.TabStop = false;
            this.gbMuu.Text = "Muuta huomioitavaa";
            // 
            // tbMuu
            // 
            this.tbMuu.Location = new System.Drawing.Point(6, 19);
            this.tbMuu.MinimumSize = new System.Drawing.Size(150, 60);
            this.tbMuu.Name = "tbMuu";
            this.tbMuu.Size = new System.Drawing.Size(312, 20);
            this.tbMuu.TabIndex = 1;
            this.tbMuu.TabStop = false;
            this.tbMuu.TextChanged += new System.EventHandler(this.tbMuu_TextChanged);
            // 
            // gbKr
            // 
            this.gbKr.Controls.Add(this.tbKrNimi);
            this.gbKr.Controls.Add(this.lbKrN);
            this.gbKr.Controls.Add(this.lbKrID);
            this.gbKr.Enabled = false;
            this.gbKr.Location = new System.Drawing.Point(341, 195);
            this.gbKr.Name = "gbKr";
            this.gbKr.Size = new System.Drawing.Size(324, 59);
            this.gbKr.TabIndex = 4;
            this.gbKr.TabStop = false;
            this.gbKr.Text = "Kurssi";
            // 
            // tbKrNimi
            // 
            this.tbKrNimi.Location = new System.Drawing.Point(104, 32);
            this.tbKrNimi.Name = "tbKrNimi";
            this.tbKrNimi.Size = new System.Drawing.Size(214, 20);
            this.tbKrNimi.TabIndex = 27;
            this.tbKrNimi.TabStop = false;
            this.tbKrNimi.TextChanged += new System.EventHandler(this.tbKrNimi_TextChanged);
            // 
            // lbKrN
            // 
            this.lbKrN.AutoSize = true;
            this.lbKrN.Location = new System.Drawing.Point(101, 16);
            this.lbKrN.Name = "lbKrN";
            this.lbKrN.Size = new System.Drawing.Size(27, 13);
            this.lbKrN.TabIndex = 5;
            this.lbKrN.Text = "Nimi";
            // 
            // lbKrID
            // 
            this.lbKrID.AutoSize = true;
            this.lbKrID.Location = new System.Drawing.Point(3, 30);
            this.lbKrID.Name = "lbKrID";
            this.lbKrID.Size = new System.Drawing.Size(55, 13);
            this.lbKrID.TabIndex = 4;
            this.lbKrID.Text = "Kurssin ID";
            // 
            // btnHakuKur
            // 
            this.btnHakuKur.Location = new System.Drawing.Point(241, 20);
            this.btnHakuKur.Name = "btnHakuKur";
            this.btnHakuKur.Size = new System.Drawing.Size(75, 23);
            this.btnHakuKur.TabIndex = 3;
            this.btnHakuKur.TabStop = false;
            this.btnHakuKur.Text = "Haku";
            this.btnHakuKur.UseVisualStyleBackColor = true;
            this.btnHakuKur.Click += new System.EventHandler(this.btnHakuKur_Click);
            // 
            // tbKr
            // 
            this.tbKr.Location = new System.Drawing.Point(4, 22);
            this.tbKr.Name = "tbKr";
            this.tbKr.Size = new System.Drawing.Size(231, 20);
            this.tbKr.TabIndex = 2;
            this.tbKr.TabStop = false;
            // 
            // gbKoe
            // 
            this.gbKoe.Controls.Add(this.tbVaik);
            this.gbKoe.Controls.Add(this.tbKieli);
            this.gbKoe.Controls.Add(this.tbPvm);
            this.gbKoe.Controls.Add(this.tbSPO);
            this.gbKoe.Controls.Add(this.tbTPO);
            this.gbKoe.Controls.Add(this.tbOpett);
            this.gbKoe.Controls.Add(this.tbKoeNimi);
            this.gbKoe.Controls.Add(this.lbPerc);
            this.gbKoe.Controls.Add(this.lbReq);
            this.gbKoe.Controls.Add(this.lbPvm);
            this.gbKoe.Controls.Add(this.lbKiel);
            this.gbKoe.Controls.Add(this.lbVaik);
            this.gbKoe.Controls.Add(this.lbOpt);
            this.gbKoe.Controls.Add(this.lbKoN);
            this.gbKoe.Controls.Add(this.lbKoID);
            this.gbKoe.Enabled = false;
            this.gbKoe.Location = new System.Drawing.Point(341, 322);
            this.gbKoe.Name = "gbKoe";
            this.gbKoe.Size = new System.Drawing.Size(324, 166);
            this.gbKoe.TabIndex = 5;
            this.gbKoe.TabStop = false;
            this.gbKoe.Text = "Kokeet";
            // 
            // tbVaik
            // 
            this.tbVaik.Location = new System.Drawing.Point(9, 78);
            this.tbVaik.Name = "tbVaik";
            this.tbVaik.Size = new System.Drawing.Size(55, 20);
            this.tbVaik.TabIndex = 31;
            this.tbVaik.TabStop = false;
            this.tbVaik.TextChanged += new System.EventHandler(this.tbVaik_TextChanged);
            // 
            // tbKieli
            // 
            this.tbKieli.Location = new System.Drawing.Point(70, 78);
            this.tbKieli.Name = "tbKieli";
            this.tbKieli.Size = new System.Drawing.Size(120, 20);
            this.tbKieli.TabIndex = 30;
            this.tbKieli.TabStop = false;
            this.tbKieli.TextChanged += new System.EventHandler(this.tbKieli_TextChanged);
            // 
            // tbPvm
            // 
            this.tbPvm.Location = new System.Drawing.Point(199, 78);
            this.tbPvm.Name = "tbPvm";
            this.tbPvm.Size = new System.Drawing.Size(119, 20);
            this.tbPvm.TabIndex = 27;
            this.tbPvm.TabStop = false;
            this.tbPvm.TextChanged += new System.EventHandler(this.tbPvm_TextChanged);
            // 
            // tbSPO
            // 
            this.tbSPO.Location = new System.Drawing.Point(167, 126);
            this.tbSPO.Name = "tbSPO";
            this.tbSPO.Size = new System.Drawing.Size(151, 20);
            this.tbSPO.TabIndex = 29;
            this.tbSPO.TabStop = false;
            this.tbSPO.TextChanged += new System.EventHandler(this.tbSPO_TextChanged);
            // 
            // tbTPO
            // 
            this.tbTPO.Location = new System.Drawing.Point(9, 126);
            this.tbTPO.Name = "tbTPO";
            this.tbTPO.Size = new System.Drawing.Size(152, 20);
            this.tbTPO.TabIndex = 27;
            this.tbTPO.TabStop = false;
            this.tbTPO.TextChanged += new System.EventHandler(this.tbTPO_TextChanged);
            // 
            // tbOpett
            // 
            this.tbOpett.Location = new System.Drawing.Point(199, 39);
            this.tbOpett.Name = "tbOpett";
            this.tbOpett.Size = new System.Drawing.Size(119, 20);
            this.tbOpett.TabIndex = 28;
            this.tbOpett.TabStop = false;
            this.tbOpett.TextChanged += new System.EventHandler(this.tbOpett_TextChanged);
            // 
            // tbKoeNimi
            // 
            this.tbKoeNimi.Location = new System.Drawing.Point(70, 39);
            this.tbKoeNimi.Name = "tbKoeNimi";
            this.tbKoeNimi.Size = new System.Drawing.Size(120, 20);
            this.tbKoeNimi.TabIndex = 27;
            this.tbKoeNimi.TabStop = false;
            this.tbKoeNimi.TextChanged += new System.EventHandler(this.tbKoeNimi_TextChanged);
            // 
            // lbPerc
            // 
            this.lbPerc.AutoSize = true;
            this.lbPerc.Location = new System.Drawing.Point(164, 110);
            this.lbPerc.Name = "lbPerc";
            this.lbPerc.Size = new System.Drawing.Size(106, 13);
            this.lbPerc.TabIndex = 14;
            this.lbPerc.Text = "Saatu prosenttiosuus";
            // 
            // lbReq
            // 
            this.lbReq.AutoSize = true;
            this.lbReq.Location = new System.Drawing.Point(6, 110);
            this.lbReq.Name = "lbReq";
            this.lbReq.Size = new System.Drawing.Size(126, 13);
            this.lbReq.TabIndex = 13;
            this.lbReq.Text = "Tarvittava prosenttiosuus";
            // 
            // lbPvm
            // 
            this.lbPvm.AutoSize = true;
            this.lbPvm.Location = new System.Drawing.Point(196, 64);
            this.lbPvm.Name = "lbPvm";
            this.lbPvm.Size = new System.Drawing.Size(63, 13);
            this.lbPvm.TabIndex = 12;
            this.lbPvm.Text = "Päivämäärä";
            // 
            // lbKiel
            // 
            this.lbKiel.AutoSize = true;
            this.lbKiel.Location = new System.Drawing.Point(70, 64);
            this.lbKiel.Name = "lbKiel";
            this.lbKiel.Size = new System.Drawing.Size(26, 13);
            this.lbKiel.TabIndex = 11;
            this.lbKiel.Text = "Kieli";
            // 
            // lbVaik
            // 
            this.lbVaik.AutoSize = true;
            this.lbVaik.Location = new System.Drawing.Point(6, 65);
            this.lbVaik.Name = "lbVaik";
            this.lbVaik.Size = new System.Drawing.Size(45, 13);
            this.lbVaik.TabIndex = 10;
            this.lbVaik.Text = "Vaikeus";
            // 
            // lbOpt
            // 
            this.lbOpt.AutoSize = true;
            this.lbOpt.Location = new System.Drawing.Point(196, 23);
            this.lbOpt.Name = "lbOpt";
            this.lbOpt.Size = new System.Drawing.Size(47, 13);
            this.lbOpt.TabIndex = 9;
            this.lbOpt.Text = "Opettaja";
            // 
            // lbKoN
            // 
            this.lbKoN.AutoSize = true;
            this.lbKoN.Location = new System.Drawing.Point(70, 23);
            this.lbKoN.Name = "lbKoN";
            this.lbKoN.Size = new System.Drawing.Size(27, 13);
            this.lbKoN.TabIndex = 8;
            this.lbKoN.Text = "Nimi";
            // 
            // lbKoID
            // 
            this.lbKoID.AutoSize = true;
            this.lbKoID.Location = new System.Drawing.Point(6, 36);
            this.lbKoID.Name = "lbKoID";
            this.lbKoID.Size = new System.Drawing.Size(58, 13);
            this.lbKoID.TabIndex = 6;
            this.lbKoID.Text = "Kokeen ID";
            // 
            // btnHakuKoe
            // 
            this.btnHakuKoe.Location = new System.Drawing.Point(243, 21);
            this.btnHakuKoe.Name = "btnHakuKoe";
            this.btnHakuKoe.Size = new System.Drawing.Size(75, 23);
            this.btnHakuKoe.TabIndex = 7;
            this.btnHakuKoe.TabStop = false;
            this.btnHakuKoe.Text = "Haku";
            this.btnHakuKoe.UseVisualStyleBackColor = true;
            this.btnHakuKoe.Click += new System.EventHandler(this.btnHakuKoe_Click);
            // 
            // tbKoe
            // 
            this.tbKoe.Location = new System.Drawing.Point(9, 23);
            this.tbKoe.Name = "tbKoe";
            this.tbKoe.Size = new System.Drawing.Size(231, 20);
            this.tbKoe.TabIndex = 6;
            this.tbKoe.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(244, 494);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 28);
            this.btnNew.TabIndex = 6;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "Uusi";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnResEmp
            // 
            this.btnResEmp.Enabled = false;
            this.btnResEmp.Location = new System.Drawing.Point(445, 494);
            this.btnResEmp.Name = "btnResEmp";
            this.btnResEmp.Size = new System.Drawing.Size(101, 28);
            this.btnResEmp.TabIndex = 7;
            this.btnResEmp.TabStop = false;
            this.btnResEmp.Text = "Palauta";
            this.btnResEmp.UseVisualStyleBackColor = true;
            this.btnResEmp.Click += new System.EventHandler(this.btnResEmp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(552, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbHakuOp
            // 
            this.gbHakuOp.Controls.Add(this.tbOp);
            this.gbHakuOp.Controls.Add(this.btnHakuOp);
            this.gbHakuOp.Location = new System.Drawing.Point(33, 42);
            this.gbHakuOp.Name = "gbHakuOp";
            this.gbHakuOp.Size = new System.Drawing.Size(302, 62);
            this.gbHakuOp.TabIndex = 11;
            this.gbHakuOp.TabStop = false;
            this.gbHakuOp.Text = "Opiskelijan haku (sukunimi)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.palautaTyhjennäToolStripMenuItem,
            this.suljeToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Enabled = false;
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            // 
            // palautaTyhjennäToolStripMenuItem
            // 
            this.palautaTyhjennäToolStripMenuItem.Enabled = false;
            this.palautaTyhjennäToolStripMenuItem.Name = "palautaTyhjennäToolStripMenuItem";
            this.palautaTyhjennäToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.palautaTyhjennäToolStripMenuItem.Text = "Palauta/Tyhjennä";
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.suljeToolStripMenuItem.Text = "Sulje";
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            this.tietojaToolStripMenuItem.Click += new System.EventHandler(this.tietojaToolStripMenuItem_Click);
            // 
            // btnIDPrev
            // 
            this.btnIDPrev.Location = new System.Drawing.Point(29, 494);
            this.btnIDPrev.Name = "btnIDPrev";
            this.btnIDPrev.Size = new System.Drawing.Size(103, 28);
            this.btnIDPrev.TabIndex = 13;
            this.btnIDPrev.TabStop = false;
            this.btnIDPrev.Text = "Edellinen";
            this.btnIDPrev.UseVisualStyleBackColor = true;
            this.btnIDPrev.Click += new System.EventHandler(this.btnIDPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(135, 494);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 28);
            this.btnNext.TabIndex = 14;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Seuraava";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btndelet
            // 
            this.btndelet.Enabled = false;
            this.btndelet.Location = new System.Drawing.Point(341, 494);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(98, 28);
            this.btndelet.TabIndex = 15;
            this.btndelet.TabStop = false;
            this.btndelet.Text = "Poista";
            this.btndelet.UseVisualStyleBackColor = true;
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // gbKrHaku
            // 
            this.gbKrHaku.Controls.Add(this.btnHakuKur);
            this.gbKrHaku.Controls.Add(this.tbKr);
            this.gbKrHaku.Enabled = false;
            this.gbKrHaku.Location = new System.Drawing.Point(341, 135);
            this.gbKrHaku.Name = "gbKrHaku";
            this.gbKrHaku.Size = new System.Drawing.Size(324, 54);
            this.gbKrHaku.TabIndex = 4;
            this.gbKrHaku.TabStop = false;
            this.gbKrHaku.Text = "Kurssin haku";
            // 
            // gbKoeHaku
            // 
            this.gbKoeHaku.Controls.Add(this.btnHakuKoe);
            this.gbKoeHaku.Controls.Add(this.tbKoe);
            this.gbKoeHaku.Enabled = false;
            this.gbKoeHaku.Location = new System.Drawing.Point(341, 260);
            this.gbKoeHaku.Name = "gbKoeHaku";
            this.gbKoeHaku.Size = new System.Drawing.Size(324, 59);
            this.gbKoeHaku.TabIndex = 28;
            this.gbKoeHaku.TabStop = false;
            this.gbKoeHaku.Text = "Kokeiden haku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 532);
            this.Controls.Add(this.gbKoeHaku);
            this.Controls.Add(this.gbKrHaku);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnIDPrev);
            this.Controls.Add(this.gbHakuOp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnResEmp);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gbKoe);
            this.Controls.Add(this.gbKr);
            this.Controls.Add(this.gbMuu);
            this.Controls.Add(this.gbOp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Opiskelijahakemisto";
            this.gbOp.ResumeLayout(false);
            this.gbOp.PerformLayout();
            this.gbMuu.ResumeLayout(false);
            this.gbMuu.PerformLayout();
            this.gbKr.ResumeLayout(false);
            this.gbKr.PerformLayout();
            this.gbKoe.ResumeLayout(false);
            this.gbKoe.PerformLayout();
            this.gbHakuOp.ResumeLayout(false);
            this.gbHakuOp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbKrHaku.ResumeLayout(false);
            this.gbKrHaku.PerformLayout();
            this.gbKoeHaku.ResumeLayout(false);
            this.gbKoeHaku.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOp;
        private System.Windows.Forms.Button btnHakuOp;
        private System.Windows.Forms.GroupBox gbOp;
        private System.Windows.Forms.Label lbThN;
        private System.Windows.Forms.Label lbYrt;
        private System.Windows.Forms.Label lbPuh2;
        private System.Windows.Forms.Label lbPuh1;
        private System.Windows.Forms.Label lbWeb;
        private System.Windows.Forms.Label lbSaPo;
        private System.Windows.Forms.Label lbPostnum;
        private System.Windows.Forms.Label lbKunta;
        private System.Windows.Forms.Label lbOs;
        private System.Windows.Forms.Label lbMaa;
        private System.Windows.Forms.Label lbHlotun;
        private System.Windows.Forms.Label lbSuku;
        private System.Windows.Forms.Label lbEtu;
        private System.Windows.Forms.Label lbOpID;
        private System.Windows.Forms.GroupBox gbMuu;
        private System.Windows.Forms.TextBox tbMuu;
        private System.Windows.Forms.GroupBox gbKr;
        private System.Windows.Forms.Label lbKrN;
        private System.Windows.Forms.Label lbKrID;
        private System.Windows.Forms.Button btnHakuKur;
        private System.Windows.Forms.TextBox tbKr;
        private System.Windows.Forms.GroupBox gbKoe;
        private System.Windows.Forms.Label lbReq;
        private System.Windows.Forms.Label lbPvm;
        private System.Windows.Forms.Label lbKiel;
        private System.Windows.Forms.Label lbVaik;
        private System.Windows.Forms.Label lbOpt;
        private System.Windows.Forms.Label lbKoN;
        private System.Windows.Forms.Label lbKoID;
        private System.Windows.Forms.Button btnHakuKoe;
        private System.Windows.Forms.TextBox tbKoe;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnResEmp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbHakuOp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palautaTyhjennäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.Button btnIDPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbPerc;
        private System.Windows.Forms.Button btndelet;
        private System.Windows.Forms.TextBox tbThNim;
        private System.Windows.Forms.TextBox tbYritys;
        private System.Windows.Forms.TextBox tbPuh2;
        private System.Windows.Forms.TextBox tbPuh;
        private System.Windows.Forms.TextBox tbSite;
        private System.Windows.Forms.TextBox tbSaPo;
        private System.Windows.Forms.TextBox tbKunta;
        private System.Windows.Forms.TextBox tbPostnum;
        private System.Windows.Forms.TextBox tbOsoite;
        private System.Windows.Forms.TextBox tbMaa;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        public System.Windows.Forms.TextBox tbHloT;
        private System.Windows.Forms.TextBox tbKrNimi;
        private System.Windows.Forms.TextBox tbVaik;
        private System.Windows.Forms.TextBox tbKieli;
        private System.Windows.Forms.TextBox tbPvm;
        private System.Windows.Forms.TextBox tbSPO;
        private System.Windows.Forms.TextBox tbTPO;
        private System.Windows.Forms.TextBox tbOpett;
        private System.Windows.Forms.TextBox tbKoeNimi;
        private System.Windows.Forms.GroupBox gbKrHaku;
        private System.Windows.Forms.GroupBox gbKoeHaku;
    }
}

