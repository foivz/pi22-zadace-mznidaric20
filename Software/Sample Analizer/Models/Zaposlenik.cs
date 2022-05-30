using Sample_Analizer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Analizer.Models
{
    public class Zaposlenik
    {
        public int Id_Zaposlenika { get; set; }
        public string Korisnicko_Ime { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Vrsta_Zaposlenika { get; set; }
        public string Oib { get; set; }
        public string Adresa { get; set; }
    }
}
