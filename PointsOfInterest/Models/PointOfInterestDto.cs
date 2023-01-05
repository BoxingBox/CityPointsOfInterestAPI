namespace CityInfo.API.Models
{
    public class PointOfInterestDto
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<PointOfInterestDto> Points { get; set; } = new List<PointOfInterestDto>();
    }
}
