namespace Sample_Analizer
{
    partial class FrmArhiva
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
            this.btnOtvoreniRadninalozi = new System.Windows.Forms.Button();
            this.btnOtvoriRadniNalog = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dataGridViewOtvoreniRadniNalozi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtvoreniRadniNalozi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtvoreniRadninalozi
            // 
            this.btnOtvoreniRadninalozi.Location = new System.Drawing.Point(1239, 386);
            this.btnOtvoreniRadninalozi.Name = "btnOtvoreniRadninalozi";
            this.btnOtvoreniRadninalozi.Size = new System.Drawing.Size(140, 49);
            this.btnOtvoreniRadninalozi.TabIndex = 29;
            this.btnOtvoreniRadninalozi.Text = "Otvoreni radni nalozi";
            this.btnOtvoreniRadninalozi.UseVisualStyleBackColor = true;
            this.btnOtvoreniRadninalozi.Click += new System.EventHandler(this.btnOtvoreniRadninalozi_Click);
            // 
            // btnOtvoriRadniNalog
            // 
            this.btnOtvoriRadniNalog.Location = new System.Drawing.Point(1239, 322);
            this.btnOtvoriRadniNalog.Name = "btnOtvoriRadniNalog";
            this.btnOtvoriRadniNalog.Size = new System.Drawing.Size(140, 47);
            this.btnOtvoriRadniNalog.TabIndex = 28;
            this.btnOtvoriRadniNalog.Text = "Otvori radni nalog";
            this.btnOtvoriRadniNalog.UseVisualStyleBackColor = true;
            this.btnOtvoriRadniNalog.Click += new System.EventHandler(this.btnOtvoriRadniNalog_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(1239, 256);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(140, 45);
            this.btnUredi.TabIndex = 23;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1239, 194);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(140, 44);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dataGridViewOtvoreniRadniNalozi
            // 
            this.dataGridViewOtvoreniRadniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtvoreniRadniNalozi.Location = new System.Drawing.Point(105, 103);
            this.dataGridViewOtvoreniRadniNalozi.Name = "dataGridViewOtvoreniRadniNalozi";
            this.dataGridViewOtvoreniRadniNalozi.Size = new System.Drawing.Size(1060, 410);
            this.dataGridViewOtvoreniRadniNalozi.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "Arhiva";
            this.label1.UseMnemonic = false;
            // 
            // FrmArhiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOtvoreniRadninalozi);
            this.Controls.Add(this.btnOtvoriRadniNalog);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dataGridViewOtvoreniRadniNalozi);
            this.Name = "FrmArhiva";
            this.Text = "FrmArhiva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtvoreniRadniNalozi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtvoreniRadninalozi;
        private System.Windows.Forms.Button btnOtvoriRadniNalog;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dataGridViewOtvoreniRadniNalozi;
        private System.Windows.Forms.Label label1;
    }
}