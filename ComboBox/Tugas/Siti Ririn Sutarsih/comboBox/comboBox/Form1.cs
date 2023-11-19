using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace comboBox
{
    public partial class Form1 : Form
    {
        MyDB koneksi = new MyDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = koneksi.getData("select * from prodi");
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "nama_Prodi";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.SelectedValue.ToString());
        }
    }
}
