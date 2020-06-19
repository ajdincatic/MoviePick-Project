using AutoMapper;
using MoviePick.Data.Request;
using MoviePick.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            // source - destination
            CreateMap<Genre, Data.Model.Genre>();
            CreateMap<Role, Data.Model.Role>();
            CreateMap<ProductionCompany, Data.Model.ProductionCompany>();
            CreateMap<Person, Data.Model.Person>();
            CreateMap<Data.Model.Person, Person>();
            CreateMap<PersonUpsertRequest, Person>();
            CreateMap<Quote, Data.Model.Quote>();
            CreateMap<QuoteUpsertRequest, Quote>();
            CreateMap<MovieAndTvshow, Data.Model.MovieAndTvshow>();
            CreateMap<MovieAndTvshowUpsertRequest, MovieAndTvshow>();
            CreateMap<TvshowSeason, Data.Model.TvshowSeason>();
            CreateMap<TvshowSeasonUpsertRequest, TvshowSeason>();
            CreateMap<TvshowSeasonEpisode, Data.Model.TvshowSeasonEpisode>();
            CreateMap<TvshowSeasonEpisodeUpsertRequest, TvshowSeasonEpisode>();
            CreateMap<MovieAndTvshowGenre, Data.Model.MovieTvShowGenre>();
            CreateMap<MovieAndTvshowPerson, Data.Model.MovieAndTvshowPerson>();
            CreateMap<UserUpsertRequest, User>().ReverseMap();
            CreateMap<User, Data.Model.User>();
            CreateMap<MovieAndTvshowPersonUpsertRequest, MovieAndTvshowPerson>();
            CreateMap<UserType, Data.Model.UserType>();
            CreateMap<News, Data.Model.News>();
            CreateMap<NewsUpsertRequest, News>();
            CreateMap<MovieAndTvshowNews, Data.Model.MovieAndTvShowNews>();
            CreateMap<Rating, Data.Model.Rating>();
            CreateMap<RatingUpsertRequest, Rating>();
            CreateMap<CommentUpsertRequest, Comment>();
            CreateMap<Data.Model.Comment, Comment>().ReverseMap();
        }
    }
}
