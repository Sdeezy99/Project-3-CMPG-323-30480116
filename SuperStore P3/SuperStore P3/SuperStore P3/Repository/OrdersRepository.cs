using Data;
using Models;

namespace EcoPower_Logistics
{
   public class OrderRepository : GenericRepository<Order>, IOrdersRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentService()
        {
            return _context.Orders.OrderByDescending(service => service.OrderDate).FirstOrDefault();
        }

    }

}
