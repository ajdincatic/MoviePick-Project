using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.ViewModel
{
    public class frmNewsSearchVM
    {
        public int Id { get; set; }
        public DateTime DateTimeOfNews { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
