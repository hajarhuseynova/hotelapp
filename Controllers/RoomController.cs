using HotelApp.Context;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly HotelAppDbContext _context;
public RoomController(HotelAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Room> rooms = await _context.Rooms.Where(x => !x.IsDeleted)
                .Include(x => x.RoomBookTypes).ThenInclude(x=>x.BookType)
                .Include(x=>x.SpecRooms).ThenInclude(x=>x.Spec).ToListAsync();
            return View(rooms);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Room? Room = await _context.Rooms
                .Include(x => x.RoomBookTypes).ThenInclude(x => x.BookType)
                .Include(x => x.SpecRooms).ThenInclude(x => x.Spec).FirstOrDefaultAsync(x=>x.Id==id);
            if (Room == null)
            {
                return RedirectToAction("Error","home");
            }
            return View(Room);
        }
    }
}
