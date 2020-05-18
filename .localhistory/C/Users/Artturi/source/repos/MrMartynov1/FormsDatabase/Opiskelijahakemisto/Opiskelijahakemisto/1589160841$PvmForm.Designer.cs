namespace Opiskelijahakemisto
{
    partial class PvmForm
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
            this.nudPv = new System.Windows.Forms.NumericUpDown();
            this.nudKk = new System.Windows.Forms.NumericUpDown();
            this.nudV = new System.Windows.Forms.NumericUpDown();
            this.nudT = new System.Windows.Forms.NumericUpDown();
            this.nudmin = new System.Windows.Forms.NumericUpDown();
            this.lbDP = new System.Windows.Forms.Label();
            this.btnPeru = new System.Windows.Forms.Button();
            this.btnVal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPv
            // 
            this.nudPv.Location = new System.Drawing.Point(22, 61);
            this.nudPv.Name = "nudPv";
            this.nudPv.Size = new System.Drawing.Size(46, 20);
            this.nudPv.TabIndex = 0;
            // 
            // nudKk
            // 
            this.nudKk.Location = new System.Drawing.Point(74, 61);
            this.nudKk.Name = "nudKk";
            this.nudKk.Size = new System.Drawing.Size(46, 20);
            this.nudKk.TabIndex = 1;
            // 
            // nudV
            // 
            this.nudV.Location = new System.Drawing.Point(126, 61);
            this.nudV.Name = "nudV";
            this.nudV.Size = new System.Drawing.Size(68, 20);
            this.nudV.TabIndex = 2;
            // 
            // nudT
            // 
            this.nudT.Enabled = false;
            this.nudT.Location = new System.Drawing.Point(214, 61);
            this.nudT.Name = "nudT";
            this.nudT.Size = new System.Drawing.Size(46, 20);
            this.nudT.TabIndex = 3;
            // 
            // nudmin
            // 
            this.nudmin.Enabled = false;
            this.nudmin.Location = new System.Drawing.Point(271, 61);
            this.nudmin.Name = "nudmin";
            this.nudmin.Size = new System.Drawing.Size(46, 20);
            this.nudmin.TabIndex = 4;
            // 
            // lbDP
            // 
            this.lbDP.AutoSize = true;
            this.lbDP.Enabled = false;
            this.lbDP.Location = new System.Drawing.Point(260, 63);
            this.lbDP.Name = "lbDP";
            this.lbDP.Size = new System.Drawing.Size(10, 13);
            this.lbDP.TabIndex = 5;
            this.lbDP.Text = ":";
            // 
            // btnPeru
            // 
            this.btnPeru.Location = new System.Drawing.Point(14, 135);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(120, 28);
            this.btnPeru.TabIndex = 13;
            this.btnPeru.TabStop = false;
            this.btnPeru.Text = "Peruuta";
            this.btnPeru.UseVisualStyleBackColor = true;
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(202, 135);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(120, 28);
            this.btnVal.TabIndex = 12;
            this.btnVal.TabStop = false;
            this.btnVal.Text = "Valitse";
            this.btnVal.UseVisualStyleBackColor = true;
            // 
            // PvmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 217);
            this.Controls.Add(this.btnPeru);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.lbDP);
            this.Controls.Add(this.nudmin);
            this.Controls.Add(this.nudT);
            this.Controls.Add(this.nudV);
            this.Controls.Add(this.nudKk);
            this.Controls.Add(this.nudPv);
            this.Name = "PvmForm";
            this.Text = "Päivämäärä";
            ((System.ComponentModel.ISupportInitialize)(this.nudPv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPv;
        private System.Windows.Forms.NumericUpDown nudKk;
        private System.Windows.Forms.NumericUpDown nudV;
        private System.Windows.Forms.NumericUpDown nudT;
        private System.Windows.Forms.NumericUpDown nudmin;
        private System.Windows.Forms.Label lbDP;
        private System.Windows.Forms.Button btnPeru;
        private System.Windows.Forms.Button btnVal;
    }
}