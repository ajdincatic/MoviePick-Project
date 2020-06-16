using eProdaja.Mobile;
using MoviePick.Data.Request;
using MoviePick.MobileUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviePick.MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieChatPage : ContentPage
    {
        private readonly APIService _CommentService = new APIService("Comment");

        MovieChatViewModel model = null;
        public MovieChatPage(Data.Model.MovieAndTvshow mtvs)
        {
            InitializeComponent();
            BindingContext = model = new MovieChatViewModel
            {
                mtvs = mtvs
            };
        }

        private void ScrollToEnd()
        {
            var LastComment = model.CommentList.LastOrDefault();
            MessageList.ScrollTo(LastComment, ScrollToPosition.End, true);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            ScrollToEnd();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await _CommentService.Insert<Data.Model.Comment>(new CommentUpsertRequest
            {
                MovieAndTvshowId = model.mtvs.Id,
                AppUserId = APIService.UserId,
                DateTimeOfComment = DateTime.Now,
                Content = MessageText.Text
            });
            await model.Init();
            MessageText.Text = "";
            ScrollToEnd();
        }
    }
}