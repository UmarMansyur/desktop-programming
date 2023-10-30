using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;

namespace Pertemuan2.Controller
{
    class Product
    {
        public void Create(DataTable table, Models.Toko toko)
        {
            try
            {
                string[] product = new string[4];
                product[0] = toko.kodeBarang;
                product[1] = toko.namaBarang;
                product[2] = toko.kategoriBarang;
                product[3] = toko.stok.ToString();

                table.Rows.Add(product);
                MessageBox.Show("Data product berhasil ditambahkan", "Pesan");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
