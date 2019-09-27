using System;
using System.Collections.Generic;
using System.Text;

namespace ProShopBuddy2.Models
{
    public enum MenuItemType
    {
        Browse,
        Reference,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
