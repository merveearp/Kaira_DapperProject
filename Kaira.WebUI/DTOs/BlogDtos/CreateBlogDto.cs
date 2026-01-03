namespace Kaira.WebUI.DTOs.BlogDtos
{
    public class CreateBlogDto
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
