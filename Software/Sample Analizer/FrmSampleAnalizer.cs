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
    public partial class FrmSampleAnalizer : Form
    {
        private RadniNalog radniNalog;

        public FrmSampleAnalizer()
        {
            InitializeComponent();
            /*dataGridViewOtvoreniRadniNalozi;*/
        }

        private void FrmSampleAnalizer_Load(object sender, EventArgs e)
        {
            PokaziRadneNaloge();
        }

        public void PokaziRadneNaloge() {
            var radniNalozi = RadniNaloziRepository.GetRadniNalozi();
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

        private void btnStvaranjeNovogRadnogNaloga_Click(object sender, EventArgs e)
        {
            FrmNoviRadniNalog frmNoviRadniNalog = new FrmNoviRadniNalog();
            Hide();
            frmNoviRadniNalog.ShowDialog();
            Close();
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

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            var trazi = txtTrazi.Text;

            Hide();
            FrmSampleAnalizer2 frmSampleAnalizer2 = new FrmSampleAnalizer2(trazi);
            Close();
            frmSampleAnalizer2.ShowDialog();
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
            Close();
            frmSampleAnalizer.ShowDialog();
        }

        private void btnZatvoriradniNalog_Click(object sender, EventArgs e)
        {
            RadniNalog odabraniRadniNalog = dataGridViewOtvoreniRadniNalozi.CurrentRow.DataBoundItem as RadniNalog;
            if (odabraniRadniNalog != null)
            {

                var interni_broj = odabraniRadniNalog.Interni_Broj.ToString();
                RadniNaloziRepository.ZatvoriRadniNalog(interni_broj);
                Hide();
                FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
                Close();
                frmSampleAnalizer.ShowDialog();
            }
        }

        private void btnArhiva_Click(object sender, EventArgs e)
        {
            Hide();
            FrmArhiva frmArhiva = new FrmArhiva();
            Close();
            frmArhiva.ShowDialog();
        }
    }
}
