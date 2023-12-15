using FluentValidation;
using HotelProjectWebUI.Dtos.GuestDto;

namespace HotelProjectWebUI.ValidationRules.GuestValidatonRules
{
    public class GuestCreateValidator:AbstractValidator<CreateGuestDto>
    {
        public GuestCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.SurName).NotEmpty().WithMessage(" Soy İsim Alanı Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage(" Şehir Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.SurName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.City).MaximumLength(15).WithMessage("Lütfen en fazla 15 karakter girişi yapınız");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girişi yapınız");
            RuleFor(x => x.SurName).MaximumLength(10).WithMessage("Lütfen en fazla 10 karakter girişi yapınız");
        }
    }
}
