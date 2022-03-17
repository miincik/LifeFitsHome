using LifeFitsHome.Model.Entity;

public interface IAreaRepository{
    Task<Area> FindAreaById(int id);
    Task<Area>FindAreaByName(int name);
    
    Task<Area>DeleteArea(int id);
    Task<Area>UpdateArea(int id,Area area);
    Task<List<Area>> GetAllArea();
    
    
}