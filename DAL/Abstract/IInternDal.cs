using MVCSQLEFCore.DAL.Concrete.EF;
using MVCSQLEFCore.Entities;

namespace MVCSQLEFCore.DAL.Abstract
{
    public interface IInternDal: BaseRepository<Intern, HospitalDbContext>
    {

    }
}
