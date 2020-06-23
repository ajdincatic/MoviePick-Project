using Microsoft.EntityFrameworkCore;
using MoviePick.Database;
using MoviePick.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick
{
    public class Recomender
    {
        MoviePick.Database.MoviePickContext db = new Database.MoviePickContext();

        Dictionary<int, List<Rating>> movies = new Dictionary<int, List<Rating>>();

        public List<MovieAndTvshow> LoadSimilar(int titleId)
        {
            LoadTitles(titleId);
            List<Rating> ratingsOfThis = db.Rating.Where(x => x.Id == titleId).OrderBy(x => x.AppUser.Id).ToList();

            List<Rating> ratings1 = new List<Rating>();
            List<Rating> ratings2 = new List<Rating>();
            List<MovieAndTvshow> recomendedMovies = new List<MovieAndTvshow>();

            foreach (var item in movies)
            {
                foreach (Rating rating in ratingsOfThis)
                {
                    if(item.Value.Where(x=>x.AppUser.Id == rating.AppUser.Id).Count() > 0)
                    {
                        ratings1.Add(rating);
                        ratings2.Add(item.Value.Where(x => x.AppUser.Id == rating.AppUser.Id).First());
                    }
                }
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    recomendedMovies.Add(db.MovieAndTvshow.Where(x => x.Id == item.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }

            return recomendedMovies;
        }

        private double GetSimilarity(List<Rating> ratings1, List<Rating> ratings2)
        {
            if(ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x = ratings1[i].RatingValue * ratings2[i].RatingValue;
                y1 = ratings1[i].RatingValue * ratings1[i].RatingValue;
                y2 = ratings2[i].RatingValue * ratings2[i].RatingValue;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }

        private void LoadTitles(int mtvsId)
        {
            List<MovieAndTvshow> mtvs = db.MovieAndTvshow.Where(x => x.Id != mtvsId).ToList();
            List<Rating> ratings = new List<Rating>();
            foreach (MovieAndTvshow item in mtvs)
            {
                ratings = db.Rating.Include(x => x.AppUser).Where(x => x.MovieAndTvshowId == item.Id).OrderBy(x => x.AppUser.Id).ToList();
                if (ratings.Count > 0)
                    movies.Add(item.Id, ratings);
            }
        }
    }
}
