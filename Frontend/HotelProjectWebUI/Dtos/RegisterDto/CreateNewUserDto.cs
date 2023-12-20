using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı Gereklidir")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı alanı Gereklidir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail alanı Gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı Gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre  Tekrar alanı Gereklidir")]
        [Compare("Password",ErrorMessage ="Şifre Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        public int WorkLocationID { get; set; }
    }
}
