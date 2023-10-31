# Repositori Praktikum Visual

### Tugas
1. Buatlah database dari program yang kalian buat.
2. Export database tersebut lalu letakkan ke dalam folder **Database**.
3. Buatlah koneksi ke database dengan membuat folder Config. Lalu buatlah file dengan nama **Connection.cs**. Gunakan konsep singleton dalam membuat koneksi.
4. Di dalam file **Connection.cs**, buatlah class Connection. Di dalamnya berisi fungsi Query dan instance. Ikuti konsep singleton.
5. Jika tidak ada yang tahu tentang konsep singleton. Silahkan searching dengan keyword **design patern singleton c#**
6. Untuk membuat database, Gunakanlah drawsql(https://drawsql.app/).
7. Screenshoot rancangan tablenya.

Silahkan buat folder dengan nama kalian, kemudian push kode yang telah dibuat ke repositori ini.

### Query Builder
Saat membuat program yang berhubungan dengan database. Pasti ada salah satu fitur dari CRUD yang akan digunakan. Untuk membuat kode menjadi lebih efektif dan efisien, query builder dapat menjadi pilihan tepat. Hal tersebut dikarenakan penggunaannya yang dapat meringkat query serta dapat digunakan secara berulang. Untuk membuat query builder di .net, dapat mengikuti tahapan berikut ini:

1. Buatlah folder dengan nama Models.
2. Buatlah file dengan nama BaseModels.
3. Di dalam class BaseModels, tuliskan kode berikut
``` c#
  public void Create(IDictionary<string, object> request)
    {
        MySqlCommand _command = _connection.getConnection().CreateCommand();
        string fields = string.Join(", ", request.Keys);
        string values = string.Join(", ", request.Keys.Select(key => "@" + key));
        string sql = "INSERT INTO " + this.table.TableName + " (" + fields + ") VALUES (" + values + ")";
        _command.CommandText = sql;
        foreach (var kvp in request)
        {
            _command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
        }

        _command.ExecuteNonQuery();
    } 

    public void Update(int id, IDictionary<string, object> request)
    {
        MySqlCommand _command = _connection.getConnection().CreateCommand();
        string fields = string.Join(", ", request.Keys.Select(key => key + " = @" + key));
        string sql = "UPDATE " + this.table.TableName + " SET " + fields + " WHERE id = " + id;
        _command.CommandText = sql;
        foreach (var kvp in request)
        {
            _command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
        }
        _command.ExecuteNonQuery();

    }

    public void Delete(int id)
    {
        if(id < 0)
        {
            MessageBox.Show("Pilih data yang akan dihapus");
            return;
        }
        MySqlCommand _command = _connection.getConnection().CreateCommand();
        string sql = "DELETE FROM " + this.table.TableName + " WHERE id = " + id;
        _command.CommandText = sql;
        _command.ExecuteNonQuery();
    }
```
