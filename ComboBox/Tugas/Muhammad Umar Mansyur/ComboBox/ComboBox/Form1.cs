using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ComboBox
{

    public partial class Form1 : Form
    {
        Config.Connection _conn = Config.Connection.getInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = this._conn.Query("SELECT * FROM prodi");

            while (result.Read())
            {
                comboBox1.Items.Add(new Helpers.ComboBox(result.GetInt32(0), result.GetString(1)));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Helpers.ComboBox)comboBox1.SelectedItem).ToString());
        }
    }
}
