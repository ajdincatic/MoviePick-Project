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

        }
    }
}
