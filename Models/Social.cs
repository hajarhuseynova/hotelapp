using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Social:BaseModel
    {
        [Required]
        public string Icon { get; set; }

        [Required]
        public string Link { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
