using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Position:BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
