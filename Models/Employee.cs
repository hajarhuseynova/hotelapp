using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Employee:BaseModel
    {
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }    

        public string Image { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }  
        public List<Social> Socials { get; set; }
    }
}
