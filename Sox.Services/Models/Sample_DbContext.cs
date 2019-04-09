using Microsoft.EntityFrameworkCore;

namespace Sox.Services.Models
{
    public partial class Sample_DbContext : DbContext
    {
        //"Server=(localdb)\\mssqllocaldb;Database=Sample_Db;Trusted_Connection=True;"
        private readonly string _sqlCnn;

        public Sample_DbContext()
        {
        }

        public Sample_DbContext(string sqlCnn)
        {
            _sqlCnn = sqlCnn;
        }
        public Sample_DbContext(DbContextOptions<Sample_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerMaster> CustomerMaster { get; set; }
        public virtual DbSet<FrequencyMaster> FrequencyMaster { get; set; }
        public virtual DbSet<UsecaseMaster> UsecaseMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_sqlCnn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Customer_Master");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasColumnName("Customer_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrequencyMaster>(entity =>
            {
                entity.HasKey(e => e.FrequencyId);

                entity.ToTable("Frequency_Master");

                entity.Property(e => e.FrequencyId).HasColumnName("Frequency_ID");

                entity.Property(e => e.FrequencyCode)
                    .IsRequired()
                    .HasColumnName("Frequency_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsecaseMaster>(entity =>
            {
                entity.HasKey(e => e.UsecaseId);

                entity.ToTable("Usecase_Master");

                entity.Property(e => e.UsecaseId).HasColumnName("Usecase_ID");

                entity.Property(e => e.UsecaseCode)
                    .IsRequired()
                    .HasColumnName("Usecase_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
