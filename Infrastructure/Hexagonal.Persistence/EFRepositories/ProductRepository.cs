using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Persistence.Contexts;

namespace Hexagonal.Persistence.EFRepositories
{
    public class ProductRepository(MyContext context) : BaseRepository<Product>(context), IProductRepository
    {

    }
}
