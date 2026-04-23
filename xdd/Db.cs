using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xdd
{
    public static class Db
    {
        private static readonly string connectionString =
            "server=localhost;database=your_database;uid=root;pwd=your_password;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

