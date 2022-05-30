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
    public partial class FrmUredivanje : Form
    {
        private RadniNalog radniNalog;

        public RadniNalog OdabraniRadniNalog { get => radniNalog; set => radniNalog = value;}
        public FrmUredivanje( RadniNalog odabraniRadniNalog)
        {
            InitializeComponent();
            OdabraniRadniNalog = odabraniRadniNalog;
            txtPacijent.Text = odabraniRadniNalog.Pacijent.ToString();
            txtVrstaNaloga.Text = odabraniRadniNalog.Vrsta_Naloga.ToString();
            txtPretrage.Text = odabraniRadniNalog.Pretrage.ToString();
            var Ime = FrmPrijava.LoggedZaposlenik.Ime;
            var Prezime = FrmPrijava.LoggedZaposlenik.Prezime;
            txtZaposlenik.Text = Ime + " " + Prezime;
            txtDatumZaprimanjaNaloga.Text = OdabraniRadniNalog.Datum_Zaprimanja.ToString();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
          

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite prekinuti popunjavanje radnog naloga?", "Problem", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
                    Hide();
                    frmSampleAnalizer.ShowDialog();
                    Close();
                }

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtPacijent.Text == "")
            {
                MessageBox.Show("Niste unijeli ime pacijenta!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtVrstaNaloga.Text == "")
            {
                MessageBox.Show("Niste unijeli vrstu naloga!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPretrage.Text == "")
            {
                MessageBox.Show("Niste unijeli vrstu pretrage!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var interni_broj = OdabraniRadniNalog.Interni_Broj.ToString();
                var pacijent = int.Parse(txtPacijent.Text);
                var vrsta_naloga = txtVrstaNaloga.Text;
                var pretrage = txtPretrage.Text;
                var zaposlenik = FrmPrijava.LoggedZaposlenik.Id_Zaposlenika;
                var datum = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                RadniNaloziRepository.UrediRadniNalog(pacijent, vrsta_naloga, pretrage, zaposlenik, datum, interni_broj);
                txtDatumZaprimanjaNaloga.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                Hide();
                FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
                Close();
                frmSampleAnalizer.ShowDialog();

            }

        }
    }
}
