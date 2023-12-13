using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarasını giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Resmini giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Fiyatını giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisini giriniz")]
        [StringLength(50,ErrorMessage ="Lütfen En Az 50 Karakter Giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen Yatak Sayısı  giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen Banyo Numarasını giriniz")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
