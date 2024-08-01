using ASP_HomeWork_4_.Context;
using ASP_HomeWork_4_.Entities;

namespace ASP_HomeWork_4_.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public EFProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();  
        }

        public async Task DeleteAsync(int id)
        {
            Product deletedProduct = _context.Products.SingleOrDefault(pr => pr.Id == id);

            _context.Products.Remove(deletedProduct);

            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<Product>> GetAllProductAsync()
        {
            return _context.Products;

        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return _context.Products.SingleOrDefault(pr => pr.Id == id);
        }

        public async Task ModifyAsync(Product product)
        {
           
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

        }
    }
}
