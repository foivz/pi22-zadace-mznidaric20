using Sample_Analizer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Analizer.Models
{
    public class RadniNalog
    {
        public int Interni_Broj { get; set; }
        public DateTime Datum_Zaprimanja { get; set; }
        public string Vrsta_Naloga { get; set; }
        public string Pretrage { get; set; }
        public int Zaposlenik{ get; set; }
        public int Pacijent{ get; set; }
        public string Status_Naloga { get; set; }
        public string Komentar { get; set; }
        /*
        public Zaposlenik Zaposlenik { get; set; }
        public Pacijent Pacijent { get; set; }
        */
    }
}
