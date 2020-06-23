using Microsoft.EntityFrameworkCore;
using MoviePick.Helper;
using System;
using System.Collections.Generic;
using System.IO;
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
            modelBuilder.Entity<ProductionCompany>().HasData(new ProductionCompany()
            {
                Id = 3,
                ProductionCompanyName = "Marvel"
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
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 4,
                GenreName = "Action"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 5,
                GenreName = "Comedy"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 6,
                GenreName = "Mystery"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 7,
                GenreName = "Sci-Fi"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 8,
                GenreName = "Thriller"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 9,
                GenreName = "Animation"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 10,
                GenreName = "Fantasy"
            });

            // mtvs
            MovieAndTvshow m1 = new MovieAndTvshow
            {
                Id = 1,
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 1, 27),
                Budget = 100000000,
                Language = "English",
                Finished = true,
                NumberOfRatings = 1,
                RunningTime = "130",
                ProductionCompanyId = 1,
                Poster = new byte[0],
                Description = @"The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
            };
            modelBuilder.Entity<MovieAndTvshow>().HasData(m1);

            MovieAndTvshow m2 = new MovieAndTvshow
            {
                Id = 2,
                Title = "Mr. Robot",
                ReleaseDate = new DateTime(2015, 5, 20),
                Budget = 100000000,
                Language = "English",
                Finished = true,
                NumberOfRatings = 1,
                RunningTime = "45",
                ProductionCompanyId = 3,
                Poster = new byte[0],
                Description = "Elliot, a brilliant but highly unstable young cyber-security engineer and vigilante hacker, becomes a key figure in a complex game of global dominance when he and his shadowy allies try to take down the corrupt corporation he works for."
            };
            modelBuilder.Entity<MovieAndTvshow>().HasData(m2);

            MovieAndTvshow m3 = new MovieAndTvshow
            {
                Id = 3,
                Title = "The Curious Case of Benjamin Button",
                ReleaseDate = new DateTime(2006, 5, 20),
                Budget = 100000000,
                Language = "English",
                Finished = true,
                NumberOfRatings = 1,
                RunningTime = "175",
                ProductionCompanyId = 3,
                Poster = new byte[0],
                Description = "Tells the story of Benjamin Button, a man who starts aging backwards with consequences."
            };
            modelBuilder.Entity<MovieAndTvshow>().HasData(m3);

            MovieAndTvshow m4 = new MovieAndTvshow
            {
                Id = 4,
                Title = "Fight Club",
                ReleaseDate = new DateTime(1999, 5, 20),
                Budget = 100000000,
                Language = "English",
                Finished = true,
                NumberOfRatings = 1,
                RunningTime = "175",
                ProductionCompanyId = 3,
                Poster = new byte[0],
                Description = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more."
            };
            modelBuilder.Entity<MovieAndTvshow>().HasData(m4);

            // mtvs genres
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
            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 3,
                GenreId = 1,
                MovieAndTvshowId = 2
            });
            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 4,
                GenreId = 2,
                MovieAndTvshowId = 2
            });
            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 5,
                GenreId = 8,
                MovieAndTvshowId = 3
            });
            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 6,
                GenreId = 2,
                MovieAndTvshowId = 3
            });
            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 7,
                GenreId = 9,
                MovieAndTvshowId = 3
            });
            modelBuilder.Entity<MovieAndTvshowGenre>().HasData(new MovieAndTvshowGenre()
            {
                Id = 8,
                GenreId = 1,
                MovieAndTvshowId = 4
            });

            // rating
            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                Id = 1,
                MovieAndTvshowId = 1,
                AppUserId = 2,
                RatingValue = 100
            });
            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                Id = 2,
                MovieAndTvshowId = 2,
                AppUserId = 2,
                RatingValue = 88
            });
            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                Id = 3,
                MovieAndTvshowId = 3,
                AppUserId = 2,
                RatingValue = 99
            });
            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                Id = 4,
                MovieAndTvshowId = 4,
                AppUserId = 2,
                RatingValue = 76
            });

            // quote
            modelBuilder.Entity<Quote>().HasData(new Quote()
            {
                Id = 1,
                QuoteText = "Friendship is everything. Friendship is more than talent. It is more than the government.",
                MovieAndTvshowId = 1
            });
            modelBuilder.Entity<Quote>().HasData(new Quote()
            {
                Id = 2,
                QuoteText = "A friend should always underestimate your virtues and an enemy overestimate your faults.",
                MovieAndTvshowId = 1
            });

            //roles
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = 1,
                RoleName = "Actor"
            });
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = 2,
                RoleName = "Director"
            });
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = 3,
                RoleName = "Writter"
            });
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = 4,
                RoleName = "Producer"
            });

            // seasons & episodes
            modelBuilder.Entity<TvshowSeason>().HasData(new TvshowSeason()
            {
                Id = 1,
                MovieAndTvshowId = 2,
                Finished = true,
                SeasonName = "Season 1",
            });
            modelBuilder.Entity<TvshowSeason>().HasData(new TvshowSeason()
            {
                Id = 2,
                MovieAndTvshowId = 2,
                Finished = true,
                SeasonName = "Season 2",
            });

            modelBuilder.Entity<TvshowSeasonEpisode>().HasData(new TvshowSeasonEpisode()
            {
                Id = 1,
                EpisodeNumber = 1,
                TvshowSeasonId = 1,
                TvshowId = 2,
                AirDate = new DateTime(2015, 3, 15),
                EpisodeName = "eps1.0_hellofriend.mov"
            });
            modelBuilder.Entity<TvshowSeasonEpisode>().HasData(new TvshowSeasonEpisode()
            {
                Id = 2,
                EpisodeNumber = 2,
                TvshowSeasonId = 1,
                TvshowId = 2,
                AirDate = new DateTime(2015, 3, 19),
                EpisodeName = "eps1.1_ones-and-zer0es.mpeg"
            });
            modelBuilder.Entity<TvshowSeasonEpisode>().HasData(new TvshowSeasonEpisode()
            {
                Id = 3,
                EpisodeNumber = 1,
                TvshowSeasonId = 2,
                TvshowId = 2,
                AirDate = new DateTime(2016, 3, 19),
                EpisodeName = "eps2.1_EPISODE1.mpeg"
            });

            // person
            Person p1 = new Person
            {
                Id = 1,
                FirstName = "Al",
                LastName = "Pacino",
                Biography = "Alfredo James Pacino established himself as a film actor during one of cinema's most vibrant decades, the 1970s, and has become an enduring and iconic figure in the world of American movies. He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young",
                DateOfBirth = new DateTime(1940, 4, 25),
                DateOfDeath = null,
                Gender = "M",
                Photo = new byte[0],
                PlaceOfBirth = "Manhattan, New York City, New York, USA"
            };
            modelBuilder.Entity<Person>().HasData(p1);
            
            Person p2 = new Person
            {
                Id = 2,
                FirstName = "Francis",
                LastName = "Ford Coppola",
                Biography = "Francis Ford Coppola was born in 1939 in Detroit, Michigan, but grew up in a New York suburb in a creative, supportive Italian-American family. His father, Carmine Coppola, was a composer and musician. His mother, Italia Coppola (née Pennino), had been an actress. Francis Ford Coppola graduated with a degree in drama from Hofstra University.",
                DateOfBirth = new DateTime(1939, 7, 4),
                DateOfDeath = null,
                Gender = "M",
                Photo = new byte[0],
                PlaceOfBirth = "Detroit, Michigan, USA"
            };
            modelBuilder.Entity<Person>().HasData(p2);

            Person p3 = new Person
            {
                Id = 3,
                FirstName = "Brad",
                LastName = "Pitt",
                Biography = "An actor and producer known as much for his versatility as he is for his handsome face, Golden Globe-winner Brad Pitt's most widely recognized role may be Tyler Durden in Fight Club (1999). However, his portrayals of Billy Beane in Moneyball (2011), and Rusty Ryan in the remake of Ocean's Eleven (2001) and its sequels, also loom large in his ...",
                DateOfBirth = new DateTime(1970, 7, 4),
                DateOfDeath = null,
                Gender = "M",
                Photo = new byte[0],
                PlaceOfBirth = "Los Angeles"
            };
            modelBuilder.Entity<Person>().HasData(p3);

            Person p4 = new Person
            {
                Id = 4,
                FirstName = "David",
                LastName = "Fincher",
                Biography = "An actor and producer known as much for his versatility as he is for his handsome face, Golden Globe-winner Brad Pitt's most widely recognized role may be Tyler Durden in Fight Club (1999). However, his portrayals of Billy Beane in Moneyball (2011), and Rusty Ryan in the remake of Ocean's Eleven (2001) and its sequels, also loom large in his ...",
                DateOfBirth = new DateTime(1965, 7, 4),
                DateOfDeath = null,
                Gender = "M",
                Photo = new byte[0],
                PlaceOfBirth = "New York"
            };
            modelBuilder.Entity<Person>().HasData(p4);

            // mtvs person
            modelBuilder.Entity<MovieAndTvshowPerson>().HasData(new MovieAndTvshowPerson()
            {
                Id = 1,
                MovieAndTvshowId = 1,
                PersonId = 1,
                NameInMovie = "Michael Corleone",
                RoleId = 1
            });
            modelBuilder.Entity<MovieAndTvshowPerson>().HasData(new MovieAndTvshowPerson()
            {
                Id = 2,
                MovieAndTvshowId = 1,
                PersonId = 2,
                RoleId = 2
            });
            modelBuilder.Entity<MovieAndTvshowPerson>().HasData(new MovieAndTvshowPerson()
            {
                Id = 3,
                MovieAndTvshowId = 3,
                PersonId = 3,
                RoleId = 1,
                NameInMovie = "Benjamin Button"
            });
            modelBuilder.Entity<MovieAndTvshowPerson>().HasData(new MovieAndTvshowPerson()
            {
                Id = 4,
                MovieAndTvshowId = 4,
                PersonId = 3,
                RoleId = 1,
                NameInMovie = "Tyler Durden"
            });
            modelBuilder.Entity<MovieAndTvshowPerson>().HasData(new MovieAndTvshowPerson()
            {
                Id = 5,
                MovieAndTvshowId = 3,
                PersonId = 4,
                RoleId = 2,
            });
            modelBuilder.Entity<MovieAndTvshowPerson>().HasData(new MovieAndTvshowPerson()
            {
                Id = 6,
                MovieAndTvshowId = 4,
                PersonId = 4,
                RoleId = 2,
            });

            // news
            News n1 = new News
            {
                Id = 1,
                AuthorId = 1,
                DateTimeOfNews = new DateTime(2020, 5, 17, 12, 12, 12),
                Title = "Awesome MCU Supercut Shows The Infinity Saga",
                Content = @"A new fan edit combines the entire Infinity Saga into two minutes. At this point, whether a superhero fan or not, almost everybody has at least heard about the Marvel Cinematic Universe. So far, there have been 23 movies in the MCU, which have introduced over a dozen superheroes across eleven years.
                            Marvel Studios and Paramount Pictures started the universe out strong with Iron Man in 2008 years,
                            but all of the films were building up to the events of Avengers: Endgame.Now, one fan has condensed the eleven-year venture into one 2 minute clip.",
                CoverPhoto = new byte[0],
            };
            modelBuilder.Entity<News>().HasData(n1);
            News n2 = new News
            {
                Id = 2,
                AuthorId = 1,
                DateTimeOfNews = new DateTime(2020, 5, 20, 12, 12, 14),
                Title = "Kristen Stewart Is Princess Diana in Pablo Larraín's Spencer",
                Content = @"Charlie's Angels star Kristen Stewart is set to portray Princess Di in the upcoming drama movie Spencer, and Pablo Larraín is also on board to direct the project with Peaky Blinders writer Steven Knight penning the screenplay. Known for directing movies like Jackie and Neruda, Larraín will also be serving as a producer for Spencer in addition to helming the project. Larraín's Fabula partners Juan de Dios, Jonas Dornbach, Janine Jackowski, and Paul Webster will also produce.
                            Spencer is not quite a Princess Diana biopic, focusing particularly on one critical weekend in her life in the early '90s. Taking place over the span of three days, the movie delves into the moments when Diana decided her marriage to Prince Charles wasn't working, and that she needed to veer from a path that put her in line to one day be queen. Famously, Diana and Charles had divorced in 1996 after the two had been married since 1981, and the sordid details of their relationship had been highly publicized at the time. After walking away from royalty, the former Princess of Wales was killed in 1997 as the result of a devastating car crash while fleeing from paparazzi, but that incident won't be covered in the movie.",
                CoverPhoto = new byte[0],
            };
            modelBuilder.Entity<News>().HasData(n2);
            News n3 = new News
            {
                Id = 3,
                AuthorId = 1,
                DateTimeOfNews = new DateTime(2020, 5, 19, 12, 12, 16),
                Title = "Is Disney+ Planning a Bunch of Star Wars Interconnected Live-Action TV Shows for 2021?",
                Content = @"We might be getting a whole lot more Star Wars on the small screen in the not-too-distant future. This, according to a new rumor (with rumor being the keyword for now) that suggests Lucasfilm is gearing up to bring a series of live-action shows set within a galaxy far, far away to Disney+ starting next year. Game of Thrones is being used as a comparison.
                            Before we dive in we must again caution that this should only be regarded as a rumor for the time being, and nothing more.That said, it does line up with much of what we've been hearing about The Mandalorian season 2, as well as other rumors floating around. According to a new report, starting in mid-2021, Disney and Lucasfilm plan to release a new season of a live-action Star Wars show every quarter. These shows will feature an interconnected storyline, but each series will be able to stand alone. It is compared to the way Game of Thrones featured various families. In this case, each family would get its own show.",
                CoverPhoto = new byte[0],
            };
            modelBuilder.Entity<News>().HasData(n3);

            // comment
            Comment c1 = new Comment
            {
                Id = 1,
                AppUserId = 2,
                DateTimeOfComment = new DateTime(2020, 7, 15),
                MovieAndTvshowId = 1,
                Content = "Great movie !"
            };
            modelBuilder.Entity<Comment>().HasData(c1);
            Comment c2 = new Comment
            {
                Id = 2,
                AppUserId = 2,
                DateTimeOfComment = new DateTime(2020, 7, 16),
                MovieAndTvshowId = 1,
                Content = "Amazing !"
            };
            modelBuilder.Entity<Comment>().HasData(c2);

        }
    }
}
