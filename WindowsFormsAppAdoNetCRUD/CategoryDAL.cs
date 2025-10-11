using System.Data.SqlClient;

namespace WindowsFormsAppAdoNetCRUD
{
    public class CategoryDAL : OrtakDAL
    {
        public int Add(Category category)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Insert into Categories (Name, Description, IsActive, CreateDate) " +
                "values (@Name, @Description, @IsActive, @CreateDate)", _connection);
            cmd.Parameters.AddWithValue("@Name", category.Name);
            cmd.Parameters.AddWithValue("@Description", category.Description);
            cmd.Parameters.AddWithValue("@IsActive", category.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", category.CreateDate);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }



        public int Update(Category category)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Update Categories Set Name=@Name, Description=@Description, IsActive=@IsActive, " +
                "CreateDate=@CreateDate where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Name", category.Name);
            cmd.Parameters.AddWithValue("@Description", category.Description);
            cmd.Parameters.AddWithValue("@IsActive", category.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", category.CreateDate);
            cmd.Parameters.AddWithValue("@Id", category.Id);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }

        public int Delete(int Id)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Delete from Categories where Id=@Id", _connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }
    }
}
