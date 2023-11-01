CREATE TABLE `kategori_produk`(
    `id_kategori` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `jenis_kategori` VARCHAR(255) NOT NULL
);
CREATE TABLE `produk`(
    `kode_barang` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(255) NOT NULL,
    `stok` INT NOT NULL
);