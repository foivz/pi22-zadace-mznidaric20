using DBLayer;
using Sample_Analizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Analizer.Repositories
{
    internal class ZaposleniciRepository
    {

        public static Zaposlenik GetZaposlenik(string Korisnicko_ime)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE Korisnicko_ime = '{Korisnicko_ime}'";
            return FetchZaposlenik(sql);

        }


        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE Id_zaposlenika = {id}";
            return FetchZaposlenik(sql);
        }

        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return zaposlenik;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id_Zaposlenika = int.Parse(reader["Id_zaposlenika"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string korisnicko_Ime = reader["Korisnicko_ime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string vrsta_Zaposlenika = reader["Vrsta_zaposlenika"].ToString();
            string adresa = reader["Adresa"].ToString();
            string oib = reader["OIB"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id_Zaposlenika = id_Zaposlenika,
                Ime = ime,
                Prezime = prezime,
                Korisnicko_Ime = korisnicko_Ime,
                Lozinka = lozinka,
                Vrsta_Zaposlenika = vrsta_Zaposlenika,
                Adresa = adresa,
                Oib = oib

            };
            return zaposlenik;
        }

    }
}
