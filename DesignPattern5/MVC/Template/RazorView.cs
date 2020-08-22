using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Template
{
    class RazorView : AbstractView
    {
        protected override void BuildPage(IDictionary<string, object> viewData)
        {
            Console.WriteLine($"构造Razor页面");
        }

        protected override void TransformData(IDictionary<string, object> viewData)
        {
            Console.WriteLine($"将数据转换成Razor数据");
        }

        protected override void WritePage(HttpContext httpcContext)
        {
            Console.WriteLine($"输出Razor页面");
        }
    }
}
