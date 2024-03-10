using iCafe.Areas.Admin.Data.Entites;

namespace iCafe.Areas.Admin.Data.Repositories
{
    public class UserReposirory(AppDbContext db) : Repository<User>(db), IUserInterface
    {
    }
}
