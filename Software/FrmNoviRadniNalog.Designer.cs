namespace Sample_Analizer
{
    partial class FrmNoviRadniNalog
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
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVrstaNaloga = new System.Windows.Forms.TextBox();
            this.txtPretrage = new System.Windows.Forms.TextBox();
            this.txtDatumZaprimanjaNaloga = new System.Windows.Forms.TextBox();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(114, 48);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(198, 20);
            this.txtPacijent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacijent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta Naloga :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pretrage :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vrijeme zaprimanja naloga :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nalog zaprimio :";
            // 
            // txtVrstaNaloga
            // 
            this.txtVrstaNaloga.Location = new System.Drawing.Point(114, 79);
            this.txtVrstaNaloga.Name = "txtVrstaNaloga";
            this.txtVrstaNaloga.Size = new System.Drawing.Size(198, 20);
            this.txtVrstaNaloga.TabIndex = 6;
            // 
            // txtPretrage
            // 
            this.txtPretrage.Location = new System.Drawing.Point(114, 110);
            this.txtPretrage.Name = "txtPretrage";
            this.txtPretrage.Size = new System.Drawing.Size(198, 20);
            this.txtPretrage.TabIndex = 7;
            // 
            // txtDatumZaprimanjaNaloga
            // 
            this.txtDatumZaprimanjaNaloga.Location = new System.Drawing.Point(172, 168);
            this.txtDatumZaprimanjaNaloga.Name = "txtDatumZaprimanjaNaloga";
            this.txtDatumZaprimanjaNaloga.ReadOnly = true;
            this.txtDatumZaprimanjaNaloga.Size = new System.Drawing.Size(174, 20);
            this.txtDatumZaprimanjaNaloga.TabIndex = 8;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(172, 190);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(174, 20);
            this.txtZaposlenik.TabIndex = 9;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnOdustani.Location = new System.Drawing.Point(93, 257);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Izađi";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(237, 257);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Unesi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(88, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Unos novog radnog nalaza";
            this.label11.UseMnemonic = false;
            // 
            // FrmNoviRadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 334);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
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
            this.Name = "FrmNoviRadniNalog";
            this.Text = "Novi radni nalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVrstaNaloga;
        private System.Windows.Forms.TextBox txtPretrage;
        private System.Windows.Forms.TextBox txtDatumZaprimanjaNaloga;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label11;
    }
}