using DisplayProp.Models;
using Microsoft.EntityFrameworkCore;

namespace DisplayProp.Data
{
    //Creates a new database context named StudentInformationContext
    public class DisplayPropContext : DbContext
    {
        public DisplayPropContext(DbContextOptions<DisplayPropContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Camper> Campers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}