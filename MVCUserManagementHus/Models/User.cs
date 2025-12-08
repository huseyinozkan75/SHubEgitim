using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCUserManagementHus.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı girilmeli!"), DisplayName("Ad")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı girilmeli!"), DisplayName("Soyad")]
        [StringLength(50)]
        public string SurName { get; set; }

        [Required(ErrorMessage = "E-posta alanı girilmeli!"), DataType(DataType.EmailAddress), DisplayName("E-Posta")]
        [StringLength(50)]

        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon no alanı girilmeli!"), DataType(DataType.PhoneNumber), DisplayName("Telefon No")]
        [StringLength(30)]

        public string Phone { get; set; }

        [DisplayName("Doğum Tarihi"), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]

        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "Kullanıcı adı alanı girilmeli!"),  DisplayName("Kullanıcı Adı")]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required, DisplayName("Şifre"), DataType(dataType:DataType.Password)]
        [StringLength(20)]
        public string Password { get; set; }
        
    }
}