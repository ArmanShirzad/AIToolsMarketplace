using AIToolsMarketplace.DTOs;

namespace AIToolsMarketplace.Services.Category
{
    public interface ICategory
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto> GetCategoryByIdAsync(int categoryId);
        //Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto categoryCreateDto);
        //Task UpdateCategoryAsync(int categoryId, CategoryUpdateDto categoryUpdateDto);
        Task DeleteCategoryAsync(int categoryId);
    }
}
