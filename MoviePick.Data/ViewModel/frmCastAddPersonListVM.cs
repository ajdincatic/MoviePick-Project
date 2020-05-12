using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.ViewModel
{
    public class frmCastAddPersonListVM
    {
        public int MTVSPId { get; set; }
        public int PersonId { get; set; }
        public string Person { get; set; }
        public string NameInMovie { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
    }
}
