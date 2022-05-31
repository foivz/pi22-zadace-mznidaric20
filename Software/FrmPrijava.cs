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
    public partial class FrmPrijava : Form
    {
        public static Zaposlenik LoggedZaposlenik { get; set; }
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoggedZaposlenik = ZaposleniciRepository.GetZaposlenik(txtKorisnickoIme.Text) ;

                if (LoggedZaposlenik != null && LoggedZaposlenik.Lozinka == txtLozinka.Text)

                {    
                    FrmSampleAnalizer frmSampleAnalizer = new FrmSampleAnalizer();
                    Hide();
                    frmSampleAnalizer.ShowDialog();
                    Close(); 
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                
            }
        }
    }
}
