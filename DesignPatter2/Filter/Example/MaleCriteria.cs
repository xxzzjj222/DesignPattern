using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Filter.Example
{
    class MaleCriteria : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getGender().Equals("Male"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
