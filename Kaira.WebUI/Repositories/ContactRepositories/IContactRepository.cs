using Kaira.WebUI.DTOs.ContactDtos;

namespace Kaira.WebUI.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<UpdateContactDto> GetAsync();
        Task UpdateAsync(UpdateContactDto updateDto);
    }
}
