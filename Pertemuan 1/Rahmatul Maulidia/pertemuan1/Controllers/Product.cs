using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pertemuan1.Controllers
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

                MessageBox.Show("Data produk berhasil ditambahkan");
            } catch(Exception err) 
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void Update(int index, DataTable table, Models.Toko toko)
        {
            try
            {
                table.Rows[index]["Kode Barang"] = toko.kodeBarang;
                table.Rows[index]["Nama Barang"] = toko.namaBarang;
                    table.Rows[index]["Stok"] = toko.stok;
                table.Rows[index]["Kategori Barang"] = toko.kategoriBarang;
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void Delete(int index, DataTable table)
        {
            try
            {
                if (index < -1)
                {
                    MessageBox.Show("Anda belum memilih item");
                    return;
                }
                table.Rows[index].Delete();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
