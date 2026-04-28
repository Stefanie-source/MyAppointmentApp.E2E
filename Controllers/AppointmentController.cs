using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyAppointmentApp.Data;
using MyAppointmentApp.Models;

namespace MyAppointmentApp.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AppointmentDbContext _context;

        public AppointmentController(AppointmentDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var appointments= _context.Appointments.ToList();
            return View(appointments);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
