using System.ComponentModel.DataAnnotations.Schema;

namespace HRSMF.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public int ManagerId { get; set; }
        public bool IsActive { get; set; } = true;


        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position? Position { get; set; }
    }
}
