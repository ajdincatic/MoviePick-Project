using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoviePick.Database
{
    public partial class MoviePickContext : DbContext
    {
        public MoviePickContext()
        {
        }

        public MoviePickContext(DbContextOptions<MoviePickContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<MovieAndTvshow> MovieAndTvshow { get; set; }
        public virtual DbSet<MovieAndTvshowGenre> MovieAndTvshowGenre { get; set; }
        public virtual DbSet<MovieAndTvshowNews> MovieAndTvshowNews { get; set; }
        public virtual DbSet<MovieAndTvshowPerson> MovieAndTvshowPerson { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<ProductionCompany> ProductionCompany { get; set; }
        public virtual DbSet<Quote> Quote { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<TvshowSeason> TvshowSeason { get; set; }
        public virtual DbSet<TvshowSeasonEpisode> TvshowSeasonEpisode { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=MoviePick;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DateTimeOfComment).HasColumnType("datetime");

                entity.Property(e => e.MovieAndTvshowId).HasColumnName("MovieAndTVShowId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__AppUser__412EB0B6");

                entity.HasOne(d => d.MovieAndTvshow)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.MovieAndTvshowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__MovieAn__4222D4EF");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MovieAndTvshow>(entity =>
            {
                entity.ToTable("MovieAndTVShow");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.RunningTime)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ProductionCompany)
                    .WithMany(p => p.MovieAndTvshow)
                    .HasForeignKey(d => d.ProductionCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAndT__Produ__4316F928");
            });

            modelBuilder.Entity<MovieAndTvshowGenre>(entity =>
            {
                entity.ToTable("MovieAndTVShowGenre");

                entity.Property(e => e.MovieAndTvshowId).HasColumnName("MovieAndTVShowId");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.MovieAndTvshowGenre)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAndT__Genre__440B1D61");

                entity.HasOne(d => d.MovieAndTvshow)
                    .WithMany(p => p.MovieAndTvshowGenre)
                    .HasForeignKey(d => d.MovieAndTvshowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAndT__Movie__44FF419A");
            });

            modelBuilder.Entity<MovieAndTvshowNews>(entity =>
            {
                entity.ToTable("MovieAndTVShowNews");

                entity.Property(e => e.MovieAndTvshowId).HasColumnName("MovieAndTVShowId");

                entity.HasOne(d => d.MovieAndTvshow)
                    .WithMany(p => p.MovieAndTvshowNews)
                    .HasForeignKey(d => d.MovieAndTvshowId)
                    .HasConstraintName("FK__MovieAndT__Movie__45F365D3");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.MovieAndTvshowNews)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK__MovieAndT__NewsI__46E78A0C");
            });

            modelBuilder.Entity<MovieAndTvshowPerson>(entity =>
            {
                entity.ToTable("MovieAndTVShowPerson");

                entity.Property(e => e.MovieAndTvshowId).HasColumnName("MovieAndTVShowId");

                entity.Property(e => e.NameInMovie).HasMaxLength(50);

                entity.HasOne(d => d.MovieAndTvshow)
                    .WithMany(p => p.MovieAndTvshowPerson)
                    .HasForeignKey(d => d.MovieAndTvshowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAndT__Movie__47DBAE45");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MovieAndTvshowPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAndT__Perso__48CFD27E");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MovieAndTvshowPerson)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAndT__RoleI__49C3F6B7");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.DateTimeOfNews).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__News__AuthorId__4AB81AF0");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Biography)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateOfDeath).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PlaceOfBirth)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductionCompany>(entity =>
            {
                entity.Property(e => e.ProductionCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.Property(e => e.MovieAndTvshowId).HasColumnName("MovieAndTVShowId");

                entity.Property(e => e.QuoteText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MovieAndTvshow)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.MovieAndTvshowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Quote__MovieAndT__4BAC3F29");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.MovieAndTvshowId).HasColumnName("MovieAndTVShowId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rating__AppUserI__4CA06362");

                entity.HasOne(d => d.MovieAndTvshow)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.MovieAndTvshowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rating__MovieAnd__4D94879B");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TvshowSeason>(entity =>
            {
                entity.ToTable("TVShowSeason");

                entity.Property(e => e.MovieAndTvshowId).HasColumnName("MovieAndTVShowId");

                entity.Property(e => e.SeasonName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MovieAndTvshow)
                    .WithMany(p => p.TvshowSeason)
                    .HasForeignKey(d => d.MovieAndTvshowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TVShowSea__Movie__4E88ABD4");
            });

            modelBuilder.Entity<TvshowSeasonEpisode>(entity =>
            {
                entity.ToTable("TVShowSeasonEpisode");

                entity.Property(e => e.AirDate).HasColumnType("date");

                entity.Property(e => e.EpisodeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TvshowSeasonId).HasColumnName("TVShowSeasonId");

                entity.HasOne(d => d.TvshowSeason)
                    .WithMany(p => p.TvshowSeasonEpisode)
                    .HasForeignKey(d => d.TvshowSeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TVShowSea__TVSho__4F7CD00D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User__UserTypeId__5070F446");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
