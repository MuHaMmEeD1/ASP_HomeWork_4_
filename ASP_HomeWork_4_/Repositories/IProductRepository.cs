using ASP_HomeWork_4_.Entities;

namespace ASP_HomeWork_4_.Repositories
{
    public interface IProductRepository
    {

        Task<IQueryable<Product>> GetAllProductAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(Product product);
        Task ModifyAsync(Product product);
    }
}
