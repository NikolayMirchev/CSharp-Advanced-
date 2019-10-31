using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Define_a_Class_Person
{
    public class Family
    {

        public List<Person> People;

        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public List<Person> Sort(List<Person> list)
        {
            return list.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }
    }
}
