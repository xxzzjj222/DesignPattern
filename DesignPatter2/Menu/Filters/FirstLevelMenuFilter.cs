using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Menu.Filters
{
    public class FirstLevelMenuFilter : IMenuFilter
    {
        private const string mu_level = "1";
        public List<Menu> FilterMenu(List<Menu> menus)
        {
            List<Menu> levelMenus = new List<Menu>();
            foreach (Menu menu in menus)
            {
                if (menu.getMu_level().Equals(mu_level))
                {
                    levelMenus.Add(menu);
                }
            }
            return levelMenus;
        }
    }
}
