using AIToolsMarketplace.DTOs;
using AIToolsMarketplace.UnitOfWork;
using  AIToolsMarketplace.Models ;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AIToolsMarketplace.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateProductAsync(ProductCreateDto productCreateDto)
        {
            var product = _mapper.Map<Models.Product>(productCreateDto);
            if (product == null)
            {
                throw new ApplicationException("product not mapped");
            }
            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<ProductDto>(product);


        }

        public async Task DeleteProductAsync(int productId)
        {
            var prodcut = await _unitOfWork.Products.GetByIdAsync(productId);
            if (prodcut == null) return;
            _unitOfWork.Products.Remove(prodcut); // no async why?
            await   _unitOfWork.CompleteAsync();

        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            if (products == null)
            {
                throw new ApplicationException("User not found.");
            }
                return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> GetProductByIdAsync(int productId)
        {
            var products = await _unitOfWork.Products.GetByIdAsync(productId);
            if (products == null)
            {
                throw new ApplicationException("User not found.");
            }
            return _mapper.Map<ProductDto>(products);

        }



        public async Task<IEnumerable<ProductDto>> SearchProductsAsync(string searchTerm, int? categoryId, decimal? minPrice, decimal? maxPrice)
        {
            var query = _unitOfWork.Products.GetQueryable();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Name.Contains(searchTerm) || p.Description.Contains(searchTerm));
            }
            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }
            if (minPrice.HasValue)
            {
                query = query.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.Price <= maxPrice.Value);
            }
            var products = await query.ToListAsync(); // This operation is asynchronous
            return _mapper.Map<IEnumerable<ProductDto>>(products); // Map th
        }

        public async Task UpdateProductAsync(int productId, ProductUpdateDto productUpdateDto)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(productId);
            if (product == null) return;
            _mapper.Map(productUpdateDto, product); // learn this line
            _unitOfWork.Products.UpdateProduct(product);
        }
    }
}
