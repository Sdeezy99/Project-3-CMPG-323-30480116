using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetMostRecentService()
        {
            return _context.OrderDetails.OrderByDescending(service => service.OrderDetailsId).FirstOrDefault();

        }
    }
}
