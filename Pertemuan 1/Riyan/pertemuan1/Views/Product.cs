using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pertemuan1
{
    public partial class produk : Form
    {
        DataTable toko = new DataTable();
        Models.Toko TokoModel = new Models.Toko();
        Controllers.Product product = new Controllers.Product();
        private int index = -1;
        public produk()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selected = (ComboBox)sender;
            if (selected.SelectedItem.ToString() == "Anak-Anak")
            {
                kode.Text = "A" + (toko.Rows.Count + 1).ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kategori.SelectedIndex = 0;
            dataGridView1.DataSource = toko;
            this.TokoModel.setColumn(toko);
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            nama.Enabled = true;
            stok.Enabled = true;
            kategori.Enabled = true;
            simpan.Enabled = true;

            if(tambah.Text == "Batal"){
                setClearForm();
                tambah.Text = "Tambah";
                setEnabled(false);
                this.index = -1;
            }
            
        }

        private void kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selected = (ComboBox)sender;
            if (selected.SelectedItem.ToString() == "Anak-Anak")
            {
                kode.Text = "A" + (toko.Rows.Count + 1).ToString();
            }

            if (selected.SelectedItem.ToString() == "Remaja")
            {
                kode.Text = "R" + (toko.Rows.Count + 1).ToString();
            }

            if (selected.SelectedItem.ToString() == "Dewasa")
            {
                kode.Text = "D" + (toko.Rows.Count + 1).ToString();
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            this.TokoModel.kodeBarang = kode.Text;
            this.TokoModel.namaBarang = nama.Text;
            this.TokoModel.kategoriBarang = kategori.Text;
            this.TokoModel.stok = int.Parse(stok.Value.ToString());

            if (kategori.SelectedIndex == 0)
            {
                MessageBox.Show("Anda Belum Memilih Kategori Barang");
                return;
            }

            if(this.index > -1)
            {
;                this.product.Update(this.index, this.toko, this.TokoModel);
            }
            else
            {
                this.product.Create(this.toko, this.TokoModel);
            }
            this.index = -1;
            kode.Text = "";
            nama.Text = "";
            kategori.SelectedIndex = 0;
            stok.Value = 0;
            setEnabled(false);
        }

        private void setEnabled(bool enable)
        {
            kode.Enabled = enable;
            nama.Enabled = enable;
            kategori.Enabled = enable;
            stok.Enabled = enable;
            simpan.Enabled = enable;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            setEnabled(true);
            tambah.Text = "Batal";

        }

        private void setClearForm()
        {
            kode.Clear();
            nama.Clear();
            kategori.SelectedIndex = 0;
            stok.Value = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            kode.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            nama.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            kategori.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            stok.Value = int.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());

            edit.Enabled = true;
            simpan.Enabled = true;
            hapus.Enabled = true;
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (this.index < -1) {
                MessageBox.Show("Anda Belum Melilih Item");
                return;
            }
            this.product.Delete(this.index, this.toko);
            this.index = -1;
            setClearForm();
            hapus.Enabled = false;
            simpan.Enabled = false;
            edit.Enabled = false;
        }

    }
}
