using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatTuaDuLich.Models
{
    public class DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        // Thêm các DbSet khác nếu cần thiết

    }
}
