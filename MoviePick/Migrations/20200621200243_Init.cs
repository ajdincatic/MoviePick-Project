using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePick.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<byte[]>(nullable: true),
                    Biography = table.Column<string>(maxLength: 500, nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Gender = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    PlaceOfBirth = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionCompanyName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieAndTVShow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    Language = table.Column<string>(maxLength: 50, nullable: false),
                    RunningTime = table.Column<string>(maxLength: 10, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    Budget = table.Column<double>(nullable: true),
                    Poster = table.Column<byte[]>(nullable: true),
                    NumberOfRatings = table.Column<int>(nullable: false),
                    Finished = table.Column<bool>(nullable: true),
                    ProductionCompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAndTVShow", x => x.Id);
                    table.ForeignKey(
                        name: "FK__MovieAndT__Produ__4316F928",
                        column: x => x.ProductionCompanyId,
                        principalTable: "ProductionCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 500, nullable: false),
                    PasswordSalt = table.Column<string>(maxLength: 500, nullable: false),
                    UserTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK__User__UserTypeId__5070F446",
                        column: x => x.UserTypeId,
                        principalTable: "UserType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieAndTVShowGenre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieAndTVShowId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAndTVShowGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK__MovieAndT__Genre__440B1D61",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MovieAndT__Movie__44FF419A",
                        column: x => x.MovieAndTVShowId,
                        principalTable: "MovieAndTVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieAndTVShowPerson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieAndTVShowId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    NameInMovie = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAndTVShowPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK__MovieAndT__Movie__47DBAE45",
                        column: x => x.MovieAndTVShowId,
                        principalTable: "MovieAndTVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MovieAndT__Perso__48CFD27E",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MovieAndT__RoleI__49C3F6B7",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieAndTVShowId = table.Column<int>(nullable: false),
                    QuoteText = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Quote__MovieAndT__4BAC3F29",
                        column: x => x.MovieAndTVShowId,
                        principalTable: "MovieAndTVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TVShowSeason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieAndTVShowId = table.Column<int>(nullable: false),
                    Finished = table.Column<bool>(nullable: true),
                    SeasonName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShowSeason", x => x.Id);
                    table.ForeignKey(
                        name: "FK__TVShowSea__Movie__4E88ABD4",
                        column: x => x.MovieAndTVShowId,
                        principalTable: "MovieAndTVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(nullable: false),
                    MovieAndTVShowId = table.Column<int>(nullable: false),
                    DateTimeOfComment = table.Column<DateTime>(type: "datetime", nullable: false),
                    Content = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Comment__AppUser__412EB0B6",
                        column: x => x.AppUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Comment__MovieAn__4222D4EF",
                        column: x => x.MovieAndTVShowId,
                        principalTable: "MovieAndTVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(nullable: false),
                    DateTimeOfNews = table.Column<DateTime>(type: "datetime", nullable: false),
                    CoverPhoto = table.Column<byte[]>(nullable: true),
                    Content = table.Column<string>(maxLength: 4000, nullable: true),
                    Title = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK__News__AuthorId__4AB81AF0",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(nullable: false),
                    MovieAndTVShowId = table.Column<int>(nullable: false),
                    RatingValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Rating__AppUserI__4CA06362",
                        column: x => x.AppUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Rating__MovieAnd__4D94879B",
                        column: x => x.MovieAndTVShowId,
                        principalTable: "MovieAndTVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TVShowSeasonEpisode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TVShowSeasonId = table.Column<int>(nullable: false),
                    EpisodeName = table.Column<string>(maxLength: 50, nullable: false),
                    AirDate = table.Column<DateTime>(type: "date", nullable: false),
                    EpisodeNumber = table.Column<int>(nullable: true),
                    TVShowId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShowSeasonEpisode", x => x.Id);
                    table.ForeignKey(
                        name: "FK__TVShowSea__TVSho__4F7CD00D",
                        column: x => x.TVShowSeasonId,
                        principalTable: "TVShowSeason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieAndTVShowNews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieAndTVShowId = table.Column<int>(nullable: true),
                    NewsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAndTVShowNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK__MovieAndT__Movie__45F365D3",
                        column: x => x.MovieAndTVShowId,
                        principalTable: "MovieAndTVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MovieAndT__NewsI__46E78A0C",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserId",
                table: "Comment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MovieAndTVShowId",
                table: "Comment",
                column: "MovieAndTVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShow_ProductionCompanyId",
                table: "MovieAndTVShow",
                column: "ProductionCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShowGenre_GenreId",
                table: "MovieAndTVShowGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShowGenre_MovieAndTVShowId",
                table: "MovieAndTVShowGenre",
                column: "MovieAndTVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShowNews_MovieAndTVShowId",
                table: "MovieAndTVShowNews",
                column: "MovieAndTVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShowNews_NewsId",
                table: "MovieAndTVShowNews",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShowPerson_MovieAndTVShowId",
                table: "MovieAndTVShowPerson",
                column: "MovieAndTVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShowPerson_PersonId",
                table: "MovieAndTVShowPerson",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTVShowPerson_RoleId",
                table: "MovieAndTVShowPerson",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Quote_MovieAndTVShowId",
                table: "Quote",
                column: "MovieAndTVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_AppUserId",
                table: "Rating",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_MovieAndTVShowId",
                table: "Rating",
                column: "MovieAndTVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_TVShowSeason_MovieAndTVShowId",
                table: "TVShowSeason",
                column: "MovieAndTVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_TVShowSeasonEpisode_TVShowSeasonId",
                table: "TVShowSeasonEpisode",
                column: "TVShowSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeId",
                table: "User",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "MovieAndTVShowGenre");

            migrationBuilder.DropTable(
                name: "MovieAndTVShowNews");

            migrationBuilder.DropTable(
                name: "MovieAndTVShowPerson");

            migrationBuilder.DropTable(
                name: "Quote");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "TVShowSeasonEpisode");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "TVShowSeason");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "MovieAndTVShow");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "ProductionCompany");
        }
    }
}
