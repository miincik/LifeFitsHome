using LifeFitsHome.Model.Entity;

public class QRCode : IEntity
{
    public int Id { get; set; }
    public string Description { get; set; }
    public virtual User? User { get; set; }


}