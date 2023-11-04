CREATE TABLE `kategori_produk`(
    `id_produk` INT NOT NULL,
    `jenis_kategori` VARCHAR(255) NOT NULL
);
ALTER TABLE
    `kategori_produk` ADD PRIMARY KEY(`id_produk`);
CREATE TABLE `produk`(
    `kode_barang` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(255) NOT NULL,
    `stok` INT NOT NULL
);
ALTER TABLE
    `produk` ADD CONSTRAINT `produk_nama_barang_foreign` FOREIGN KEY(`nama_barang`) REFERENCES `kategori_produk`(`jenis_kategori`);