using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Filter.Example
{
    class OrCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = criteria.meetCriteria(persons);
            List<Person> otherCriteriaItems = otherCriteria.meetCriteria(persons);

            foreach (var item in firstCriteriaItems)
            {
                if (!otherCriteriaItems.Contains(item))
                {
                    otherCriteriaItems.Add(item);
                }
            }

            return otherCriteriaItems;
        }
    }
}
