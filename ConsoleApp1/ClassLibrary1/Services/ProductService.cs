using ClassLibrary1.Entities;
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProductListAsync();
    }

    public class ProductService : IProductService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public async Task<List<ProductModel>> GetProductListAsync()
        {
            var products = await db.Products.Select(x => new ProductModel()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                CategoryName = x.Category.Name,
            }).ToListAsync();

            Sum([1,2,3,4]);

            return new List<ProductModel>();
        }

        public int Sum(int a, int b)
        {
            return 2;
        }

        public int Sum(int[] arr)
        {
            var result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return result;
        }
    }
}
