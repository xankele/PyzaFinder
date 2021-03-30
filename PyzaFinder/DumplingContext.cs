using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PyzaFinder
{
    public partial class DumplingContext : DbContext
    {
        public DumplingContext()
        {
        }

        public DumplingContext(DbContextOptions<DumplingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Coordinate> Coordinates { get; set; }
        public virtual DbSet<DumplingRestaurant> DumplingRestaurants { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<Opinion> Opinions { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Database=pierogi;User Id=postgres;Password=studia");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum(null, "acctype", new[] { "user", "admin" })
                .HasAnnotation("Relational:Collation", "Polish_Poland.1250");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("account_pkey");

                entity.ToTable("account");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Acctype)
                    .HasMaxLength(255)
                    .HasColumnName("acctype")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Coordinate>(entity =>
            {
                entity.HasKey(e => e.IdCoordinates)
                    .HasName("coordinates_pkey");

                entity.ToTable("coordinates");

                entity.Property(e => e.IdCoordinates).HasColumnName("id_coordinates");

                entity.Property(e => e.CoordinateX).HasColumnName("coordinate_x");

                entity.Property(e => e.CoordinateY).HasColumnName("coordinate_y");

                entity.Property(e => e.IdRestaurant).HasColumnName("id_restaurant");

                entity.HasOne(d => d.IdRestaurantNavigation)
                    .WithMany(p => p.Coordinates)
                    .HasForeignKey(d => d.IdRestaurant)
                    .HasConstraintName("coordinates_id_restaurant_fkey");
            });

            modelBuilder.Entity<DumplingRestaurant>(entity =>
            {
                entity.HasKey(e => e.IdRestaurant)
                    .HasName("dumpling_restaurant_pkey");

                entity.ToTable("dumpling_restaurant");

                entity.Property(e => e.IdRestaurant).HasColumnName("id_restaurant");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("address")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.HasKey(e => e.IdLink)
                    .HasName("links_pkey");

                entity.ToTable("links");

                entity.Property(e => e.IdLink).HasColumnName("id_link");

                entity.Property(e => e.FacebookLink)
                    .HasMaxLength(255)
                    .HasColumnName("facebook_link")
                    .IsFixedLength(true);

                entity.Property(e => e.IdRestaurant).HasColumnName("id_restaurant");

                entity.Property(e => e.InstagramLink)
                    .HasMaxLength(255)
                    .HasColumnName("instagram_link")
                    .IsFixedLength(true);

                entity.Property(e => e.PageLink)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("page_link")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdRestaurantNavigation)
                    .WithMany(p => p.Links)
                    .HasForeignKey(d => d.IdRestaurant)
                    .HasConstraintName("links_id_restaurant_fkey");
            });

            modelBuilder.Entity<Opinion>(entity =>
            {
                entity.HasKey(e => e.IdOpinion)
                    .HasName("opinion_pkey");

                entity.ToTable("opinion");

                entity.Property(e => e.IdOpinion).HasColumnName("id_opinion");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.IdRestaurant).HasColumnName("id_restaurant");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdRestaurantNavigation)
                    .WithMany(p => p.Opinions)
                    .HasForeignKey(d => d.IdRestaurant)
                    .HasConstraintName("opinion_id_restaurant_fkey");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => e.IdPhoto)
                    .HasName("photo_pkey");

                entity.ToTable("photo");

                entity.Property(e => e.IdPhoto).HasColumnName("id_photo");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.IdRestaurant).HasColumnName("id_restaurant");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("path")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdRestaurantNavigation)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.IdRestaurant)
                    .HasConstraintName("photo_id_restaurant_fkey");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.IdSchedule)
                    .HasName("schedule_pkey");

                entity.ToTable("schedule");

                entity.Property(e => e.IdSchedule).HasColumnName("id_schedule");

                entity.Property(e => e.Friday)
                    .HasMaxLength(255)
                    .HasColumnName("friday")
                    .IsFixedLength(true);

                entity.Property(e => e.IdRestaurant).HasColumnName("id_restaurant");

                entity.Property(e => e.Monday)
                    .HasMaxLength(255)
                    .HasColumnName("monday")
                    .IsFixedLength(true);

                entity.Property(e => e.Saturday)
                    .HasMaxLength(255)
                    .HasColumnName("saturday")
                    .IsFixedLength(true);

                entity.Property(e => e.Sunday)
                    .HasMaxLength(255)
                    .HasColumnName("sunday")
                    .IsFixedLength(true);

                entity.Property(e => e.Thursday)
                    .HasMaxLength(255)
                    .HasColumnName("thursday")
                    .IsFixedLength(true);

                entity.Property(e => e.Tuesday)
                    .HasMaxLength(255)
                    .HasColumnName("tuesday")
                    .IsFixedLength(true);

                entity.Property(e => e.Wednesday)
                    .HasMaxLength(255)
                    .HasColumnName("wednesday")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdRestaurantNavigation)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.IdRestaurant)
                    .HasConstraintName("schedule_id_restaurant_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
