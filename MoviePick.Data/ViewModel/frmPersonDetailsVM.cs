using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.ViewModel
{
    public class frmPersonDetailsVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string RoleName { get; set; }
        public string NameInMovie { get; set; }
    }
}
