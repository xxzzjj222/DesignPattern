using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Filter.Example
{
    class FemaleCriteria : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getGender().Equals("Female"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
