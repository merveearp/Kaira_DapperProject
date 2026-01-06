using Kaira.WebUI.DTOs.WearDtos;

namespace Kaira.WebUI.Repositories.WearRepositories
{
    public interface IWearRepository
    {
        Task<IEnumerable<ResultWearDto>> GetAllAsync();
        Task<IEnumerable<ResultWearDto>> GetCategoryByAllAsync();
        Task<UpdateWearDto> GetByIdAsync(int id);
        Task<ResultWearDto> GetWearDetailAsync(int id);
        Task CreateAsync(CreateWearDto createDto);
        Task UpdateAsync(UpdateWearDto updateDto);
        Task DeleteAsync(int id);


        Task<IEnumerable<ResultWearDto>> GetByCategoryIdAsync(int id);
        Task<IEnumerable<ResultWearDto>> GetIsHomeAsync();
    }
}
