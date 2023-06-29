namespace HotelApp.Models
{
    public class RoomBookType:BaseModel
    {
        public int RoomId { get; set; }
        public int BookTypeId { get; set; }
        public Room Room { get; set; }
        public BookType BookType { get; set; }  

    }
}
