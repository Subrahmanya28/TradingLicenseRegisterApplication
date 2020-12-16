using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    public partial class TradingLicenseDbContext : DbContext
    {
        public TradingLicenseDbContext()
        {
        }

        public TradingLicenseDbContext(DbContextOptions<TradingLicenseDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LicenceApplicationTemp> LicenceApplicationTemps { get; set; }
        public virtual DbSet<LicenceMasterTemp> LicenceMasterTemps { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Minor> Minors { get; set; }
        public virtual DbSet<Mlc> Mlcs { get; set; }
        public virtual DbSet<Sub> Subs { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.*/
                optionsBuilder.UseSqlServer("Server=DESKTOP-T0TJ48T\\SQLEXPRESS01;Initial Catalog=tradelicense;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LicenceApplicationTemp>(entity =>
            {
                entity.Property(e => e.AcknowledgementNumber).IsUnicode(false);

                entity.Property(e => e.AcknowledgementSecurityCode).IsUnicode(false);

                entity.Property(e => e.ApplicationNumber).IsUnicode(false);

                entity.Property(e => e.BescomRrnumber).IsUnicode(false);

                entity.Property(e => e.DocsSubmitted).IsUnicode(false);

                entity.Property(e => e.InactiveReason).IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NewApplicationNumber).IsUnicode(false);

                entity.Property(e => e.ReceiptNumber).IsUnicode(false);

                entity.Property(e => e.ReceiptSecurityCode).IsUnicode(false);

                entity.Property(e => e.Tinnumber).IsUnicode(false);

                entity.Property(e => e.Vatnumber).IsUnicode(false);
            });

            modelBuilder.Entity<LicenceMasterTemp>(entity =>
            {
                entity.Property(e => e.DoorNumber).IsUnicode(false);

                entity.Property(e => e.EmailId).IsUnicode(false);

                entity.Property(e => e.Gisnumber).IsUnicode(false);

                entity.Property(e => e.KhathaNumber).IsUnicode(false);

                entity.Property(e => e.LandLineNumber).IsUnicode(false);

                entity.Property(e => e.LicenceNumber).IsUnicode(false);

                entity.Property(e => e.MobileNumber).IsUnicode(false);

                entity.Property(e => e.NewlicenceNumber).IsUnicode(false);

                entity.Property(e => e.OldapplicationNumber).IsUnicode(false);

                entity.Property(e => e.Pidnumber).IsUnicode(false);

                entity.Property(e => e.Street).IsUnicode(false);

                entity.Property(e => e.SurveyNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Minor>(entity =>
            {
                entity.Property(e => e.Minorname).IsUnicode(false);
            });

            modelBuilder.Entity<Mlc>(entity =>
            {
                entity.Property(e => e.Mlcname).IsUnicode(false);
            });

            modelBuilder.Entity<Sub>(entity =>
            {
                entity.Property(e => e.Subname).IsUnicode(false);
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.Property(e => e.Wardname).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
