using System.ComponentModel.DataAnnotations;

namespace FIAPUniversity.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();      
    }
}
