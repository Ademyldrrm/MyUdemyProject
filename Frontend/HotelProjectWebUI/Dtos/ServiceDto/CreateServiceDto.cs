using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet İkon Linkini Giriniz")]
        public string Serviceİcon { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığını Giriniz")]
        [StringLength(50, ErrorMessage = "Hizmet Başlığı En Fazla 50 Karakter Olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet Açıklamasını Giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet Açıklması En Fazla 100 Karakter Olabilir")]
        public string Description { get; set; }
    }
}
