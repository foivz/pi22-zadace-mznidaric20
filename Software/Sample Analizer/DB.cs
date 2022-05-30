﻿using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Analizer
{
    public static class DB
    {
        private static string _connectionString = @"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=mznidaric20_DB; 
User=mznidaric20; Password=>2dj%VK8";
        private static SqlConnection _connection;
        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }
        public static void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }
        public static int ExecuteCommand(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, _connection);
            return command.ExecuteNonQuery();
        }

    }
}
