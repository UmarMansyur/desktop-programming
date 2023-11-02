using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pertemuan1.Models
{
    class Toko
    {
        public List<String> fillable;
        public string kodeBarang { set; get; }
        public string namaBarang { set; get; }
        public string kategoriBarang { set; get; }
        public int stok { set; get; }

        public Toko()
        {
            this.fillable = new List<String>() { "Kode Barang", "Nama Barang", "Kategori Barang", "Stok" };
        }

        public void setColumn(DataTable table) {
            foreach (string item in this.fillable)
            {
                table.Columns.Add(item);
            }
        }
    }


}
