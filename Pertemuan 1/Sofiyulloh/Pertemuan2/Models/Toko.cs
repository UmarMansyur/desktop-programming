using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pertemuan2.Models
{
    class Toko
    {
        public List<String> filLable;
        public string kodeBarang { set; get; }
        public string namaBarang { set; get; }
        public string kategoriBarang { set; get; }
        public int stok { set; get; }
        public Toko()
        {
            this.filLable = new List<String>() { "Kode Barang", "Nama Barang", "Kategori Barang", "Stok" };
        }

        public void setColumn(DataTable table)
        {
            foreach (string item in this.filLable)
            {
                table.Columns.Add(item);
            }
        }
    }
}
