using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
﻿using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pertemuan2.Config
{
    class Connection
    {
        private static Connection instance;
        private static MySqlConnection connection;
        private readonly string url = "datasource=localhost;username=root;password=;database=toko";

        public Connection()
        {
            try
            {
                connection = new MySqlConnection(this.url);
                connection.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
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
