using MoviePick.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviePick.MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FullCastPage : ContentPage
    {
        public MovieAndTvshow _MovieAndTvshow { get; }

        public FullCastPage(Data.Model.MovieAndTvshow movieAndTvshow)
        {
            InitializeComponent();
            _MovieAndTvshow = movieAndTvshow;
        }

    }
}