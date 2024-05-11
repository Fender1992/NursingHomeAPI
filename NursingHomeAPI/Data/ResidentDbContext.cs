using Microsoft.EntityFrameworkCore;
using NursingHomeAPI.Domains;

namespace NursingHomeAPI.Data
{
    public class ResidentDbContext : DbContext
    {
        public ResidentDbContext(DbContextOptions<ResidentDbContext> options): base(options) { }

        DbSet<Resident> Residents { get; set; }
        DbSet<EmergencyContact> EmergencyContacts { get; set; }
    }
}
