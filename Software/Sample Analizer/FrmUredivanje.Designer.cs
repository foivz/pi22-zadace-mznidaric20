namespace Sample_Analizer
{
    partial class FrmUredivanje
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(224, 272);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 33;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnOdustani.Location = new System.Drawing.Point(80, 272);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 32;
            this.btnOdustani.Text = "Izađi";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(159, 205);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(195, 20);
            this.txtZaposlenik.TabIndex = 26;
            // 
            // txtDatumZaprimanjaNaloga
            // 
            this.txtDatumZaprimanjaNaloga.Location = new System.Drawing.Point(159, 183);
            this.txtDatumZaprimanjaNaloga.Name = "txtDatumZaprimanjaNaloga";
            this.txtDatumZaprimanjaNaloga.ReadOnly = true;
            this.txtDatumZaprimanjaNaloga.Size = new System.Drawing.Size(195, 20);
            this.txtDatumZaprimanjaNaloga.TabIndex = 25;
            // 
            // txtPretrage
            // 
            this.txtPretrage.Location = new System.Drawing.Point(101, 125);
            this.txtPretrage.Name = "txtPretrage";
            this.txtPretrage.Size = new System.Drawing.Size(100, 20);
            this.txtPretrage.TabIndex = 24;
            // 
            // txtVrstaNaloga
            // 
            this.txtVrstaNaloga.Location = new System.Drawing.Point(101, 94);
            this.txtVrstaNaloga.Name = "txtVrstaNaloga";
            this.txtVrstaNaloga.Size = new System.Drawing.Size(100, 20);
            this.txtVrstaNaloga.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nalog zaprimio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Vrijeme zaprimanja naloga :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pretrage :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vrsta Naloga :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pacijent :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(101, 63);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(100, 20);
            this.txtPacijent.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(64, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Uređivanje radnog naloga";
            this.label6.UseMnemonic = false;
            // 
            // FrmUredivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 331);
            this.Controls.Add(this.label6);
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
            this.Name = "FrmUredivanje";
            this.Text = "FrmUredivanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
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
        private System.Windows.Forms.Label label6;
    }
}