CREATE TABLE `Categories`(
    `id_kategori` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `anak_anak` VARCHAR(255) NOT NULL,
    `remaja` VARCHAR(255) NOT NULL,
    `Dewasa` VARCHAR(255) NOT NULL
);
CREATE TABLE `Product`(
    `Kode_Barang` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Nama_Barang` VARCHAR(255) NOT NULL,
    `Stok` INT NOT NULL
);