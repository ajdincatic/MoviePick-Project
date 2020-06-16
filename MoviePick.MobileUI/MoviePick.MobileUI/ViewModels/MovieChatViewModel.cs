using eProdaja.Mobile;
using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviePick.MobileUI.ViewModels
{
    public class MovieChatViewModel
    {
        private readonly APIService _CommentService = new APIService("Comment");

        public ObservableCollection<Data.Model.Comment> CommentList { get; set; } = new ObservableCollection<Data.Model.Comment>();

        public Data.Model.MovieAndTvshow mtvs { get; set; }

        public MovieChatViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public string PageTitle {
            get {
                if (mtvs != null)
                    return mtvs.Title + " chat";
                return string.Empty;
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            List<Data.Model.Comment> comments = await _CommentService.Get<List<Data.Model.Comment>>(new CommentSearchRequest
            {
                MovieAndTvshowId = mtvs.Id
            });

            comments = comments.OrderBy(x => x.DateTimeOfComment).ToList();

            CommentList.Clear();
            foreach (var item in comments)
            {
                CommentList.Add(item);
            }
        }
    }
}
