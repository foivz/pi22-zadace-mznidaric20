using System;
using Sample_Analizer.Models;
using Sample_Analizer.Repositories;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Analizer
{
    public partial class FrmArhiva : Form
    {
        public FrmArhiva()
        {
            InitializeComponent();
            PokaziRadneNalogeArhiva();
        }
        public void PokaziRadneNalogeArhiva()
        {
            var radniNalozi = RadniNaloziRepository.PokaziRadneNalogeArhiva();
            dataGridViewOtvoreniRadniNalozi.DataSource = radniNalozi;
            dataGridViewOtvoreniRadniNalozi.Columns["Interni_Broj"].DisplayIndex = 0;
            dataGridViewOtvoreniRadniNalozi.Columns["Datum_Zaprimanja"].DisplayIndex = 1;
            dataGridViewOtvoreniRadniNalozi.Columns["Vrsta_Naloga"].DisplayIndex = 2;
            dataGridViewOtvoreniRadniNalozi.Columns["Pretrage"].DisplayIndex = 3;
            dataGridViewOtvoreniRadniNalozi.Columns["Zaposlenik"].DisplayIndex = 4;
            dataGridViewOtvoreniRadniNalozi.Columns["Pacijent"].DisplayIndex = 5;
            dataGridViewOtvoreniRadniNalozi.Columns["Status_Naloga"].Visible = false;
            dataGridViewOtvoreniRadniNalozi.Columns["Komentar"].Visible = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            RadniNalog odabraniRadniNalog = dataGridViewOtvoreniRadniNalozi.CurrentRow.DataBoundItem as RadniNalog;
            if (odabraniRadniNalog != null)
            {
                var interni_broj = odabraniRadniNalog.Interni_Broj.ToString();
                RadniNaloziRepository.ObrisiRadniNalog(interni_broj);
                Hide();
                FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
                Close();
                frmSampleAnalizer.ShowDialog();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            RadniNalog odabraniRadniNalog = dataGridViewOtvoreniRadniNalozi.CurrentRow.DataBoundItem as RadniNalog;
            if (odabraniRadniNalog != null)
            {
                Hide();
                FrmUredivanje frmUredivanje = new FrmUredivanje(odabraniRadniNalog);
                Close();
                frmUredivanje.ShowDialog();
            }
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
            Close();
            frmSampleAnalizer.ShowDialog();
        }

        private void btnOtvoriRadniNalog_Click(object sender, EventArgs e)
        {
            RadniNalog odabraniRadniNalog = dataGridViewOtvoreniRadniNalozi.CurrentRow.DataBoundItem as RadniNalog;
            if (odabraniRadniNalog != null)
            {
                var interni_broj = odabraniRadniNalog.Interni_Broj.ToString();
                RadniNaloziRepository.OtvoriRadniNalog(interni_broj);
                Hide();
                FrmArhiva frmArhiva = new FrmArhiva();
                Close();
                frmArhiva.ShowDialog();
            }
        }

        private void btnOtvoreniRadninalozi_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
            Close();
            frmSampleAnalizer.ShowDialog();
        }
    }
}
