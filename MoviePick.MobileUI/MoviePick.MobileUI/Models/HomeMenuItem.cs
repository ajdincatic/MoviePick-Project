using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.MobileUI.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        MTVS,
        NewsPlace,
        Logout,
        Home,
        HowDoYouFeel,
        YourProfile
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
