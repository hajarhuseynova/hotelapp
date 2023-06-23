
using HotelApp.Context;
using HotelApp.Models;
using HotelApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HotelApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HotelAppDbContext _context;

        public HomeController(HotelAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
           HomeVM homeVM = new HomeVM();
            homeVM.Slides = _context.Slides.Where(x => !x.IsDeleted).ToList();
            homeVM.Settings = _context.Settings.FirstOrDefault();
            homeVM.Services = _context.Services.Where(x => !x.IsDeleted).ToList();
            homeVM.Employees = _context.Employees.Where(x => !x.IsDeleted).Include(x => x.Position).
                Include(x => x.Socials.Where(s => !s.IsDeleted).ToList();
            return View(homeVM);
        }

        //public async Task<IActionResult> CreatePosition()
        //{
        //    Position position = new Position {
        //        CreatedDate = DateTime.Now,
        //        Name="Developer"
        //    };
        //    Position position1 = new Position
        //    {
        //        CreatedDate = DateTime.Now,
        //        Name = "UX Designer"
        //    };
        //    Position position3 = new Position
        //    {
        //        CreatedDate = DateTime.Now,
        //        Name = "Teacher"
        //    };
        //    Position position4 = new Position
        //    {
        //        CreatedDate = DateTime.Now,
        //        Name = "Engineer"
        //    };
        //    await _context.Positions.AddAsync(position);
        //    await _context.Positions.AddAsync(position1);
        //    await _context.Positions.AddAsync(position3);
        //    await _context.Positions.AddAsync(position4);
        //    await _context.SaveChangesAsync();
        //    return Json("OK");
        //}
        //public async Task<IActionResult> CreateEmployee()
        //{
        //    Employee employee = new Employee
        //    {
        //        FullName = "Huseyn Huseynov",
        //        CreatedDate = DateTime.Now,
        //        PositionId = 1,
        //    };
        //    Employee employee1 = new Employee
        //    {
        //        FullName = "Faiq Huseynov",
        //        CreatedDate = DateTime.Now,
        //        PositionId = 2,
        //    };
        //    Employee employee2 = new Employee
        //    {
        //        FullName = "Vuqar Huseynov",
        //        CreatedDate = DateTime.Now,
        //        PositionId = 3,
        //    };
        //    Employee employee3 = new Employee
        //    {
        //        FullName = "Ilqae Huseynov",
        //        CreatedDate = DateTime.Now,
        //        PositionId = 2,
        //    };
        //    await _context.Employees.AddAsync(employee);
        //    await _context.Employees.AddAsync(employee1);
        //    await _context.Employees.AddAsync(employee2);
        //    await _context.Employees.AddAsync(employee3);

        //    List<Social> Socials = new List<Social>
        //    {
        //  new Social{
        //            CreatedDate=DateTime.Now,
        //            Icon="<i class='fab fa-facebook-f'></i>",
        //            Link="https://www.facebook.com/",
        //            Employee=employee
        //        },
        //  new Social{
        //            CreatedDate=DateTime.Now,
        //            Icon="<i class='fab fa-twitter'></i>",
        //            Link="https://www.facebook.com/",
        //                 Employee=employee
        //        },
        //  new Social{
        //            CreatedDate=DateTime.Now,
        //            Icon="<i class='fab fa-instagram'></i>",
        //            Link="https://www.facebook.com/",
        //                 Employee=employee
        //        }
        //    };
        //    await _context.Socials.AddRangeAsync(Socials);
        //    await _context.SaveChangesAsync();
        //    return Json("OK");
        //}
        //public async Task<IActionResult> Create()
        //{
        //    Slider Slider = new Slider
        //    {
        //        CreatedDate = DateTime.Now,
        //        Title = "WELCOME 10",
        //        IsDeleted = false,
        //        Image = "carousel-1.jpg",
        //        Link = "hahaha",
        //        isActive = true
        //    };
        //    Slider Slider2 = new Slider
        //    {
        //        CreatedDate = DateTime.Now,
        //        Title = "WELCOME 20",
        //        IsDeleted = false,
        //        Image = "carousel-1.jpg",
        //        Link = "hahaha"
        //    };
        //    await _context.AddAsync(Slider);
        //    await _context.AddAsync(Slider2);
        //    await _context.SaveChangesAsync();
        //    return Json("OK");
        //}


        //public async Task<IActionResult> Create()
        //{
        //    Setting Setting = new Setting
        //    {
        //        CreatedDate = DateTime.Now,
        //       Email ="hajar@code.edu",
        //       Address="gunaydinsokak",
        //       ClientCount=50,
        //       StaffCount=250,
        //       RoomCount=500,
        //       PhoneNumber="+9943928274",
        //       AboutText="gunaydiiin cocxular xosh geldizniz",
        //       DiscoverDescription="lalala ben enguzel",
        //       DiscoverTitle="babiesss",
        //       VideoLink= "https://www.youtube.com/watch?v=ueEA3pTOUuU&list=RDueEA3pTOUuU&start_radio=1"
        //    };

        //    await _context.AddAsync(Setting);
        //    await _context.SaveChangesAsync();
        //    return Json("OK");
        //}

    }
}