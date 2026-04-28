using Microsoft.EntityFrameworkCore;
using MyAppointmentApp.Models;

namespace MyAppointmentApp.Data
{
    public class AppointmentDbContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }

        public AppointmentDbContext(DbContextOptions<AppointmentDbContext>options)
            :base(options)
        {
            
        }
    }
}
