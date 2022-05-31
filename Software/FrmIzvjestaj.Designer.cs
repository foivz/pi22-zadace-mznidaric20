namespace Sample_Analizer
{
    partial class FrmIzvjestaj
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.txtDatumZaprimanjaNaloga = new System.Windows.Forms.TextBox();
            this.txtPretrage = new System.Windows.Forms.TextBox();
            this.txtVrstaNaloga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(180, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Izvještaj";
            this.label6.UseMnemonic = false;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(206, 181);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(195, 20);
            this.txtZaposlenik.TabIndex = 44;
            // 
            // txtDatumZaprimanjaNaloga
            // 
            this.txtDatumZaprimanjaNaloga.Location = new System.Drawing.Point(206, 155);
            this.txtDatumZaprimanjaNaloga.Name = "txtDatumZaprimanjaNaloga";
            this.txtDatumZaprimanjaNaloga.ReadOnly = true;
            this.txtDatumZaprimanjaNaloga.Size = new System.Drawing.Size(195, 20);
            this.txtDatumZaprimanjaNaloga.TabIndex = 43;
            // 
            // txtPretrage
            // 
            this.txtPretrage.Location = new System.Drawing.Point(206, 129);
            this.txtPretrage.Name = "txtPretrage";
            this.txtPretrage.ReadOnly = true;
            this.txtPretrage.Size = new System.Drawing.Size(195, 20);
            this.txtPretrage.TabIndex = 42;
            // 
            // txtVrstaNaloga
            // 
            this.txtVrstaNaloga.Location = new System.Drawing.Point(206, 103);
            this.txtVrstaNaloga.Name = "txtVrstaNaloga";
            this.txtVrstaNaloga.ReadOnly = true;
            this.txtVrstaNaloga.Size = new System.Drawing.Size(195, 20);
            this.txtVrstaNaloga.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nalog zaprimio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Vrijeme zaprimanja naloga :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pretrage :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Vrsta Naloga :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pacijent :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(206, 77);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.ReadOnly = true;
            this.txtPacijent.Size = new System.Drawing.Size(195, 20);
            this.txtPacijent.TabIndex = 35;
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 308);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.txtDatumZaprimanjaNaloga);
            this.Controls.Add(this.txtPretrage);
            this.Controls.Add(this.txtVrstaNaloga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPacijent);
            this.Name = "FrmIzvjestaj";
            this.Text = "FrmIzvjestaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.TextBox txtDatumZaprimanjaNaloga;
        private System.Windows.Forms.TextBox txtPretrage;
        private System.Windows.Forms.TextBox txtVrstaNaloga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacijent;
    }
}