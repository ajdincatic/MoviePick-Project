using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class ProductionCompany
    {
        public ProductionCompany()
        {
            MovieAndTvshow = new HashSet<MovieAndTvshow>();
        }

        public int Id { get; set; }
        public string ProductionCompanyName { get; set; }

        public virtual ICollection<MovieAndTvshow> MovieAndTvshow { get; set; }
    }
}
