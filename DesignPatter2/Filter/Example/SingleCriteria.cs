using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Filter.Example
{
    class SingleCriteria : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getMaritalStatus().Equals("Single"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
