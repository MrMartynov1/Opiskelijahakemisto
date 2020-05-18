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
    public partial class OpListForm : Form
    {
        public List<Opiskelija> opiskelijat;
        public string SukuVar { get; set; }
        public string idChecker;
        public string altered;
        public string selectedid { get; set; }

        public OpListForm(List<Opiskelija> Op, string getit, string checker, string alt)
        {
            InitializeComponent();
            
            DataAccess db = new DataAccess();
            SukuVar = getit;
            idChecker = checker;
            altered = alt;
            opiskelijat = db.HaeOpiskelijat(SukuVar);
            UpdateBindingOp();
            opiskelijat = Op;
            
            
        }

        public void UpdateBindingOp()
        {
            lsbOp.DataSource = opiskelijat;
            lsbOp.DisplayMember = "OpListInfo";
        }

        private void lsbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NOT SURE IF ITS THIS FUNCTION, BUT THE CONTENT IS THE FOLLOWING
            idChecker = lsbOp.SelectedItem.ToString();
            altered = lsbOp.SelectedItems[0].ToString();            
            //this.Close();

        }

        private void lsbOp_Click(object sender, EventArgs e)
        {

        }

        private void lsbOp_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lsbOp_Enter(object sender, EventArgs e)
        {

        }

        public void btnVal_Click(object sender, EventArgs e)
        {
            if (idChecker != null && altered != null)
            {
                //
                this.selectedid = lsbOp.SelectedValue.ToString();
                this.Close();
            }
            else
            {
                //
                MessageBox.Show("Ei valittu!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
            }
        }

        private void btnPeru_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpListForm_Load(object sender, EventArgs e)
        {
            //REMOVE THIS LATER (ONLY NEEDED AS CONFIRMATION)
            //MessageBox.Show(this.SukuVar);
        }
        
    }
}
