using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Persistence.Contexts;

namespace Hexagonal.Persistence.EFRepositories
{
    public class OrderDetailRepository(MyContext context) : BaseRepository<OrderDetail>(context), IOrderDetailRepository
    {

    }
}
