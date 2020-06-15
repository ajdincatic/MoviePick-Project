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
        News
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
