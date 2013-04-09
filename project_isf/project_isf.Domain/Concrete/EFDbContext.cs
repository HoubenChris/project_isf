using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using project_isf.Domain.POCO;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace project_isf.Domain.Concrete
{
    public class EFDbContext: DbContext
    {

        public EFDbContext()
            : base("ProjectISFDb")
        {
        }

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<AdvertisementLocation> AdvertisementLocations { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ISFRepresentative> ISFRepresantives { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingEvent> MeetingEvents { get; set; }
        public DbSet<NSF> NSFs { get; set; }
        public DbSet<NSFRepresentative> NSFRepresentatives { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolCupCoordinator> SchoolCupCoordinators { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Team> Teams { get; set; }

        //voorkomen dat EF automatisch "s" toevoegd aan de naam van het model
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
