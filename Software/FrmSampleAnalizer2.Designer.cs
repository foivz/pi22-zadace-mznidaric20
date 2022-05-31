namespace Sample_Analizer
{
    partial class FrmSampleAnalizer2
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
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dataGridViewOtvoreniRadniNalozi = new System.Windows.Forms.DataGridView();
            this.btnStvaranjeNovogRadnogNaloga = new System.Windows.Forms.Button();
            this.btnResetiraj = new System.Windows.Forms.Button();
            this.btnZatvoriradniNalog = new System.Windows.Forms.Button();
            this.btnArhiva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtvoreniRadniNalozi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(559, 569);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 15;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Traži po vrsti naloga:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(351, 571);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(187, 20);
            this.txtTrazi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(101, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sample Analizer";
            this.label1.UseMnemonic = false;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(1243, 290);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(140, 45);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1243, 228);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(140, 44);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dataGridViewOtvoreniRadniNalozi
            // 
            this.dataGridViewOtvoreniRadniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtvoreniRadniNalozi.Location = new System.Drawing.Point(109, 137);
            this.dataGridViewOtvoreniRadniNalozi.Name = "dataGridViewOtvoreniRadniNalozi";
            this.dataGridViewOtvoreniRadniNalozi.Size = new System.Drawing.Size(1060, 410);
            this.dataGridViewOtvoreniRadniNalozi.TabIndex = 9;
            // 
            // btnStvaranjeNovogRadnogNaloga
            // 
            this.btnStvaranjeNovogRadnogNaloga.Location = new System.Drawing.Point(1243, 137);
            this.btnStvaranjeNovogRadnogNaloga.Name = "btnStvaranjeNovogRadnogNaloga";
            this.btnStvaranjeNovogRadnogNaloga.Size = new System.Drawing.Size(140, 64);
            this.btnStvaranjeNovogRadnogNaloga.TabIndex = 8;
            this.btnStvaranjeNovogRadnogNaloga.Text = "Stvaranje novog radnog naloga";
            this.btnStvaranjeNovogRadnogNaloga.UseVisualStyleBackColor = true;
            this.btnStvaranjeNovogRadnogNaloga.Click += new System.EventHandler(this.btnStvaranjeNovogRadnogNaloga_Click);
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.Location = new System.Drawing.Point(640, 569);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(75, 23);
            this.btnResetiraj.TabIndex = 17;
            this.btnResetiraj.Text = "Resetiraj";
            this.btnResetiraj.UseVisualStyleBackColor = true;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // btnZatvoriradniNalog
            // 
            this.btnZatvoriradniNalog.Location = new System.Drawing.Point(1243, 356);
            this.btnZatvoriradniNalog.Name = "btnZatvoriradniNalog";
            this.btnZatvoriradniNalog.Size = new System.Drawing.Size(140, 47);
            this.btnZatvoriradniNalog.TabIndex = 18;
            this.btnZatvoriradniNalog.Text = "Zatvori Radni Nalog";
            this.btnZatvoriradniNalog.UseVisualStyleBackColor = true;
            this.btnZatvoriradniNalog.Click += new System.EventHandler(this.btnZatvoriradniNalog_Click);
            // 
            // btnArhiva
            // 
            this.btnArhiva.Location = new System.Drawing.Point(1243, 420);
            this.btnArhiva.Name = "btnArhiva";
            this.btnArhiva.Size = new System.Drawing.Size(140, 49);
            this.btnArhiva.TabIndex = 19;
            this.btnArhiva.Text = "Arhiva";
            this.btnArhiva.UseVisualStyleBackColor = true;
            this.btnArhiva.Click += new System.EventHandler(this.btnArhiva_Click);
            // 
            // FrmSampleAnalizer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnArhiva);
            this.Controls.Add(this.btnZatvoriradniNalog);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dataGridViewOtvoreniRadniNalozi);
            this.Controls.Add(this.btnStvaranjeNovogRadnogNaloga);
            this.Name = "FrmSampleAnalizer2";
            this.Text = "FrmSampleAnalizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtvoreniRadniNalozi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dataGridViewOtvoreniRadniNalozi;
        private System.Windows.Forms.Button btnStvaranjeNovogRadnogNaloga;
        private System.Windows.Forms.Button btnResetiraj;
        private System.Windows.Forms.Button btnZatvoriradniNalog;
        private System.Windows.Forms.Button btnArhiva;
    }
}