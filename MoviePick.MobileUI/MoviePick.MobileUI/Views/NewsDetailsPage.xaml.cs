using MoviePick.MobileUI.ViewModels;
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
    public partial class NewsDetailsPage : ContentPage
    {
        NewsDetailsViewModel model = null;

        public NewsDetailsPage(Data.Model.News news)
        {
            InitializeComponent();
            BindingContext = model = new NewsDetailsViewModel
            {
                news = news
            };
        }
    }
}