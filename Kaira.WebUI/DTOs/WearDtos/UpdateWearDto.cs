namespace Kaira.WebUI.DTOs.WearDtos
{
    public class UpdateWearDto
    {
        public int WearId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
