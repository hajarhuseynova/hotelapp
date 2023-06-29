namespace HotelApp.Models
{
    public class BookType:BaseModel
    {
        public string Name { get; set; }
        public List<RoomBookType> RoomBookTypes { get; set; }
    }
}
