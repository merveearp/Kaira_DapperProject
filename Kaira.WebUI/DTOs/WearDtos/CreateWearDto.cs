namespace Kaira.WebUI.DTOs.WearDtos
{
    public class CreateWearDto
    {
        public int WearId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
        public string IsHome { get; set; }
        public int CategoryId { get; set; }
    }
}
