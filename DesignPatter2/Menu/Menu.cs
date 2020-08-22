using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPatter2.Menu
{
	[Serializable]
    public class Menu : ICloneable
    {
		private string mu_id;           //菜单编号
		private string mu_name;         //菜单名称
		private string mu_parentid;     //父菜单编号
		private string mu_url;          //菜单url
		private string mu_level;        //菜单级别(1：一级菜单，2：二级菜单)
		private string mu_issub_node;   //是否有子节点
		private string mu_sort;         //菜单排序
		private string mu_remark;       //菜单备注
		private string mu_icon;         //菜单图片路径
		private List<Menu> child_menus = new List<Menu>(); //子菜单集合
		public string getMu_id()
		{
			return mu_id;
		}
		public void setMu_id(string mu_id)
		{
			this.mu_id = mu_id;
		}
		public string getMu_name()
		{
			return mu_name;
		}
		public void setMu_name(string mu_name)
		{
			this.mu_name = mu_name;
		}

		public string getMu_url()
		{
			return mu_url;
		}
		public void setMu_url(string mu_url)
		{
			this.mu_url = mu_url;
		}
		public string getMu_sort()
		{
			return mu_sort;
		}
		public void setMu_sort(string mu_sort)
		{
			this.mu_sort = mu_sort;
		}
		public string getMu_remark()
		{
			return mu_remark;
		}
		public void setMu_remark(string mu_remark)
		{
			this.mu_remark = mu_remark;
		}
		public string getMu_parentid()
		{
			return mu_parentid;
		}
		public void setMu_parentid(string mu_parentid)
		{
			this.mu_parentid = mu_parentid;
		}
		public string getMu_level()
		{
			return mu_level;
		}
		public void setMu_level(string mu_level)
		{
			this.mu_level = mu_level;
		}
		public string getMu_issub_node()
		{
			return mu_issub_node;
		}
		public void setMu_issub_node(string mu_issub_node)
		{
			this.mu_issub_node = mu_issub_node;
		}
		public List<Menu> getChild_menus()
		{
			return child_menus;
		}
		public void setChild_menus(List<Menu> child_menus)
		{
			this.child_menus = child_menus;
		}
		public string getMu_icon()
		{
			return mu_icon;
		}
		public void setMu_icon(string mu_icon)
		{
			this.mu_icon = mu_icon;
		}
		public object Clone()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return binaryFormatter.Deserialize(memoryStream);
        }
    }
}
