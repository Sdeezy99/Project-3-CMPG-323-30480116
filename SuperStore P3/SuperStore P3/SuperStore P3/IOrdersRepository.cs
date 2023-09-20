using Models;

namespace EcoPower_Logistics
{
    public interface IOrdersRepository : IGenericRepository<Order>
    {
        Order GetMostRecentService();
    }

}
