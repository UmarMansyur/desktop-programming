using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace tugasss
{
    class MyDataBase
    {
        string strkoneksi = "datasource=localhost;uid=root;pwd=;database=universitas";
        MySqlConnection koneksi;

        public MyDataBase()
        {
            koneksi = new MySqlConnection(strkoneksi);
        }

        public DataTable getData(string qwr)
        { 
            DataTable dt = new DataTable();
            koneksi.Open();
            MySqlCommand ambil = new MySqlCommand(qwr, koneksi);
            MySqlDataReader datanya = ambil.ExecuteReader();
            dt.Load(datanya);
            koneksi.Close();

            return dt;
        }
    }
}
