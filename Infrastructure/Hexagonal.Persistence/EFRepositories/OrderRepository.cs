using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Persistence.Contexts;

namespace Hexagonal.Persistence.EFRepositories
{
    public class OrderRepository(MyContext context) : BaseRepository<Order>(context), IOrderRepository
    {

    }
}
