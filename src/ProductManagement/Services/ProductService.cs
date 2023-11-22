using Microsoft.EntityFrameworkCore;
using ProductManagement.Core.Entities;
using ProductManagement.Core.Models;

namespace ProductManagement.Core.Services
{
    interface IProductService
    {
        Task<List<ProductModel>> GetProductsAsync();
        Task<ProductModel?> GetProductAsync(int id);
        Task<ProductModel> AddProductAsync(ProductModel p);
        Task UpdateProductAsync(ProductModel p);
        Task DeleteProductAsync(int id);
    }

    public class ProductService : IProductService
    {
        private ApplicationDbContext db = new();

        public async Task<List<ProductModel>> GetProductsAsync()
        {
            var products = await db.Products.Select(x => new ProductModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Quatity = x.Quatity,
            }).ToListAsync();

            return products;
        }

        public async Task<ProductModel?> GetProductAsync(int id)
        {
            var product = await db.Products
                .Where(x => x.Id == id)
                .Select(x => new ProductModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Quatity = x.Quatity,
                }).FirstOrDefaultAsync();

            return product;
        }

        public async Task<ProductModel> AddProductAsync(ProductModel p)
        {
            Product product = new();
            product.Name = p.Name;
            product.Price = p.Price;
            product.Quatity = p.Quatity;

            db.Products.Add(product);
            var save = await db.SaveChangesAsync();

            if (save == 0)
            {
                throw new Exception("Cannot save change.");
            }

            return new ProductModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quatity = product.Quatity,
            };
        }

        public async Task UpdateProductAsync(ProductModel p)
        {
            var product = await db.Products.FirstOrDefaultAsync(x => x.Id == p.Id);

            if (product == null)
            {
                throw new Exception($"No product found by Id {p.Id}");
            }

            product.Name = p.Name;
            product.Price = p.Price;
            product.Quatity = p.Quatity;

            var save = await db.SaveChangesAsync();

            if (save == 0)
            {
                throw new Exception("Cannot save change.");
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new Exception("This product doesn't exist.");
            }

            db.Products.Remove(product);
            var save = await db.SaveChangesAsync();

            if (save == 0)
            {
                throw new Exception("Cannot save change.");
            }
        }
    }
}
