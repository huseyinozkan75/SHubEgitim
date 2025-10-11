using System.Data; // Veritabanı işlemleri için gerekli kütüphaneyi ekliyoruz
using System.Data.SqlClient; // SQL Server bağlantısı için gerekli kütüphaneyi ekliyoruz


namespace WindowsFormsAppAdoNetCRUD
{
    public  class OrtakDAL
    {
        internal SqlConnection _connection = 
        new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=WindowsFormsAppAdoNetCRUD;Integrated Security = True;");
        // veritabanı bağlantısı için SqlConnection nesnesi oluşturuyoruz.

        internal void ConnectionControl()  // Veritabanı bağlantısını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed) // eğer bağlantı kapalıysa 
            {
                _connection.Open(); // bağlantıyı aç
            }
        }

        public DataTable GetDataTable(string sqlSorgu) // SQL sorgusunu çalıştırıp sonuçları DataTable olarak döndüren metot
        {
            DataTable dataTable = new DataTable(); // boş bir DataTable nesnesi oluşturuyoruz
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand sqlCommand = new SqlCommand(sqlSorgu, _connection); // SQL komutunu ve bağlantıyı belirtiyoruz
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); // SQL komutunu çalıştırıp sonuçları okuyoruz
            dataTable.Load(sqlDataReader); // sonuçları DataTable'a yüklüyoruz
            sqlDataReader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return dataTable; // sonuçları döndürüyoruz
        }


    }
}
