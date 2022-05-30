using Sample_Analizer.Models;
using Sample_Analizer.Repositories;
using System;
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
    public partial class FrmNoviRadniNalog : Form
    {
        public FrmNoviRadniNalog()
        {
            InitializeComponent();
            var Ime = FrmPrijava.LoggedZaposlenik.Ime;
            var Prezime = FrmPrijava.LoggedZaposlenik.Prezime;
            txtZaposlenik.Text = Ime +" " + Prezime;
            DateTime datum_upisa = DateTime.Now;
            txtDatumZaprimanjaNaloga.Text = datum_upisa.ToString();
            
            
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
            else {
                var pacijent = int.Parse(txtPacijent.Text);
                var vrsta_naloga = txtVrstaNaloga.Text;
                var pretrage = txtPretrage.Text;
                var zaposlenik = FrmPrijava.LoggedZaposlenik.Id_Zaposlenika;
                var datum = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                RadniNaloziRepository.UpisiRadniNalog(pacijent, vrsta_naloga, pretrage, zaposlenik, datum);
               
                    txtPacijent.Text = null;
                    txtVrstaNaloga.Text = null;
                    txtPretrage.Text = null;
                    txtDatumZaprimanjaNaloga.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }

        }

    }
}
