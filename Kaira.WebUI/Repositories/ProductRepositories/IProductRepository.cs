using Kaira.WebUI.DTOs.ProductDtos;

namespace Kaira.WebUI.Repositories.ProductRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ResultProductDto>> GetAllAsync();
        Task<UpdateProductDto> GetByIdAsync(int id);
        Task<ResultProductDto> GetProductDetailAsync(int id);
        Task CreateAsync(CreateProductDto createDto);
        Task UpdateAsync(UpdateProductDto updateDto);
        Task DeleteAsync(int id);


        Task<IEnumerable<ResultProductDto>> GetByCategoryIdAsync(int id);
        Task<IEnumerable<ResultProductDto>> GetIsActiveAsync();
        Task<IEnumerable<ResultProductDto>> GetByWearIdAsync(int id);
    }
}
