using Microsoft.EntityFrameworkCore;

namespace solemnsinger.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Location> Locations { get; set; }
        
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongSinger> SongSingers { get;set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Contract>().HasKey(c => new { c.LocationId, c.TermId });
            //modelBuilder.Entity<Contract>().HasOne(c => c.EventLocation).WithOne(el => el.Contract).OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Contract>().HasOne(c => c.Term).WithMany(t => t.Contracts).OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AccessLevelModifications>().HasKey(alm => new { alm.AccessLevelId, alm.ModificationId });
            //modelBuilder.Entity<AccessLevelModifications>().HasOne(alm => alm.AccessLevel).WithMany(al => al.AccessLevelModifications).HasForeignKey(alm => alm.AccessLevelId)
            //    .OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<AccessLevelModifications>().HasOne(alm => alm.Modification).WithMany(m => m.AccessLevelModifications).HasForeignKey(alm => alm.ModificationId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
