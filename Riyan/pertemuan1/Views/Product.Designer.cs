namespace pertemuan1
{
    partial class produk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stok = new System.Windows.Forms.NumericUpDown();
            this.edit = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpan = new System.Windows.Forms.Button();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.kode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stok
            // 
            this.stok.Enabled = false;
            this.stok.Location = new System.Drawing.Point(188, 154);
            this.stok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(112, 26);
            this.stok.TabIndex = 30;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Enabled = false;
            this.edit.Location = new System.Drawing.Point(546, 154);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(74, 35);
            this.edit.TabIndex = 29;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambah.Location = new System.Drawing.Point(644, 154);
            this.tambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(87, 35);
            this.tambah.TabIndex = 28;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapus.Enabled = false;
            this.hapus.Location = new System.Drawing.Point(452, 154);
            this.hapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(74, 35);
            this.hapus.TabIndex = 27;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(452, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 119);
            this.panel1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOKO ABADI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 189);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // simpan
            // 
            this.simpan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpan.Enabled = false;
            this.simpan.Location = new System.Drawing.Point(309, 154);
            this.simpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(112, 35);
            this.simpan.TabIndex = 24;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = false;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // kategori
            // 
            this.kategori.Enabled = false;
            this.kategori.FormattingEnabled = true;
            this.kategori.Items.AddRange(new object[] {
            "Pilih Kategori Barang",
            "Anak-Anak",
            "Remaja",
            "Dewasa"});
            this.kategori.Location = new System.Drawing.Point(188, 111);
            this.kategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(229, 28);
            this.kategori.TabIndex = 23;
            this.kategori.SelectedIndexChanged += new System.EventHandler(this.kategori_SelectedIndexChanged);
            // 
            // nama
            // 
            this.nama.Enabled = false;
            this.nama.Location = new System.Drawing.Point(188, 68);
            this.nama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(229, 26);
            this.nama.TabIndex = 22;
            // 
            // kode
            // 
            this.kode.Enabled = false;
            this.kode.Location = new System.Drawing.Point(188, 23);
            this.kode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kode.Name = "kode";
            this.kode.Size = new System.Drawing.Size(229, 26);
            this.kode.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kategori Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kode Barang";
            // 
            // produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(750, 425);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.kode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "produk";
            this.Text = "Produk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stok)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown stok;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox kode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

