using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAdoNetCRUD
{
    public class UserDAL : OrtakDAL
    {
        public List<User> GetAll()
        {
            var users = new List<User>();
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand sqlCommand = new SqlCommand("Select * from Users", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader(); // sql sorgusunu çalıştırıyoruz ve verileri okuyoruz
            while (reader.Read())
            {
                var user = new User
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    SurName = reader["SurName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    IsActive = (bool)reader["IsActive"],
                    CreateDate = Convert.ToDateTime(reader["CreateDate"])
                };
                users.Add(user);
            }

            reader.Close(); // SqlDataReader'ı kapatıyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            sqlCommand.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            return users;
        }

        public int Add(User user)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Insert into Users (Name, SurName, Password, Email, IsActive, CreateDate ) " +
                "values (@Name, @SurName, @Password, @Email, @IsActive, @CreateDate)", _connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@SurName", user.SurName);
            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }



        public int Update(User user)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Update Users set Name=@Name, SurName=@SurName, IsActive=@IsActive, " +
                "Email=@Email, Password=@Password, CreateDate=@CreateDate where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@SurName", user.SurName);
            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            cmd.Parameters.AddWithValue("@Id", user.Id);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }

        public int Delete(int Id)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantıyı kontrol ediyoruz
            SqlCommand cmd = new SqlCommand("Delete from Users where Id=@Id", _connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            sonuc = cmd.ExecuteNonQuery(); // sql sorgusunu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
            cmd.Dispose(); // SqlCommand nesnesini bellekten temizliyoruz
            _connection.Close(); // bağlantıyı kapatıyoruz
            return sonuc;

        }
    }
}
