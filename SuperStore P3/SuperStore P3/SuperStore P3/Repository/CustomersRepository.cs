using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomersRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomersRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentService()
        {
            return _context.Customers.OrderByDescending(service => service.CustomerName).FirstOrDefault();

        }
    }
}
