using Microsoft.EntityFrameworkCore;
using MySqlEf.Data.Entity;

namespace MySqlEf.Data.DbContext
{
    public class NewShopContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(@"User Id=root;password=P@ssw0rd; port=3306;server=localhost;database=newshop;");
            optionsBuilder.UseMySQL(@"server=localhost;database=newshop;user=root;password=P@ssw0rd");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_User");

                entity.ToTable("USER");

                entity.Property(e => e.Id).HasColumnName("USER_ID");

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Location");

                entity.ToTable("LOCATION");

                entity.Property(e => e.Id).HasColumnName("LOCATION_ID");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("PHONE_NUMBER")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}
