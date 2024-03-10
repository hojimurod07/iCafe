using iCafe.Areas.Admin.Data.Entites;
using iCafe.Areas.Admin.Data.interfaces;

namespace iCafe.Areas.Admin.Data.Repositories
{
    public class BuscetRepository(AppDbContext db) : Repository<Buscet>(db), IBuscetInterface
    {
    }
}
