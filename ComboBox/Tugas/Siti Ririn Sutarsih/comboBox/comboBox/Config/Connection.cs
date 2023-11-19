using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComboBox.Config
{
    class Connection
    {
        private static Connection instance;
        private static MySqlConnection connection;
        private readonly string url = "datasource=localhost;username=root;password=;database=universitas;Convert Zero Datetime=True";

        private Connection()
        {
            try
            {
                connection = new MySqlConnection(this.url);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public MySqlDataReader Query(string sql)
        {
            try
            {
                MySqlDataReader response;
                connection.Close();
                connection.Open();
                MySqlCommand query = new MySqlCommand(sql, getConnection());
                query.ExecuteNonQuery();
                response = query.ExecuteReader();
                return response;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return null;
        }

        public static Connection getInstance()
        {
            if (instance == null)
            {
                instance = new Connection();
            }
            return instance;

        }
    }
}
