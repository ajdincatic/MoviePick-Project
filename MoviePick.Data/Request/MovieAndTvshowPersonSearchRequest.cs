﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class MovieAndTvshowPersonSearchRequest
    {
        public int RoleId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public int PersonId { get; set; }
    }
}
