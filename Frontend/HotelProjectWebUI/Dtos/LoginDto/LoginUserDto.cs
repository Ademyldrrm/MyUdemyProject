using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = " Şifreyi Giriniz")]
        public string Pasword { get; set; }
    }
}
