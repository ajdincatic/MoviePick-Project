using Microsoft.EntityFrameworkCore;
using MoviePick.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Database
{
    public partial class MoviePickContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            // user types
            modelBuilder.Entity<UserType>().HasData(new UserType()
            {
                Id = 1,
                Type = "Admin"
            });

            modelBuilder.Entity<UserType>().HasData(new UserType()
            {
                Id = 2,
                Type = "MobileAppUser"
            });

            // admin
            User u1 = new User
            {
                Id = 1,
                UserTypeId = 1,
                Username = "desktop",
                Phone = "061234567",
                FirstName = "Ajdin",
                LastName = "Xata",
                Email = "ajdin@fit.ba",
            };
            u1.PasswordSalt = HashGenerator.GenerateSalt();
            u1.PasswordHash = HashGenerator.GenerateHash(u1.PasswordSalt, "test");
            modelBuilder.Entity<User>().HasData(u1);

            // mobile user
            User u2 = new User
            {
                Id = 2,
                UserTypeId = 2,
                Username = "mobile",
                Phone = "061234567",
                FirstName = "Mobile",
                LastName = "Test",
                Email = "mobile@fit.ba",
            };
            u2.PasswordSalt = HashGenerator.GenerateSalt();
            u2.PasswordHash = HashGenerator.GenerateHash(u2.PasswordSalt, "test");
            modelBuilder.Entity<User>().HasData(u2);

            // prod. companies
            modelBuilder.Entity<ProductionCompany>().HasData(new ProductionCompany()
            {
                Id = 1,
                ProductionCompanyName = "Paramount pictures"
            });

            modelBuilder.Entity<ProductionCompany>().HasData(new ProductionCompany()
            {
                Id = 2,
                ProductionCompanyName = "MGM"
            });

            // genres
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 1,
                GenreName = "Drama"
            });

            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 2,
                GenreName = "Crime"
            });

            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 3,
                GenreName = "Horror"
            });

            // mtvs
            MovieAndTvshow m1 = new MovieAndTvshow
            {
                Id = 1,
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 1, 1),
                Budget = 100000000,
                Language = "English",
                Finished = true,
                NumberOfRatings = 0,
                RunningTime = "130",
                ProductionCompanyId = 1,
                Poster = new byte[15],
                Description = "desc"
            };
            modelBuilder.Entity<MovieAndTvshow>().HasData(m1);

            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 1,
                GenreId = 1,
                MovieAndTvshowId = 1
            });

            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 2,
                GenreId = 2,
                MovieAndTvshowId = 1
            });

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                Id = 1,
                MovieAndTvshowId = 1,
                AppUserId = 2,
                RatingValue = 100
            });

            modelBuilder.Entity<Quote>().HasData(new Quote()
            {
                Id = 1,
                QuoteText = "test",
                MovieAndTvshowId = 1
            });

            //roles
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = 1,
                RoleName = "Actor"
            });

            // person
            Person p1 = new Person
            {
                Id = 1,
                FirstName = "Al",
                LastName = "Pacino",
                Biography = "test",
                DateOfBirth = new DateTime(1, 1, 1),
                DateOfDeath = null,
                Gender = "M",
                Photo = new byte[15],
                PlaceOfBirth = "test"
            };
            modelBuilder.Entity<Person>().HasData(p1);

            modelBuilder.Entity<MovieAndTvshowPerson>().HasData(new MovieAndTvshowPerson()
            {
                Id = 1,
                MovieAndTvshowId = 1,
                PersonId = 1,
                NameInMovie = "Michael",
                RoleId = 1
            });
        }
    }
}
