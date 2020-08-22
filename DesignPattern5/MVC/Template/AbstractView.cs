using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Template
{
    abstract class AbstractView
    {
        public void Render(IDictionary<string,object> viewData,HttpContext httpContext)
        {
            // 1、转换成Razor数据
            TransformData(viewData);

            // 2、构建Razor页面
            BuildPage(viewData);

            // 3、输出Razor页面
            WritePage(httpContext);
        }
        protected abstract void TransformData(IDictionary<string, object> viewData);

        protected abstract void BuildPage(IDictionary<string, object> viewData);

        protected abstract void WritePage(HttpContext httpcContext);    
    }
}
