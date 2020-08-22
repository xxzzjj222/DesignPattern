using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Menu.Filters
{
    public class SubMenuFilter : IMenuFilter
    {
        private string mu_id;

        public SubMenuFilter(string mu_id)
        {
            this.mu_id = mu_id;
        }
        public List<Menu> FilterMenu(List<Menu> menus)
        {
            List<Menu> levelMenus = new List<Menu>();
            foreach (Menu menu in menus)
            {
                if (mu_id.Equals(menu.getMu_parentid()))
                {
                    levelMenus.Add(menu);
                }
            }
            return levelMenus;
        }
    }
}
