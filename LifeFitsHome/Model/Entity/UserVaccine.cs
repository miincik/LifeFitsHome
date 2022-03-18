namespace LifeFitsHome.Model.Entity{
    public class UserVaccine : IEntity{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public User? User { get; set; }
        public int UserId { get; set; }
        public Vaccine? Vaccine { get; set; }
        public int VaccineId { get; set; }
    }
}