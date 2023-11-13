using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pertemuan2
{
    public partial class Form1 : Form
    {
        DataTable toko = new DataTable();
        Config.Connection koneksi = new Config.Connection();
        Models.Toko TokoModel = new Models.Toko();
        Controller.Product product = new Controller.Product();
        public Form1()
        {
            InitializeComponent();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            this.TokoModel.kodeBarang = kode.Text;
            this.TokoModel.namaBarang = nama.Text;
            this.TokoModel.kategoriBarang = kategori.Text;
            this.TokoModel.stok = int.Parse(stok.Value.ToString());
            this.product.Create(this.toko, this.TokoModel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            koneksi.getConnection();
            kategori.SelectedIndex = 0;
            dataGridView1.DataSource = toko;

            this.TokoModel.setColumn(this.toko);
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            nama.Enabled = true;
            stok.Enabled = true;
            kategori.Enabled = true;
            simpan.Enabled = true;
            reset.Enabled = true;
        }

        private void kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selected = (ComboBox)sender;
            if (selected.SelectedItem.ToString() == "Anak-Anak")
            {
                kode.Text = "A" + (toko.Rows.Count + 1).ToString();
            }

            if (selected.SelectedItem.ToString() == "Dewasa")
            {
                kode.Text = "D" + (toko.Rows.Count + 1).ToString();
            }

            if (selected.SelectedItem.ToString() == "Remaja")
            {
                kode.Text = "R" + (toko.Rows.Count + 1).ToString();
            }
        }
    }
}
