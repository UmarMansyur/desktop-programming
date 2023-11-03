CREATE TABLE `produk`(
    `kode_barang` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(255) NOT NULL,
    `stok` INT NOT NULL
);
CREATE TABLE `kategori_barang`(
    `id_kategori` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `jenis_kategori` VARCHAR(255) NOT NULL
);
ALTER TABLE
    `kategori_barang` ADD CONSTRAINT `kategori_barang_id_kategori_foreign` FOREIGN KEY(`id_kategori`) REFERENCES `produk`(`kode_barang`);