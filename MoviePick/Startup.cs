using AutoMapper;
using eProdaja.Services;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MoviePick.Data.Request;
using MoviePick.Database;
using MoviePick.Interfaces;
using MoviePick.Services;
using MoviePick.WebAPI.Filters;
using MoviePick.WebAPI.Security;
using Newtonsoft.Json;
using System;

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

            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddMvc(x => x.EnableEndpointRouting = false)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            // swagger configuration
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MoviePick API", Version = "v1" });

                // basic auth swagger
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            // connection to database
            // Scaffold-DbContext -Connection "Server=(local);Database=MoviePick;Integrated Security=True;Trusted_Connection=True;" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database -context MoviePickContext -force
            services.AddDbContext<MoviePickContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("MoviePick"))
            .EnableSensitiveDataLogging());

            // basic auth
            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            // hangfire for back. service
            services.AddHangfire(x =>
                x.SetDataCompatibilityLevel(CompatibilityLevel.Version_110)
                .UseDefaultTypeSerializer()
                .UseMemoryStorage());

            services.AddHangfireServer();

            // auto mapper configuration
            services.AddAutoMapper(typeof(Startup));

            #region dependency injection

            services.AddScoped<IService<Data.Model.Genre, object>, BaseService<Data.Model.Genre, object, Database.Genre>>();
            services.AddScoped<IService<Data.Model.Role, object>, BaseService<Data.Model.Role, object, Database.Role>>();
            services.AddScoped<IService<Data.Model.UserType, object>, BaseService<Data.Model.UserType, object, Database.UserType>>();
            services.AddScoped<IService<Data.Model.ProductionCompany, object>, BaseService<Data.Model.ProductionCompany, object, ProductionCompany>>();

            services.AddScoped<ICRUDService<Data.Model.Quote, QuoteSearchRequest, QuoteUpsertRequest, QuoteUpsertRequest>, QuoteService>();
            services.AddScoped<ICRUDService<Data.Model.Person, PersonSearchRequest, PersonUpsertRequest, PersonUpsertRequest>, PersonService>();
            services.AddScoped<ICRUDService<Data.Model.MovieAndTvshow, MovieAndTvshowSearchRequest, MovieAndTvshowUpsertRequest, MovieAndTvshowUpsertRequest>, MovieAndTvShowService>();
            services.AddScoped<ICRUDService<Data.Model.TvshowSeason, TvshowSeasonSearchRequest, TvshowSeasonUpsertRequest, TvshowSeasonUpsertRequest>, TvshowSeasonService>();
            services.AddScoped<ICRUDService<Data.Model.TvshowSeasonEpisode, TvshowSeasonEpisodeSearchRequest, TvshowSeasonEpisodeUpsertRequest, TvshowSeasonEpisodeUpsertRequest>, TvshowSeasonEpisodeService>();
            services.AddScoped<ICRUDService<Data.Model.News, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest>, NewsService>();
            services.AddScoped<ICRUDService<Data.Model.MovieAndTvshowPerson, MovieAndTvshowPersonSearchRequest, MovieAndTvshowPersonUpsertRequest, MovieAndTvshowPersonUpsertRequest>, CastService>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<ICommentService, CommentService>();


            services.AddScoped<IQuoteOfTheDay, QuoteOfTheDay>();

            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IRecurringJobManager recurringJobManager,
            IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "";
            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseHangfireDashboard();

            // BACKGROUND SERVICE FOR QUOTE OF THE DAY
            recurringJobManager.AddOrUpdate(
                "Generate QOTD",
                () => serviceProvider.GetService<IQuoteOfTheDay>().GenerateRandomQuote(),
                Cron.Daily
            );
            recurringJobManager.Trigger("Generate QOTD");
        }
    }
}
