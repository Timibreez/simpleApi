using Microsoft.EntityFrameworkCore;
using SimpleApi.Models;

namespace SimpleApi.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }
        public ApiContext(DbContextOptions <ApiContext> options)
            :base(options)
        {

        }
    }
}
