using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DemoDotnetCoreApp.Data
{
    public partial class AzureConsultationDatabaseContext : DbContext
    {
        public AzureConsultationDatabaseContext()
        {
        }

        public AzureConsultationDatabaseContext(DbContextOptions<AzureConsultationDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Proposal> Proposals { get; set; }
        public virtual DbSet<Site> Sites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=azureconsulationserver.database.windows.net;Database=AzureConsultationDatabase;User id=adminazure;Password=Azurepassword@1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proposal>(entity =>
            {
                entity.ToTable("Proposal");

                entity.Property(e => e.ProposalId).HasColumnName("ProposalID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SIteNo");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasKey(e => e.SiteNo)
                    .HasName("PK__Site__73CF1FFC83539091");

                entity.ToTable("Site");

                entity.Property(e => e.SiteNo)
                    .ValueGeneratedNever()
                    .HasColumnName("SIteNo");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
