using Microsoft.EntityFrameworkCore;
using SimpleApi.Models;

namespace SimpleApi.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; } = default!;
        public ApiContext(DbContextOptions <ApiContext> options)
            :base(options)
        {

        }
    }
}
