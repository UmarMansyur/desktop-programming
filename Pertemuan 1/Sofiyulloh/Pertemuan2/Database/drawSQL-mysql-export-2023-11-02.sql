CREATE TABLE `kategori`(
    `id_product` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_kategori` VARCHAR(255) NOT NULL
);
CREATE TABLE `product`(
    `kode` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama` VARCHAR(255) NOT NULL,
    `stock` INT NOT NULL
);
ALTER TABLE
    `product` ADD CONSTRAINT `product_nama_foreign` FOREIGN KEY(`nama`) REFERENCES `kategori`(`nama_kategori`);