using CrudAssessment.Server.Services;
using CrudAssessment.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrudAssessment.Server.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public virtual  DbSet<UserInfo> UserInform { get; set; } = null!;

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.UserPk);

                entity.Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("UserName");

                entity.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Email");

                entity.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(100).HasColumnName("PhoneNumber");

                entity.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Password");

                entity.Property(x => x.PasswordHash)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("PasswordHash");

                entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')").HasColumnName("CreationDate");
                entity.Property(e => e.CreationDateStamp)
                .HasDefaultValueSql("(CONVERT([bigint],(0)))").HasColumnName("CreationTimeStamp");


                entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')").HasColumnName("UpdateDate");
                entity.Property(e => e.UpdateDateStamp)
                .HasDefaultValueSql("(CONVERT([bigint],(0)))").HasColumnName("UpdateDateStamp");

                entity.Property(x => x.DeleteBy).HasColumnName("DeleteBy");

                entity.Property(e => e.DeleteDate)
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')").HasColumnName("DeleteDate");
                entity.Property(e => e.DeleteDateStamp)
                .HasDefaultValueSql("(CONVERT([bigint],(0)))").HasColumnName("DeleteDateStamp");

            });
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

       partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }
}
