using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Menu.Filters
{
    public interface IMenuFilter
    {
        /// <summary>
        /// 过滤菜单方法
        /// </summary>
        /// <param name="menus"></param>
        /// <returns></returns>
        public List<Menu> FilterMenu(List<Menu> menus);
    }
}
