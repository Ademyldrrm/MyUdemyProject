namespace HotelProjectWebUI.Dtos.AppUserDto
{
    public class ResultAppUserWithWorkLocationDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImageUrl { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public int WorkLocationID { get; set; }
        public string? WorkLocationName { get; set; }
    }
}
