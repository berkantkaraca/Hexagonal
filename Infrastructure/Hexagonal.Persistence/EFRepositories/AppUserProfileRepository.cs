using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Persistence.Contexts;

namespace Hexagonal.Persistence.EFRepositories
{
    public class AppUserProfileRepository(MyContext context) : BaseRepository<AppUserProfile>(context), IAppUserProfileRepository
    {
    }
}