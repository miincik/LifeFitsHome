namespace LifeFitsHome.Model.Entity;


public class Area {
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Description {get; set;}
    public bool? IsSafety { get; set; }

    //public virtual ICollection<Address> Adress {get; set;}
    public AreaTypeEnum AreaType{get; set;}

}