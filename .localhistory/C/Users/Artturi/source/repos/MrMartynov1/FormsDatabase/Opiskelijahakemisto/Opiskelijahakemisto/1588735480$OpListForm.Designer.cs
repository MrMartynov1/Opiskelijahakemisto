namespace Opiskelijahakemisto
{
    partial class OpListForm
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
            this.lsbOp = new System.Windows.Forms.ListBox();
            this.btnVal = new System.Windows.Forms.Button();
            this.btnPeru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbOp
            // 
            this.lsbOp.FormattingEnabled = true;
            this.lsbOp.Location = new System.Drawing.Point(12, 12);
            this.lsbOp.Name = "lsbOp";
            this.lsbOp.Size = new System.Drawing.Size(308, 225);
            this.lsbOp.TabIndex = 0;
            this.lsbOp.TabStop = false;
            this.lsbOp.Click += new System.EventHandler(this.lsbOp_Click);
            this.lsbOp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbOp_MouseClick);
            this.lsbOp.SelectedIndexChanged += new System.EventHandler(this.lsbOp_SelectedIndexChanged);
            this.lsbOp.Enter += new System.EventHandler(this.lsbOp_Enter);
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(200, 243);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(120, 28);
            this.btnVal.TabIndex = 1;
            this.btnVal.Text = "Valitse";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnPeru
            // 
            this.btnPeru.Location = new System.Drawing.Point(12, 243);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(120, 28);
            this.btnPeru.TabIndex = 2;
            this.btnPeru.Text = "Peruuta";
            this.btnPeru.UseVisualStyleBackColor = true;
            this.btnPeru.Click += new System.EventHandler(this.btnPeru_Click);
            // 
            // OpListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 280);
            this.Controls.Add(this.btnPeru);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.lsbOp);
            this.Name = "OpListForm";
            this.Text = "Opiskelijan haku";
            this.Load += new System.EventHandler(this.OpListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbOp;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnPeru;
    }
}