using Microsoft.EntityFrameworkCore;

namespace CarRentalApp
{
    class RentalModel : DbContext
    {
        public virtual DbSet<CustomerAccounts> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RentalAccountDB;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAccounts>(entity =>
            {
                entity.HasKey(e => e.CustomerAccountNumber)
                .HasName("PK_AccountNumber");

                entity.Property(e => e.CustomerEmailAddress)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerName)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerAddress)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerPhoneNumber)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerDriversLicenseNumber)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerCreditCardNumber)
                .ValueGeneratedOnAdd();

            });
        }
    }
}
