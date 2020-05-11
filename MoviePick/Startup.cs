using AutoMapper;
using eProdaja.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MoviePick.Data.Request;
using MoviePick.Database;
using MoviePick.Interfaces;
using MoviePick.Properties;
using MoviePick.Services;
using Newtonsoft.Json;

namespace MoviePick
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddMvc(x => x.EnableEndpointRouting = false)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            // swagger configuration
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MoviePick API", Version = "v1" });
            });


            // connection to database
            services.AddDbContext<MoviePickContext>(opt => opt.UseSqlServer(Resources.Local_ConString));

            // auto mapper configuration
            services.AddAutoMapper(typeof(Startup));

            #region dependency injection

            services.AddScoped<IService<Data.Model.Genre, object>, BaseService<Data.Model.Genre, object, Database.Genre>>();
            services.AddScoped<IService<Data.Model.Role, object>, BaseService<Data.Model.Role, object, Database.Role>>();
            services.AddScoped<IService<Data.Model.UserType, object>, BaseService<Data.Model.UserType, object, Database.UserType>>();
            services.AddScoped<IService<Data.Model.ProductionCompany, object>, BaseService<Data.Model.ProductionCompany, object, ProductionCompany>>();
            services.AddScoped<IService<Data.Model.MovieTvShowGenre, GenreMovieTvShowSearchRequest>, GenreMovieTvShowService>();

            services.AddScoped<ICRUDService<Data.Model.Quote, QuoteSearchRequest, QuoteUpsertRequest, QuoteUpsertRequest>, QuoteService>();
            services.AddScoped<ICRUDService<Data.Model.Person, PersonSearchRequest, PersonUpsertRequest, PersonUpsertRequest>, PersonService>();
            services.AddScoped<ICRUDService<Data.Model.MovieAndTvshow, MovieAndTvshowSearchRequest, MovieAndTvshowUpsertRequest, MovieAndTvshowUpsertRequest>, MovieAndTvShowService>();
            services.AddScoped<ICRUDService<Data.Model.TvshowSeason, TvshowSeasonSearchRequest, TvshowSeasonUpsertRequest, TvshowSeasonUpsertRequest>, TvshowSeasonService>();
            services.AddScoped<ICRUDService<Data.Model.TvshowSeasonEpisode, TvshowSeasonEpisodeSearchRequest, TvshowSeasonEpisodeUpsertRequest, TvshowSeasonEpisodeUpsertRequest>, TvshowSeasonEpisodeService>();
            services.AddScoped<ICRUDService<Data.Model.User, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>, UserService>();
            services.AddScoped<ICRUDService<Data.Model.News, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest>, NewsService>();
            services.AddScoped<ICRUDService<Data.Model.MovieAndTvshowPerson, MovieAndTvshowPersonSearchRequest, MovieAndTvshowPersonUpsertRequest, MovieAndTvshowPersonUpsertRequest>, CastService>();

            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<ICommentService, CommentService>();

            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
