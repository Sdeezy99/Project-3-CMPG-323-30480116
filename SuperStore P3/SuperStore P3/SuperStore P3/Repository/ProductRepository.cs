using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        public Product SortProductbyName()
        {
            return _context.Products.OrderByDescending(service => service.ProductName).FirstOrDefault();
        }


    }

}
