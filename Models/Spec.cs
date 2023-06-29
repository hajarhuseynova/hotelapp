using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Spec:BaseModel
    {
        [Required]
        public string Icon { get; set; }
        [Required]
        public string SpecName { get; set; }  
        public List<SpecRoom> SpecRooms { get; set; }
    }
}
