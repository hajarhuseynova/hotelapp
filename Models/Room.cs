using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Room : BaseModel
    { 
        [Required]
        public string Image { get; set; }
        [Range(0,999999999999.99)]
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Desc { get; set; }
        public List<RoomBookType> RoomBookTypes { get; set; }
        public List<SpecRoom> SpecRooms { get; set; }
    }
}
