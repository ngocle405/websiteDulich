using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApp_01.Data
{
    public partial class TravelContext : DbContext
    {
        public TravelContext()
        {
        }

        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<CategoriesNew> CategoriesNews { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<TopMenu> TopMenus { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ADMIN;Database=Travel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CategoriesNew>(entity =>
            {
                entity.ToTable("CategoriesNew");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(500);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Logo).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(250);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_News_CategoriesNew");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OrderEmail).HasMaxLength(500);

                entity.Property(e => e.OrderName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OrderNote).HasMaxLength(500);

                entity.Property(e => e.TotalMoney).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.ToTable("Place");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("Promotion");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.Logo).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Setting");

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Facebook)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Hotline1)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Hotline2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Info)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Logo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Zalo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Slide>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.Logo).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TopMenu>(entity =>
            {
                entity.ToTable("TopMenu");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.Logo).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.ToTable("Tour");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeparturePoint).HasMaxLength(50);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.PlaceName).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceDiscount).HasColumnType("decimal(18, 0)");

               // entity.Property(e => e.Start).HasColumnType("date");

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(250);

                entity.Property(e => e.Vehicle).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Tours)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Tour_Category");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Tours)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("FK_Tour_Place");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
