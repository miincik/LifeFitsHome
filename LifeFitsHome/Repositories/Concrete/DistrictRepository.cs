using LifeFitsHome.Contexts;
using LifeFitsHome.Model.Entity;
using LifeFitsHome.Repositories.Base;
using LifeFitsHome.Repositories.Interfaces;

namespace LifeFitsHome.Repositories.Concrete
{
    public class DistrictRepository : EfEntityRepositoryBase<District, DbContextBase>, IDistrictRepository
    {
        
    }
}
