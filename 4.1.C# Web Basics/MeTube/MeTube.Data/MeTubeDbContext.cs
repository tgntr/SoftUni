namespace MeTube.Data

{
    using Microsoft.EntityFrameworkCore;
    using MeTube.Models;


    public class MeTubeDbContext : DbContext
    {
      
        public DbSet<User> Users { get; set; }

        public DbSet<Tube> Tubes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(@"Server=.\SqlExpress;Database=MeTube_tgntr;Trusted_Connection=True;");
            }

            base.OnConfiguring(builder);
        }
        

           
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            builder
               .Entity<User>()
               .HasIndex(u => u.Email)
               .IsUnique();

            base.OnModelCreating(builder);

        }
       
    }
}
