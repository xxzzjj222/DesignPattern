using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Template
{
    class ViewResult
    {
        //1.页面需要数据
        public IDictionary<string,object> ViewData { get; set; }

        //2.试图名称
        public string ViewName { get; set; }

        //3.试图类型
        public string ViewType { get; set; }

    }
}
