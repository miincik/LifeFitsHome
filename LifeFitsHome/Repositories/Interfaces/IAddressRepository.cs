public interface IAddressRepository
{
    Task<City> FindCityByName(string Name);
    Task<Region> FindRegionByName(string Name);
    Task<List<Address>> GetAllAddress();
    Task<Address> GetAddressById(int Id);
    Task<Address>UpdateAddress(int Id,Address address);
    Task<Address> RegisterAddress(Address address);
    Task<District> FindDistrictByName(string DistirctName);
    Task<Address> DeleteAddress(int Id);

}