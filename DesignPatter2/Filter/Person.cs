using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Filter
{
    public class Person
    {
        private string name; // 姓名
        private string gender;// 性别
        private string maritalStatus;// 婚姻状态

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string getName()
        {
            return name;
        }
        public string getGender()
        {
            return gender;
        }
        public string getMaritalStatus()
        {
            return maritalStatus;
        }
    }
}
