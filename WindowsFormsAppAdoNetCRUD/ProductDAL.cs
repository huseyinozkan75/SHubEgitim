using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace WindowsFormsAppAdoNetCRUD
{
    public class ProductDAL : OrtakDAL
    {

        // Datatable'dan daha performaslı çalışır.
        public List<Product> GetAll()
        {
            var products = new List<Product>();
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader(); // sql sorgusunu çalıştırıyoruz ve verileri okuyoruz
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Stock = (int)reader["Stock"],
                    IsActive = (bool)reader["IsActive"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"])
                };
                products.Add(product);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return products;
        }
        
        public int Add(Product product)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Insert into Products (Name, Description, IsActive, CreateDate, Stock, Price ) " +
                "values (@Name, @Description, @IsActive, @CreateDate, @Stock, @Price )", _connection);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }



        public int Update(Product product)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Update Products Set Name=@Name, Description=@Description, IsActive=@IsActive, " +
                "CreateDate=@CreateDate, Stock=@Stock, Price=@Price where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Id", product.Id);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }

        public int Delete(int Id)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Delete from Products where Id=@Id", _connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }

    }
}
