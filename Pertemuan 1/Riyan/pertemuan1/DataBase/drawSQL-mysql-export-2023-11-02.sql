CREATE TABLE `produks`(
    `kode` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(255) NOT NULL,
    `stok` INT NOT NULL
);
CREATE TABLE `kategori`(
    `id_kategori` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_kategori` VARCHAR(255) NOT NULL
);