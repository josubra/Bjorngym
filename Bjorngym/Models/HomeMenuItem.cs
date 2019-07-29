using System;
using System.Collections.Generic;
using System.Text;

namespace Bjorngym.Models
{
    public enum MenuItemType
    {
        Home,
        MeuTreino,
        Planos,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
