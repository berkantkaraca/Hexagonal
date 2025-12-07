using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Persistence.Contexts;

namespace Hexagonal.Persistence.EFRepositories
{
    public class AppUserRepository(MyContext context) : BaseRepository<AppUser>(context), IAppUserRepository
    {
    }
}
