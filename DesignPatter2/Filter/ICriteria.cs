using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Filter
{
    public interface ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons);
    }
}
