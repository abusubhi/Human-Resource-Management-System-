using System.ComponentModel.DataAnnotations;

namespace HRSMF.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
