using LifeFitsHome.Repositories.Interfaces;
using LifeFitsHome.Services.Interfaces;
using LifeFitsHome.Utilities.Results;

namespace LifeFitsHome.Services.Concrete
{
    public class RegionService:IRegionService
    {
        private IRegionRepository _regionRepository;
        public RegionService(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public Utilities.Results.IResult Add(Region entity)
        {
            throw new NotImplementedException();
        }

        public Utilities.Results.IResult Delete(Region entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Region>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Region> GetRegionById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Region> GetRegionByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Utilities.Results.IResult Update(Region entity)
        {
            throw new NotImplementedException();
        }
    }
}