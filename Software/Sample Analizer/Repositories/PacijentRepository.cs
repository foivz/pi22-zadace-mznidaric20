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
    internal class PacijentRepository
    {

        public static Pacijent GetPacijent(string ime)
        {
            string sql = $"SELECT * FROM Pacijent WHERE ime = '{ime}'";
            return FetchPacijent(sql);

        }


        public static Pacijent GetPacijent(int id)
        {
            string sql = $"SELECT * FROM Pacijent WHERE ID_pacijenta = {id}";
            return FetchPacijent(sql);
        }

        private static Pacijent FetchPacijent(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Pacijent pacijent = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                pacijent = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return pacijent;
        }

        private static Pacijent CreateObject(SqlDataReader reader)
        {
            int id_Pacijenta = int.Parse(reader["Id_pacijenta"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string adresa = reader["Adresa"].ToString();
            string oib = reader["OIB"].ToString();

            var pacijent = new Pacijent
            {
                Id_pacijenta = id_Pacijenta,
                Ime = ime,
                Prezime = prezime,
                Adresa = adresa,
                Oib = oib

            };
            return pacijent;
        }

    }
}
