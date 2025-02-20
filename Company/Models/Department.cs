namespace Company.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? MGRName { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; } = new HashSet<Employee>();
    }
}
