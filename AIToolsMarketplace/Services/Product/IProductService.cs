using AIToolsMarketplace.DTOs;

namespace AIToolsMarketplace.Services.Product
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int productId);
        Task<ProductDto> CreateProductAsync(ProductCreateDto productCreateDto);
        Task UpdateProductAsync(int productId, ProductUpdateDto productUpdateDto);
        Task DeleteProductAsync(int productId);

        // Search and filter method signature can be added here
        Task<IEnumerable<ProductDto>> SearchProductsAsync(string searchTerm, int? categoryId, decimal? minPrice, decimal? maxPrice);
    }
}
