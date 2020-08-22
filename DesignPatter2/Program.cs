using DesignPatter2.Composite;
using DesignPatter2.Filter;
using DesignPatter2.Filter.Example;
using DesignPatter2.Menu.Services;
using DesignPatter2.Prototype;
using DesignPatter2.Prototype.Download;
using System;
using System.Collections.Generic;

namespace DesignPatter2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、原型模式
            {
                //// 1、从数据库加载视频进行缓存(文件服务器) 缓存速度
                //// 解决性能问题
                //VideoCache.LoadCache();

                //// 2、对缓存视频分别做不通下载
                //Video clonedVideo = (Video)VideoCache.GetVideo("1");
                //Video clonedVideo2 = (Video)VideoCache.GetVideo("1");
                //IDownload download = new GreenWaterDownload();
                //download.DownloadVideo(clonedVideo);
                //IDownload download2 = new RedWaterDownload();
                //download2.DownloadVideo(clonedVideo2);

            }
            #endregion

            #region 2、组合模式
            {
                //// 1、树形机构的场景，使用组合模式
                //Employee CEO = new Employee("张三", "CEO", 30000);

                //Employee headMarketing = new Employee("李四", "技术经理", 20000);

                //Employee headSales = new Employee("王五", "销售经理", 20000);

                //Employee clerk1 = new Employee("赵六", "销售", 10000);
                //Employee clerk2 = new Employee("钱七", "销售", 10000);

                //Employee salesExecutive1 = new Employee("Tony", "技术", 10000);
                //Employee salesExecutive2 = new Employee("Mark", "技术", 10000);

                //CEO.add(headSales);
                //CEO.add(headMarketing);

                //headSales.add(clerk1);
                //headSales.add(clerk2);

                //headMarketing.add(salesExecutive1);
                //headMarketing.add(salesExecutive2);

                ////打印该组织的所有员工
                //Console.WriteLine(CEO.toString());
                //foreach (Employee headEmployee in CEO.getSubordinates())
                //{
                //    Console.WriteLine(headEmployee.toString());
                //    foreach (Employee employee in headEmployee.getSubordinates())
                //    {
                //        Console.WriteLine(employee.toString());
                //    }
                //}
            }
            #endregion

            #region 3、过滤器模式
            {
                //List<Person> persons = new List<Person>();

                //persons.Add(new Person("张三", "Male", "Single"));
                //persons.Add(new Person("李四", "Male", "Married"));
                //persons.Add(new Person("王五", "Female", "Married"));
                //persons.Add(new Person("赵六", "Female", "Single"));
                //persons.Add(new Person("钱七", "Male", "Single"));
                //persons.Add(new Person("Tony", "Male", "Single"));

                //ICriteria male = new MaleCriteria();
                //ICriteria female = new FemaleCriteria();
                //ICriteria single = new SingleCriteria();
                //ICriteria singleMale = new AndCriteria(single, male);
                //ICriteria singleOrFemale = new OrCriteria(single, female);

                //Console.WriteLine("Males: ");
                //PrintPersons(male.meetCriteria(persons));

                //Console.WriteLine("\nFemales: ");
                //PrintPersons(female.meetCriteria(persons));

                //Console.WriteLine("\nSingle Males: ");
                //PrintPersons(singleMale.meetCriteria(persons));

                //Console.WriteLine("\nSingle Or Females: ");
                //PrintPersons(singleOrFemale.meetCriteria(persons));
            }
            #endregion

            #region 4、菜单测试
            Menu.Menu menu = new Menu.Menu();
            menu.setMu_id("1");
            menu.setMu_name("文件");
            menu.setMu_level("1");
            menu.setMu_url("/file.html");

            Menu.Menu menu2 = (Menu.Menu)menu.Clone();
            menu2.setMu_id("2");
            menu2.setMu_name("编辑");
            menu2.setMu_level("2");
            menu2.setMu_url("/file.html");
            menu2.setMu_parentid("1");

            MenuService menuService = new MenuService();
            menuService.AddMenu(menu);
            menuService.AddMenu(menu2);
            var xx=menuService.GetHierarchicalMenu();


            foreach (var item in xx)
            {
                Console.WriteLine($"{item.getMu_id()}:{item.getChild_menus().Count},{item.getMu_name()}");
            }
            #endregion

            Console.Read();


        }

        public static void PrintPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.getName()
                   + ", Gender : " + person.getGender()
                   + ", Marital Status : " + person.getMaritalStatus()
                   + " ]");
            }
        }
    }
}
