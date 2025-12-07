using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Persistence.Contexts;

namespace Hexagonal.Persistence.EFRepositories
{
    public class CategoryRepository(MyContext context) : BaseRepository<Category>(context), ICategoryRepository
    {

    }
}
