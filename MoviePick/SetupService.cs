using Microsoft.EntityFrameworkCore;
using MoviePick.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick
{
    public class SetupService
    {
        public static void Init(MoviePickContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}