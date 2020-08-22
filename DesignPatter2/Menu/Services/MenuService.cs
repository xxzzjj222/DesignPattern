using DesignPatter2.Menu.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Menu.Services
{
    public class MenuService
    {

        /// <summary>
        /// 菜单集合
        /// </summary>
        private List<Menu> menus = new List<Menu>();

        /// <summary>
        /// 1、添加菜单
        /// </summary>
        public void AddMenu(Menu menu)
        {
            menus.Add(menu);
        }


        /// <summary>
        /// 2、查询所有菜单
        /// </summary>
        public List<Menu> GetMenus()
        {
            return menus;
        }

        /// <summary>
        /// 查询层级菜单
        /// </summary>
        /// <returns></returns>
        public List<Menu> GetHierarchicalMenu()
        {
            FirstLevelMenuFilter menuFilter = new FirstLevelMenuFilter();

            List<Menu> firstMenus = menuFilter.FilterMenu(menus);

            foreach (var menu in firstMenus)
            {
                SubMenuFilter subMenuFilter = new SubMenuFilter(menu.getMu_id());
                menu.setChild_menus(subMenuFilter.FilterMenu(menus));
            }

            return menus;
        }
    } 
}
