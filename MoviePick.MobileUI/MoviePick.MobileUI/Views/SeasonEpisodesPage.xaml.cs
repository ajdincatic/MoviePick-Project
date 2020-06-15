﻿using MoviePick.MobileUI.ViewModels;
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
    public partial class SeasonEpisodesPage : ContentPage
    {
        SeasonEpisodesViewModel model = null;
        public SeasonEpisodesPage(int mtvId)
        {
            InitializeComponent();
            BindingContext = model = new SeasonEpisodesViewModel
            {
                MTVSId = mtvId
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}