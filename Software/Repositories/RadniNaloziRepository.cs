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
    public class RadniNaloziRepository
    {
        public static RadniNalog UpisiRadniNalog(int pacijent, string vrsta_naloga, string pretrage, int zaposlenik, string datum)
        {
            RadniNalog radniNalog = null;

            string sql = $"INSERT INTO Radni_Nalog (Datum_zaprimanja, Vrsta_naloga, Pretrage, Pacijent, Zaposlenik, Status_naloga, Komentar) VALUES('{datum}', '{vrsta_naloga}', '{pretrage}', '{pacijent}', '{zaposlenik}', 'Otvoren', 'Nema komentara.'); ";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            return radniNalog;
        }
        public static RadniNalog UrediRadniNalog(int pacijent, string vrsta_naloga, string pretrage, int zaposlenik, string datum, string interni_broj)
        {
            RadniNalog radniNalog = null;

            string sql = $"UPDATE Radni_Nalog SET Vrsta_naloga = '{vrsta_naloga}', Pretrage = '{pretrage}', Pacijent = '{pacijent}' WHERE Interni_broj = '{interni_broj}'; ";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            return radniNalog;
        }
        public static RadniNalog ObrisiRadniNalog(string Interni_broj)
        {
            RadniNalog radniNalog = null;

            string sql = $"DELETE FROM Radni_Nalog WHERE Interni_broj = '{Interni_broj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            return radniNalog;
        }
        public static RadniNalog ZatvoriRadniNalog(string Interni_broj)
        {
            RadniNalog radniNalog = null;

            string sql = $"UPDATE Radni_Nalog SET Status_naloga = 'Zatvoren' WHERE Interni_broj = '{Interni_broj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            return radniNalog;
        }
        public static RadniNalog OtvoriRadniNalog(string Interni_broj)
        {
            RadniNalog radniNalog = null;

            string sql = $"UPDATE Radni_Nalog SET Status_naloga = 'Otvoren' WHERE Interni_broj = '{Interni_broj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            return radniNalog;
        }
        public static RadniNalog GetRadniNalozi(int Interni_broj)
        {
            RadniNalog radniNalog = null;

            string sql = $"SELECT * FROM Radni_Nalog WHERE Id = {Interni_broj}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                radniNalog = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return radniNalog;
        }

        public static List<RadniNalog> GetRadniNalozi()
        {
            var radniNalozi = new List<RadniNalog>();

            string sql = "SELECT * FROM Radni_Nalog WHERE Status_naloga='Otvoren'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                RadniNalog radniNalog = CreateObject(reader);
                radniNalozi.Add(radniNalog);
            }

            reader.Close();
            DB.CloseConnection();

            return radniNalozi;
        }
        public static List<RadniNalog> PokaziRadneNalogeArhiva()
        {
            var radniNalozi = new List<RadniNalog>();

            string sql = "SELECT * FROM Radni_Nalog WHERE Status_naloga='Zatvoren'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                RadniNalog radniNalog = CreateObject(reader);
                radniNalozi.Add(radniNalog);
            }

            reader.Close();
            DB.CloseConnection();

            return radniNalozi;
        }

        public static List<RadniNalog> TraziGetRadniNalozi(string trazi)
        {
            var radniNalozi = new List<RadniNalog>();

            string sql = $"SELECT * FROM Radni_Nalog WHERE Vrsta_naloga like '%{trazi}%' AND Status_naloga='Otvoren'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                RadniNalog radniNalog = CreateObject(reader);
                radniNalozi.Add(radniNalog);
            }

            reader.Close();
            DB.CloseConnection();

            return radniNalozi;
        }
        private static RadniNalog CreateObject(SqlDataReader reader)
        {
            int interni_Broj = int.Parse(reader["Interni_broj"].ToString());
            DateTime datum_Zaprimanja = DateTime.Parse(reader["Datum_zaprimanja"].ToString());
            string vrsta_Naloga = reader["Vrsta_naloga"].ToString();
            string pretrage = reader["Pretrage"].ToString();
            int zaposlenik = int.Parse(reader["Zaposlenik"].ToString());
            int pacijent = int.Parse(reader["Pacijent"].ToString());
            string status_Naloga = reader["Status_naloga"].ToString();
            string komentar = reader["Komentar"].ToString();


            var radniNalog = new RadniNalog
            {
                Interni_Broj = interni_Broj,
                Datum_Zaprimanja = datum_Zaprimanja,
                Vrsta_Naloga = vrsta_Naloga,
                Pretrage = pretrage,
                Zaposlenik = zaposlenik,
                Pacijent = pacijent,
                Status_Naloga = status_Naloga,
                Komentar = komentar
            };

            return radniNalog;
        }
    }
}
