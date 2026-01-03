namespace Kaira.WebUI.DTOs.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Info { get; set; }
    }
}
