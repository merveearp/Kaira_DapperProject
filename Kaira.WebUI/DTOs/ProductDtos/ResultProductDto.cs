namespace Kaira.WebUI.DTOs.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }
        public string CoverImage { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int WearId { get; set; }
        public string WearTitle { get; set; }
        public string WearSubtitle { get; set; }
        public bool IsActive { get; set; }
    }
}
