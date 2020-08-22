using DesignPattern.IOC.IOCAttribute;
using DesignPattern.IOC.Strategy;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPattern.IOC
{
    public class DefaultIOCFactory:AbstractIOCFactory
    {
        //IOC容器（存储对象）
        private Dictionary<string, object> iocContainer = new Dictionary<string, object>();

        //IOC type容器（存储类型）
        private Dictionary<string, Type> iocTypeContainer = new Dictionary<string, Type>();

        //对象创建策略
        public IObjectCreateStrategy objectCreateStrategy { get; set; }

        public DefaultIOCFactory()
        {
            //加载程序集
            Assembly assembly = Assembly.LoadFile(@"F:\VS2019\DesignPattern\DesignPattern\DesignPattern\bin\Debug\netcoreapp3.1\DesignPattern.exe");

            //获取程序集所有类型
            Type[] types = assembly.GetTypes();

            //通过attribute获取需要注入的对象类型
            foreach (var type in types)
            {
                IOCServer iOCServer = (IOCServer)type.GetCustomAttribute(typeof(IOCServer));
                if (iOCServer != null)
                {
                    iocTypeContainer.Add(type.Name, type);
                }
            }
        }

        //创建对象
        public override object GetObject(string typeName)
        {
            //1.容器已创建，直接返回
            if (iocContainer.ContainsKey(typeName))
            {
                return iocContainer[typeName];
            }
            else
            {   //1、获取类型
                if (!iocTypeContainer.ContainsKey(typeName))
                {
                    throw new Exception("对象类型不存在");
                }
                Type type = iocTypeContainer[typeName];

                //2、创建对象
                //object _object = Activator.CreateInstance(type);
                object _object = objectCreateStrategy.CreateObject(type);

                //3.注入依赖，用递归解决
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    IOCInject iocInject = (IOCInject)property.GetCustomAttribute(typeof(IOCInject));
                    if (iocInject!=null)
                    {
                        //3.1获取属性类型
                        string propertyTypeName = property.PropertyType.Name;

                        //3.2创建属性类型对象
                        object _propertyObject = GetObject(propertyTypeName);

                        //3.3设置属性值
                        property.SetValue(_object, _propertyObject);
                    }
                }

                //4.存储对象
                iocContainer.Add(type.Name, _object);

                //5.返回对象
                return _object;
            }
        }
    }
}
