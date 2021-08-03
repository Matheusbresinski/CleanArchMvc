namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetCategories();
        
        Task<Product> GetProductCategoryAsync(int? id);   

        Task<Product> Create(Product product);

        Task<Product> Update(Product product);

        Task<Product> Remove(Product product);
 
    }
}