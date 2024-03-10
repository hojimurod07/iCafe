using iCafe.Areas.Admin.Data.Entites;
using iCafe.Areas.Admin.Data.interfaces;

namespace iCafe.Areas.Admin.Data.Repositories
{
    public class CategoryRepository(AppDbContext db)
        : Repository<Category>(db), ICategoryInterface
    { }
}
