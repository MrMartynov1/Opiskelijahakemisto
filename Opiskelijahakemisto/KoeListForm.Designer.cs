namespace Opiskelijahakemisto
{
    partial class KoeListForm
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
            this.btnPeru = new System.Windows.Forms.Button();
            this.btnVal = new System.Windows.Forms.Button();
            this.lsbKoe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPeru
            // 
            this.btnPeru.Location = new System.Drawing.Point(12, 243);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(120, 28);
            this.btnPeru.TabIndex = 8;
            this.btnPeru.TabStop = false;
            this.btnPeru.Text = "Peruuta";
            this.btnPeru.UseVisualStyleBackColor = true;
            this.btnPeru.Click += new System.EventHandler(this.btnPeru_Click);
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(200, 243);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(120, 28);
            this.btnVal.TabIndex = 7;
            this.btnVal.TabStop = false;
            this.btnVal.Text = "Valitse";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // lsbKoe
            // 
            this.lsbKoe.FormattingEnabled = true;
            this.lsbKoe.Location = new System.Drawing.Point(12, 12);
            this.lsbKoe.Name = "lsbKoe";
            this.lsbKoe.Size = new System.Drawing.Size(308, 225);
            this.lsbKoe.TabIndex = 6;
            this.lsbKoe.TabStop = false;
            this.lsbKoe.SelectedIndexChanged += new System.EventHandler(this.lsbKoe_SelectedIndexChanged);
            // 
            // KoeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 280);
            this.Controls.Add(this.btnPeru);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.lsbKoe);
            this.Name = "KoeListForm";
            this.Text = "Koehaku";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPeru;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.ListBox lsbKoe;
    }
}