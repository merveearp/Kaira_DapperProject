namespace Kaira.WebUI.DTOs.ProductDtos
{
    public class CreateProductDto
    {
        public string CoverImage { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int WearId { get; set; }
        public string WearName { get; set; }
        public bool IsActive { get; set; }
    }
}
