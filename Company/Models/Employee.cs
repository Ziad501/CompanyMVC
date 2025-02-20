using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public string? Image { get; set; }
        [ForeignKey("Department")] // Department here is the second Department in the navigation property
        public int DepartmentID { get; set; }
        public virtual Department? Department { get; set; } // Navigation property for Department "when creating object بتاخد  الريفرينس القديم مش بيعمل واحد جديد"
        //navigation property >> Navigation properties are used to link tables, like foreign keys in databases.
        //navigation property >> They come in handy when you want to retrieve related data without writing complex SQL queries.
        //navigation property >> They also help maintain referential integrity.

    }
}
