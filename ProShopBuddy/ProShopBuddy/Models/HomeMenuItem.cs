﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProShopBuddy.Models
{
    public enum MenuItemType
    {
        Players,
        References,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
