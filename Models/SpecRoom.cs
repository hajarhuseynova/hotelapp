namespace HotelApp.Models
{
    public class SpecRoom:BaseModel
    {
        public int SpecId { get; set; }
        public int RoomId { get; set; }
        public Spec Spec { get; set; }
        public Room Room { get; set; }
    }
}
