using LifeFitsHome.Model.Entity;

public class QRCode : IEntity
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }


}